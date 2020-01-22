using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Programming_Challenges
{
    class NameGenerator
    {
        /* TO DO...
         * Pitää keksiä vielä jokin tapa poimia myös niiden maiden sukunimet, joissa
         * sukunimilläkin on sukupuolijakauma (kuten Islanti tai Azeri).
         */
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
                                kansallisuus = Regex.Match(line, @"\w+-?\w*").Value;

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
                                    if(i.Nationality == kansallisuus) {
                                        maaOlio = i;
                                        continue;
                                    }
                                }

                                // Jos maa ei ollut listassa, tehdään uusi maa
                                if(maaOlio == null) {
                                    maaOlio = new MaaOlio(kansallisuus);
                                    maaOlio.LisaaNimiOminaisuudet(etunimi, ge);
                                    maaLista.Add(maaOlio);
                                }
                                // Jos maa oli listassa, käydään maan ominaisuudet läpi ja katsotaan onko nämä jo lisätty
                                else {
                                    bool ominaisuudet = false;
                                    foreach(var i in maaOlio.nimiOmaisuudetLista) {
                                        if((i.Gender == ge) && (i.FName == etunimi)) {
                                            ominaisuudet = true;
                                        }
                                    }
                                    if(!ominaisuudet)
                                        maaOlio.LisaaNimiOminaisuudet(etunimi, ge);
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
            public class NimiOminaisuudet
            {
                public class Nimi
                {
                    public Nimi(string name) {
                        Name = name;
                    }
                    //// Muuttujat Nimelle////
                    public string Name { get; set; }
                }
                public NimiOminaisuudet(bool fName, Gender gender) {
                    FName = fName;
                    Gender = gender;
                }
                public void LisaaNimi(string name) {
                    Nimet.Add(new Nimi(name));
                }

                //// Muuttujat NimiOliolle////
                public bool FName { get; set; }
                public Gender Gender { get; set; }
                internal List<Nimi> Nimet { get; set; } = new List<Nimi>();
            }
            public void LisaaNimiOminaisuudet(bool fname, Gender ge) {
                nimiOminaisuudet = new NimiOminaisuudet(fname, ge);
                nimiOmaisuudetLista.Add(nimiOminaisuudet);
            }
            public void LisaaNimi(string name) {
                nimiOminaisuudet.LisaaNimi(name);
                if(name == "Icelandic") {
                    int tyr = 0;
                }
            }
            //// Muuttujat MaaOliolle////
            public List<NimiOminaisuudet> nimiOmaisuudetLista { get; set; }
            private NimiOminaisuudet nimiOminaisuudet;
            public MaaOlio(string nationality) {
                Nationality = nationality;
                nimiOmaisuudetLista = new List<NimiOminaisuudet>();
            }
            public string Nationality { get; set; }
        }

        public enum Gender
        {
            Male, Female, None
        }
    }
}
