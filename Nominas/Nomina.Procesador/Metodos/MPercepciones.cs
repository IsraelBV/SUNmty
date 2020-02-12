﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Nomina.Procesador.Modelos;
using Nomina.Procesador.Datos;
using RH.Entidades;
using Common.Utils;

namespace Nomina.Procesador.Metodos
{
    public static class MPercepciones
    {
        static readonly NominasDao _nominasDao = new NominasDao();


        public static void GenerarPercepciones(NOM_Nomina nomina, bool isImpuesSobreNomina = false, decimal porcentaje = 0)
        {

        }

        #region "MÉTODOS FISCALES"

        /// <summary>
        /// Concepto de Sueldo
        /// </summary>
        /// <param name="nomina"></param>
        /// <param name="isImpuestoSobreNomina"></param>
        /// <param name="porcentaje"></param>
        public static NOM_Nomina_Detalle Sueldo(NOM_Nomina nomina, int diasPeriodo, bool isImpuestoSobreNomina = false, decimal porcentaje = 0, int diasVacaciones = 0)
        {

            decimal _sueldo = 0;
            decimal _sueldoI = 0;
            decimal _impuestoSobreNomina = 0;
            int diasSueldo = 0;

            diasSueldo = nomina.Dias_Laborados;

            if (diasVacaciones > 0)
            {
                diasSueldo -= diasVacaciones;
            }

            _sueldo = Utils.TruncateDecimales(nomina.SD * diasSueldo);
            _sueldoI = Utils.TruncateDecimales(nomina.SDI * diasSueldo);

            if (isImpuestoSobreNomina)
            {
                //_impuestoSobreNomina = _sueldoI * porcentaje;
                //_impuestoSobreNomina = Utils.ImpuestoSobreNomina(_sueldoI, porcentaje, diasPeriodo);
                _impuestoSobreNomina = Utils.ImpuestoSobreNomina(nomina.SD, porcentaje, diasSueldo);
            }

            NOM_Nomina_Detalle item = new NOM_Nomina_Detalle()
            {
                Id = 0,
                IdNomina = nomina.IdNomina,
                IdConcepto = 1,
                Total = _sueldo,
                GravadoISR = _sueldo,
                ExentoISR = 0,
                IntegraIMSS = _sueldoI,
                ImpuestoSobreNomina = _impuestoSobreNomina,
                Complemento = false
            };

            return item;

        }

        public static NOM_Nomina_Detalle Vacaciones(NOM_Nomina nomina,  int diasDeVacaciones, bool isImpuestoSobreNomina = false, decimal porcentaje = 0)
        {
            decimal _vacaciones = 0;
            decimal _impuestoSobreNominaVac = 0;

            //Grava 100%
            _vacaciones = Utils.TruncateDecimales(nomina.SD * diasDeVacaciones);

            if (isImpuestoSobreNomina)
            {
                _impuestoSobreNominaVac = Utils.ImpuestoSobreNomina(_vacaciones , porcentaje);
            }

            NOM_Nomina_Detalle item = new NOM_Nomina_Detalle()
            {
                Id = 0,
                IdNomina = nomina.IdNomina,
                IdConcepto = 148,
                Total = _vacaciones,
                GravadoISR = _vacaciones,
                ExentoISR = 0,
                IntegraIMSS = 0,
                ImpuestoSobreNomina =_impuestoSobreNominaVac,
                Complemento = false
            };

            return item;

        }

        public static NOM_Nomina_Detalle PrimaVacaciones(NOM_Nomina nomina, decimal vacaciones, decimal smg, bool isImpuestoSobreNomina = false, decimal porcentaje = 0)
        {

            if (vacaciones <= 0)
                return null;

            decimal _primaVacacional = 0;
            decimal _topePrima = 0;
            decimal _impuestoSobreNominaPrima = 0;
            decimal PrimaVacacionalExcento = 0;
            decimal PrimaVacacionaGravado = 0;

            //Tope SMG * 15
            _topePrima = smg * 15;
            _primaVacacional = Utils.TruncateDecimales(vacaciones * (decimal).25);


            PrimaVacacionalExcento = Utils.TruncateDecimales(_primaVacacional <= _topePrima ? _primaVacacional : _topePrima);
            PrimaVacacionaGravado = Utils.TruncateDecimales(_primaVacacional - PrimaVacacionalExcento);

            if (isImpuestoSobreNomina)
            {
                _impuestoSobreNominaPrima = Utils.ImpuestoSobreNomina(PrimaVacacionalExcento, porcentaje);
            }

            NOM_Nomina_Detalle item = new NOM_Nomina_Detalle()
            {
                Id = 0,
                IdNomina = nomina.IdNomina,
                IdConcepto = 16,
                Total = _primaVacacional,
                GravadoISR = PrimaVacacionaGravado,
                ExentoISR = PrimaVacacionalExcento,
                IntegraIMSS = 0,
                ImpuestoSobreNomina = _impuestoSobreNominaPrima,
                Complemento = false
            };

            return item;

        }

