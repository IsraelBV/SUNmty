//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RH.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Inasistencias
    {
        public int IdInasistencia { get; set; }
        public int IdEmpleado { get; set; }
        public int IdTipoInasistencia { get; set; }
        public System.DateTime Fecha { get; set; }
        public Nullable<System.DateTime> FechaFin { get; set; }
        public int Dias { get; set; }
        public bool xNomina { get; set; }
        public int idPeriodo { get; set; }
        public int IdContrato { get; set; }
        public int IdEmpresaFiscal { get; set; }
        public System.DateTime FechaReg { get; set; }
        public int IdUsuario { get; set; }
    }
}
