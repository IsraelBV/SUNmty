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
    
    public partial class C_NOM_Conceptos
    {
        public int IdConcepto { get; set; }
        public string Descripcion { get; set; }
        public string DescripcionCorta { get; set; }
        public string Clave { get; set; }
        public int IdTipoOtroPago { get; set; }
        public bool Obligatorio { get; set; }
        public string Cuenta_Deudora { get; set; }
        public string Cuenta_Acredora { get; set; }
        public int TipoConcepto { get; set; }
        public bool ImpuestoSobreNomina { get; set; }
        public bool FormulaFiscal { get; set; }
        public bool FormulaComplemento { get; set; }
        public bool AsignadoByDefault { get; set; }
    }
}
