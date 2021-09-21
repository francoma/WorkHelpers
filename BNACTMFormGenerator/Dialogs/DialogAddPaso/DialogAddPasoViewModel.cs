using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using BNACTMFormGenerator.Dialogs.DialogService;
using BNACTMFormGenerator.Model;
using BNACTMFormGenerator.ViewModel;

namespace BNACTMFormGenerator.Dialogs.DialogAddPaso
{
    class DialogAddPasoViewModel : DialogViewModelBase {
        private ICommand _aceptarCommand = null;
        private ICommand _cancelarCommand = null;
        

        public ICommand AceptarCommand  {
            get { return _aceptarCommand; }
            set { _aceptarCommand = value; }  
        }

        public ICommand CancelarCommand  {
            get { return _cancelarCommand; }
            set { _cancelarCommand = value; }  
        }

        public DialogAddPasoViewModel(PasoViewModel<Paso> paso) : base(paso) {
            
            _aceptarCommand = new BaseCommand(OnAceptarClicked, param => paso.IsValid);
            _cancelarCommand = new BaseCommand(OnCancelarClicked);  
        }

        private void OnAceptarClicked(object parameter) {
            CloseDialogWithResult(parameter as Window, DialogResult.Yes);
        }

        private void OnCancelarClicked(object parameter) {
            CloseDialogWithResult(parameter as Window, DialogResult.No);
        }  
    }
}
