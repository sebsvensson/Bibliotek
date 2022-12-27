using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteksapplikation.Model
{
    class Medlem
    {
        public string MedlemID
        {
            get; private set;
        }

        public string Namn
        {
            get; private set;
        }

        public string Telefon
        {
            get; private set;
        }

        public string Email
        {
            get; private set;
        }

        internal Medlem(string id, string namn, string telefon, string email)
        {
            MedlemID = id;
            Namn = namn;
            Telefon = telefon;
            Email = email;
        }
    }
}
