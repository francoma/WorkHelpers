using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;
using BNACTMFormGenerator.Model;

namespace BNACTMFormGenerator.ViewModel
{
    class MainWindowViewModel : BaseViewModel, INotifyPropertyChanged {
        private ReadOnlyCollection<CommandViewModel> _commands;
        private BaseViewModel _selectedView;

        private CabeceraFormularioCTMViewModel _cabeceraView;
        private RelacionOtrosJobsViewModel _relacionOtrosJobsView;
        private AccionesATomarViewModel _accionesATomarView;
        private PasosViewModel _pasos;
        private FormularioCTMViewModel _formulario;

        public MainWindowViewModel() {
            _commands = new ReadOnlyCollection<CommandViewModel>(AgregarCommandos());
            _cabeceraView = new CabeceraFormularioCTMViewModel();
            _cabeceraView.Visible = "Visible";

            _relacionOtrosJobsView = new RelacionOtrosJobsViewModel();
            _relacionOtrosJobsView.Visible = "Hidden";

            _accionesATomarView = new AccionesATomarViewModel();
            _accionesATomarView.Visible = "Hidden";

            _pasos = new PasosViewModel();
            _pasos.Visible = "Hidden";

            _formulario = new FormularioCTMViewModel(_cabeceraView, _relacionOtrosJobsView, _accionesATomarView, _pasos);
            _formulario.Visible = "Hidden";
        }

        private List<CommandViewModel> AgregarCommandos() {
            return new List<CommandViewModel>
            {
                new CommandViewModel("Cabecera", TVista.Cabecera, new BaseCommand(MostrarVista)),
                new CommandViewModel("Otros Jobs", TVista.Jobs, new BaseCommand(MostrarVista)),
                new CommandViewModel("Acciones", TVista.Acciones, new BaseCommand(MostrarVista)),                
                new CommandViewModel("Pasos", TVista.Pasos , new BaseCommand(MostrarVista)),        
                new CommandViewModel("Generar Formularios", TVista.Formulario , new BaseCommand(MostrarVista)),        
                new CommandViewModel("Cargar Formulario existente", TVista.CargarArchivo, new BaseCommand(MostrarVista))      
            };
        }

        public void MostrarVista(object obj) {
            switch ((TVista)obj) { 
                case TVista.Cabecera:
                    RelacionOtrosJobsView.Visible = "Hidden";
                    CabeceraView.Visible = "Visible";
                    AccionesATomar.Visible = "Hidden";
                    Pasos.Visible = "Hidden";
                    Formulario.Visible = "Hidden";

                    SelectedView = _cabeceraView;
                    break;
                
                case TVista.Jobs:
                    RelacionOtrosJobsView.Visible = "Visible";
                    CabeceraView.Visible = "Hidden";
                    AccionesATomar.Visible = "Hidden";
                    Pasos.Visible = "Hidden";
                    Formulario.Visible = "Hidden";

                    SelectedView = _relacionOtrosJobsView;
                    break;

                case TVista.Acciones:
                    RelacionOtrosJobsView.Visible = "Hidden";
                    CabeceraView.Visible = "Hidden";
                    AccionesATomar.Visible = "Visible";
                    Pasos.Visible = "Hidden";
                    Formulario.Visible = "Hidden";

                    SelectedView = _accionesATomarView;
                    break;

                case TVista.Pasos:
                    RelacionOtrosJobsView.Visible = "Hidden";
                    CabeceraView.Visible = "Hidden";
                    AccionesATomar.Visible = "Hidden";                    
                    Pasos.Visible = "Visible";
                    Formulario.Visible = "Hidden";

                    SelectedView = _pasos;
                    break;

                case TVista.Formulario:
                    RelacionOtrosJobsView.Visible = "Hidden";
                    CabeceraView.Visible = "Hidden";
                    AccionesATomar.Visible = "Hidden";
                    Pasos.Visible = "Hidden";
                    Formulario.Visible = "Visible";

                    Formulario.Pasos = _pasos.PasosToList();
                    SelectedView = Formulario;
                    break;

                case TVista.CargarArchivo:                    
                    CabeceraView.Visible = "Hidden";
                    RelacionOtrosJobsView.Visible = "Hidden";
                    AccionesATomar.Visible = "Hidden";
                    Pasos.Visible = "Hidden";
                    Formulario.Visible = "Hidden";

                    using (var ofd = new System.Windows.Forms.OpenFileDialog()) {
                        System.Windows.Forms.DialogResult result = ofd.ShowDialog();

                        if (result == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(ofd.FileName)) {
                            FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                            XmlSerializer xs = new XmlSerializer(typeof(FormularioCTM));
                            _formulario = new FormularioCTMViewModel((FormularioCTM)xs.Deserialize(fs));
                            RaisePropertyChanged("Formulario");
                            fs.Close();

                            _cabeceraView = new CabeceraFormularioCTMViewModel();
                            _cabeceraView.DataObject = _formulario.Cabecera;
                            RaisePropertyChanged("CabeceraView");
                            
                            _relacionOtrosJobsView = new RelacionOtrosJobsViewModel();
                            _relacionOtrosJobsView.DataObject = _formulario.Relaciones;
                            RaisePropertyChanged("RelacionOtrosJobsView");

                            _accionesATomarView = new AccionesATomarViewModel();
                            _accionesATomarView.DataObject = _formulario.Acciones;
                            RaisePropertyChanged("AccionesATomar");

                            _pasos = new PasosViewModel();
                            _pasos.PasosFromList(_formulario.Pasos);
                            RaisePropertyChanged("Pasos");
                        }
            
                        CabeceraView.Visible = "Visible";
                        RelacionOtrosJobsView.Visible = "Hidden";
                        AccionesATomar.Visible = "Hidden";
                        Pasos.Visible = "Hidden";
                        Formulario.Visible = "Hidden";

                        SelectedView = CabeceraView;
                    }                   

                    break;
            }
            
            RaisePropertyChanged("SelectedView");
            RaisePropertyChanged("Visible");
        }
        
        public ReadOnlyCollection<CommandViewModel> Commands {
            get { return _commands; }
            set {
                _commands = value;
                RaisePropertyChanged("Commands");
            }
        }

        public BaseViewModel SelectedView  {
            get { return _selectedView; }
            set {
                _selectedView = value;
                RaisePropertyChanged("SelectedView");                
            }
        }

        public CabeceraFormularioCTMViewModel CabeceraView {
            get { return _cabeceraView; }
            set {
                _cabeceraView = value;
                RaisePropertyChanged("CabeceraView");
            }
        }

        public RelacionOtrosJobsViewModel RelacionOtrosJobsView {
            get { return _relacionOtrosJobsView; }
            set {
                _relacionOtrosJobsView = value;
                RaisePropertyChanged("RelacionOtrosJobsView");
            }

        }

        public AccionesATomarViewModel AccionesATomar {
            get { return _accionesATomarView; }
            set{
                _accionesATomarView = value;
                RaisePropertyChanged("AccionesATomar");
            }
        }

        public PasosViewModel Pasos {
            get { return _pasos;  }
            set {
                _pasos = value;
                RaisePropertyChanged("Pasos");
            }
        }

        public FormularioCTMViewModel Formulario {
            get { return _formulario; }
            set {
                _formulario = value;               
                RaisePropertyChanged("Formulario");
            }
        }

        public override string GetValidationError(string propertyName) {
            return null;
        }

    }
}