        /// <summary>
        /// Metodo usado para el remigen 02 Sueldo -
        /// </summary>
        /// <param name="nomina"></param>
        /// <param name="diasPeriodo"></param>
        /// <param name="isImpuestoSobreNomina"></param>
        /// <param name="porcentaje"></param>
        /// <returns></returns>
        public static NOM_Nomina_Detalle AsimiladosASalarios(NOM_Nomina nomina, int diasPeriodo, bool isImpuestoSobreNomina = false, decimal porcentaje = 0)
        {
            decimal _sueldo = 0;
            decimal _sueldoI = 0;
            _sueldo = Utils.TruncateDecimales(nomina.SD * nomina.Dias_Laborados);
            _sueldoI = nomina.SDI * nomina.Dias_Laborados;
            decimal _impuestoSobreNomina = 0;
            if (isImpuestoSobreNomina)
            {
                //_impuestoSobreNomina = _sueldoI * porcentaje;
                //_impuestoSobreNomina = Utils.ImpuestoSobreNomina(_sueldoI, porcentaje, diasPeriodo);
                _impuestoSobreNomina = Utils.ImpuestoSobreNomina(nomina.SD, porcentaje, nomina.Dias_Laborados);
            }

            NOM_Nomina_Detalle item = new NOM_Nomina_Detalle()
            {
                Id = 0,
                IdNomina = nomina.IdNomina,
                IdConcepto = 37,
                Total = _sueldo,
                GravadoISR = _sueldo,
                ExentoISR = 0,
                IntegraIMSS = 0,
                ImpuestoSobreNomina = 0, //_impuestoSobreNomina,
                Complemento = false
            };

            return item;

        }

        /// <summary>
        /// Concepto Premios de Asistencias
        /// </summary>
        /// <param name="nomina"></param>
        /// <param name="isImpuestoSobreNomina"></param>
        /// <param name="porcentaje"></param>
        public static NOM_Nomina_Detalle PremiosAsistencia(NOM_Nomina nomina, int diasPeriodo, bool isImpuestoSobreNomina = false, decimal porcentaje = 0)
        {

            decimal _premiosAsistencia = 0;
            const decimal diez = (decimal)0.10;
            _premiosAsistencia = Utils.TruncateDecimales((nomina.SDI * nomina.Dias_Laborados) * diez);
            decimal _impuestoSobreNomina = 0;

            if (isImpuestoSobreNomina)
            {
                _impuestoSobreNomina = Utils.ImpuestoSobreNomina(_premiosAsistencia, porcentaje);
                //_impuestoSobreNomina = _premiosAsistencia * porcentaje; // CANCUN
                // _impuestoSobreNomina = Utils.ImpuestoSobreNomina(_premiosAsistencia, porcentaje, nomina.Dias_Laborados); //MTY
            }

            //   GuardarConcepto(nomina.IdNomina, 40, _premiosAsistencia, _premiosAsistencia, impuestoNomina: _impuestoSobreNomina);

            NOM_Nomina_Detalle item = new NOM_Nomina_Detalle()
            {
                Id = 0,
                IdNomina = nomina.IdNomina,
                IdConcepto = 40,
                Total = _premiosAsistencia,
                GravadoISR = _premiosAsistencia,
                ExentoISR = 0,
                IntegraIMSS = 0,
                //ImpuestoSobreNomina = Utils.TruncateDecimales(_impuestoSobreNomina),
                ImpuestoSobreNomina = _impuestoSobreNomina,
                Complemento = false
            };

            return item;


        }

