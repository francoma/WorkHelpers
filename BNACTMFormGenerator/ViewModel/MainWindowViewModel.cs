﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
        }

        public RelacionOtrosJobsViewModel RelacionOtrosJobsView {
            get { return _relacionOtrosJobsView; }
        }

        public AccionesATomarViewModel AccionesATomar {
            get { return _accionesATomarView; }
        }

        public PasosViewModel Pasos {
            get { return _pasos;  }
        }

        public FormularioCTMViewModel Formulario {
            get { return _formulario; }
        }

        public override string GetValidationError(string propertyName) {
            return null;
        }

    }
}