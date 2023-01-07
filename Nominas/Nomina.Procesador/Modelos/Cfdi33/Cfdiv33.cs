﻿
using System.Xml.Serialization;
using Nomina.Procesador.Modelos.Nomina12;

namespace Nomina.Procesador.Modelos.Cfdi33
{

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.sat.gob.mx/cfd/4", IsNullable = false)]
    public partial class Comprobante
    {

        private ComprobanteCfdiRelacionados cfdiRelacionadosField;

        private ComprobanteEmisor emisorField;

        private ComprobanteReceptor receptorField;

        private ComprobanteConcepto[] conceptosField;

        private ComprobanteImpuestos impuestosField;
        //////
        //////Cambio de septiembre respecto a los namespaces
        //////
        //private ComprobanteComplemento[] complementoField;
        private ComprobanteComplemento complementoField;

        private ComprobanteAddenda addendaField;

        private string versionField;

        private string serieField;

        private string folioField;

        private System.DateTime fechaField;

        private string selloField;

        private c_FormaPago formaPagoField;

        private bool formaPagoFieldSpecified;

        private string noCertificadoField;

        private string certificadoField;

        private string condicionesDePagoField;

        private decimal subTotalField;

        private decimal descuentoField;

        private bool descuentoFieldSpecified;

        private c_Moneda monedaField;

        private decimal tipoCambioField;

        private bool tipoCambioFieldSpecified;

        private decimal totalField;

        private c_TipoDeComprobante tipoDeComprobanteField;

        private c_MetodoPago metodoPagoField;

        private bool metodoPagoFieldSpecified;

        private string lugarExpedicionField;

        private string confirmacionField;

        private string exportacionField;

        private string schemaLocationFieldSpecified;

        public Comprobante()
        {
            this.versionField = "4.0";
        }

        /// <comentarios/>
        public ComprobanteCfdiRelacionados CfdiRelacionados
        {
            get { return this.cfdiRelacionadosField; }
            set { this.cfdiRelacionadosField = value; }
        }

        /// <comentarios/>
        public ComprobanteEmisor Emisor
        {
            get { return this.emisorField; }
            set { this.emisorField = value; }
        }

