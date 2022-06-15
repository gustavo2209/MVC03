using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MVC03.Models;

namespace MVC03.Controllers
{
    public class HomeController : Controller
    {
        private DaoAmigos daoAmigos;

        public HomeController()
        {
            daoAmigos = new DaoAmigos();
        }

        public ActionResult Index()
        {
            string accion = Request["accion"]; // INS/DEL/UPD

            if (accion != null)
            {
                switch (accion)
                {
                    case "INS":

                        string nombre = Request["nombre"];
                        string correo = Request["correo"];
                        string telefono = Request["telefono"];
                        string direccion = Request["direccion"];

                        amigos t = new amigos();
                        t.nombre = nombre;
                        t.correo = correo;
                        t.telefono = telefono;
                        t.direccion = direccion;

                        daoAmigos.amigosIns(t);

                        break;
                    case "UPD":
                        int idamigo = Convert.ToInt32(Request["idamigo"]);
                        nombre = Request["nombre"];
                        correo = Request["correo"];
                        telefono = Request["telefono"];
                        direccion = Request["direccion"];

                        t = new amigos();
                        t.idamigo = idamigo;
                        t.nombre = nombre;
                        t.correo = correo;
                        t.telefono = telefono;
                        t.direccion = direccion;

                        daoAmigos.amigosUpd(t);
                        break;
                    case "DEL":
                        idamigo = Convert.ToInt32(Request["idamigo"]);
                        daoAmigos.amigosDel(idamigo);
                        break;
                }
            }

            List<amigos> list = daoAmigos.amigosQry();
            ViewBag.Lista = list;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}