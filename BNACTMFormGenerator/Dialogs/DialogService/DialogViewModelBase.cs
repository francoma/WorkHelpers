using System.Windows;
using BNACTMFormGenerator.Model;
using BNACTMFormGenerator.ViewModel;

namespace BNACTMFormGenerator.Dialogs.DialogService
{
    public abstract class DialogViewModelBase
    {
        public DialogResult UserDialogResult {
            get;
            private set;
        }        
        public PasoViewModel<Paso> Paso { get; private set; }

        public DialogViewModelBase(PasoViewModel<Paso> paso) {
            Paso = paso; 
        }

        public void CloseDialogWithResult(Window dialog, DialogResult result) {
            this.UserDialogResult = result;
            if (dialog != null)
                dialog.DialogResult = true;
        } 
    } 
}
