using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PlanCobroController : Controller
    {
        // GET: PlanCobro
        public ActionResult Index()
        {
            List<GESTION_PLANES_COBRO> listaPlanesCobro = new List<GESTION_PLANES_COBRO>();
            try
            {
                using (CONDOMINIOSEntities ctx = new CONDOMINIOSEntities())
                {
                    listaPlanesCobro = ctx.GESTION_PLANES_COBRO.Include(x => x.USUARIO).ToList();
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
            }
            return View(listaPlanesCobro);
        }
        public ActionResult Details(int? id)
        {
            GESTION_PLANES_COBRO oPlanCobro = null;
            try
            {
                using (CONDOMINIOSEntities ctx = new CONDOMINIOSEntities())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;
                    oPlanCobro = ctx.GESTION_PLANES_COBRO
                        .Where(l => l.ID_PLAN_COBRO == id)
                        .Include(x => x.USUARIO).Include(x => x.USUARIO.ESTADO_USUARIO)
                        .FirstOrDefault();
                }
            }
            catch
            {
                throw;
            }
            return View(oPlanCobro);
        }
    }
}