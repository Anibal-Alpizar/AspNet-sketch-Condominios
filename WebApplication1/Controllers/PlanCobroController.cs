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
    }
}