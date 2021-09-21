using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BNACTMFormGenerator
{
    class BaseCommand : ICommand {
        readonly Action<object> _execute;
        readonly Predicate<object> _canExecute;        

      public BaseCommand(Action<object> executeMethod) : this(executeMethod, null){     
      }

      public BaseCommand(Action<object> execute, Predicate<object> canExecute) {
          if (execute == null) throw new ArgumentNullException("execute");

          _execute = execute;
         _canExecute = canExecute; 
      }

      [DebuggerStepThrough]
      bool ICommand.CanExecute(object parameter) {
          return _canExecute == null ? true : _canExecute(parameter);
      }
		
      // Beware - should use weak references if command instance lifetime is longer than lifetime of UI objects that get hooked up to command 			
      // Prism commands solve this in their implementation 
      public event EventHandler CanExecuteChanged {
          add { CommandManager.RequerySuggested += value; }
          remove { CommandManager.RequerySuggested -= value; }
      }

      void ICommand.Execute(object parameter) {
          if (_execute != null) {
              _execute(parameter); 
         } 
      } 
   }
}
