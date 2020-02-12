﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RH.Entidades;

namespace RH.BLL
{
    public static class ConceptosNomina
    {
        /// <summary>
        /// Asigna los conceptos marcados como ByDefault al empleado 
        /// </summary>
        /// <param name="idSucursal"></param>
        /// <param name="idEmpleado"></param>
        /// <returns></returns>
        public static bool AsignarConceptosDefaultByEmpleado(int idSucursal, int idEmpleado)
        {
            RHEntities _ctx = new RHEntities();

            //Obtener los conceptos By Default
            var listaConceptos = _ctx.C_NOM_Conceptos.Where(x => x.AsignadoByDefault == true).ToList();

            //Validacion
            if (listaConceptos.Count <= 0) return false;

            //por cada concepto se agrega un registro en la tabla de configuracion
            foreach (var itemLista in listaConceptos)
            {
                var itemExiste =
                    _ctx.NOM_Empleado_Conceptos.FirstOrDefault(x => x.IdEmpleado == idEmpleado && x.IdSucursal == idSucursal &&
                            x.IdConcepto == itemLista.IdConcepto);

                if (itemExiste != null) continue;

                NOM_Empleado_Conceptos item = new NOM_Empleado_Conceptos()
                {
                    IdEmpleado = idEmpleado,
                    IdConcepto = itemLista.IdConcepto,
                    IdSucursal = idSucursal,
                    Fiscal = itemLista.FormulaFiscal,
                    Complemento = itemLista.FormulaComplemento
                };
                _ctx.NOM_Empleado_Conceptos.Add(item);
            }

            _ctx.SaveChanges();

            return true;
        }



    }
}
