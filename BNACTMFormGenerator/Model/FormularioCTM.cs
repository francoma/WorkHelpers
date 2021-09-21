using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BNACTMFormGenerator.Helpers;
using BNACTMFormGenerator.ViewModel;
using Microsoft.Office.Interop.Excel;

namespace BNACTMFormGenerator.Model
{
    public enum TipoPeriodicidad
    {
        Esporádico,
        Diaria,
        Semanal,
        Quincenal,
        Mensual,
        Bimestral,
        Trimestral,
        Semestral,
        Anual
    };

    class FormularioCTM : DataErrorInfoBase {
        public CabeceraFormularioCTM Cabecera { get; set; }
        public AccionesATomar Acciones { get; set; }
        public RelacionOtrosJobs Relaciones { get; set; }
        public List<Paso> Pasos { get; set; }        
        private Application _xlsx;
        private _Worksheet _sheet;        
        
        private string[] BoldText = new string[] { "PASO", "Servidor", "Base de Datos", "Usuario de ejecución SQL", "Valor de parámetros", "Param", "Ubicación", "Archivo", "Archivos o Patrón", "Nombre Script", "Nombre SP", "Usuario de ejecución sh", "Ubicación Origen", "Parámetros" };
        private int[] _celdasAccionesExitosas = { 268, 274, 280, 286, 292, 298 };
        private string[] _textboxesAccionesExitosas = { "Text Box 6", "Text Box 16", "Text Box 17", "Text Box 18", "Text Box 19", "Text Box 32" };
        private int[] _celdasAccionesErroneas = { 309, 315, 321, 327, 333, 339, 345, 351, 357 };
        private string[] _textboxesAccionesErroneas = { "Text Box 22", "Text Box 55", "Text Box 57", "Text Box 61", "Text Box 63", "Text Box 65", "Text Box 66", "Text Box 68", "Text Box 70" };

        const int maxTextBoxSize = 1306;
        const int minFilasJobsEntrada = 180;
        const int minFilasJobsSalida = 189;
        const int maxFilasJobsEntrada = 185;
        const int maxFilasJobsSalida = 194;
        const int minServidoresIntervinientes = 202;
        const int minSOIntervinientes = 207;
        const int minMotoresDBIntervinientes = 210;
        const int minDBIntervinientes = 213;
        const int minJobNoParalelos = 225;
        const string USUARIO = "Text Box 72";
        const string AREA = "Text Box 67";
        const string DESCRIPCION = "Text Box 7";
        const string PASOS1 = "Text Box 2";
        const string PASOS2 = "Text Box 71";
        const string DETALLE_FRECUENCIA = "Text Box 4";
        const string ACLARACIONES = "Text Box 3";
        const string ACCION_NO_EJECUCION = "Text Box 5";
        const string ACCION_JOB_NO_FINALIZA = "Text Box 15";


        public FormularioCTM() {
            Cabecera = new CabeceraFormularioCTM();
            Acciones = new AccionesATomar();
            Relaciones = new RelacionOtrosJobs();
            Pasos = new List<Paso>();
        }

        public void GenForm(string outPath, string entorno) {
            WriteExcel(System.IO.Path.Combine(outPath, entorno + ".xlsx"), entorno);            
        }

        public void WriteExcel(string outPath, string entorno) {
            string path = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "data", "f.xlsx");

            _xlsx = new Application();
            _xlsx.Workbooks.Open(path);
            _sheet = this._xlsx.ActiveSheet;

            _sheet.Cells[16, 7] = Cabecera.Fecha;
            _sheet.Cells[17, 7] = Cabecera.NombreProc;
            _sheet.Shapes.Item(USUARIO).TextFrame.Characters(Type.Missing, Type.Missing).Text = Cabecera.Usuario;
            _sheet.Shapes.Item(AREA).TextFrame.Characters(Type.Missing, Type.Missing).Text = Cabecera.Area;
            _sheet.Shapes.Item(DESCRIPCION).TextFrame.Characters(1, Type.Missing).Text = Cabecera.Descr;
            
            // Periodicidad
            for (int i = 4; i < 11; i++) _sheet.Cells[155, i] = String.Empty;
            for (int i = 4; i < 6; i++) _sheet.Cells[157, i] = String.Empty;

