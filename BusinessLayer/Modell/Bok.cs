using Biblioteksapplikation.Internals;
using Biblioteksapplikation.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BiblioteksApplikation.Model
{
    public class Bok
    {

        public long ISBN { get; private set; }
        public string Titel { get; private set; }
        public int Dagar { get; private set; }

        private List<Bokning> repos;

        internal Bok(long isbn, string titel)
        {
            repos = new List<Bokning>();
            ISBN = isbn;
            Titel = titel;
            Dagar = 1;
        }

        public void LäggBokning(Bokning bokning)
        {
            repos.Add(bokning);
        }

        public bool ÄrTillgänglig(DateTime start)
        {
            foreach (var item in repos)
            {
                
                if ((start < item.UtgångsDatum && start < item.Datum.AddDays(Dagar)) && item.Återlämnad == null)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
