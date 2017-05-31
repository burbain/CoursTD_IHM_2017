using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetail2017.ViewModels
{
    public class DetailViewModel : ViewModelBase
    {
        private string _nom;
        private string _prenom;

        public DelegateCommand CloseCommand { get; private set; }

        public string Nom
        {
            get
            {
                return _nom;
            }

            set
            {
                _nom = value;
                NotifyPropertyChanged("Nom");
            }
        }

        public string Prenom
        {
            get
            {
                return _prenom;
            }

            set
            {
                _prenom = value;
                NotifyPropertyChanged("Prenom");
            }
        }

        public DetailViewModel()
        {
            CloseCommand = new DelegateCommand(OnClose);
        }

        private void OnClose(object obj)
        {
            ButtonPressedEvent.GetInstance().OnButtonPressedHandler(EventArgs.Empty);
        }

        private void OnEventReceived(object sender, EventArgs e)
        {
            
        }
    }
}
