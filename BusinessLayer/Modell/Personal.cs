using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteksapplikation.Model
{
    public class Personal
    {
        public string PersonalID
        {
            get; private set;
        }

        public string Namn
        {
            get; private set;
        }

        internal Personal(string id, string lösenord, string name)
        {
            PersonalID = id;
            this.Lösenord = lösenord;
            Namn = name;
        }

        internal bool VerifieraLösenord(string inmatatLösen)
        {
            return Lösenord == inmatatLösen;
        }

        private string Lösenord;
    }
}
