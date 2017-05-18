using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetail2017.Model
{
    public class PersonneModel
    {
        private string _nom;
        private string _prenom;
        public string Nom
        {
            get
            {
                return _nom;
            }

            set
            {
                _nom = value;
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
            }
        }
        public override string ToString()
        {
            return $"{Nom} - {Prenom}";
        }
    }
}
