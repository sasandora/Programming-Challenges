using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Programming_Challenges
{
    public partial class frnNameGenerator : Form
    {
        private NameGenerator ng;
        public frnNameGenerator() {
            InitializeComponent();
            ng = new NameGenerator();
            ng.LueNimet();
            string buffer;
            List<string> maat = new List<string>();

            // Käydään nimet listaan
            foreach(var item in ng.maaLista) {
                string maa = item.Nationality;
                maat.Add(maa);
            }
            maat.Sort();

            // Ei lisätä duplikaatteja komponenttiin
            foreach(var m in maat) {
                chklbNationalities.Items.Add(m);
            }
        }
        /* TO DO...
         Jos sukupuolta ei ole valittu, tulee etunimen olla satunnainen.
             */
        private void btnLuoNimi_Click(object sender, System.EventArgs e) {
            btnLuoNimi.Enabled = false;
            Random random = new Random();
            List<string> valitutMaat = new List<string>();
            NameGenerator.Gender sukupuoli;
            if(rdMies.Checked)
                sukupuoli = NameGenerator.Gender.Male;
            else if(rdNainen.Checked)
                sukupuoli = NameGenerator.Gender.Female;
            else
                sukupuoli = NameGenerator.Gender.None;

            // Tarkistetaan onko maita valittu
            if(chklbNationalities.CheckedItems != null) {
                // Käydään jokainen valittu maa listaan
                foreach(var item in chklbNationalities.CheckedItems)
                    valitutMaat.Add(item.ToString());

                // Käydään jokainen nimi läpi
                foreach(var nimi in ng.maaLista) {
                    // Verrataan valittuja maita listalta löytyviin maihin
                    foreach(var maa in valitutMaat) {
                        // Hypätään yli, jos maa ei ollut valittujen listassa
                        if(maa == nimi.Nationality) {
                            // Tarkistetaan, onko listan nimi etu- vai sukunimi
                            foreach(var ominaisuudet in nimi.nimiOmaisuudetLista) {
                                if(ominaisuudet.Gender == NameGenerator.Gender.Male) {
                                    int arpa = random.Next(ominaisuudet.Nimet.Count);
                                    txtEnimi.Text = ominaisuudet.Nimet[arpa].Name;
                                } else if(ominaisuudet.Gender == NameGenerator.Gender.None) {
                                    int arpa = random.Next(ominaisuudet.Nimet.Count);
                                    txtSnimi.Text = ominaisuudet.Nimet[arpa].Name;
                                }
                            }
                        }
                    }
                }
            }
            btnLuoNimi.Enabled = true;
        }
    }
}