        /// <summary>
        /// Concepto de Premios de Puntualidad
        /// </summary>
        /// <param name="nomina"></param>
        /// <param name="isImpuestoSobreNomina"></param>
        /// <param name="porcentaje"></param>
        public static NOM_Nomina_Detalle PremiosPuntualidad(NOM_Nomina nomina, int diasPeriodo, bool isImpuestoSobreNomina = false, decimal porcentaje = 0)
        {
            decimal _premiosPuntualidad = 0;
            const decimal diez = (decimal)0.10;
            _premiosPuntualidad = Utils.TruncateDecimales((nomina.SDI * nomina.Dias_Laborados) * diez);
            decimal _impuestoSobreNomina = 0;

            if (isImpuestoSobreNomina)
            {
                _impuestoSobreNomina = Utils.ImpuestoSobreNomina(_premiosPuntualidad, porcentaje);
                //_impuestoSobreNomina = _premiosPuntualidad * porcentaje;// CANCUN
                //_impuestoSobreNomina = Utils.ImpuestoSobreNomina(_premiosPuntualidad, porcentaje, nomina.Dias_Laborados); // MTY
            }

            //   GuardarConcepto(nomina.IdNomina, 8, _premiosPuntualidad, _premiosPuntualidad, impuestoNomina: _impuestoSobreNomina);

            NOM_Nomina_Detalle item = new NOM_Nomina_Detalle()
            {
                Id = 0,
                IdNomina = nomina.IdNomina,
                IdConcepto = 8,
                Total = _premiosPuntualidad,
                GravadoISR = _premiosPuntualidad,
                ExentoISR = 0,
                IntegraIMSS = 0,
                ImpuestoSobreNomina = _impuestoSobreNomina,
                Complemento = false
            };

            return item;
        }

