using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteksapplikation.Model
{
    public class Bokning
    {
        public string Bokningsreferens { get; private set; }
        public string PersonalID { get; private set; }
        public string Titel { get; private set; }
        public string MedlemID { get; private set; }
        public long ISBN { get; private set; }
        public DateTime Datum { get; private set; }
        public DateTime UtgångsDatum { get; private set; }
        public DateTime? Återlämnad { get; set; }
        public double Totalpris { get; set; }

        internal Bokning(string bokningsRef, string personalId, string titel, string medlemId, long isbn, DateTime startDatum, DateTime utgångsDatum)
        {
            Bokningsreferens = bokningsRef;
            PersonalID = personalId;
            Titel = titel;
            MedlemID = medlemId;
            ISBN = isbn;
            Datum = startDatum;
            UtgångsDatum = utgångsDatum;
            Återlämnad = null;
            Totalpris = 0;
        }
    }
}
