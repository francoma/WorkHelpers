using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Serialization;
using BNACTMFormGenerator.Model;

namespace BNACTMFormGenerator.ViewModel
{
    class FormularioCTMViewModel : BaseViewModel {
        private FormularioCTM _form;
        public string RutaFormularios { get; set; }
        public string RutaConfiguracion { get; set; }
        public BaseCommand GuardarFormulario { get; set; }
        public BaseCommand SeleccionarCarpeta { get; set; }
        public BaseCommand SeleccionarArchivo { get; set; }
        private string _mensaje;

        private void Ctor() {
            GuardarFormulario = new BaseCommand(OnGenFormulario, CanGenFormulario);
            SeleccionarCarpeta = new BaseCommand(OnSeleccionarCarpeta);
            SeleccionarArchivo = new BaseCommand(OnSeleccionarArchivo);

            RutaFormularios = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            RutaConfiguracion = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "ctm_" + DateTime.Now.ToString("ddMMyyyy") + ".dat");
            Mensaje = String.Empty;        
        }

        public FormularioCTMViewModel(CabeceraFormularioCTMViewModel c, RelacionOtrosJobsViewModel r, AccionesATomarViewModel a, PasosViewModel p) {
            _form = new FormularioCTM();
            _form.Cabecera = c.DataObject;
            _form.Relaciones = r.DataObject;
            _form.Acciones = a.DataObject;
            _form.Pasos = p.PasosToList();

            Ctor();
        }

        public FormularioCTMViewModel(FormularioCTM f) {
            _form = f;
            Ctor();
        }

        private void OnSeleccionarCarpeta(object o) {
            using (var fbd = new System.Windows.Forms.FolderBrowserDialog())
            {
                System.Windows.Forms.DialogResult result = fbd.ShowDialog();

                if (result == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath)) {
                    RutaFormularios = fbd.SelectedPath;
                    RaisePropertyChanged("RutaFormularios");
                }
            }
        }

        private void OnSeleccionarArchivo(object o) {
            using (var s = new System.Windows.Forms.SaveFileDialog()) {
                s.Filter = "Archivo de Configuración|*.dat|Archivo de Texto|*.txt|Archivo XML|*.xml";
                System.Windows.Forms.DialogResult result = s.ShowDialog();

                if (result == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(s.FileName)) {
                    RutaConfiguracion = s.FileName;
                    Serializar();
                    RaisePropertyChanged("RutaConfiguracion");
                }                
            }
        }

        private bool CanGenFormulario(object obj) {
            return _form.Cabecera.IsValid && _form.Relaciones.IsValid && _form.Acciones.IsValid && _form.Pasos.Count > 0;
        }
                
        private void OnGenFormulario(object obj) {
            string nombreJob = "PC";
            
            Mensaje = "Generando Formularios...";

            switch (_form.Cabecera.Periodicidad) { 
                case TipoPeriodicidad.Esporádico:
                    nombreJob += "DE";
                    break;
                case TipoPeriodicidad.Diaria:
                    nombreJob += "DD";
                    break;
                case TipoPeriodicidad.Semanal:
                    nombreJob += "DS";
                    break;
                case TipoPeriodicidad.Quincenal:
                    nombreJob += "DQ";
                    break;
                case TipoPeriodicidad.Mensual: 
                    nombreJob += "DM";
                    break;
                case TipoPeriodicidad.Bimestral:
                    nombreJob += "DB";
                    break;
                case TipoPeriodicidad.Trimestral:
                    nombreJob += "DT";
                    break;
                case TipoPeriodicidad.Semestral:
                    nombreJob += "DX";
                    break;
                case TipoPeriodicidad.Anual:
                    nombreJob += "DA";
                    break;
            }

            string rutaTest = Path.Combine(RutaFormularios, nombreJob + "XXXT.xlsx");
            string rutaProd = Path.Combine(RutaFormularios, nombreJob + "XXX.xlsx");

            _form.GenForm(rutaTest, "TEST");
            Mensaje = "Formuario para Test generado en " + rutaTest;
            _form.GenForm(rutaProd, "PROD");
            Mensaje += "\nFormuario para Prod generado en " + rutaProd;
            
        }

        private void Serializar() {
            ////////////// SERIALIZAR ////////////// 
            //FileStream fs = new FileStream("c:\\Cabecera.dat", FileMode.OpenOrCreate);
            //XmlSerializer xs = new XmlSerializer(typeof(CabeceraFormularioCTM));
            //xs.Serialize(fs, _form.Cabecera);
            //fs.Close();

            //fs = new FileStream("c:\\AccionesATomar.dat", FileMode.OpenOrCreate);
            //xs = new XmlSerializer(typeof(AccionesATomar));
            //xs.Serialize(fs, _form.Acciones);
            //fs.Close();

            //fs = new FileStream("c:\\RelacionOtrosJobs.dat", FileMode.OpenOrCreate);
            //xs = new XmlSerializer(typeof(RelacionOtrosJobs));
            //xs.Serialize(fs, _form.Relaciones);
            //fs.Close();

            //fs = new FileStream("c:\\Pasos.dat", FileMode.OpenOrCreate);
            //xs = new XmlSerializer(typeof(List<Paso>));
            //xs.Serialize(fs, _form.Pasos);
            //fs.Close();

            FileStream fs = new FileStream(RutaConfiguracion, FileMode.OpenOrCreate);
            XmlSerializer xs = new XmlSerializer(typeof(FormularioCTM));
            xs.Serialize(fs, _form);
            fs.Close();
            ////////////// SERIALIZAR //////////////         
        }

        public CabeceraFormularioCTM Cabecera {
            get { return _form.Cabecera; }
            set {
                _form.Cabecera = value;
                RaisePropertyChanged("Cabecera");
            } 
        }

        public string Mensaje {
            get {
                return _mensaje;
            }
            set {
                _mensaje = value;
                RaisePropertyChanged("Mensaje");
            }
        }

        public AccionesATomar Acciones {
            get { return _form.Acciones; }
            set {
                _form.Acciones = value;
                RaisePropertyChanged("Acciones");
            }
        }

        public RelacionOtrosJobs Relaciones {
            get { return _form.Relaciones; }
            set {
                _form.Relaciones = value;
                RaisePropertyChanged("Relaciones");
            }
        }

        public List<Paso> Pasos {
            get { return _form.Pasos; }
            set {
                _form.Pasos = value;
                RaisePropertyChanged("Pasos");
            }
        }

        public override string GetValidationError(string propertyName) {
            return null;
        }

        public override bool IsValid {
            get {
                return _form.IsValid;
            }
        }
    }
}
