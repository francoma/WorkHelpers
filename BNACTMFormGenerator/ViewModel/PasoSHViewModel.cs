using System;
using System.Collections.ObjectModel;
using BNACTMFormGenerator.Model;

namespace BNACTMFormGenerator.ViewModel
{
    class PasoSHViewModel : PasoViewModel<Paso> {        
        private string _selectedParam;
        public string _currentTipoSh;
        public string NewParam { get; set; }
        public BaseCommand AddParam {get; set;}
        public BaseCommand DelParam { get; set; }

        public PasoSHViewModel() : base(new PasoSH()) {
            NewParam = "";
            AddParam = new BaseCommand(OnAddParam, param => NewParam.Trim().Length > 0);
            DelParam = new BaseCommand(OnDelParam, param => _selectedParam != null);
        }

        public PasoSHViewModel(PasoSH p) : base(p) {
            NewParam = "";
            AddParam = new BaseCommand(OnAddParam, param => NewParam.Trim().Length > 0);
            DelParam = new BaseCommand(OnDelParam, param => _selectedParam != null);
        }

        public string CurrentTipoSh { 
            get { return _currentTipoSh; }
            set {
                if (_currentTipoSh != value) {
                    _currentTipoSh = value;

                    switch (_currentTipoSh) {
                        case "Ejecución Workflow":
                            ServidorTest = "[TUX82CT0001 | TUX82AT0001 (utilizar este último en caso de fallo del CT)]";
                            ServidorProd = "[SUX82CT0001 | SUX82AT0001 (utilizar este último en caso de fallo del CT)]";
                            UbicacionScriptTest = "/opt/siebel/BATCH_Script/scripts/";
                            UbicacionScriptProd = "/opt/siebel/BATCH_Script/scripts/";
                            Script = "WFExecution.sh";

                            if (Parametros == null) Parametros = new ObservableCollection<string>();
                            else Parametros.Clear();

                            Parametros.Add("SBLSRVFIN1 (SUX82CT001), SBLSRVFIN2 (SUX82AT0001)");
                            NewParam = "Reemplace este texto por el nombre del Workflow de Siebel";

                            RaisePropertyChanged("NewParam");
                            break;

                        case "Ejecución Tarea EIM":
                            ServidorTest = "[TUX81CT0001 | TUX81AT0001 (utilizar este último en caso de fallo del CT)]";
                            ServidorProd = "[SUX81CT0001 | SUX81AT0001 (utilizar este último en caso de fallo del CT)]";
                            UbicacionScriptTest = "/opt/siebel/EIM_Script/scripts/";
                            UbicacionScriptProd = "/opt/siebel/EIM_Script/scripts/";
                            Script = "Reemplace este texto por el nombre del Sh";

                            if (Parametros == null) Parametros = new ObservableCollection<string>();
                            else Parametros.Clear();

                            Parametros.Add("SBLSRVEIM1(Server EIMCT) | SBLSRVEIM2(ServerEIMAT)");

                            break;

                        case "Otro":
                            ServidorTest = String.Empty;
                            ServidorProd = String.Empty;
                            UbicacionScriptTest = String.Empty;
                            UbicacionScriptProd = String.Empty;
                            Script = String.Empty;

                            if (Parametros != null) Parametros.Clear();
                            
                            break;

                    }
                    RaisePropertyChanged("ServidorTest");
                    RaisePropertyChanged("ServidorProd");
                    RaisePropertyChanged("UbicacionScriptTest");
                    RaisePropertyChanged("UbicacionScriptProd");
                    RaisePropertyChanged("Script");
                    RaisePropertyChanged("Parametros");
                    RaisePropertyChanged("CurrentTipoSh");
                }
            }
        }

        public void OnAddParam(object obj) {
            if (Parametros == null) {
                Parametros = new ObservableCollection<string>();
            }
            Parametros.Add(NewParam);
            NewParam = "";
            RaisePropertyChanged("NewParam");
            RaisePropertyChanged("Parametros");
        }

        public void OnDelParam(object obj) {
            Parametros.Remove(SelectedParam);
            RaisePropertyChanged("Parametros");
            RaisePropertyChanged("SelectedParam");
        }
        
        public ObservableCollection<string> Parametros {
            get { return ((PasoSH)DataObject).Parametros; }
            set {
                PasoSH psp = (PasoSH)DataObject;
                psp.Parametros = value;

                RaisePropertyChanged("Parametros");
            }
        }

        public string SelectedParam {
            get { return _selectedParam; }
            set {
                if (_selectedParam != value) {
                    _selectedParam = value;
                    RaisePropertyChanged("SelectedParam");
                }
            }
        }

        public string BaseDatosTest {
            get { return ((PasoSH)DataObject).BaseDatosTest; }
            set
            {
                PasoSH psql = (PasoSH)DataObject;

                if (psql.BaseDatosTest != value) {
                    psql.BaseDatosTest = value;
                    RaisePropertyChanged("BaseDatosTest");
                }
            }
        }

        public string BaseDatosProd {
            get { return ((PasoSH)DataObject).BaseDatosProd; }
            set {
                PasoSH psql = (PasoSH)DataObject;

                if (psql.BaseDatosProd != value) {
                    psql.BaseDatosProd = value;
                    RaisePropertyChanged("BaseDatosProd");
                }
            }
        }

        public string UsuarioEjecucionTest {
            get { return ((PasoSH)DataObject).UsuarioEjecucionTest; }
            set {
                PasoSH psql = (PasoSH)DataObject;

                if (psql.UsuarioEjecucionTest != value) {
                    psql.UsuarioEjecucionTest = value;
                    RaisePropertyChanged("UsuarioEjecucionTest");
                }
            }
        }

        public string UsuarioEjecucionProd {
            get { return ((PasoSH)DataObject).UsuarioEjecucionProd; }
            set {
                PasoSH psql = (PasoSH)DataObject;

                if (psql.UsuarioEjecucionProd != value) {
                    psql.UsuarioEjecucionProd = value;
                    RaisePropertyChanged("UsuarioEjecucionProd");
                }
            }
        }

        public string UbicacionScriptTest {
            get { return ((PasoSH)DataObject).UbicacionScriptTest; }
            set {
                PasoSH psql = (PasoSH)DataObject;

                if (psql.UbicacionScriptTest != value) {
                    psql.UbicacionScriptTest = value;
                    RaisePropertyChanged("UbicacionScriptTest");
                }
            }
        }

        public string UbicacionScriptProd {
            get { return ((PasoSH)DataObject).UbicacionScriptProd; }
            set {
                PasoSH psql = (PasoSH)DataObject;

                if (psql.UbicacionScriptProd != value) {
                    psql.UbicacionScriptProd = value;
                    RaisePropertyChanged("UbicacionScriptProd");
                }
            }
        }

        public string Script {
            get { return ((PasoSH)DataObject).Script; }
            set {
                PasoSH psh = (PasoSH)DataObject;

                if (psh.Script != value) {
                    psh.Script = value;
                    RaisePropertyChanged("Script");
                }
            }
        }

        override public string GetValidationError(string propertyName) {
            return ((PasoSH)DataObject).GetValidationError(propertyName);
        }

        public override bool IsValid {
            get {
                return ((PasoSH)DataObject).IsValid;
            }
        }    
    }
}