        public static List<NOM_Nomina_Detalle> HorasExtras(NOM_Nomina nomina, decimal salarioMin, NOM_PeriodosPago periodoPago, bool isImpuestoSobreNomina = false, decimal porcentaje = 0)
        {
            decimal sd = nomina.SD;
            decimal limiteExento = 0;
            int horasExtras = 0;

            decimal valorDobles = 0;
            decimal valorTriples = 0;

            int horasDobles = 0;
            int horasTriples = 0;

            int diasD = 0;
            int diasT = 0;
            int tipo = 0;

            decimal isnDobles = 0;
            decimal isnTriples = 0;

            List<NOM_Nomina_Detalle> listaDetalles = new List<NOM_Nomina_Detalle>();

            //GetData()
            //Validar el rango de fechas del periodo
            //Recibo
            //integrar al xml

            //Para obtener los dias, no solo sera con el count sino revisar que no sean las mismas fechas

            List<HorasExtrasEmpleado> listaGeneral = NominasDao.GetHorasExtras(nomina.IdEmpleado, periodoPago);

            listaGeneral = listaGeneral.OrderBy(x => x.Fecha).ToList();

            if (listaGeneral.Count <= 0) return null;

            List<HorasExtrasEmpleado> listaSimples = listaGeneral.Where(x => x.Simples == true).ToList();

            List<HorasExtrasEmpleado> listaDobleTriples = listaGeneral.Where(x => x.Simples == false).ToList();

            #region SIMPLES

            if (listaSimples.Count > 0)
            {
                int horasTotalesSimples = 0;

                horasTotalesSimples = listaSimples.Sum(x => x.Horas);

                //limte exento
                decimal limiteExentoSimple = salarioMin * 5;

                decimal gravadoSimple1 = 0;
                decimal exentoSimple = 0;
                decimal gravadoSimple2 = 0;
                decimal totalGravadoSimple = 0;
                decimal mitadSimple = 0;
                decimal totalSimples = 0;
                int diasSimples = 0;
                decimal isnSimples = 0;

                diasSimples = listaSimples.Select(x => x.Fecha).Distinct().Count(); ;

                totalSimples = sd * horasTotalesSimples;

                mitadSimple = totalSimples / 2;

                //gravado 1
                gravadoSimple1 = mitadSimple;

                //gravado 2
                if (mitadSimple > limiteExentoSimple)
                {
                    gravadoSimple2 = mitadSimple;
                }
                else
                {
                    //exento
                    exentoSimple = mitadSimple;
                }

                totalGravadoSimple = gravadoSimple1 + gravadoSimple2;

                isnSimples = totalSimples * porcentaje;

                NOM_Nomina_Detalle itemS = new NOM_Nomina_Detalle()
                {
                    Id = 0,
                    IdNomina = nomina.IdNomina,
                    IdConcepto = 14,
                    Total = Utils.TruncateDecimales(totalSimples),
                    GravadoISR = Utils.TruncateDecimales(totalGravadoSimple),
                    ExentoISR = exentoSimple,
                    IntegraIMSS = 0,
                    ImpuestoSobreNomina = isnSimples, //genera impuesto sobre nomina ?
                    Complemento = false,
                    DiasHE = diasSimples,
                    TipoHE = 3,
                    HorasE = horasTotalesSimples
                };

                if (itemS.Total > 0)
                {
                    listaDetalles.Add(itemS);
                }
            }

            #endregion

            #region HORAS DOBLES TRIPLES

            if (listaDobleTriples.Count > 0)
            {
                int horasTotales = listaDobleTriples.Sum(x => x.Horas);

                if (horasTotales > 9) //
                {
                    int cont = 0;
                    int indx = 1;

                    DateTime hold = new DateTime(1999, 1, 1);
                    int diasDoble = 0;
                    int diasTriples = 0;

                    foreach (var item in listaDobleTriples)
                    {

                        if (hold != item.Fecha && cont < 9)
                        {
                            hold = item.Fecha;
                            //incrementa dias d y cont
                            diasDoble++;
                            cont += item.Horas;

                            if (cont > 9)
                                diasTriples++;
                        }
                        else if (cont <= 9)
                        {
                            //solo incrementa cont
                            cont += item.Horas;

                            if (cont > 9)
                                diasTriples++;
                        }
                        else if (hold != item.Fecha && cont > 9)
                        {
                            hold = item.Fecha;
                            //incrementa dias t y cont
                            diasTriples++;
                            cont += item.Horas;
                        }
                        else
                        {
                            //solo incrementa cont
                            cont += item.Horas;
                        }
                        //    cont = item.Horas;
                        //if (cont < 9)
                        //{
                        //    indx++;
                        //}
                        //else
                        //{
                        //    diasD = indx;
                        //    break;
                        //}

                    }

                    //diasT = listaDobleTriples.Count - diasD;
                    diasD = diasDoble;
                    diasT = diasTriples;

                    horasDobles = 9;
                    horasTriples = horasTotales - 9;
                }
                else
                {
                    diasD = listaDobleTriples.Select(x => x.Fecha).Distinct().Count();
                    horasDobles = horasTotales;
                }

                //limte exento
                limiteExento = salarioMin * 5;

                valorDobles = 2 * sd;
                valorTriples = 3 * sd;

                //total horas dobles
                decimal totalDobles = horasDobles * valorDobles;

                //total horas triples
                decimal totalTriples = horasTriples * valorTriples;

                //total a pagat
                decimal totalPago = totalDobles + totalTriples;

                //GRAVADOS
                //DIVIDMOS EN DOS LAS PARTE DE LAS HORAS DOBLES
                decimal gravado2 = 0;
                decimal exento = 0;
                decimal gravado1 = 0;
                decimal totalGravado = 0;

                decimal mitadDobles = totalDobles / 2;

                //gravado 1
                gravado1 = mitadDobles;

                //gravado 2
                if (mitadDobles > limiteExento)
                {
                    gravado2 = mitadDobles;
                }
                else
                {
                    //exento
                    exento = mitadDobles;
                }

                totalGravado = gravado1 + gravado2;

                //1 dobles
                //2 triples
                //3 simples
                isnDobles = totalDobles * porcentaje;
                NOM_Nomina_Detalle itemD = new NOM_Nomina_Detalle()
                {
                    Id = 0,
                    IdNomina = nomina.IdNomina,
                    IdConcepto = 14,
                    Total = Utils.TruncateDecimales(totalDobles),
                    GravadoISR = Utils.TruncateDecimales(totalGravado),
                    ExentoISR = exento,
                    IntegraIMSS = 0,
                    ImpuestoSobreNomina = isnDobles, //genera impuesto sobre nomina ?
                    Complemento = false,
                    DiasHE = diasD,
                    TipoHE = 1,
                    HorasE = horasDobles
                };

                isnTriples = totalTriples * porcentaje;
                NOM_Nomina_Detalle itemT = new NOM_Nomina_Detalle()
                {
                    Id = 0,
                    IdNomina = nomina.IdNomina,
                    IdConcepto = 14,
                    Total = Utils.TruncateDecimales(totalTriples),
                    GravadoISR = Utils.TruncateDecimales(totalTriples),
                    ExentoISR = 0,
                    IntegraIMSS = 0,
                    ImpuestoSobreNomina = isnTriples, //genera impuesto sobre nomina ?
                    Complemento = false,
                    DiasHE = diasT,
                    TipoHE = 2,
                    HorasE = horasTriples
                };

                if (itemD.Total > 0)
                    listaDetalles.Add(itemD);
                if (itemT.Total > 0)
                    listaDetalles.Add(itemT);
            }

            #endregion

            return listaDetalles;


        }

