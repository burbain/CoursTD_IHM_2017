using Library;
using MasterDetail2017.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MasterDetail2017.ViewModels
{
    /// <summary>
    /// View model
    /// </summary>
    public class MasterDetailViewModel : ViewModelBase
    {
        #region private
        private string _masterDetailLabel;
        private List<PersonneModel> _listPersonne;
        private string _nom;
        private string _nom1;
        private PersonneModel _selectedPersonne;
        private bool _IsVisible;
        private bool _isClick;

        #endregion

        #region Public

        public DelegateCommand ClickCommand { get; private set; }

        public DelegateCommand MouseOverCommand { get; private set; }

        private DetailWindow _view;

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
                _isClick = true;
                if (ClickCommand != null)
                {
                    ClickCommand.RaiseCanExecuteChanged();
                }
                NotifyPropertyChanged("SelectedPersonne");
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

        public bool IsVisible
        {
            get
            {
                return _IsVisible;
            }

            set
            {
                _IsVisible = value;
                NotifyPropertyChanged("IsVisible");
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

            IsVisible = true;
            _isClick = true;
            ClickCommand = new DelegateCommand(OnExecuteClick, CanExcuteClick);
            MouseOverCommand = new DelegateCommand(OnMouseOver);
            _view = new DetailWindow();
        }

        private void OnMouseOver(object obj)
        {
            MessageBox.Show("ça marche !");
        }

        private bool CanExcuteClick(object obj)
        {
            return _isClick;
        }

        private void OnExecuteClick(object obj)
        {          
            _view.Show();

            ButtonPressedEvent.GetInstance().Handler += OnClose;
        }

        private void OnClose(object sender, EventArgs e)
        {
            _view.Close();
            ButtonPressedEvent.GetInstance().Handler -= OnClose;
        }
    }
}
