using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CL1_POO2_T4KB_Penadillo_Angelo.Models;

namespace CL1_POO2_T4KB_Penadillo_Angelo.Controllers
{
    public class ConsultasController : Controller
    {
        // Definir la variable del DAO
        ConsultasDAO dao = new ConsultasDAO();

        // GET: Consultas
        public ActionResult consultaVentas()
        {
            var listado = dao.ConsultaVentas();
            return View(listado);
        }

        public ActionResult consultaVentasAnios(int year1 = 0, int year2 = 0)
        {
            var listado = dao.ConsultaVentasAños(year1, year2);
            //
            ViewBag.YEAR1 = year1;
            ViewBag.YEAR2 = year2;
            //
            int cantidad = listado.Count;
            //
            ViewBag.CANTIDAD = cantidad;
            //
            return View(listado);
        }
        public ActionResult Ventas_Vendedor_Anio(int cod_ven = 0, int year = 0)
        {
            var listado = dao.Ventas_Vendedor_Año(cod_ven, year);
            //
            ViewBag.COD_VEN = cod_ven;
            ViewBag.YEAR = year;
            //
            int cantidad = listado.Count;
            //
            ViewBag.CANTIDAD = cantidad;
            //
            return View(listado);
        }
    }
}