using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNACTMFormGenerator.Dialogs.DialogService
{
    public static class DialogService {

        public static DialogResult OpenDialog(DialogViewModelBase vm) {
            DialogWindow win = new DialogWindow();
            win.DataContext = vm;
            win.ShowDialog();
            DialogResult result = (win.DataContext as DialogViewModelBase).UserDialogResult;
            return result;  
        } 
    }
}
