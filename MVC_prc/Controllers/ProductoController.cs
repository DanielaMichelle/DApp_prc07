using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_prc.datos;
using MVC_prc.Models;

namespace MVC_prc.Controllers
{
    public class ProductoController : Controller
    {
        ProductoAdmin admin = new ProductoAdmin();
        // GET: Producto
        public ActionResult Index() // => Método de acción
        {
            return View(admin.Consultar());
        }
        public ActionResult Detalle(int id) // => Método de acción
        {
            return View(admin.Consultar(id));
        }
        public ActionResult Crear()
        {
            return View();
        }
        public ActionResult Guardar(PRODUCTO modelo)
        {
            admin.Guardar(modelo);
            return View("Crear", modelo);
        }
        public ActionResult Editar(int id)
        {
            return View(admin.Consultar(id));
        }
        public ActionResult Modificar(PRODUCTO modelo)
        {
            admin.Modificar(modelo);
            return View("Editar", modelo);
        }
        public ActionResult Eliminar(int id)
        {
            PRODUCTO modelo = admin.Consultar(id);
            admin.Eliminar(modelo);
            return View("Index", admin.Consultar());
        }
    }
}