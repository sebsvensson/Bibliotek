using Biblioteksapplikation.Model;
using BiblioteksApplikation.Model;
using System;
using System.Collections.Generic;

namespace Biblioteksapplikation.Internals
{
    /// <summary>
    ///  This class is used to access the storage in the application.
    /// </summary>
    internal class UnitOfWork
    {

        public Repository<Medlem> MedlemRepository
        {
            get; private set;
        }
        public Repository<Personal> PersonalRepository
        {
            get; private set;
        }

        public Repository<Bok> BokRepository
        {
            get;
        }

        public Repository<Bokning> BokningRepository
        {
            get;
        }

        internal UnitOfWork()
        {
            MedlemRepository = new Repository<Medlem>();
            PersonalRepository = new Repository<Personal>();
            BokRepository = new Repository<Bok>();
            BokningRepository = new Repository<Bokning>();

            if (PersonalRepository.Table.Count == 0 && BokRepository.Table.Count == 0)
            {
                Fyll();
            }
        }

        private void Fyll()
        {
            //Personal
            PersonalRepository.Table.Add(new Personal("admin", "lösenord", "Gabriella"));

            //Medlemmar
            MedlemRepository.Table.Add(new Medlem("101", "Kenta", "070-4623158", "s185152@student.hb.se"));
            MedlemRepository.Table.Add(new Medlem("102", "Hertig", "070-7851351", "s206452@student.hb.se"));
            MedlemRepository.Table.Add(new Medlem("103", "Jordan", "070-9563289", "s204569@student.hb.se"));

            //Böcker
            BokRepository.Table.Add(new Bok(12344555694, "Harry Potter och de vise sten"));
            BokRepository.Table.Add(new Bok(66844555612, "Harry Potter, Fången från azkaban"));
            BokRepository.Table.Add(new Bok(99844555614, "The Climb"));
            BokRepository.Table.Add(new Bok(26123425612, "Greta Gris"));
            BokRepository.Table.Add(new Bok(10123425699, "Hur gör man?"));
            BokRepository.Table.Add(new Bok(84123425612, "Harry Potter och hemligheternas kammare"));
            BokRepository.Table.Add(new Bok(88890123451, "Programmera mera"));
            BokRepository.Table.Add(new Bok(23901234561, "Test av IT-system"));
            BokRepository.Table.Add(new Bok(34012345677, "Mången gången"));
            BokRepository.Table.Add(new Bok(45123456786, "Tunnan och Moroten"));
            BokRepository.Table.Add(new Bok(95765432104, "Ondskan"));
            BokRepository.Table.Add(new Bok(22901234561, "Husmorstips"));
            BokRepository.Table.Add(new Bok(84012345677, "Pojken som kallades det"));
            BokRepository.Table.Add(new Bok(01123456786, "Bibeln"));
            BokRepository.Table.Add(new Bok(13744432104, "Koranen"));
            BokRepository.Table.Add(new Bok(67543456786, "The Matrix"));
            BokRepository.Table.Add(new Bok(78545432104, "Pojken som kallades den"));
            BokRepository.Table.Add(new Bok(54233456786, "IT"));
            BokRepository.Table.Add(new Bok(81275432104, "Kalle och chokladfabriken"));
            BokRepository.Table.Add(new Bok(99367978919, "Mamma mu och kråkan"));
            BokRepository.Table.Add(new Bok(45275432104, "Bajskalas"));
        }
    }
}