        /// <comentarios/>
        public ComprobanteReceptor Receptor
        {
            get { return this.receptorField; }
            set { this.receptorField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Concepto", IsNullable = false)]
        public ComprobanteConcepto[] Conceptos
        {
            get { return this.conceptosField; }
            set { this.conceptosField = value; }
        }

        /// <comentarios/>
        public ComprobanteImpuestos Impuestos
        {
            get { return this.impuestosField; }
            set { this.impuestosField = value; }
        }

        //////
        //////Cambio de septiembre respecto a los namespaces
        //////
        /// <comentarios/>
        //[System.Xml.Serialization.XmlElementAttribute("Complemento")]
        //public ComprobanteComplemento[] Complemento
        //{
        //    get { return this.complementoField; }
        //    set { this.complementoField = value; }
        //}

        public ComprobanteComplemento Complemento
        {
            get { return this.complementoField; }
            set { this.complementoField = value; }
        }
        /// <comentarios/>
        public ComprobanteAddenda Addenda
        {
            get { return this.addendaField; }
            set { this.addendaField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Version
        {
            get { return this.versionField; }
            set { this.versionField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Serie
        {
            get { return this.serieField; }
            set { this.serieField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Folio
        {
            get { return this.folioField; }
            set { this.folioField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime Fecha
        {
            get { return this.fechaField; }
            set { this.fechaField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Sello
        {
            get { return this.selloField; }
            set { this.selloField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_FormaPago FormaPago
        {
            get { return this.formaPagoField; }
            set { this.formaPagoField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FormaPagoSpecified
        {
            get { return this.formaPagoFieldSpecified; }
            set { this.formaPagoFieldSpecified = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NoCertificado
        {
            get { return this.noCertificadoField; }
            set { this.noCertificadoField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Certificado
        {
            get { return this.certificadoField; }
            set { this.certificadoField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CondicionesDePago
        {
            get { return this.condicionesDePagoField; }
            set { this.condicionesDePagoField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal SubTotal
        {
            get { return this.subTotalField; }
            set { this.subTotalField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Descuento
        {
            get { return this.descuentoField; }
            set { this.descuentoField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DescuentoSpecified
        {
            get { return this.descuentoFieldSpecified; }
            set { this.descuentoFieldSpecified = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_Moneda Moneda
        {
            get { return this.monedaField; }
            set { this.monedaField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TipoCambio
        {
            get { return this.tipoCambioField; }
            set { this.tipoCambioField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TipoCambioSpecified
        {
            get { return this.tipoCambioFieldSpecified; }
            set { this.tipoCambioFieldSpecified = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Total
        {
            get { return this.totalField; }
            set { this.totalField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_TipoDeComprobante TipoDeComprobante
        {
            get { return this.tipoDeComprobanteField; }
            set { this.tipoDeComprobanteField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_MetodoPago MetodoPago
        {
            get { return this.metodoPagoField; }
            set { this.metodoPagoField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MetodoPagoSpecified
        {
            get { return this.metodoPagoFieldSpecified; }
            set { this.metodoPagoFieldSpecified = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LugarExpedicion
        {
            get { return this.lugarExpedicionField; }
            set { this.lugarExpedicionField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Confirmacion
        {
            get { return this.confirmacionField; }
            set { this.confirmacionField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Exportacion
        {
            get { return this.exportacionField; }
            set { this.exportacionField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string schemaLocation
        {
            get { return this.schemaLocationFieldSpecified; }
            set { this.schemaLocationFieldSpecified = value; }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteCfdiRelacionados
    {

        private ComprobanteCfdiRelacionadosCfdiRelacionado[] cfdiRelacionadoField;

        private c_TipoRelacion tipoRelacionField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("CfdiRelacionado")]
        public ComprobanteCfdiRelacionadosCfdiRelacionado[] CfdiRelacionado
        {
            get { return this.cfdiRelacionadoField; }
            set { this.cfdiRelacionadoField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_TipoRelacion TipoRelacion
        {
            get { return this.tipoRelacionField; }
            set { this.tipoRelacionField = value; }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteCfdiRelacionadosCfdiRelacionado
    {

        private string uUIDField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UUID
        {
            get { return this.uUIDField; }
            set { this.uUIDField = value; }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
    public enum c_TipoRelacion
    {

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("05")]
        Item05,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("06")]
        Item06,
    }





    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteEmisor
    {

        private string rfcField;

        private string nombreField;

        private c_RegimenFiscal regimenFiscalField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Rfc
        {
            get { return this.rfcField; }
            set { this.rfcField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Nombre
        {
            get { return this.nombreField; }
            set { this.nombreField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_RegimenFiscal RegimenFiscal
        {
            get { return this.regimenFiscalField; }
            set { this.regimenFiscalField = value; }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
    public enum c_RegimenFiscal
    {

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("601")]
        Item601,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("603")]
        Item603,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("605")]
        Item605,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("606")]
        Item606,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("608")]
        Item608,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("609")]
        Item609,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("610")]
        Item610,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("611")]
        Item611,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("612")]
        Item612,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("614")]
        Item614,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("616")]
        Item616,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("620")]
        Item620,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("621")]
        Item621,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("622")]
        Item622,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("623")]
        Item623,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("624")]
        Item624,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("628")]
        Item628,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("607")]
        Item607,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("629")]
        Item629,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("630")]
        Item630,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("615")]
        Item615,
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteReceptor
    {

        private string rfcField;

        private string nombreField;

        private string domicilioFiscalReceptorField;

        private c_RegimenFiscal regimenFiscalReceptorField;

        private string residenciaFiscalField; //c_pais

        private bool residenciaFiscalFieldSpecified;

        private string numRegIdTribField;

        private c_UsoCFDI usoCFDIField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Rfc
        {
            get { return this.rfcField; }
            set { this.rfcField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Nombre
        {
            get { return this.nombreField; }
            set { this.nombreField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DomicilioFiscalReceptor
        {
            //c_Pais
            get { return this.domicilioFiscalReceptorField; }
            set { this.domicilioFiscalReceptorField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_RegimenFiscal regimenFiscalReceptor
        {
            //c_Pais
            get { return this.regimenFiscalReceptorField; }
            set { this.regimenFiscalReceptorField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResidenciaFiscal
        {
            //c_Pais
            get { return this.residenciaFiscalField; }
            set { this.residenciaFiscalField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResidenciaFiscalSpecified
        {
            get { return this.residenciaFiscalFieldSpecified; }
            set { this.residenciaFiscalFieldSpecified = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumRegIdTrib
        {
            get { return this.numRegIdTribField; }
            set { this.numRegIdTribField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_UsoCFDI UsoCFDI
        {
            get { return this.usoCFDIField; }
            set { this.usoCFDIField = value; }
        }
    }

    /// <comentarios/>

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
    public enum c_UsoCFDI
    {

        /// <comentarios/>
        G01,

        /// <comentarios/>
        G02,

        /// <comentarios/>
        G03,

        /// <comentarios/>
        I01,

        /// <comentarios/>
        I02,

        /// <comentarios/>
        I03,

        /// <comentarios/>
        I04,

        /// <comentarios/>
        I05,

        /// <comentarios/>
        I06,

        /// <comentarios/>
        I07,

        /// <comentarios/>
        I08,

        /// <comentarios/>
        D01,

        /// <comentarios/>
        D02,

        /// <comentarios/>
        D03,

        /// <comentarios/>
        D04,

        /// <comentarios/>
        D05,

        /// <comentarios/>
        D06,

        /// <comentarios/>
        D07,

        /// <comentarios/>
        D08,

        /// <comentarios/>
        D09,

        /// <comentarios/>
        D10,

        /// <comentarios/>
        S01,

        /// <comentarios/>
        CP01,

        /// <comentarios/>
        CN01,
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteConcepto
    {

        private ComprobanteConceptoImpuestos impuestosField;

        private ComprobanteConceptoInformacionAduanera[] informacionAduaneraField;

        private ComprobanteConceptoCuentaPredial cuentaPredialField;

        private ComprobanteConceptoComplementoConcepto complementoConceptoField;

        private ComprobanteConceptoParte[] parteField;

        private string claveProdServField; //c_ClaveProdServ

        private string noIdentificacionField;

        private decimal cantidadField;

        private string claveUnidadField; //c_ClaveUnidad

        private string unidadField;

        private string descripcionField;

        private decimal valorUnitarioField;

        private decimal importeField;

        private decimal descuentoField;

        private bool descuentoFieldSpecified;

        private int objetoImpField;

        /// <comentarios/>
        public ComprobanteConceptoImpuestos Impuestos
        {
            get { return this.impuestosField; }
            set { this.impuestosField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("InformacionAduanera")]
        public ComprobanteConceptoInformacionAduanera[] InformacionAduanera
        {
            get { return this.informacionAduaneraField; }
            set { this.informacionAduaneraField = value; }
        }

        /// <comentarios/>
        public ComprobanteConceptoCuentaPredial CuentaPredial
        {
            get { return this.cuentaPredialField; }
            set { this.cuentaPredialField = value; }
        }

        /// <comentarios/>
        public ComprobanteConceptoComplementoConcepto ComplementoConcepto
        {
            get { return this.complementoConceptoField; }
            set { this.complementoConceptoField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("Parte")]
        public ComprobanteConceptoParte[] Parte
        {
            get { return this.parteField; }
            set { this.parteField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ClaveProdServ
        {
            //c_ClaveProdServ
            get { return this.claveProdServField; }
            set { this.claveProdServField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NoIdentificacion
        {
            get { return this.noIdentificacionField; }
            set { this.noIdentificacionField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Cantidad
        {
            get { return this.cantidadField; }
            set { this.cantidadField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ClaveUnidad
        {
            //c_ClaveUnidad
            get { return this.claveUnidadField; }
            set { this.claveUnidadField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Unidad
        {
            get { return this.unidadField; }
            set { this.unidadField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Descripcion
        {
            get { return this.descripcionField; }
            set { this.descripcionField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ValorUnitario
        {
            get { return this.valorUnitarioField; }
            set { this.valorUnitarioField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Importe
        {
            get { return this.importeField; }
            set { this.importeField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Descuento
        {
            get { return this.descuentoField; }
            set { this.descuentoField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int ObjetoImp
        {
            get { return this.objetoImpField; }
            set { this.objetoImpField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DescuentoSpecified
        {
            get { return this.descuentoFieldSpecified; }
            set { this.descuentoFieldSpecified = value; }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteConceptoImpuestos
    {

        private ComprobanteConceptoImpuestosTraslado[] trasladosField;

        private ComprobanteConceptoImpuestosRetencion[] retencionesField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Traslado", IsNullable = false)]
        public ComprobanteConceptoImpuestosTraslado[] Traslados
        {
            get { return this.trasladosField; }
            set { this.trasladosField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Retencion", IsNullable = false)]
        public ComprobanteConceptoImpuestosRetencion[] Retenciones
        {
            get { return this.retencionesField; }
            set { this.retencionesField = value; }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteConceptoImpuestosTraslado
    {

        private decimal baseField;

        private c_Impuesto impuestoField;

        private c_TipoFactor tipoFactorField;

        private decimal tasaOCuotaField;

        private bool tasaOCuotaFieldSpecified;

        private decimal importeField;

        private bool importeFieldSpecified;

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Base
        {
            get { return this.baseField; }
            set { this.baseField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_Impuesto Impuesto
        {
            get { return this.impuestoField; }
            set { this.impuestoField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_TipoFactor TipoFactor
        {
            get { return this.tipoFactorField; }
            set { this.tipoFactorField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TasaOCuota
        {
            get { return this.tasaOCuotaField; }
            set { this.tasaOCuotaField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TasaOCuotaSpecified
        {
            get { return this.tasaOCuotaFieldSpecified; }
            set { this.tasaOCuotaFieldSpecified = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Importe
        {
            get { return this.importeField; }
            set { this.importeField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ImporteSpecified
        {
            get { return this.importeFieldSpecified; }
            set { this.importeFieldSpecified = value; }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
    public enum c_Impuesto
    {

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("001")]
        Item001,//ISR

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("002")]
        Item002,//IVA

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("003")]
        Item003,//IEPS
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
    public enum c_TipoFactor
    {

        /// <comentarios/>
        Tasa,

        /// <comentarios/>
        Cuota,

        /// <comentarios/>
        Exento,
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteConceptoImpuestosRetencion
    {

        private decimal baseField;

        private c_Impuesto impuestoField;

        private c_TipoFactor tipoFactorField;

        private decimal tasaOCuotaField;

        private decimal importeField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Base
        {
            get { return this.baseField; }
            set { this.baseField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_Impuesto Impuesto
        {
            get { return this.impuestoField; }
            set { this.impuestoField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_TipoFactor TipoFactor
        {
            get { return this.tipoFactorField; }
            set { this.tipoFactorField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TasaOCuota
        {
            get { return this.tasaOCuotaField; }
            set { this.tasaOCuotaField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Importe
        {
            get { return this.importeField; }
            set { this.importeField = value; }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteConceptoInformacionAduanera
    {

        private string numeroPedimentoField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumeroPedimento
        {
            get { return this.numeroPedimentoField; }
            set { this.numeroPedimentoField = value; }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteConceptoCuentaPredial
    {

        private string numeroField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Numero
        {
            get { return this.numeroField; }
            set { this.numeroField = value; }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteConceptoComplementoConcepto
    {

        private System.Xml.XmlElement[] anyField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any
        {
            get { return this.anyField; }
            set { this.anyField = value; }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteConceptoParte
    {

        private ComprobanteConceptoParteInformacionAduanera[] informacionAduaneraField;

        private string claveProdServField; //c_ClaveProdServ

        private string noIdentificacionField;

        private decimal cantidadField;

        private string unidadField;

        private string descripcionField;

        private decimal valorUnitarioField;

        private bool valorUnitarioFieldSpecified;

        private decimal importeField;

        private bool importeFieldSpecified;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("InformacionAduanera")]
        public ComprobanteConceptoParteInformacionAduanera[] InformacionAduanera
        {
            get { return this.informacionAduaneraField; }
            set { this.informacionAduaneraField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ClaveProdServ
        {
            //c_ClaveProdServ
            get { return this.claveProdServField; }
            set { this.claveProdServField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NoIdentificacion
        {
            get { return this.noIdentificacionField; }
            set { this.noIdentificacionField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Cantidad
        {
            get { return this.cantidadField; }
            set { this.cantidadField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Unidad
        {
            get { return this.unidadField; }
            set { this.unidadField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Descripcion
        {
            get { return this.descripcionField; }
            set { this.descripcionField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ValorUnitario
        {
            get { return this.valorUnitarioField; }
            set { this.valorUnitarioField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValorUnitarioSpecified
        {
            get { return this.valorUnitarioFieldSpecified; }
            set { this.valorUnitarioFieldSpecified = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Importe
        {
            get { return this.importeField; }
            set { this.importeField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ImporteSpecified
        {
            get { return this.importeFieldSpecified; }
            set { this.importeFieldSpecified = value; }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteConceptoParteInformacionAduanera
    {

        private string numeroPedimentoField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumeroPedimento
        {
            get { return this.numeroPedimentoField; }
            set { this.numeroPedimentoField = value; }
        }
    }



    //DESDE AQUI


    //HASTA AQUI


    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteImpuestos
    {

        private ComprobanteImpuestosRetencion[] retencionesField;

        private ComprobanteImpuestosTraslado[] trasladosField;

        private decimal totalImpuestosRetenidosField;

        private bool totalImpuestosRetenidosFieldSpecified;

        private decimal totalImpuestosTrasladadosField;

        private bool totalImpuestosTrasladadosFieldSpecified;

        /// <comentarios/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Retencion", IsNullable = false)]
        public ComprobanteImpuestosRetencion[] Retenciones
        {
            get { return this.retencionesField; }
            set { this.retencionesField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Traslado", IsNullable = false)]
        public ComprobanteImpuestosTraslado[] Traslados
        {
            get { return this.trasladosField; }
            set { this.trasladosField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TotalImpuestosRetenidos
        {
            get { return this.totalImpuestosRetenidosField; }
            set { this.totalImpuestosRetenidosField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalImpuestosRetenidosSpecified
        {
            get { return this.totalImpuestosRetenidosFieldSpecified; }
            set { this.totalImpuestosRetenidosFieldSpecified = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TotalImpuestosTrasladados
        {
            get { return this.totalImpuestosTrasladadosField; }
            set { this.totalImpuestosTrasladadosField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalImpuestosTrasladadosSpecified
        {
            get { return this.totalImpuestosTrasladadosFieldSpecified; }
            set { this.totalImpuestosTrasladadosFieldSpecified = value; }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteImpuestosRetencion
    {

        private c_Impuesto impuestoField;

        private decimal importeField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_Impuesto Impuesto
        {
            get { return this.impuestoField; }
            set { this.impuestoField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Importe
        {
            get { return this.importeField; }
            set { this.importeField = value; }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteImpuestosTraslado
    {

        private c_Impuesto impuestoField;

        private c_TipoFactor tipoFactorField;

        private decimal tasaOCuotaField;

        private decimal importeField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_Impuesto Impuesto
        {
            get { return this.impuestoField; }
            set { this.impuestoField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_TipoFactor TipoFactor
        {
            get { return this.tipoFactorField; }
            set { this.tipoFactorField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TasaOCuota
        {
            get { return this.tasaOCuotaField; }
            set { this.tasaOCuotaField = value; }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Importe
        {
            get { return this.importeField; }
            set { this.importeField = value; }
        }
    }


    //////
    //////Cambio de septiembre respecto a los namespaces
    //////
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    //[System.SerializableAttribute()]
    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.ComponentModel.DesignerCategoryAttribute("code")]
    ////[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    //public partial class ComprobanteComplemento
    //{
    //    private System.Xml.XmlElement[] anyField;

    //    /// <comentarios/>
    //    [System.Xml.Serialization.XmlAnyElementAttribute()]
    //    public System.Xml.XmlElement[] Any
    //    {
    //        get { return this.anyField; }
    //        set { this.anyField = value; }
    //    }
    //}

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
    public partial class ComprobanteComplemento
    {
        private Modelos.Nomina12.Nomina NominaField;
        
        public Modelos.Nomina12.Nomina Nomina
        {
            get { return this.NominaField; }
            set { this.NominaField = value; }
        }
        
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteAddenda
    {

        private System.Xml.XmlElement[] anyField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any
        {
            get { return this.anyField; }
            set { this.anyField = value; }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
    public enum c_FormaPago
    {

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("05")]
        Item05,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("06")]
        Item06,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("08")]
        Item08,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("13")]
        Item13,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("14")]
        Item14,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("15")]
        Item15,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("17")]
        Item17,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("23")]
        Item23,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("24")]
        Item24,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("25")]
        Item25,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("26")]
        Item26,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("27")]
        Item27,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("28")]
        Item28,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("29")]
        Item29,

        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("99")]
        Item99,
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
    public enum c_Moneda
    {

        /// <comentarios/>
        AED,

        /// <comentarios/>
        AFN,

        /// <comentarios/>
        ALL,

        /// <comentarios/>
        AMD,

        /// <comentarios/>
        ANG,

        /// <comentarios/>
        AOA,

        /// <comentarios/>
        ARS,

        /// <comentarios/>
        AUD,

        /// <comentarios/>
        AWG,

        /// <comentarios/>
        AZN,

        /// <comentarios/>
        BAM,

        /// <comentarios/>
        BBD,

        /// <comentarios/>
        BDT,

        /// <comentarios/>
        BGN,

        /// <comentarios/>
        BHD,

        /// <comentarios/>
        BIF,

        /// <comentarios/>
        BMD,

        /// <comentarios/>
        BND,

        /// <comentarios/>
        BOB,

        /// <comentarios/>
        BOV,

        /// <comentarios/>
        BRL,

        /// <comentarios/>
        BSD,

        /// <comentarios/>
        BTN,

        /// <comentarios/>
        BWP,

        /// <comentarios/>
        BYR,

        /// <comentarios/>
        BZD,

        /// <comentarios/>
        CAD,

        /// <comentarios/>
        CDF,

        /// <comentarios/>
        CHE,

        /// <comentarios/>
        CHF,

        /// <comentarios/>
        CHW,

        /// <comentarios/>
        CLF,

        /// <comentarios/>
        CLP,

        /// <comentarios/>
        CNY,

        /// <comentarios/>
        COP,

        /// <comentarios/>
        COU,

        /// <comentarios/>
        CRC,

        /// <comentarios/>
        CUC,

        /// <comentarios/>
        CUP,

        /// <comentarios/>
        CVE,

        /// <comentarios/>
        CZK,

        /// <comentarios/>
        DJF,

        /// <comentarios/>
        DKK,

        /// <comentarios/>
        DOP,

        /// <comentarios/>
        DZD,

        /// <comentarios/>
        EGP,

        /// <comentarios/>
        ERN,

        /// <comentarios/>
        ETB,

        /// <comentarios/>
        EUR,

        /// <comentarios/>
        FJD,

        /// <comentarios/>
        FKP,

        /// <comentarios/>
        GBP,

        /// <comentarios/>
        GEL,

        /// <comentarios/>
        GHS,

        /// <comentarios/>
        GIP,

        /// <comentarios/>
        GMD,

        /// <comentarios/>
        GNF,

        /// <comentarios/>
        GTQ,

        /// <comentarios/>
        GYD,

        /// <comentarios/>
        HKD,

        /// <comentarios/>
        HNL,

        /// <comentarios/>
        HRK,

        /// <comentarios/>
        HTG,

        /// <comentarios/>
        HUF,

        /// <comentarios/>
        IDR,

        /// <comentarios/>
        ILS,

        /// <comentarios/>
        INR,

        /// <comentarios/>
        IQD,

        /// <comentarios/>
        IRR,

        /// <comentarios/>
        ISK,

        /// <comentarios/>
        JMD,

        /// <comentarios/>
        JOD,

        /// <comentarios/>
        JPY,

        /// <comentarios/>
        KES,

        /// <comentarios/>
        KGS,

        /// <comentarios/>
        KHR,

        /// <comentarios/>
        KMF,

        /// <comentarios/>
        KPW,

        /// <comentarios/>
        KRW,

        /// <comentarios/>
        KWD,

        /// <comentarios/>
        KYD,

        /// <comentarios/>
        KZT,

        /// <comentarios/>
        LAK,

        /// <comentarios/>
        LBP,

        /// <comentarios/>
        LKR,

        /// <comentarios/>
        LRD,

        /// <comentarios/>
        LSL,

        /// <comentarios/>
        LYD,

        /// <comentarios/>
        MAD,

        /// <comentarios/>
        MDL,

        /// <comentarios/>
        MGA,

        /// <comentarios/>
        MKD,

        /// <comentarios/>
        MMK,

        /// <comentarios/>
        MNT,

        /// <comentarios/>
        MOP,

        /// <comentarios/>
        MRO,

        /// <comentarios/>
        MUR,

        /// <comentarios/>
        MVR,

        /// <comentarios/>
        MWK,

        /// <comentarios/>
        MXN,

        /// <comentarios/>
        MXV,

        /// <comentarios/>
        MYR,

        /// <comentarios/>
        MZN,

        /// <comentarios/>
        NAD,

        /// <comentarios/>
        NGN,

        /// <comentarios/>
        NIO,

        /// <comentarios/>
        NOK,

        /// <comentarios/>
        NPR,

        /// <comentarios/>
        NZD,

        /// <comentarios/>
        OMR,

        /// <comentarios/>
        PAB,

        /// <comentarios/>
        PEN,

        /// <comentarios/>
        PGK,

        /// <comentarios/>
        PHP,

        /// <comentarios/>
        PKR,

        /// <comentarios/>
        PLN,

        /// <comentarios/>
        PYG,

        /// <comentarios/>
        QAR,

        /// <comentarios/>
        RON,

        /// <comentarios/>
        RSD,

        /// <comentarios/>
        RUB,

        /// <comentarios/>
        RWF,

        /// <comentarios/>
        SAR,

        /// <comentarios/>
        SBD,

        /// <comentarios/>
        SCR,

        /// <comentarios/>
        SDG,

        /// <comentarios/>
        SEK,

        /// <comentarios/>
        SGD,

        /// <comentarios/>
        SHP,

        /// <comentarios/>
        SLL,

        /// <comentarios/>
        SOS,

        /// <comentarios/>
        SRD,

        /// <comentarios/>
        SSP,

        /// <comentarios/>
        STD,

        /// <comentarios/>
        SVC,

        /// <comentarios/>
        SYP,

        /// <comentarios/>
        SZL,

        /// <comentarios/>
        THB,

        /// <comentarios/>
        TJS,

        /// <comentarios/>
        TMT,

        /// <comentarios/>
        TND,

        /// <comentarios/>
        TOP,

        /// <comentarios/>
        TRY,

        /// <comentarios/>
        TTD,

        /// <comentarios/>
        TWD,

        /// <comentarios/>
        TZS,

        /// <comentarios/>
        UAH,

        /// <comentarios/>
        UGX,

        /// <comentarios/>
        USD,

        /// <comentarios/>
        USN,

        /// <comentarios/>
        UYI,

        /// <comentarios/>
        UYU,

        /// <comentarios/>
        UZS,

        /// <comentarios/>
        VEF,

        /// <comentarios/>
        VND,

        /// <comentarios/>
        VUV,

        /// <comentarios/>
        WST,

        /// <comentarios/>
        XAF,

        /// <comentarios/>
        XAG,

        /// <comentarios/>
        XAU,

        /// <comentarios/>
        XBA,

        /// <comentarios/>
        XBB,

        /// <comentarios/>
        XBC,

        /// <comentarios/>
        XBD,

        /// <comentarios/>
        XCD,

        /// <comentarios/>
        XDR,

        /// <comentarios/>
        XOF,

        /// <comentarios/>
        XPD,

        /// <comentarios/>
        XPF,

        /// <comentarios/>
        XPT,

        /// <comentarios/>
        XSU,

        /// <comentarios/>
        XTS,

        /// <comentarios/>
        XUA,

        /// <comentarios/>
        XXX,

        /// <comentarios/>
        YER,

        /// <comentarios/>
        ZAR,

        /// <comentarios/>
        ZMW,

        /// <comentarios/>
        ZWL,
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
    public enum c_TipoDeComprobante
    {

        /// <comentarios/>
        I,

        /// <comentarios/>
        E,

        /// <comentarios/>
        T,

        /// <comentarios/>
        N,

        /// <comentarios/>
        P,
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
    public enum c_MetodoPago
    {

        /// <comentarios/>
        PUE,

        /// <comentarios/>
        PIP,

        /// <comentarios/>
        PPD,
    }

}