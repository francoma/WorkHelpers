using System.Collections.ObjectModel;
using BNACTMFormGenerator.Model;

namespace BNACTMFormGenerator.ViewModel
{
    class RelacionOtrosJobsViewModel : BaseViewModel {
        private JobViewModel _selectedJobEntrada;
        public BaseCommand DeleteCommandJobEntrada { get; set; }
        public BaseCommand AddCommandJobEntrada { get; set; }
                
        private JobViewModel _selectedJobSalida;
        public BaseCommand DeleteCommandJobSalida { get; set; }
        public BaseCommand AddCommandJobSalida { get; set; }
                
        private JobViewModel _selectedJobParalelo;
        public BaseCommand DeleteCommandJobParalelo { get; set; }
        public BaseCommand AddCommandJobParalelo { get; set; }

        private RelacionOtrosJobs _relacioOtrosJobs;

        public RelacionOtrosJobsViewModel() {
            _relacioOtrosJobs = new RelacionOtrosJobs();

            DeleteCommandJobEntrada = new BaseCommand(OnDeleteJobEntrada, CanDeleteJobEntrada);
            AddCommandJobEntrada = new BaseCommand(OnAddJobEntrada, CanAddJobEntrada);

            DeleteCommandJobSalida = new BaseCommand(OnDeleteJobSalida, CanDeleteJobSalida);
            AddCommandJobSalida = new BaseCommand(OnAddJobSalida, CanAddJobSalida);

            DeleteCommandJobParalelo = new BaseCommand(OnDeleteJobParalelo, CanDeleteJobParalelo);
            AddCommandJobParalelo = new BaseCommand(OnAddJobParalelo, CanAddJobParalelo);
        }

        public RelacionOtrosJobs DataObject {
            get { return _relacioOtrosJobs; }
            set {
                _relacioOtrosJobs = value;
                RaisePropertyChanged("DataObject");
            }
        }

        public ObservableCollection<JobViewModel> JobsEntrada {
            get { return _relacioOtrosJobs.JobsEntrada; }
            set {
                _relacioOtrosJobs.JobsEntrada = value;
                RaisePropertyChanged("JobsEntrada");
            }
        }

        public ObservableCollection<JobViewModel> JobsSalida {
            get { return _relacioOtrosJobs.JobsSalida; }
            set {
                _relacioOtrosJobs.JobsSalida = value;
                RaisePropertyChanged("JobsSalida");
            }
        }

        public ObservableCollection<JobViewModel> JobsParalelos {
            get { return _relacioOtrosJobs.JobsParalelos; }
            set {
                _relacioOtrosJobs.JobsParalelos = value;
                RaisePropertyChanged("JobsParalelos");
            }
        }

        public string Aclaraciones {
            get { return _relacioOtrosJobs.Aclaraciones; }
            set {
                if (!_relacioOtrosJobs.Aclaraciones.Equals(value)) {
                    _relacioOtrosJobs.Aclaraciones = value;
                    RaisePropertyChanged("Aclaraciones");
                }
            }
        }

        public JobViewModel SelectedJobEntrada {
            get { return _selectedJobEntrada; }
            set {
                _selectedJobEntrada = value;
            }
        }

        public JobViewModel SelectedJobSalida {
            get { return _selectedJobSalida; }
            set {
                _selectedJobSalida = value;
            }
        }

        public JobViewModel SelectedJobParalelo {
            get { return _selectedJobParalelo; }
            set {
                _selectedJobParalelo = value;
            }
        }

        #region Command Jobs Entrada
        private void OnDeleteJobEntrada(object obj) {
            _relacioOtrosJobs.JobsEntrada.Remove(_selectedJobEntrada);
        }

        private bool CanDeleteJobEntrada(object obj) {
            return _selectedJobEntrada != null;
        }

        private void OnAddJobEntrada(object obj) {
            _relacioOtrosJobs.JobsEntrada.Add(new JobViewModel());
        }

        private bool CanAddJobEntrada(object obj) {
            return _relacioOtrosJobs.JobsEntrada.Count <= 18;
        }
        #endregion Command Jobs Entrada

        #region Command Jobs Salida

        private void OnDeleteJobSalida(object obj) {
            _relacioOtrosJobs.JobsSalida.Remove(_selectedJobSalida);
        }

        private bool CanDeleteJobSalida(object obj) {
            return _selectedJobSalida != null;
        }

        private void OnAddJobSalida(object obj) {
            _relacioOtrosJobs.JobsSalida.Add(new JobViewModel());
        }

        private bool CanAddJobSalida(object obj) {
            return _relacioOtrosJobs.JobsSalida.Count <= 18;
        }

        #endregion Command Jobs Salida

        #region Command Jobs Paralelos

        private void OnDeleteJobParalelo(object obj) {
            _relacioOtrosJobs.JobsParalelos.Remove(_selectedJobParalelo);
        }

        private bool CanDeleteJobParalelo(object obj) {
            return _selectedJobParalelo != null;
        }

        private void OnAddJobParalelo(object obj) {
            _relacioOtrosJobs.JobsParalelos.Add(new JobViewModel());
        }

        private bool CanAddJobParalelo(object obj) {
            return _relacioOtrosJobs.JobsParalelos.Count <= 18;
        }

        #endregion Command Jobs Paralelos

        override public string GetValidationError(string propertyName) {
            return _relacioOtrosJobs.GetValidationError(propertyName);            
        }
    }
}