            switch (Cabecera.Periodicidad) {
                case TipoPeriodicidad.Esporádico:
                    _sheet.Cells[155, 4] = "X";                    
                    break;
                case TipoPeriodicidad.Diaria:
                    _sheet.Cells[155, 5] = "X";
                    break;
                case TipoPeriodicidad.Semanal:
                    _sheet.Cells[155, 6] = "X";
                    break;
                case TipoPeriodicidad.Quincenal:
                    _sheet.Cells[155, 7] = "X";
                    break;
                case TipoPeriodicidad.Mensual:
                    _sheet.Cells[155, 8] = "X";
                    break;
                case TipoPeriodicidad.Bimestral:
                    _sheet.Cells[155, 9] = "X";
                    break;
                case TipoPeriodicidad.Trimestral:
                    _sheet.Cells[155, 10] = "X";
                    break;
                case TipoPeriodicidad.Semestral:
                    _sheet.Cells[157, 4] = "X";
                    break;
                case TipoPeriodicidad.Anual:
                    _sheet.Cells[157, 5] = "X";
                    break;
            }
            
            _sheet.Shapes.Item(DETALLE_FRECUENCIA).TextFrame.Characters(Type.Missing, Type.Missing).Text = Cabecera.DetalleFrecuencia;
            _sheet.Cells[166, 9] = Cabecera.HoraInicioEjecucion.ToString().PadLeft(2, '0') + ":" + Cabecera.MinutosInicioEjecucion.ToString().PadLeft(2, '0');
            _sheet.Cells[167, 9] = Cabecera.HoraLimiteInicioEjecucion.ToString().PadLeft(2, '0') + ":" + Cabecera.MinutosLimiteInicioEjecucion.ToString().PadLeft(2, '0');

            // Jobs Entrada
            int fila = minFilasJobsEntrada;
            int columna = 5;
            
            foreach (JobViewModel job in Relaciones.JobsEntrada) {
                _sheet.Cells[fila, columna] = entorno == "TEST" ? job.NombreJobTest : job.NombreJobProd;

                if (fila.Equals(maxFilasJobsEntrada)) {
                    fila = minFilasJobsEntrada;
                    columna += 2;
                } else fila++;
            }
            
            // Jobs Salida
            fila = minFilasJobsSalida;
            columna = 5;
                        
            foreach (JobViewModel job in Relaciones.JobsSalida) {
                _sheet.Cells[fila, columna] = entorno == "TEST" ? job.NombreJobTest : job.NombreJobProd;

                if (fila.Equals(maxFilasJobsSalida)) {
                    fila = minFilasJobsSalida;
                    columna += 2;
                } else fila++;
            }
            
            // Jobs No Paralelos
            int lenList = Relaciones.JobsParalelos.Count;

            for (int i = 0; i < lenList; i++) {
                if (i < 5) 
                    _sheet.Cells[minJobNoParalelos + i, "G"] = entorno == "TEST" ? Relaciones.JobsParalelos.ElementAt(i).NombreJobTest : Relaciones.JobsParalelos.ElementAt(i).NombreJobProd;
                else if (i > 4 && lenList < i)
                    _sheet.Cells[minJobNoParalelos + (i % 5), "I"] = entorno == "TEST" ? Relaciones.JobsParalelos.ElementAt(i).NombreJobTest : Relaciones.JobsParalelos.ElementAt(i).NombreJobProd;
            }

            _sheet.Shapes.Item(ACLARACIONES).TextFrame.Characters(Type.Missing, Type.Missing).Text = Relaciones.Aclaraciones;

            _sheet.Cells[253, "D"] = Acciones.HoraAccionNoInicia.ToString().PadLeft(2, '0') + ":" + Acciones.MinutosAccionNoInicia.ToString().PadLeft(2, '0');
            _sheet.Shapes.Item(ACCION_NO_EJECUCION).TextFrame.Characters(Type.Missing, Type.Missing).Text = Acciones.AvisoNoInicio;

            _sheet.Cells[261, "D"] = Acciones.TiempoJobNoFinaliza;
            _sheet.Shapes.Item(ACCION_JOB_NO_FINALIZA).TextFrame.Characters(Type.Missing, Type.Missing).Text = Acciones.AvisoJobNoFinaliza;

