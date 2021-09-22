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
        public BaseCommand GuardarFormulario { get; set; }
        
        public FormularioCTMViewModel(CabeceraFormularioCTMViewModel c, RelacionOtrosJobsViewModel r, AccionesATomarViewModel a, PasosViewModel p) {
            _form = new FormularioCTM();

            

            _form.Cabecera = c.DataObject;
            _form.Relaciones = r.DataObject;
            _form.Acciones = a.DataObject;
            _form.Pasos = p.PasosToList();
            
            GuardarFormulario = new BaseCommand(OnGenFormulario, CanGenFormulario);
        }

        private bool CanGenFormulario(object obj) {
            return _form.Cabecera.IsValid && _form.Relaciones.IsValid && _form.Acciones.IsValid && _form.Pasos.Count > 0;
        }
                
        private void OnGenFormulario(object obj) {
            ////////////_form.GenForm(RutaFormularios, "TEST");
            //Mensaje = "Formuario para Test Generado en " + RutaFormularios + "TEST.xlsx";
            ////////////_form.GenForm(RutaFormularios, "PROD");
            //Mensaje += "\nFormuario para Prod Generado en " + RutaFormularios + "PROD.xlsx";


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
            ////////////// SERIALIZAR ////////////// 

        }

        public CabeceraFormularioCTM Cabecera {
            get { return _form.Cabecera; }
            set {
                _form.Cabecera = value;
                RaisePropertyChanged("Cabecera");
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
