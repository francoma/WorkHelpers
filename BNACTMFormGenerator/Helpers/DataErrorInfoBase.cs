using System;
using System.ComponentModel;

namespace BNACTMFormGenerator.Helpers
{
    abstract public class DataErrorInfoBase : IDataErrorInfo {

        protected bool IsStringMissing(string value) {
            return String.IsNullOrEmpty(value) || value.Trim() == String.Empty;
        }
        
        public string Error {
            get { return String.Empty; }
        }

        string[] ValidatedProperties = {};

        public string this[string columnName] {
            get { return this.GetValidationError(columnName); }
        }

        abstract public string GetValidationError(string propertyName);

        virtual public bool IsValid {
            get {
                foreach (string property in ValidatedProperties) {
                    if (GetValidationError(property) != null) {
                        return false;
                    }
                }
                return true;
            }
        }        
    }
}