            // Acciones exitosas
            for (int i = 0; i < Acciones.AccionesExitosas.Count ; i++) {
                _sheet.Cells[_celdasAccionesExitosas[i], "D"] = Acciones.AccionesExitosas.ElementAt(i).TextoBuscado;
                _sheet.Shapes.Item(_textboxesAccionesExitosas[i]).TextFrame.Characters(Type.Missing, Type.Missing).Text = Acciones.AccionesExitosas.ElementAt(i).TextoAccion;
            }

            // Acciones erroneas
            for (int i = 0; i < Acciones.AccionesErroneas.Count; i++) {
                _sheet.Cells[_celdasAccionesErroneas[i], "D"] = Acciones.AccionesErroneas.ElementAt(i).TextoBuscado;
                _sheet.Shapes.Item(_textboxesAccionesErroneas[i]).TextFrame.Characters(Type.Missing, Type.Missing).Text = Acciones.AccionesErroneas.ElementAt(i).TextoAccion;
            }

            string txtPasos1 = "";
            string txtPasos2 = "";

            _sheet.Shapes.Item(PASOS1).TextFrame.Characters(Type.Missing, Type.Missing).Text = " ";

            for (int i = 0; i < Pasos.Count; i++)
                if (txtPasos1.Length + Pasos.ElementAt(i).ToStringFormat(entorno).Length < maxTextBoxSize) {
                    txtPasos1 += Pasos.ElementAt(i).ToStringFormat(entorno);
                } else {
                    txtPasos2 += Pasos.ElementAt(i).ToStringFormat(entorno);
                }

            _sheet.Shapes.Item(PASOS1).TextFrame.Characters(Type.Missing, Type.Missing).Text = txtPasos1;
            _sheet.Shapes.Item(PASOS2).TextFrame.Characters(Type.Missing, Type.Missing).Text = txtPasos2;
            Boldify();

            _sheet.SaveAs(outPath);
            _xlsx.Workbooks.Close();
            _xlsx.Quit();
        }

        private IEnumerable<int> AllIndexesOf(string str, string value) {
            if (String.IsNullOrEmpty(value))
                throw new ArgumentException("the string to find may not be empty", "value");
            for (int index = 0; ; index += value.Length) {
                index = str.IndexOf(value, index);
                if (index == -1)
                    break;
                yield return index;
            }
        }

        private string ExtractText(int pos, string txtPasos, string palabraBuscada) {
            int search = pos + 5;

            if (palabraBuscada.Equals("PASO"))
            {
                while (!txtPasos.ElementAt(search).Equals('\n'))
                    search++;
                search -= pos;
            }
            else if (palabraBuscada.Equals("Param"))
            {
                while (!txtPasos.ElementAt(search).Equals(':'))
                    search++;
                search -= pos;
            }
            else
            {
                search = palabraBuscada.Length;
            }

            return txtPasos.Substring(pos, search);
        }

        private void Boldify() {
            int i;
            string txt1 = _sheet.Shapes.Item(PASOS1).TextFrame.Characters(Type.Missing, Type.Missing).Text;
            string txt2 = _sheet.Shapes.Item(PASOS2).TextFrame.Characters(Type.Missing, Type.Missing).Text;

            for (i = 0; i < this.BoldText.Length; i++) {
                foreach (int indice in AllIndexesOf(txt1, BoldText[i])) {
                    _sheet.Shapes.Item(PASOS1).TextFrame.Characters(indice + 1, ExtractText(indice, txt1, BoldText[i]).Length).Font.Bold = true;
                }

                foreach (int indice in AllIndexesOf(txt2, BoldText[i])) {
                    _sheet.Shapes.Item(PASOS2).TextFrame.Characters(indice + 1, ExtractText(indice, txt2, BoldText[i]).Length).Font.Bold = true;
                }
            }
        }

        static readonly string[] ValidatedProperties = 
        { 
            "Cabecera",
            "Acciones",
            "Relaciones",
            "Pasos",
        };

        override public string GetValidationError(string propertyName) {
            string error = null;

            if (propertyName == "Pasos")
                if (Pasos.Count == 0)
                    error = "Debe existir al menos un Paso en el Formulario";

            return error;
        }

        public override bool IsValid {
            get {
                return Cabecera.IsValid && Acciones.IsValid && Relaciones.IsValid && GetValidationError("Pasos") == null;
            }
        }
    }
}
