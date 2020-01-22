using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;

namespace Programming_Challenges {
    public partial class frnHighLow : Form {
        public frnHighLow() {
            InitializeComponent();
            lblArpa1.Text = "1.luku: " + highLow.ArvoYksi();
        }

        HighLow highLow = new HighLow();

        private void btnIsompi_Click(object sender, EventArgs e) {
            Paivitys(highLow.Veikkaus(true));
            btnIsompi.Enabled = btnPienempi.Enabled = false;
            btnSeuraavaPeli.Enabled = true;
            lblVoittoPutki.Text = $"Voittoputki: {highLow.Voittoputki}";
        }

        private void btnPienempi_Click(object sender, EventArgs e) {
            Paivitys(highLow.Veikkaus(false));
            btnIsompi.Enabled = btnPienempi.Enabled = false;
            btnSeuraavaPeli.Enabled = true;
            lblVoittoPutki.Text = $"Voittoputki: {highLow.Voittoputki}";
        }

        private void Paivitys(bool _voitto) {
            lblArpa1.Text = "1.luku: " + highLow.Arpa1.ToString();
            lblArpa2.Text = "2.luku: " + highLow.Arpa2.ToString();

            if(_voitto == true) {
                lblTulos.Text = "Tulos: VOITIT!";
            } else
                lblTulos.Text = "Tulos: hävisit...";
        }

        private void btnSeuraavaPeli_Click(object sender, EventArgs e) {
            lblArpa1.Text = "1.luku: " + highLow.ArvoYksi();
            lblArpa2.Text = "2.luku: ";
            lblTulos.Text = "Tulos: !";
            btnIsompi.Enabled = btnPienempi.Enabled = true;
            btnSeuraavaPeli.Enabled = false;
        }
    }
}
