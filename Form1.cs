using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbl_BrojPomeraja.Text = "0";

            lbl_BrojPomerajaDesno.Text = "0";
            lbl_BrojPomerajaLevo.Text = "0";
            lbl_BrojPomerajaGore.Text = "0";
            lbl_BrojPomerajaDole.Text = "0";

            lbl_BrojGresaka.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int formY = p_PanelZaFormu.Height;
            int formX = p_PanelZaFormu.Width;
            lbl_labelaZaPomeranje.Location = new Point(formX/2, formY/2);
            lbl_TrenutnaPozicijaTabele.Text = "({"+ lbl_labelaZaPomeranje.Location.X + "}, {"+ lbl_labelaZaPomeranje.Location.Y + "}";
        }

        private void btn_levo_Click(object sender, EventArgs e)
        {
            if(lbl_labelaZaPomeranje.Location.X - Convert.ToInt32(tb_BrojPikselaZaPomeranje.Text) > p_PanelZaFormu.Location.X)
            {
                lbl_labelaZaPomeranje.Location = new Point(lbl_labelaZaPomeranje.Location.X - Convert.ToInt32(tb_BrojPikselaZaPomeranje.Text), lbl_labelaZaPomeranje.Location.Y);
               
                int privremeni = Convert.ToInt32(lbl_BrojPomeraja.Text);
                privremeni++;
                lbl_BrojPomeraja.Text = Convert.ToString(privremeni);

                privremeni = Convert.ToInt32(lbl_BrojPomerajaLevo.Text);
                privremeni++;
                lbl_BrojPomerajaLevo.Text = Convert.ToString(privremeni);

                lbl_TrenutnaPozicijaTabele.Text = "({" + lbl_labelaZaPomeranje.Location.X + "}, {" + lbl_labelaZaPomeranje.Location.Y + "}";
            }
            else
            {
                int privremeni = Convert.ToInt32(lbl_BrojGresaka.Text);
                privremeni++;
                lbl_BrojGresaka.Text = Convert.ToString(privremeni);
                MessageBox.Show("Ne moze dalje");
            }
        }

        private void btn_desno_Click(object sender, EventArgs e)
        {
            if (lbl_labelaZaPomeranje.Location.X + Convert.ToInt32(tb_BrojPikselaZaPomeranje.Text) < p_PanelDesno.Location.X)
            {
                lbl_labelaZaPomeranje.Location = new Point(lbl_labelaZaPomeranje.Location.X + Convert.ToInt32(tb_BrojPikselaZaPomeranje.Text), lbl_labelaZaPomeranje.Location.Y);
                
                int privremeni = Convert.ToInt32(lbl_BrojPomeraja.Text);
                privremeni++;
                lbl_BrojPomeraja.Text = Convert.ToString(privremeni);

                privremeni = Convert.ToInt32(lbl_BrojPomerajaDesno.Text);
                privremeni++;
                lbl_BrojPomerajaDesno.Text = Convert.ToString(privremeni);

                lbl_TrenutnaPozicijaTabele.Text = "({" + lbl_labelaZaPomeranje.Location.X + "}, {" + lbl_labelaZaPomeranje.Location.Y + "}";
            }
            else
            {
                int privremeni = Convert.ToInt32(lbl_BrojGresaka.Text);
                privremeni++;
                lbl_BrojGresaka.Text = Convert.ToString(privremeni);
                MessageBox.Show("Ne moze dalje");
            }
        }

        private void btn_gore_Click(object sender, EventArgs e)
        {
            if (lbl_labelaZaPomeranje.Location.Y - Convert.ToInt32(tb_BrojPikselaZaPomeranje.Text) > p_PanelZaFormu.Location.Y)
            {
                lbl_labelaZaPomeranje.Location = new Point(lbl_labelaZaPomeranje.Location.X, lbl_labelaZaPomeranje.Location.Y - Convert.ToInt32(tb_BrojPikselaZaPomeranje.Text));
               
                int privremeni = Convert.ToInt32(lbl_BrojPomeraja.Text);
                privremeni++;
                lbl_BrojPomeraja.Text = Convert.ToString(privremeni);

                privremeni = Convert.ToInt32(lbl_BrojPomerajaGore.Text);
                privremeni++;
                lbl_BrojPomerajaGore.Text = Convert.ToString(privremeni);

                lbl_TrenutnaPozicijaTabele.Text = "({" + lbl_labelaZaPomeranje.Location.X + "}, {" + lbl_labelaZaPomeranje.Location.Y + "}";
            }
            else
            {
                int privremeni = Convert.ToInt32(lbl_BrojGresaka.Text);
                privremeni++;
                lbl_BrojGresaka.Text = Convert.ToString(privremeni);
                MessageBox.Show("Ne moze dalje");
            }
        }

        private void btn_dole_Click(object sender, EventArgs e)
        {
            if (lbl_labelaZaPomeranje.Location.Y + Convert.ToInt32(tb_BrojPikselaZaPomeranje.Text) < p_PanelDole.Location.Y)
            {
                lbl_labelaZaPomeranje.Location = new Point(lbl_labelaZaPomeranje.Location.X, lbl_labelaZaPomeranje.Location.Y + Convert.ToInt32(tb_BrojPikselaZaPomeranje.Text));
                
                int privremeni = Convert.ToInt32(lbl_BrojPomeraja.Text);
                privremeni++;
                lbl_BrojPomeraja.Text = Convert.ToString(privremeni);

                privremeni = Convert.ToInt32(lbl_BrojPomerajaDole.Text);
                privremeni++;
                lbl_BrojPomerajaDole.Text = Convert.ToString(privremeni);

                lbl_TrenutnaPozicijaTabele.Text = "({" + lbl_labelaZaPomeranje.Location.X + "}, {" + lbl_labelaZaPomeranje.Location.Y + "}";
            }
            else
            {
                int privremeni = Convert.ToInt32(lbl_BrojGresaka.Text);
                privremeni++;
                lbl_BrojGresaka.Text = Convert.ToString(privremeni);
                MessageBox.Show("Ne moze dalje");
            }
        }

        private void lbl_TekstZaBrojPomeraja_Click(object sender, EventArgs e)
        {

        }

        private void lbl_TrenutnaPozicijaTabeleTekst_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void p_PanelZaFormu_Resize(object sender, EventArgs e)
        {
            int formY = p_PanelZaFormu.Height;
            int formX = p_PanelZaFormu.Width;
            lbl_labelaZaPomeranje.Location = new Point(formX / 2, formY / 2);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
