using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppRetoKitolBet.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace AppRetoKitolBet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(User);
        }

        public async Task<IActionResult> About()
        {
            ////BOOLEANO QUE MIRA SI HAY MAS PAGINAS EN LA API
            //bool next = true;
            ////OBJETO RESPUESTA (DEPENDERA DE COMO ESTA ORGANIZADA LA API)
            //Response items = null;
            ////INICIALIZAMOS EL CLIENTE HTTP
            //HttpClient client = new HttpClient();

            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/hal+json"));
            //client.DefaultRequestHeaders.Accept.Clear();

            ////VARIABLE ITERADORA QUE RECORRERA LAS PAGINAS DE LA API
            //int i = 1;
            ////INICIAMOS LA LISTA DE PERSONAJES QUE LUEGO PASAREMOS A LA LISTA
            //List<WorkPackage> workPackages = new List<WorkPackage>();

            ////MIENTRAS HAYA PAGINAS SEGUIRA EN EL BUCLE
            //while (next)
            //{
            //    //LA VARIABLE RESPONSE GUARDARA LA LLAMADA A LA API
            //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/hal+json"));
            //    client.DefaultRequestHeaders.Accept.Clear();
            //    HttpResponseMessage response = await client.GetAsync("http://carbar.openproject.com/api/v3/project/3/work_packages/?offset=" + i);
            //    //SI RECIBIMOS UNA RESPUESTA
            //    if (response.IsSuccessStatusCode)
            //    {
            //        //GUARDAREMOS EN EL OBJETO(MODELO RESPONSE) EL CONTENIDO DE LA RESPUESTA
            //        string wtfEnJson = await response.Content.ReadAsStringAsync();
            //        Response wtf = JsonConvert.DeserializeObject<Response>(wtfEnJson);
            //        items = wtf;
            //        //items = await response.Content.ReadAsAsync<Response>();
            //        //SI EL ATRIBUTO NEXT(MIRA LA URL DE LA SIGUIENTE PAGINA) ES NULL, SALDREMOS DEL BUCLE PORQUE NO HAY MAS PERSONAJES
            //        if (items.Total > 20 || items.Count > 20)
            //        {
            //            //PONEMOS NEXT A FALSO PARA QUE SALGA DEL BUCLE
            //            next = false;
            //        }
            //    }
            //    //RECORREMOS EL ARRAY RESULTS QUE ES EL QUE CONTIENE TODOS LOS DATOS QUE NECESITAMOS
            //    foreach (var item in items.WorkPackagesContainer.WorkPackages)
            //    {

            //        //CREAMOS UN PERSONAJE POR CADA ELEMENTO EN EL ARRAY RESULTS Y CREAMOS UN PERSONAJE
            //        WorkPackage p = new WorkPackage
            //        {
            //            Id = item.Id,
            //            Subject = item.Subject,
            //            Type = item.Type,
            //            Status = item.Status,
            //            Assignee = item.Assignee
            //        };

            //        //ANADIMOS EL PERSONAJE CREADO A LA LISTA DE PERSONAJES
            //        workPackages.Add(p);
            //    }
            //    //ANADIMOS UNO A i PARA PASAR A LA SIGUIENTE PAGINA
            //    i++;
            //}
            ////PASAMOS POR PARAMETRO LA LISTA DE PERSONAJES A LA VISTA
            return View(/*workPackages*/);
        }

        public async Task<IActionResult> Contact()
        {
            bool next = true;
            Response items = null;
            string username = "apikey";
            string password = "e091a02b90c3c0714b0a589b3deac0472cb565bb5fdddb89d9e9ab622964ffa3";
            string encoded = System.Convert.ToBase64String(Encoding.Default.GetBytes(username + ":" + password));
            
            //AuthenticationHeaderValue authHeaders = new AuthenticationHeaderValue("BAuth", "e091a02b90c3c0714b0a589b3deac0472cb565bb5fdddb89d9e9ab622964ffa3");

            HttpClient client = new HttpClient();
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/hal+json"));
            client.DefaultRequestHeaders.Accept.Clear();
            //httpWebRequest.Headers.Add("Authorization", "Basic " + encoded);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", encoded);

            int i = 1;
            List<User> users = new List<User>();

            while (next)
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", encoded);
                //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/hal+json"));
                HttpResponseMessage response = new HttpResponseMessage();
                response = await client.GetAsync("http://carbar.openproject.com/api/v3/users/?offset=" + i);

                if (response.IsSuccessStatusCode)
                {
                    string wtfEnJson = await response.Content.ReadAsStringAsync();
                    Response wtf = JsonConvert.DeserializeObject<Response>(wtfEnJson);
                    items = wtf;
                    if (items.Total > 30 || items.Count > 30)
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
                        Login = item.Login
                    };
                    users.Add(u);
                }
                i++;
            }
            return View(users);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
