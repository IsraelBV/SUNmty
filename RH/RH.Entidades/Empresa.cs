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
    
    public partial class Empresa
    {
        public int IdEmpresa { get; set; }
        public string RegistroPatronal { get; set; }
        public string RazonSocial { get; set; }
        public string Guia { get; set; }
        public string ClaveSeguro { get; set; }
        public string RFC { get; set; }
        public string Clase { get; set; }
        public Nullable<decimal> PrimaRiesgo { get; set; }
        public string CP { get; set; }
        public int Pais { get; set; }
        public int IdEstado { get; set; }
        public string Municipio { get; set; }
        public string Colonia { get; set; }
        public string NoExt { get; set; }
        public string Calle { get; set; }
        public bool Status { get; set; }
        public int RegimenFiscal { get; set; }
        public string ArchivoCER { get; set; }
        public string ArchivoKEY { get; set; }
        public string ArchivoPFX { get; set; }
        public string LlavePrivada { get; set; }
        public int FolioUsados { get; set; }
        public Nullable<int> ClaveEmisora_Banco { get; set; }
    }
}
