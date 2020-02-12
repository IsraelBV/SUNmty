﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nomina.BLL;
using RH.Entidades;
using RH.Entidades.GlobalModel;
using RH.BLL;
using Common.Helpers;
using Common.Utils;
using System.Diagnostics;
using FiltrosWeb;

namespace Nomina.WEB.Controllers
{
    public class ReportesGeneralController : Controller
    {
        // GET: ReportesGeneral
        public ActionResult Index()
        {


            return View();
        }


        public ActionResult DatosEmpleados()
        {

            int idUsuario = SessionHelpers.GetIdUsuario();

            var clienteSucursal = ReportesGenerales.GetSucusalesByUsuario(idUsuario);

            ViewBag.sucursales = clienteSucursal;
            return PartialView();
        }

        public ActionResult GetDatosEmpleadosBySucursal(int id)
        {

            var modelo = ReportesGenerales.GetEmpleadosClienteByIdSucursal(id);


            return PartialView(modelo);
        }

        public FileResult GetFileEmpleadosBySucursal(int id, string nombre)
        {


            var archivoBytes = ReportesGenerales.GetFileEmpleadosBySucursal(id);

            string newFileName = $"Empleados_{nombre}_.xlsx";

            return File(archivoBytes, "application /vnd.openxmlformats-officedocument.spreadsheetml.sheet", newFileName);

        }

    }
}