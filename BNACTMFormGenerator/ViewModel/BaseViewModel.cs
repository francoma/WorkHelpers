using System;
using System.ComponentModel;
using BNACTMFormGenerator.Helpers;

namespace BNACTMFormGenerator.ViewModel
{
    public abstract class BaseViewModel : DataErrorInfoBase, INotifyPropertyChanged  {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _visible;
        
        protected void RaisePropertyChanged(string property) {
            VerifyPropertyName(property);

            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public string Visible { 
            get { return _visible; } 
            set {
                if (_visible != value) {
                    _visible = value;
                    RaisePropertyChanged("Visible");
                }
            } 
        }

        public void VerifyPropertyName(string propName) {
            if (TypeDescriptor.GetProperties(this)[propName] == null) {
                throw new Exception("Nombre de Propiedad inválida: " + propName);
            }
        }

    }
}
