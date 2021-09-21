using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BNACTMFormGenerator.ViewModel
{
    public enum TVista
    {
        Cabecera,
        Jobs,
        Acciones,
        Pasos,
        Formulario,
        PasoSQL,
        PasoStoredProcedure,
        PasoJob,
        PasoCopiaArchivos,
        PasoEliminacionArchivos,
        PasoSh
    }

    class CommandViewModel : BaseViewModel {
        public string CommandText { get; set; }
        public TVista TipoVista { get; set; }

        public CommandViewModel(string displayName, TVista vw, ICommand command) {
            if (command == null)
                throw new ArgumentNullException("command");
            
            CommandText = displayName;
            Command = command;
            TipoVista = vw;
        }

        public ICommand Command { get; private set; }

        override public string GetValidationError(string propertyName) {
            return String.Empty;
        }        

    }
}
