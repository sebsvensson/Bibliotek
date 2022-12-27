using Biblioteksapplikation.Internals;
using Biblioteksapplikation.Model;
using BiblioteksApplikation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteksapplikation
{
    /// <summary>
    ///  This is the facade of the business layer.
    /// </summary>
    public class Bokningssystem
    {
        private int bokningsreferens;
        private string personalID;
        private static Bokningssystem bokningssystem;

        public Personal Inloggad
        {
            get; private set;
        }

        public Bokningssystem()
        {
            bokningsreferens = 1;
            work = new UnitOfWork();
        }

        public static Bokningssystem HämtaBöcker()
        {
            if (bokningssystem == null)
            {
                bokningssystem = new Bokningssystem();
            }
            return bokningssystem;
        }

        /// <summary>
        ///  The LogIn system operation.
        /// </summary>
        /// <param name="personalId"></param>
        /// <param name="lösenord"></param>
        /// <returns></returns>
        public bool LoggaIn(string personalId, string lösenord)
        {
            foreach (Personal personal in work.PersonalRepository.Table)
            {
                if (personal.PersonalID == personalId && personal.VerifieraLösenord(lösenord))
                {
                    Inloggad = personal;
                    return true;
                }
            }
            Inloggad = null;
            return false;
        }

        public IList<Bok> TillgängligaBöcker(DateTime datum)
        {
            List<Bok> tillgängligaBöcker = new List<Bok>();
            foreach (Bok bok in work.BokRepository.Table)
            {
                if (bok.ÄrTillgänglig(datum))
                    tillgängligaBöcker.Add(bok);
            }
            return tillgängligaBöcker;
        }

        public IList<Bok> AllaBöcker()
        {
            return work.BokRepository.Table;
        }

        public IList<Bokning> AllaBokningar()
        {
            return work.BokningRepository.Table;
        }

        public IList<Bokning> LagdaBokningar()
        {
            IList<Bokning> nuvarandeBokningar = new List<Bokning>();

            foreach (Bokning bokning in work.BokningRepository.Table)
            {
                if (bokning.Återlämnad == null)
                    nuvarandeBokningar.Add(bokning);
            }
            return nuvarandeBokningar;
        }

        public bool ÄrMedlem(string medlemID)
        {
            foreach (Medlem medlem in work.MedlemRepository.Table)
            {
                if (medlem.MedlemID == medlemID)
                    return true;
            }
            return false;
        }
       
        public void ÅterlämnaBok(string bokningId)
        {
            Bokning bokning = HittaBokning(bokningId);

            bokning.Återlämnad = DateTime.Now;
            if (bokning.UtgångsDatum < bokning.Återlämnad)
            {
                bokning.Totalpris = Math.Ceiling((DateTime.Now - bokning.UtgångsDatum).TotalDays) * 10;
            }
        }
        public Bokning HittaBokning(string bokningRef)
        {
            for (int i = 0; i < work.BokningRepository.Table.Count; i++)
            {
                if (work.BokningRepository.Table[i].Bokningsreferens.Equals(bokningRef))
                {
                    return work.BokningRepository.Table[i];
                }
            }
            return null;
        }

        public Bok HittaBok(long isbn)
        {
            foreach (var bok in work.BokRepository.Table)
            {
                if (bok.ISBN == isbn) return bok;
            }
            return null;
        }

        public void LäggBokning(string medlemId, Bok bok, DateTime datum, DateTime förfallodatum)
        {
            Bokning bokning = new Bokning("Bkn" + Convert.ToString(bokningsreferens++), personalID, bok.Titel,
                medlemId, Convert.ToInt64(bok.ISBN), datum, förfallodatum 
           );
            work.BokningRepository.Table.Add(bokning);
            bok.LäggBokning(bokning);
        }

        private UnitOfWork work;

    }
}
