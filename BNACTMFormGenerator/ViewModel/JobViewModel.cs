using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BNACTMFormGenerator.Helpers;
using BNACTMFormGenerator.Model;

namespace BNACTMFormGenerator.ViewModel
{
    public class JobViewModel : BaseViewModel {
        private Job _job;

        public JobViewModel() {
            _job = new Job();
        }

        public JobViewModel(Job job) {
            _job = job;
        }

        public JobViewModel(string nombreJob) {
            _job = new Job(nombreJob);
        }

        public string NombreJobTest {
            get { return _job.NombreJobTest; }
            set {
                if (_job.NombreJobTest != value) {
                    _job.NombreJobTest = value;
                    RaisePropertyChanged("NombreJobTest");
                }
            }
        }

        public Job Job {
            get { return _job; }
            set {
                if (_job != value) {
                    _job = value;
                    RaisePropertyChanged("NombreJobProd");
                    RaisePropertyChanged("NombreJobTest");
                }
            }
        }

        public string NombreJobProd {
            get { return _job.NombreJobProd; }
            set {
                if (_job.NombreJobProd != value) {
                    _job.NombreJobProd = value;
                    _job.NombreJobTest = value + "T";
                    RaisePropertyChanged("NombreJobProd");
                    RaisePropertyChanged("NombreJobTest");
                }
            }
        }

        override public string GetValidationError(string propertyName) {
            return _job.GetValidationError(propertyName);
        }        
    }
}
