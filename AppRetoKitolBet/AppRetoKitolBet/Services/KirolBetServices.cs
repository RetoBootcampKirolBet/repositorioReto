using AppRetoKitolBet.Data;
using AppRetoKitolBet.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace AppRetoKitolBet.Services
{

    public class KirolBetServices
    {
        private readonly ApplicationDbContext _context;

        public KirolBetServices(ApplicationDbContext context)
        {
            _context = context;
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

        public async Task<List<WorkPackage>> GetWorkPackagesApi()
        {
            //BOOLEANO QUE MIRA SI HAY MAS PAGINAS EN LA API
            bool next = true;
            //OBJETO RESPUESTA (DEPENDERA DE COMO ESTA ORGANIZADA LA API)
            ResponseWP items = null;
            string username = "apikey";
            string password = "e091a02b90c3c0714b0a589b3deac0472cb565bb5fdddb89d9e9ab622964ffa3";
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
                HttpResponseMessage response = await client.GetAsync("https://carbar.openproject.com/api/v3/project/3/work_packages/?offset=" + i);
                //SI RECIBIMOS UNA RESPUESTA
                if (response.IsSuccessStatusCode)
                {
                    //GUARDAREMOS EN EL OBJETO(MODELO RESPONSE) EL CONTENIDO DE LA RESPUESTA
                    string wtfEnJson = await response.Content.ReadAsStringAsync();
                    ResponseWP wtf = JsonConvert.DeserializeObject<ResponseWP>(wtfEnJson);
                    items = wtf;
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
                        Subject = item.Subject,
                        EstimatedTime = item.EstimatedTime,
                        StartDate = item.StartDate,
                        DueDate = item.DueDate,
                        RemainingTime = item.RemainingTime,
                        _Links = item._Links,

                    };
                    _Links l = p._Links;

                    //ANADIMOS EL PERSONAJE CREADO A LA LISTA DE PERSONAJES
                    workPackages.Add(p);
                }
                //ANADIMOS UNO A i PARA PASAR A LA SIGUIENTE PAGINA
                i++;
            }
            //PASAMOS POR PARAMETRO LA LISTA DE PERSONAJES A LA VISTA
            return workPackages;
        }

        public async Task<List<User>> GetUserApi()
        {
            bool next = true;
            ResponseUser items = null;
            string username = "apikey";
            string password = "e091a02b90c3c0714b0a589b3deac0472cb565bb5fdddb89d9e9ab622964ffa3";
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
                response = await client.GetAsync("https://carbar.openproject.com/api/v3/users/?offset=" + i);

                if (response.IsSuccessStatusCode)
                {
                    string wtfEnJson = await response.Content.ReadAsStringAsync();
                    ResponseUser wtf = JsonConvert.DeserializeObject<ResponseUser>(wtfEnJson);
                    items = wtf;
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
                        Login = item.Login
                    };
                    users.Add(u);
                }
                i++;
            }
            return users;
        }

    }
}
