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
            buffer = "";

            // Ei lisätä duplikaatteja komponenttiin
            foreach(var m in maat) {
                if(buffer != m)
                    chklbNationalities.Items.Add(m);
                buffer = m;
            }
        }
        /* TO DO...
         Tee lista, johon kertää valittujen maiden nimet. Tarkista miten pitkä lista on ja tee siitä arpa.
         Arvo sitten mikä nimistä valitaan. Ota vain valitun sukupuolen nimet listaan. Jos sukupuolta ei ole
         valittu, tulee etunimen olla satunnainen.
             */
        private void btnLuoNimi_Click(object sender, System.EventArgs e) {
            btnLuoNimi.Enabled = false;
            List<string> valitutMaat = new List<string>();
            short sukupuoli;
            if(rdMies.Checked)
                sukupuoli = 0;
            else if(rdNainen.Checked)
                sukupuoli = 1;
            else
                sukupuoli = 2;

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
                            if(nimi.FName) {
                                foreach(var item in nimi.nimiLista) {
                                    // Katsotaan vastaako nimi valittua sukupuolta
                                    if((nimi.Gender.ToString() == "Male" && sukupuoli == 0) ||
                                        (nimi.Gender.ToString() == "Female" && sukupuoli == 1) ||
                                        (sukupuoli == 2)) {
                                        txtEnimi.Text = item.Name;
                                    } else {
                                        txtSnimi.Text = item.Name;
                                    }
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