        #endregion

        #region " MÉTODOS DE COMPLEMENTOS"
        public static NOM_Nomina_Detalle Complemento_Sueldo(NOM_Nomina nomNomina, decimal cantidad = 0)
        {

            decimal total = 0;

            if (cantidad == 0)
            {
                total = nomNomina.SDReal * nomNomina.Dias_Laborados;
            }
            else
            {
                total = nomNomina.SDReal * cantidad;//nomina.Dias_Laborados;     
            }


            //    GuardarConcepto(nomNomina.IdNomina, 1, total, isComplemento: true);


            NOM_Nomina_Detalle item = new NOM_Nomina_Detalle()
            {
                Id = 0,
                IdNomina = nomNomina.IdNomina,
                IdConcepto = 1,
                Total = total,
                GravadoISR = 0,
                ExentoISR = 0,
                IntegraIMSS = 0,
                ImpuestoSobreNomina = 0,
                Complemento = true
            };

            return item;


        }
        public static NOM_Nomina_Detalle Complemento_VacacionesPagadas(NOM_Nomina nomNomina, decimal cantidad)
        {
            var total = nomNomina.SDReal * cantidad;
            //  GuardarConcepto(nomNomina.IdNomina, 79, total, isComplemento: true);


            NOM_Nomina_Detalle item = new NOM_Nomina_Detalle()
            {
                Id = 0,
                IdNomina = nomNomina.IdNomina,
                IdConcepto = 79,
                Total = total,
                GravadoISR = 0,
                ExentoISR = 0,
                IntegraIMSS = 0,
                ImpuestoSobreNomina = 0,
                Complemento = true
            };

            return item;
        }
        public static NOM_Nomina_Detalle Complemento_HorasExtrasDobles(NOM_Nomina nomNomina, decimal cantidad)
        {
            var total = ((nomNomina.SDReal / 8) * 2) * cantidad;

            //  GuardarConcepto(nomNomina.IdNomina, 80, total, isComplemento: true);

            NOM_Nomina_Detalle item = new NOM_Nomina_Detalle()
            {
                Id = 0,
                IdNomina = nomNomina.IdNomina,
                IdConcepto = 79,
                Total = total,
                GravadoISR = 0,
                ExentoISR = 0,
                IntegraIMSS = 0,
                ImpuestoSobreNomina = 0,
                Complemento = true
            };

            return item;
        }
        public static NOM_Nomina_Detalle Complemento_HorasExtrasTriples(NOM_Nomina nomNomina, decimal cantidad)
        {

            var total = ((nomNomina.SDReal / 8) * 3) * cantidad;
            // GuardarConcepto(nomNomina.IdNomina, 81, total, isComplemento: true);

            NOM_Nomina_Detalle item = new NOM_Nomina_Detalle()
            {
                Id = 0,
                IdNomina = nomNomina.IdNomina,
                IdConcepto = 81,
                Total = total,
                GravadoISR = 0,
                ExentoISR = 0,
                IntegraIMSS = 0,
                ImpuestoSobreNomina = 0,
                Complemento = true
            };

            return item;
        }
        public static NOM_Nomina_Detalle Complemento_DobleTurno(NOM_Nomina nomNomina, decimal cantidad)
        {

            var total = ((nomNomina.SDReal * cantidad) * 2);
            //  GuardarConcepto(nomNomina.IdNomina, 82, total, isComplemento: true);


            NOM_Nomina_Detalle item = new NOM_Nomina_Detalle()
            {
                Id = 0,
                IdNomina = nomNomina.IdNomina,
                IdConcepto = 82,
                Total = total,
                GravadoISR = 0,
                ExentoISR = 0,
                IntegraIMSS = 0,
                ImpuestoSobreNomina = 0,
                Complemento = true
            };

            return item;
        }
        public static NOM_Nomina_Detalle Complemento_DiaFestivo(NOM_Nomina nomNomina, decimal cantidad)
        {

            var total = ((nomNomina.SDReal * cantidad) * 2);
            //    GuardarConcepto(nomNomina.IdNomina, 83, total, isComplemento: true);

            NOM_Nomina_Detalle item = new NOM_Nomina_Detalle()
            {
                Id = 0,
                IdNomina = nomNomina.IdNomina,
                IdConcepto = 83,
                Total = total,
                GravadoISR = 0,
                ExentoISR = 0,
                IntegraIMSS = 0,
                ImpuestoSobreNomina = 0,
                Complemento = true
            };

            return item;

        }
        public static NOM_Nomina_Detalle Complemento_PrimaDominical(NOM_Nomina nomNomina, decimal cantidad)
        {

            const decimal porcentaje = (decimal)0.25;
            var total = ((nomNomina.SDReal * cantidad) * porcentaje);

            //                GuardarConcepto(nomNomina.IdNomina, 84, total, isComplemento: true);


            NOM_Nomina_Detalle item = new NOM_Nomina_Detalle()
            {
                Id = 0,
                IdNomina = nomNomina.IdNomina,
                IdConcepto = 84,
                Total = total,
                GravadoISR = 0,
                ExentoISR = 0,
                IntegraIMSS = 0,
                ImpuestoSobreNomina = 0,
                Complemento = true
            };

            return item;

        }
        public static NOM_Nomina_Detalle Complemento_OtrosDias(NOM_Nomina nomNomina, decimal cantidad)
        {

            var total = ((nomNomina.SDReal * cantidad));

            //  GuardarConcepto(nomNomina.IdNomina, 85, total, isComplemento: true);

            NOM_Nomina_Detalle item = new NOM_Nomina_Detalle()
            {
                Id = 0,
                IdNomina = nomNomina.IdNomina,
                IdConcepto = 85,
                Total = total,
                GravadoISR = 0,
                ExentoISR = 0,
                IntegraIMSS = 0,
                ImpuestoSobreNomina = 0,
                Complemento = true
            };

            return item;
        }
        public static NOM_Nomina_Detalle Complemento_VacacionesDisfrutadas(NOM_Nomina nomNomina, decimal cantidad)
        {
            var total = nomNomina.SDReal * cantidad;
            //    GuardarConcepto(nomNomina.IdNomina, 86, total, isComplemento:true);

            NOM_Nomina_Detalle item = new NOM_Nomina_Detalle()
            {
                Id = 0,
                IdNomina = nomNomina.IdNomina,
                IdConcepto = 86,
                Total = total,
                GravadoISR = 0,
                ExentoISR = 0,
                IntegraIMSS = 0,
                ImpuestoSobreNomina = 0,
                Complemento = true
            };

            return item;
        }

        #endregion

        /// <summary>
        /// Guarda un registro en detalle de nomina
        /// </summary>
        /// <param name="idNomina"></param>
        /// <param name="idConcepto"></param>
        /// <param name="total"></param>
        /// <param name="gravaIsr"></param>
        /// <param name="excentoIsr"></param>
        /// <param name="integraImss"></param>
        /// <param name="impuestoNomina"></param>
        private static void GuardarConcepto1(int idNomina = 0, int idConcepto = 0, decimal total = 0, decimal gravaIsr = 0, decimal excentoIsr = 0, decimal integraImss = 0, decimal impuestoNomina = 0, bool isComplemento = false)
        {
            var nd = new NOM_Nomina_Detalle()
            {

                IdNomina = idNomina,
                IdConcepto = idConcepto,
                Total = total,
                GravadoISR = gravaIsr,
                ExentoISR = excentoIsr,
                IntegraIMSS = integraImss,
                ExentoIMSS = 0,
                ImpuestoSobreNomina = impuestoNomina,
                Complemento = isComplemento
            };

            _nominasDao.AddDetalleNomina(nd);
        }





    }
}
