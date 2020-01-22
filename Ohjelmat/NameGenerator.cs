using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Programming_Challenges
{
    class NameGenerator
    {
        public List<MaaOlio> maaLista { get; set; }

        /* Funktio hakee nimet tiedostosta ja käy tekstin läpi rivi kerrallaan. Jokainen rivi tarkis-
         * tetaan siltä varalta, onko kyseessä nimi tai kansallisuus. Kansallisuus rivi tulee tekstissä
         * aina ensin vastaan, jonka jälkeen tulevat nimet. Nimien ja kansallisuuksien järjestys tiedos-
         * tossa pomppii rasittavasti
         */
        public void LueNimet() {

            /*  RegEx tarkistus taulukko
             *  
             * () sulkujen sisällä haetaan merkkien ryhmää
             * \w tarkoittaa sana merkkiä, eli kirjaimia tai numeroita
             * + tarkoittaa, että merkki voi tulla yhden tai useamman kerran
             * * tarkoittaa, että merkki voi tulla 0 tai enemmän kertaa
             * . tarkoittaa, että siinä kohtaa voi olla mikä tahansa merkki
             * {n,m} tarkoittaa, että merkki voi tulla vähintään n kertaa, mutta enintään m kertaa
             * 
             * Tällä lausekkeella saadan poimittua myös nimet, jotka ovat muotoa:
             * "O'Neil" tai "Vanhanen-Laatikainen"
             */

            Regex rxNimenTarkistus = new Regex("(\"\\w+.{0,3}\\w*\")");     // Etsii nimen
            Regex rxLainausmerkki = new Regex("\"");                        // Hakee lainausmerkit, joiden sisällä on sana
            Regex rxKansallisuus = new Regex("\\;([A-Z][a-z].*)");          // Tarkistaa ollaanko vaihtamassa kansallisuutta

            maaLista = new List<MaaOlio>();          
            MaaOlio maaOlio;

            string nimi, kansallisuus, sukupuoli;
            bool etunimi;
            Gender ge;

            try {
                using(StreamReader sr = new StreamReader("C:/Users/Eetu/source/repos/Programming Challenges/Programming Challenges/Resurssit/Nimilista.txt")) {
                    string line;
                    while((line = sr.ReadLine()) != null) {
                        maaOlio = null;
                        // Tarkistetaan onko rivi kansalaisuuden vaihtaminen
                        if(rxKansallisuus.IsMatch(line)) {

                            // Otetaan rivistä kansallisuus
                            if(!Regex.IsMatch(line, "(MALE|FEMALE|SURNAMES)")) {
                                kansallisuus = Regex.Match(line, "\\w+").Value;

                                // Otetaan rivistä sukupuoli
                                sukupuoli = Regex.Match(line, "(male|female)").Value;
                                etunimi = true;

                                // Jos sukupuolta ei ole, laitetaan se sukunimeksi
                                if(sukupuoli != "male" && sukupuoli != "female") {
                                    ge = Gender.None;
                                    etunimi = false;
                                } else if(sukupuoli == "male")
                                    ge = Gender.Male;
                                else
                                    ge = Gender.Female;

                                // Tarkistetaan, onko maa jo lisätty listaan
                                foreach(var i in maaLista) {
                                    if((i.Nationality == kansallisuus) && (i.Gender == ge) && (i.FName == etunimi)) {
                                        maaOlio = i;
                                        continue;
                                    }
                                }
                                // Jos maa ei ollut listassa, tehdään uusi maa
                                if(maaOlio == null) {
                                    maaOlio = new MaaOlio(kansallisuus, etunimi, ge);
                                }
                                // Hypätään seuraavaan riviin siinä uskossa, että sieltä löytyisi nimi
                                line = sr.ReadLine();

                                // Niin kauan kun rivi on nimi, jatketaan rivin lisäämistä listaan
                                while(rxNimenTarkistus.IsMatch(line)) {
                                    if(rxNimenTarkistus.Match(line).ToString() != "") {
                                        // Luodaan nimi regexin perusteella
                                        nimi = rxLainausmerkki.Replace(rxNimenTarkistus.Match(line).Value, "");
                                        maaOlio.LisaaNimi(nimi);
                                    }
                                    line = sr.ReadLine();
                                }
                                maaLista.Add(maaOlio);
                            }
                        }
                    }
                }
            } catch(Exception e) {
                Debug.WriteLine(e);
            }
        }
        public class MaaOlio
        {
            public void LisaaNimi(string name) {
                maa = new NimiOlio(name);
                NimiLista.Add(maa);
            }

            public List<NimiOlio> nimiLista = new List<NimiOlio>();
            public string Nationality { get; set; }
            public bool FName { get; set; }
            public Gender Gender { get; set; }
            public List<NimiOlio> NimiLista { get => nimiLista; set => nimiLista = value; }

            private NimiOlio maa;

            public MaaOlio(string nationality, bool fName, Gender gender) {
                Nationality = nationality;
                FName = fName;
                Gender = gender;
            }

            public class NimiOlio
            {
                public NimiOlio(string name) {
                    Name = name;
                }
                public string Name { get; set; }
            }
        }
        public enum Gender
        {
            Male, Female, None
        }
    }
}
