using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class NoticiaController : Controller
    {
        // GET: Noticia
        public ActionResult Index()
        {
            IEnumerable<NOTICIA> lista = null;
            using (CONDOMINIOSEntities ctx = new CONDOMINIOSEntities())
            {
                ctx.Configuration.LazyLoadingEnabled = false;
                //lista = ctx.NOTICIAs.ToList<NOTICIA>();

                // obtener todos las noticias incluyendo el tipo de noticia (Anuncio o Noticia)
                //lista= ctx.NOTICIA.Include(x=>x.TIPO_NOTICIA).ToList();

                lista = (from n in ctx.NOTICIA
                         select n).Include(n => n.TIPO_NOTICIA).ToList();


            }
            return View(lista);
        }

        // GET: Noticia/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Noticia/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Noticia/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Noticia/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Noticia/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Noticia/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Noticia/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
