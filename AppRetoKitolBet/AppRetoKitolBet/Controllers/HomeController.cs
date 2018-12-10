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

namespace AppRetoKitolBet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> About()
        {
            //BOOLEANO QUE MIRA SI HAY MAS PAGINAS EN LA API
            bool next = true;
            //OBJETO RESPUESTA (DEPENDERA DE COMO ESTA ORGANIZADA LA API)
            Response items = null;
            //INICIALIZAMOS EL CLIENTE HTTP
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/hal+json"));
            client.DefaultRequestHeaders.Accept.Clear();

            //VARIABLE ITERADORA QUE RECORRERA LAS PAGINAS DE LA API
            int i = 1;
            //INICIAMOS LA LISTA DE PERSONAJES QUE LUEGO PASAREMOS A LA LISTA
            List<WorkPackage> workPackages = new List<WorkPackage>();

            //MIENTRAS HAYA PAGINAS SEGUIRA EN EL BUCLE
            while (next)
            {
                //LA VARIABLE RESPONSE GUARDARA LA LLAMADA A LA API
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/hal+json"));
                client.DefaultRequestHeaders.Accept.Clear();
                HttpResponseMessage response = await client.GetAsync("http://192.168.99.100:32769/api/v3/projects/4/work_packages/?offset=" + i);
                //SI RECIBIMOS UNA RESPUESTA
                if (response.IsSuccessStatusCode)
                {
                    //GUARDAREMOS EN EL OBJETO(MODELO RESPONSE) EL CONTENIDO DE LA RESPUESTA
                    string wtfEnJson = await response.Content.ReadAsStringAsync();
                    Response wtf = JsonConvert.DeserializeObject<Response>(wtfEnJson);
                    items = wtf;
                    //items = await response.Content.ReadAsAsync<Response>();
                    //SI EL ATRIBUTO NEXT(MIRA LA URL DE LA SIGUIENTE PAGINA) ES NULL, SALDREMOS DEL BUCLE PORQUE NO HAY MAS PERSONAJES
                    if (items.Total > 20 || items.Count > 20)
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
            return View(workPackages);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
