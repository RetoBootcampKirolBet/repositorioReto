using AppRetoKitolBet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AppRetoKitolBet.Services
{
//    public class KirolBetServices
//    {
//        //BOOLEANO QUE MIRA SI HAY MAS PAGINAS EN LA API
//        bool next = true;
//        //OBJETO RESPUESTA (DEPENDERA DE COMO ESTA ORGANIZADA LA API)
//        Response items = null;
//        //INICIALIZAMOS EL CLIENTE HTTP
//        HttpClient client = new HttpClient();
//        //VARIABLE ITERADORA QUE RECORRERA LAS PAGINAS DE LA API
//        int i = 1;
//        //INICIAMOS LA LISTA DE PERSONAJES QUE LUEGO PASAREMOS A LA LISTA
//        List<MySprint> mySprints = new List<MySprint>();
//            //MIENTRAS HAYA PAGINAS SEGUIRA EN EL BUCLE
//            while (next)
//            {
//                //LA VARIABLE RESPONSE GUARDARA LA LLAMADA A LA API
//                HttpResponseMessage response = await client.GetAsync("http://192.168.99.100:32769/api/v3/projects/4/work_packages/?offset=" + i);
//                //SI RECIBIMOS UNA RESPUESTA
//                if (response.IsSuccessStatusCode)
//                {
//                    //GUARDAREMOS EN EL OBJETO(MODELO RESPONSE) EL CONTENIDO DE LA RESPUESTA
//                    items = await response.Content.ReadAsAsync<Response>();
//                    //SI EL ATRIBUTO NEXT(MIRA LA URL DE LA SIGUIENTE PAGINA) ES NULL, SALDREMOS DEL BUCLE PORQUE NO HAY MAS PERSONAJES
//                    if (items.offset == null)
//                    {
//                        //PONEMOS NEXT A FALSO PARA QUE SALGA DEL BUCLE
//                        next = false;
//                    }
//}
//                //RECORREMOS EL ARRAY RESULTS QUE ES EL QUE CONTIENE TODOS LOS DATOS QUE NECESITAMOS
//                foreach (var item in items.Results)
//                {    
                   
//                    //CREAMOS UN PERSONAJE POR CADA ELEMENTO EN EL ARRAY RESULTS Y CREAMOS UN PERSONAJE
//                    MySprint ms = new MySprint
//                    {
//                        Name = item.Name,

//                    };

//                    //ANADIMOS EL PERSONAJE CREADO A LA LISTA DE PERSONAJES
//                    mySprint.Add(ms);
//                }
//                //ANADIMOS UNO A i PARA PASAR A LA SIGUIENTE PAGINA
//                i++;
//            }
//            //PASAMOS POR PARAMETRO LA LISTA DE PERSONAJES A LA VISTA
//            return View(MySprint);
//        }

//    }
}
