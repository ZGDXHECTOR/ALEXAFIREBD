using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

using Newtonsoft.Json;

using ALEXAFIREBD.Models;

namespace ALEXAFIREBD.Controllers
{
    public class MantenedorController : Controller
    {


        IFirebaseClient cliente;



        public MantenedorController()
        {
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "Ig3vZgdkOzd19L1CMRgBJA7lUGqSvlum2VJmDs9e",
                BasePath = "https://alexabd-1f52f-default-rtdb.firebaseio.com"



            };



            cliente = new FirebaseClient(config);
        }
         


        // GET: Mantenedor
        public ActionResult Inicio()
        {
            return View();
        }
        public ActionResult Crear()
        {
            return View();
        }
        public ActionResult Editar()
        {
            return View();
        }
        public ActionResult Eliminar()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Crear(Contacto oContacto)
        {
            string IdGenerado = Guid.NewGuid().ToString("N");

            SetResponse response = cliente.Set("contactos/" + IdGenerado, oContacto);

            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return View();
            }
            else
            {
                return View();
            }


            
        }



    }
}