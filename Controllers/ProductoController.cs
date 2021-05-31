using PopcornMVC2.Business;
using PopcornMVC2.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PopcornMVC2.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            Producto_busi Producto_busi = new Producto_busi();

            var lista = Producto_busi.Listar();

            return View(lista);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var biz = new Producto_busi();
            var model = biz.Get(id);
            return View(model);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var Producto_busi = new Producto_busi();
            var producto = Producto_busi.Get(id);
            if (producto == null)
            {
                return View();
            }

            return View(producto);
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            var Producto_busi = new Producto_busi();
            var producto = Producto_busi.Get(id);
            if (producto == null)
            {
                return View();
            }

            return View(producto);
        }


        [HttpPost]
        public ActionResult Create(Producto model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            try
            {
                var biz = new Producto_busi();
                biz.Agregar(model);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                /// Que pasa con el error -> Bitacoras
                Console.WriteLine(e);
                return View(model);
            }
        }
        [HttpPost]
        public ActionResult Delete(Producto model)
        {
            var biz = new Producto_busi();
            biz.Eliminar(model);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Edit(Producto model)
        {
            if (!ModelState.IsValid || model == null)
            {
                return View();
            }
            var Producto_busi = new Producto_busi();
            Producto_busi.Update(model);

            return RedirectToAction("Index");
        }
    }
}