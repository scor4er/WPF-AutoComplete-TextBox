using JulMar.Windows.Validations;
using WpfConstrols.Demo.Model;

namespace WpfConstrols.Demo
{
    public class MainWindowViewModel: ValidatingViewModel
    {
        private State _selectedState;
        private string _name;
        private string _statesText;

        [System.ComponentModel.DataAnnotations.Required]
        public State SelectedState
        {
            get => _selectedState;
            set { _selectedState = value; RaisePropertyChanged(()=> SelectedState); }
        }

        [System.ComponentModel.DataAnnotations.Required]
        public State SelectedStateForMultiUsage
        {
            get => _selectedState;
            set { _selectedState = value; RaisePropertyChanged(() => SelectedStateForMultiUsage); }
        }

        [System.ComponentModel.DataAnnotations.Required]
        public string Name
        {
            get => _name;
            set { _name = value; RaisePropertyChanged(()=>Name); }
        }

        public string StatesText
        {
            get => _statesText;
            set { _statesText = value; RaisePropertyChanged(() => StatesText); }
        }
    }
}