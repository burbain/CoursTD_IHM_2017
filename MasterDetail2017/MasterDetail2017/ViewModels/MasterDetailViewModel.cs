using MasterDetail2017.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetail2017.ViewModels
{
    /// <summary>
    /// View model
    /// </summary>
    public class MasterDetailViewModel : INotifyPropertyChanged
    {
        #region private
        private string _masterDetailLabel;
        private List<PersonneModel> _listPersonne;
        private string _nom;
        private string _nom1;
        private PersonneModel _selectedPersonne;

        #endregion

        #region Public
        public string MasterDetailLabel
        {
            get
            {
                return _masterDetailLabel;
            }

            set
            {
                _masterDetailLabel = value;
            }
        }

        public List<PersonneModel> ListPersonne
        {
            get
            {
                return _listPersonne;
            }

            set
            {
                _listPersonne = value;
            }
        }

        public string Nom
        {
            get
            {
                return _nom;
            }

            set
            {
                _nom = value;
                Nom1 = value;
            }
        }

        public PersonneModel SelectedPersonne
        {
            get
            {
                return _selectedPersonne;
            }

            set
            {
                _selectedPersonne = value;
            }
        }

        public string Nom1
        {
            get
            {
                return _nom1;
            }

            set
            {
                _nom1 = value;
                NotifyPropertyChanged("Nom1");
            }
        }

        #endregion

        public MasterDetailViewModel()
        {
            MasterDetailLabel = "MasterDetail2017";
            ListPersonne = new List<PersonneModel>()
            {
                new PersonneModel()
                {
                    Nom = "URBAIN",
                    Prenom ="BAPTISTE"
                },
                new PersonneModel()
                {
                    Nom = "BAILLY",
                    Prenom ="THIBAUT"
                }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }
}
