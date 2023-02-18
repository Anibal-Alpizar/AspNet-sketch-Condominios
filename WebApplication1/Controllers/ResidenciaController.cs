using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ResidenciaController : Controller
    {
        // GET: Residencia

        public ActionResult Index()
        {
            List<RESIDENCIA> lista = new List<RESIDENCIA>();
            using (CONDOMINIOSEntities ctx = new CONDOMINIOSEntities())
            {
                lista = ctx.RESIDENCIA.ToList();
            }
            return View(lista);
        }
        public ActionResult Details(int? id)
        {
            RESIDENCIA oResidencia = null;
            try
            {
                using (CONDOMINIOSEntities ctx = new CONDOMINIOSEntities())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;
                    oResidencia = ctx.RESIDENCIA.
                        Where(l => l.ID_RESIDENCIA == id).
                        Include(x => x.USUARIO).
                        Include(y => y.ESTADO_RESIDENCIA).
                        FirstOrDefault();
                }
            }
            catch
            {
                throw;
            }
            return View(oResidencia);
        }
    }
}