﻿using KSProject.Data;
using KSProject.Models;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace KSProject.Services
{
    public class KSProjectServices
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<KSUser> _userManager;


        public KSProjectServices(ApplicationDbContext context, UserManager<KSUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public KSUser GetCurrentUser(string email)
        {
            KSUser user = _context.Users.Single(x => x.Email == email);
            return user;
        }
        public List<WorkPackage> GetWorkPackagesDB()
        {
            List<WorkPackage> workPackages = _context.WorkPackage.ToList();
            return workPackages;
        }

        public List<User> GetUsersDB()
        {
            List<User> users = _context.User.ToList();
            return users;
        }

        public List<UserWorkPackage> GetUserWorkPackagesDB()
        {
            List<UserWorkPackage> userWorkPackages = _context.UserWorkPackage.ToList();
            return userWorkPackages;
        }

        public async Task AsignarRole(int Id, string dropdown1)
        {
            User user = _context.User.Where(x => x.Id == Id).First();
            var KSUser = _context.Users.Single(x => x.Email == user.Login);
            Claim dropdownClaim = new Claim(dropdown1, dropdown1);
            await _userManager.AddClaimAsync(KSUser, dropdownClaim);
            user.UserRole = dropdown1;
            _context.User.Update(user);
            _context.SaveChanges();
        }

        public void AsignarTeam(int Id, string dropdown2)
        {
            User user = _context.User.Where(x => x.Id == Id).First();
            user.Team = dropdown2;
            _context.SaveChanges();
        }

        public void ActivateWPBD(int id)
        {
            // TODO: hacer la peticion con await
            WorkPackage workPackage = _context.WorkPackage.Where(x => x.Id == id).First();
            workPackage.Activation = "Activado";
            _context.SaveChanges();
        }
        public void InactivateWPBD(int id)
        {
            // TODO: hacer la peticion con await
            WorkPackage workPackage = _context.WorkPackage.Where(x => x.Id == id).First();
            workPackage.Activation = "Desactivado";
            _context.SaveChanges();
        }

        public async Task<List<WorkPackage>> GetWorkPackagesApi()
        {
            //BOOLEANO QUE MIRA SI HAY MAS PAGINAS EN LA API
            bool next = true;
            //OBJETO RESPUESTA (DEPENDERA DE COMO ESTA ORGANIZADA LA API)
            ResponseWP items = null;
            string username = "apikey";
            string password = "d7bec9bce6d5903af62e73104f8246eb44c0110ecf0557488d5527c62878333d";
            string encoded = System.Convert.ToBase64String(Encoding.Default.GetBytes(username + ":" + password));
            //INICIALIZAMOS EL CLIENTE HTTP
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", encoded);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/hal+json"));
            //client.DefaultRequestHeaders.Accept.Clear();

            //VARIABLE ITERADORA QUE RECORRERA LAS PAGINAS DE LA API
            int i = 1;
            //INICIAMOS LA LISTA DE PERSONAJES QUE LUEGO PASAREMOS A LA LISTA
            List<WorkPackage> workPackages = new List<WorkPackage>();

            //MIENTRAS HAYA PAGINAS SEGUIRA EN EL BUCLE
            while (next)
            {
                //LA VARIABLE RESPONSE GUARDARA LA LLAMADA A LA API
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", encoded);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/hal+json"));
                //client.DefaultRequestHeaders.Accept.Clear();
                HttpResponseMessage response = await client.GetAsync("https://carbardesign.openproject.com/api/v3/projects/3/work_packages/?offset=" + i);
                //SI RECIBIMOS UNA RESPUESTA
                if (response.IsSuccessStatusCode)
                {
                    //GUARDAREMOS EN EL OBJETO(MODELO RESPONSE) EL CONTENIDO DE LA RESPUESTA
                    string wpEnJson = await response.Content.ReadAsStringAsync();
                    ResponseWP wp = JsonConvert.DeserializeObject<ResponseWP>(wpEnJson);
                    items = wp;
                    //items = await response.Content.ReadAsAsync<Response>();
                    //SI EL ATRIBUTO NEXT(MIRA LA URL DE LA SIGUIENTE PAGINA) ES NULL, SALDREMOS DEL BUCLE PORQUE NO HAY MAS PERSONAJES
                    if (items.Total <= 20 || items.Count <= 20)
                    {
                        //PONEMOS NEXT A FALSO PARA QUE SALGA DEL BUCLE
                        next = false;
                    }
                }
                //RECORREMOS EL ARRAY RESULTS QUE ES EL QUE CONTIENE TODOS LOS DATOS QUE NECESITAMOS
                foreach (var item in items.WorkPackagesContainer.WorkPackages)
                {

                    //CREAMOS UN PERSONAJE POR CADA ELEMENTO EN EL ARRAY RESULTS Y CREAMOS UN PERSONAJE
                    WorkPackage p = new WorkPackage
                    {
                        Id = item.Id,
                        IdOP = item.IdOP,
                        Subject = item.Subject,
                        EstimatedTime = item.EstimatedTime,
                        StartDate = item.StartDate,
                        DueDate = item.DueDate,
                        SpentTime = item.SpentTime,
                        _Links = item._Links,
                        Description = item.Description
                    };
                    _Links l = p._Links;
                    Description d = p.Description;

                    //ANADIMOS EL PERSONAJE CREADO A LA LISTA DE PERSONAJES
                    workPackages.Add(p);
                }
                //ANADIMOS UNO A i PARA PASAR A LA SIGUIENTE PAGINA
                i++;
            }
            //PASAMOS POR PARAMETRO LA LISTA DE PERSONAJES A LA VISTA
            return workPackages;
        }

        public async Task<List<WorkPackage>> GetWorkPackagesDevApi()
        {
            bool next = true;
            ResponseWP items = null;
            string username = "apikey";
            string password = "d7bec9bce6d5903af62e73104f8246eb44c0110ecf0557488d5527c62878333d";
            string encoded = System.Convert.ToBase64String(Encoding.Default.GetBytes(username + ":" + password));
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", encoded);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/hal+json"));
            //client.DefaultRequestHeaders.Accept.Clear();

            int i = 1;
            List<WorkPackage> workPackages = new List<WorkPackage>();

            while (next)
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", encoded);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/hal+json"));
                //client.DefaultRequestHeaders.Accept.Clear();
                HttpResponseMessage response = await client.GetAsync("https://carbardesign.openproject.com/api/v3/projects/3/work_packages/?offset=" + i);
                if (response.IsSuccessStatusCode)
                {
                    string wpEnJson = await response.Content.ReadAsStringAsync();
                    ResponseWP wp = JsonConvert.DeserializeObject<ResponseWP>(wpEnJson);
                    items = wp;
                    if (items.Total <= 20 || items.Count <= 20)
                    {
                        next = false;
                    }
                }
                foreach (var item in items.WorkPackagesContainer.WorkPackages)
                {

                    WorkPackage p = new WorkPackage
                    {
                        Id = item.Id,
                        IdOP = item.IdOP,
                        Subject = item.Subject,
                        EstimatedTime = item.EstimatedTime,
                        StartDate = item.StartDate,
                        DueDate = item.DueDate,
                        SpentTime = item.SpentTime,
                        _Links = item._Links,
                        Description = item.Description
                    };
                    _Links l = p._Links;
                    Description d = p.Description;

                    workPackages.Add(p);
                }
                i++;
            }
            return workPackages;
        }

        public async Task<List<User>> GetUsersApi()
        {
            bool next = true;
            ResponseUser items = null;
            string username = "apikey";
            string password = "d7bec9bce6d5903af62e73104f8246eb44c0110ecf0557488d5527c62878333d";
            string encoded = System.Convert.ToBase64String(Encoding.Default.GetBytes(username + ":" + password));

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/hal+json"));
            //client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", encoded);

            int i = 1;
            List<User> users = new List<User>();

            while (next)
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", encoded);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/hal+json"));
                //client.DefaultRequestHeaders.Accept.Clear();
                HttpResponseMessage response = new HttpResponseMessage();
                response = await client.GetAsync("https://carbardesign.openproject.com/api/v3/users/?offset=" + i);

                if (response.IsSuccessStatusCode)
                {
                    string usEnJson = await response.Content.ReadAsStringAsync();
                    ResponseUser us = JsonConvert.DeserializeObject<ResponseUser>(usEnJson);
                    items = us;
                    if (items.Total <= 30 || items.Count <= 30)
                    {
                        next = false;
                    }
                }
                foreach (var item in items.UsersContainer.Users)
                {
                    User u = new User
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Login = item.Login,
                        UserRole = item.UserRole,
                        Team = item.Team
                    };
                    users.Add(u);
                }
                i++;
            }
            return users;
        }

        public async Task InsertWPInBD()
        {
            List<WorkPackage> workPackages = await GetWorkPackagesApi();

            if (_context.WorkPackage.Count() == 0)
            {
                foreach (WorkPackage workP in workPackages)
                {
                    _context.WorkPackage.Add(workP);
                    User user = _context.User.Single(x => x.Name == workP._Links.Assignee.Name);
                    UserWorkPackage UserWP = new UserWorkPackage
                    {
                        User = user,
                        WorkPackage = workP
                    };
                    _context.UserWorkPackage.Add(UserWP);
                    await _context.SaveChangesAsync();
                }
            }
            else
            {
                foreach (WorkPackage workP in workPackages)
                {
                    WorkPackage workPackage = new WorkPackage();
                    workPackage = _context.WorkPackage.SingleOrDefault(x => x.IdOP == workP.IdOP);
                    if (workPackage == null)
                    {
                        _context.WorkPackage.Add(workP);
                        User user = _context.User.Single(x => x.Name == workP._Links.Assignee.Name);
                        UserWorkPackage UserWP = new UserWorkPackage
                        {
                            User = user,
                            WorkPackage = workP
                        };
                        _context.UserWorkPackage.Add(UserWP);
                        await _context.SaveChangesAsync();
                    }
                }
            }

        }

        public async Task InsertUserInBD()
        {
            List<User> users = await GetUsersApi();

            if (_context.User.Count() == 0)
            {
                foreach (User user in users)
                {
                    _context.User.Add(user);
                    await _context.SaveChangesAsync();
                }
            }
            else
            {
                foreach (User u in users)
                {
                    User user = new User();
                    user = _context.User.SingleOrDefault(x => x.Login == u.Login);
                    if (user == null)
                    {
                        _context.User.Add(user);
                        await _context.SaveChangesAsync();
                    }
                }
            }
        }

        public void DesingActivBD(int id)
        {
            WorkPackage workPackage = _context.WorkPackage.Where(x => x.Id == id).First();
            workPackage.Activation = "Activado";
            _context.SaveChanges();
        }

        public void HideKsoftP()
        {

        }

    }
}