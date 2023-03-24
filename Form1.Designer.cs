
namespace MovingLabel
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_labelaZaPomeranje = new System.Windows.Forms.Label();
            this.btn_gore = new System.Windows.Forms.Button();
            this.btn_dole = new System.Windows.Forms.Button();
            this.btn_desno = new System.Windows.Forms.Button();
            this.btn_levo = new System.Windows.Forms.Button();
            this.p_PanelDole = new System.Windows.Forms.Panel();
            this.p_PanelDesno = new System.Windows.Forms.Panel();
            this.p_PanelZaFormu = new System.Windows.Forms.Panel();
            this.lbl_TekstZaBrojPomeraja = new System.Windows.Forms.Label();
            this.lbl_BrojPomeraja = new System.Windows.Forms.Label();
            this.lbl_TrenutnaPozicijaTabeleTekst = new System.Windows.Forms.Label();
            this.lbl_TrenutnaPozicijaTabele = new System.Windows.Forms.Label();
            this.lbl_BrojPomerajaLevoTekst = new System.Windows.Forms.Label();
            this.lbl_BrojPomerajaLevo = new System.Windows.Forms.Label();
            this.lbl_BrojPomerajaDesnoTekst = new System.Windows.Forms.Label();
            this.lbl_BrojPomerajaGoreTekst = new System.Windows.Forms.Label();
            this.lbl_BrojPomerajaDoleTekst = new System.Windows.Forms.Label();
            this.lbl_BrojPomerajaDesno = new System.Windows.Forms.Label();
            this.lbl_BrojPomerajaGore = new System.Windows.Forms.Label();
            this.lbl_BrojPomerajaDole = new System.Windows.Forms.Label();
            this.lbl_BrojGresakaTekst = new System.Windows.Forms.Label();
            this.lbl_BrojGresaka = new System.Windows.Forms.Label();
            this.tb_BrojPikselaZaPomeranje = new System.Windows.Forms.TextBox();
            this.lbl_BrojPikselaZaKolikoPomeramoTekst = new System.Windows.Forms.Label();
            this.p_PanelDole.SuspendLayout();
            this.p_PanelDesno.SuspendLayout();
            this.p_PanelZaFormu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_labelaZaPomeranje
            // 
            this.lbl_labelaZaPomeranje.AutoSize = true;
            this.lbl_labelaZaPomeranje.Location = new System.Drawing.Point(388, 193);
            this.lbl_labelaZaPomeranje.Name = "lbl_labelaZaPomeranje";
            this.lbl_labelaZaPomeranje.Size = new System.Drawing.Size(10, 13);
            this.lbl_labelaZaPomeranje.TabIndex = 0;
            this.lbl_labelaZaPomeranje.Text = "";
            // 
            // btn_gore
            // 
            this.btn_gore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_gore.Location = new System.Drawing.Point(427, 3);
            this.btn_gore.Name = "btn_gore";
            this.btn_gore.Size = new System.Drawing.Size(75, 23);
            this.btn_gore.TabIndex = 1;
            this.btn_gore.Text = "Gore";
            this.btn_gore.UseVisualStyleBackColor = true;
            this.btn_gore.Click += new System.EventHandler(this.btn_gore_Click);
            // 
            // btn_dole
            // 
            this.btn_dole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_dole.Location = new System.Drawing.Point(427, 32);
            this.btn_dole.Name = "btn_dole";
            this.btn_dole.Size = new System.Drawing.Size(75, 23);
            this.btn_dole.TabIndex = 2;
            this.btn_dole.Text = "Dole";
            this.btn_dole.UseVisualStyleBackColor = true;
            this.btn_dole.Click += new System.EventHandler(this.btn_dole_Click);
            // 
            // btn_desno
            // 
            this.btn_desno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_desno.Location = new System.Drawing.Point(508, 24);
            this.btn_desno.Name = "btn_desno";
            this.btn_desno.Size = new System.Drawing.Size(75, 23);
            this.btn_desno.TabIndex = 3;
            this.btn_desno.Text = "Desno";
            this.btn_desno.UseVisualStyleBackColor = true;
            this.btn_desno.Click += new System.EventHandler(this.btn_desno_Click);
            // 
            // btn_levo
            // 
            this.btn_levo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_levo.Location = new System.Drawing.Point(346, 24);
            this.btn_levo.Name = "btn_levo";
            this.btn_levo.Size = new System.Drawing.Size(75, 23);
            this.btn_levo.TabIndex = 4;
            this.btn_levo.Text = "Levo";
            this.btn_levo.UseVisualStyleBackColor = true;
            this.btn_levo.Click += new System.EventHandler(this.btn_levo_Click);
            // 
            // p_PanelDole
            // 
            this.p_PanelDole.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.p_PanelDole.Controls.Add(this.btn_dole);
            this.p_PanelDole.Controls.Add(this.btn_gore);
            this.p_PanelDole.Controls.Add(this.btn_levo);
            this.p_PanelDole.Controls.Add(this.btn_desno);
            this.p_PanelDole.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p_PanelDole.Location = new System.Drawing.Point(0, 353);
            this.p_PanelDole.Name = "p_PanelDole";
            this.p_PanelDole.Size = new System.Drawing.Size(880, 67);
            this.p_PanelDole.TabIndex = 5;
            // 
            // p_PanelDesno
            // 
            this.p_PanelDesno.BackColor = System.Drawing.SystemColors.Highlight;
            this.p_PanelDesno.Controls.Add(this.lbl_BrojPikselaZaKolikoPomeramoTekst);
            this.p_PanelDesno.Controls.Add(this.tb_BrojPikselaZaPomeranje);
            this.p_PanelDesno.Controls.Add(this.lbl_BrojGresaka);
            this.p_PanelDesno.Controls.Add(this.lbl_BrojGresakaTekst);
            this.p_PanelDesno.Controls.Add(this.lbl_BrojPomerajaDole);
            this.p_PanelDesno.Controls.Add(this.lbl_BrojPomerajaGore);
            this.p_PanelDesno.Controls.Add(this.lbl_BrojPomerajaDesno);
            this.p_PanelDesno.Controls.Add(this.lbl_BrojPomerajaDoleTekst);
            this.p_PanelDesno.Controls.Add(this.lbl_BrojPomerajaGoreTekst);
            this.p_PanelDesno.Controls.Add(this.lbl_BrojPomerajaDesnoTekst);
            this.p_PanelDesno.Controls.Add(this.lbl_BrojPomerajaLevo);
            this.p_PanelDesno.Controls.Add(this.lbl_BrojPomerajaLevoTekst);
            this.p_PanelDesno.Controls.Add(this.lbl_TrenutnaPozicijaTabele);
            this.p_PanelDesno.Controls.Add(this.lbl_TrenutnaPozicijaTabeleTekst);
            this.p_PanelDesno.Controls.Add(this.lbl_BrojPomeraja);
            this.p_PanelDesno.Controls.Add(this.lbl_TekstZaBrojPomeraja);
            this.p_PanelDesno.Dock = System.Windows.Forms.DockStyle.Right;
            this.p_PanelDesno.Location = new System.Drawing.Point(680, 0);
            this.p_PanelDesno.Name = "p_PanelDesno";
            this.p_PanelDesno.Size = new System.Drawing.Size(200, 353);
            this.p_PanelDesno.TabIndex = 6;
            // 
            // p_PanelZaFormu
            // 
            this.p_PanelZaFormu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p_PanelZaFormu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.p_PanelZaFormu.Controls.Add(this.lbl_labelaZaPomeranje);
            this.p_PanelZaFormu.Location = new System.Drawing.Point(0, 0);
            this.p_PanelZaFormu.Name = "p_PanelZaFormu";
            this.p_PanelZaFormu.Size = new System.Drawing.Size(680, 353);
            this.p_PanelZaFormu.TabIndex = 7;
            this.p_PanelZaFormu.Resize += new System.EventHandler(this.p_PanelZaFormu_Resize);
            // 
            // lbl_TekstZaBrojPomeraja
            // 
            this.lbl_TekstZaBrojPomeraja.AutoSize = true;
            this.lbl_TekstZaBrojPomeraja.Location = new System.Drawing.Point(6, 30);
            this.lbl_TekstZaBrojPomeraja.Name = "lbl_TekstZaBrojPomeraja";
            this.lbl_TekstZaBrojPomeraja.Size = new System.Drawing.Size(68, 13);
            this.lbl_TekstZaBrojPomeraja.TabIndex = 0;
            this.lbl_TekstZaBrojPomeraja.Text = "Broj pemraja:";
            this.lbl_TekstZaBrojPomeraja.Click += new System.EventHandler(this.lbl_TekstZaBrojPomeraja_Click);
            // 
            // lbl_BrojPomeraja
            // 
            this.lbl_BrojPomeraja.AutoSize = true;
            this.lbl_BrojPomeraja.Location = new System.Drawing.Point(71, 30);
            this.lbl_BrojPomeraja.Name = "lbl_BrojPomeraja";
            this.lbl_BrojPomeraja.Size = new System.Drawing.Size(35, 13);
            this.lbl_BrojPomeraja.TabIndex = 1;
            this.lbl_BrojPomeraja.Text = "label1";
            // 
            // lbl_TrenutnaPozicijaTabeleTekst
            // 
            this.lbl_TrenutnaPozicijaTabeleTekst.AutoSize = true;
            this.lbl_TrenutnaPozicijaTabeleTekst.Location = new System.Drawing.Point(3, 56);
            this.lbl_TrenutnaPozicijaTabeleTekst.Name = "lbl_TrenutnaPozicijaTabeleTekst";
            this.lbl_TrenutnaPozicijaTabeleTekst.Size = new System.Drawing.Size(123, 13);
            this.lbl_TrenutnaPozicijaTabeleTekst.TabIndex = 2;
            this.lbl_TrenutnaPozicijaTabeleTekst.Text = "Trenutna pozicija tabele:";
            this.lbl_TrenutnaPozicijaTabeleTekst.Click += new System.EventHandler(this.lbl_TrenutnaPozicijaTabeleTekst_Click);
            // 
            // lbl_TrenutnaPozicijaTabele
            // 
            this.lbl_TrenutnaPozicijaTabele.AutoSize = true;
            this.lbl_TrenutnaPozicijaTabele.Location = new System.Drawing.Point(128, 56);
            this.lbl_TrenutnaPozicijaTabele.Name = "lbl_TrenutnaPozicijaTabele";
            this.lbl_TrenutnaPozicijaTabele.Size = new System.Drawing.Size(35, 13);
            this.lbl_TrenutnaPozicijaTabele.TabIndex = 3;
            this.lbl_TrenutnaPozicijaTabele.Text = "label1";
            this.lbl_TrenutnaPozicijaTabele.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_BrojPomerajaLevoTekst
            // 
            this.lbl_BrojPomerajaLevoTekst.AutoSize = true;
            this.lbl_BrojPomerajaLevoTekst.Location = new System.Drawing.Point(3, 83);
            this.lbl_BrojPomerajaLevoTekst.Name = "lbl_BrojPomerajaLevoTekst";
            this.lbl_BrojPomerajaLevoTekst.Size = new System.Drawing.Size(97, 13);
            this.lbl_BrojPomerajaLevoTekst.TabIndex = 4;
            this.lbl_BrojPomerajaLevoTekst.Text = "Broj pomeraja levo:";
            // 
            // lbl_BrojPomerajaLevo
            // 
            this.lbl_BrojPomerajaLevo.AutoSize = true;
            this.lbl_BrojPomerajaLevo.Location = new System.Drawing.Point(106, 83);
            this.lbl_BrojPomerajaLevo.Name = "lbl_BrojPomerajaLevo";
            this.lbl_BrojPomerajaLevo.Size = new System.Drawing.Size(35, 13);
            this.lbl_BrojPomerajaLevo.TabIndex = 5;
            this.lbl_BrojPomerajaLevo.Text = "label1";
            // 
            // lbl_BrojPomerajaDesnoTekst
            // 
            this.lbl_BrojPomerajaDesnoTekst.AutoSize = true;
            this.lbl_BrojPomerajaDesnoTekst.Location = new System.Drawing.Point(3, 107);
            this.lbl_BrojPomerajaDesnoTekst.Name = "lbl_BrojPomerajaDesnoTekst";
            this.lbl_BrojPomerajaDesnoTekst.Size = new System.Drawing.Size(106, 13);
            this.lbl_BrojPomerajaDesnoTekst.TabIndex = 6;
            this.lbl_BrojPomerajaDesnoTekst.Text = "Broj pomeraja desno:";
            // 
            // lbl_BrojPomerajaGoreTekst
            // 
            this.lbl_BrojPomerajaGoreTekst.AutoSize = true;
            this.lbl_BrojPomerajaGoreTekst.Location = new System.Drawing.Point(2, 129);
            this.lbl_BrojPomerajaGoreTekst.Name = "lbl_BrojPomerajaGoreTekst";
            this.lbl_BrojPomerajaGoreTekst.Size = new System.Drawing.Size(98, 13);
            this.lbl_BrojPomerajaGoreTekst.TabIndex = 7;
            this.lbl_BrojPomerajaGoreTekst.Text = "Broj pomeraja gore:";
            // 
            // lbl_BrojPomerajaDoleTekst
            // 
            this.lbl_BrojPomerajaDoleTekst.AutoSize = true;
            this.lbl_BrojPomerajaDoleTekst.Location = new System.Drawing.Point(3, 151);
            this.lbl_BrojPomerajaDoleTekst.Name = "lbl_BrojPomerajaDoleTekst";
            this.lbl_BrojPomerajaDoleTekst.Size = new System.Drawing.Size(98, 13);
            this.lbl_BrojPomerajaDoleTekst.TabIndex = 8;
            this.lbl_BrojPomerajaDoleTekst.Text = "Broj pomeraja gore:";
            // 
            // lbl_BrojPomerajaDesno
            // 
            this.lbl_BrojPomerajaDesno.AutoSize = true;
            this.lbl_BrojPomerajaDesno.Location = new System.Drawing.Point(115, 107);
            this.lbl_BrojPomerajaDesno.Name = "lbl_BrojPomerajaDesno";
            this.lbl_BrojPomerajaDesno.Size = new System.Drawing.Size(35, 13);
            this.lbl_BrojPomerajaDesno.TabIndex = 9;
            this.lbl_BrojPomerajaDesno.Text = "label1";
            // 
            // lbl_BrojPomerajaGore
            // 
            this.lbl_BrojPomerajaGore.AutoSize = true;
            this.lbl_BrojPomerajaGore.Location = new System.Drawing.Point(106, 129);
            this.lbl_BrojPomerajaGore.Name = "lbl_BrojPomerajaGore";
            this.lbl_BrojPomerajaGore.Size = new System.Drawing.Size(35, 13);
            this.lbl_BrojPomerajaGore.TabIndex = 10;
            this.lbl_BrojPomerajaGore.Text = "label1";
            // 
            // lbl_BrojPomerajaDole
            // 
            this.lbl_BrojPomerajaDole.AutoSize = true;
            this.lbl_BrojPomerajaDole.Location = new System.Drawing.Point(108, 151);
            this.lbl_BrojPomerajaDole.Name = "lbl_BrojPomerajaDole";
            this.lbl_BrojPomerajaDole.Size = new System.Drawing.Size(35, 13);
            this.lbl_BrojPomerajaDole.TabIndex = 11;
            this.lbl_BrojPomerajaDole.Text = "label1";
            // 
            // lbl_BrojGresakaTekst
            // 
            this.lbl_BrojGresakaTekst.AutoSize = true;
            this.lbl_BrojGresakaTekst.Location = new System.Drawing.Point(2, 168);
            this.lbl_BrojGresakaTekst.Name = "lbl_BrojGresakaTekst";
            this.lbl_BrojGresakaTekst.Size = new System.Drawing.Size(68, 13);
            this.lbl_BrojGresakaTekst.TabIndex = 12;
            this.lbl_BrojGresakaTekst.Text = "BrojGresaka:";
            // 
            // lbl_BrojGresaka
            // 
            this.lbl_BrojGresaka.AutoSize = true;
            this.lbl_BrojGresaka.Location = new System.Drawing.Point(81, 168);
            this.lbl_BrojGresaka.Name = "lbl_BrojGresaka";
            this.lbl_BrojGresaka.Size = new System.Drawing.Size(35, 13);
            this.lbl_BrojGresaka.TabIndex = 13;
            this.lbl_BrojGresaka.Text = "label1";
            // 
            // tb_BrojPikselaZaPomeranje
            // 
            this.tb_BrojPikselaZaPomeranje.Location = new System.Drawing.Point(5, 205);
            this.tb_BrojPikselaZaPomeranje.Name = "tb_BrojPikselaZaPomeranje";
            this.tb_BrojPikselaZaPomeranje.Size = new System.Drawing.Size(166, 20);
            this.tb_BrojPikselaZaPomeranje.TabIndex = 14;
            // 
            // lbl_BrojPikselaZaKolikoPomeramoTekst
            // 
            this.lbl_BrojPikselaZaKolikoPomeramoTekst.AutoSize = true;
            this.lbl_BrojPikselaZaKolikoPomeramoTekst.Location = new System.Drawing.Point(3, 189);
            this.lbl_BrojPikselaZaKolikoPomeramoTekst.Name = "lbl_BrojPikselaZaKolikoPomeramoTekst";
            this.lbl_BrojPikselaZaKolikoPomeramoTekst.Size = new System.Drawing.Size(146, 13);
            this.lbl_BrojPikselaZaKolikoPomeramoTekst.TabIndex = 15;
            this.lbl_BrojPikselaZaKolikoPomeramoTekst.Text = "Za koliko zelite da pomerate?";
            this.lbl_BrojPikselaZaKolikoPomeramoTekst.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 420);
            this.Controls.Add(this.p_PanelZaFormu);
            this.Controls.Add(this.p_PanelDesno);
            this.Controls.Add(this.p_PanelDole);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.p_PanelDole.ResumeLayout(false);
            this.p_PanelDesno.ResumeLayout(false);
            this.p_PanelDesno.PerformLayout();
            this.p_PanelZaFormu.ResumeLayout(false);
            this.p_PanelZaFormu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_labelaZaPomeranje;
        private System.Windows.Forms.Button btn_gore;
        private System.Windows.Forms.Button btn_dole;
        private System.Windows.Forms.Button btn_desno;
        private System.Windows.Forms.Button btn_levo;
        private System.Windows.Forms.Panel p_PanelDole;
        private System.Windows.Forms.Panel p_PanelDesno;
        private System.Windows.Forms.Panel p_PanelZaFormu;
        private System.Windows.Forms.Label lbl_TekstZaBrojPomeraja;
        private System.Windows.Forms.Label lbl_BrojPomeraja;
        private System.Windows.Forms.Label lbl_TrenutnaPozicijaTabeleTekst;
        private System.Windows.Forms.Label lbl_TrenutnaPozicijaTabele;
        private System.Windows.Forms.Label lbl_BrojPomerajaDole;
        private System.Windows.Forms.Label lbl_BrojPomerajaGore;
        private System.Windows.Forms.Label lbl_BrojPomerajaDesno;
        private System.Windows.Forms.Label lbl_BrojPomerajaDoleTekst;
        private System.Windows.Forms.Label lbl_BrojPomerajaGoreTekst;
        private System.Windows.Forms.Label lbl_BrojPomerajaDesnoTekst;
        private System.Windows.Forms.Label lbl_BrojPomerajaLevo;
        private System.Windows.Forms.Label lbl_BrojPomerajaLevoTekst;
        private System.Windows.Forms.Label lbl_BrojGresaka;
        private System.Windows.Forms.Label lbl_BrojGresakaTekst;
        private System.Windows.Forms.TextBox tb_BrojPikselaZaPomeranje;
        private System.Windows.Forms.Label lbl_BrojPikselaZaKolikoPomeramoTekst;
    }
}

