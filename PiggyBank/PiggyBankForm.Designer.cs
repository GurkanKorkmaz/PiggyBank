namespace PiggyBank
{
    partial class PiggyBankForm
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
            this.cmbBozukPara = new System.Windows.Forms.ComboBox();
            this.cmbKagitPara = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnParaAt = new System.Windows.Forms.Button();
            this.btnParaKatla = new System.Windows.Forms.Button();
            this.btnSalla = new System.Windows.Forms.Button();
            this.btnKumbarayiKir = new System.Windows.Forms.Button();
            this.lbKumbara = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblToplamHacim = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFazlaHacim = new System.Windows.Forms.Label();
            this.lblBirikenParaMiktari = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbBozukPara
            // 
            this.cmbBozukPara.FormattingEnabled = true;
            this.cmbBozukPara.Location = new System.Drawing.Point(148, 61);
            this.cmbBozukPara.Name = "cmbBozukPara";
            this.cmbBozukPara.Size = new System.Drawing.Size(204, 28);
            this.cmbBozukPara.TabIndex = 0;
            this.cmbBozukPara.SelectedIndexChanged += new System.EventHandler(this.cmbBozukPara_SelectedIndexChanged);
            // 
            // cmbKagitPara
            // 
            this.cmbKagitPara.FormattingEnabled = true;
            this.cmbKagitPara.Location = new System.Drawing.Point(148, 110);
            this.cmbKagitPara.Name = "cmbKagitPara";
            this.cmbKagitPara.Size = new System.Drawing.Size(204, 28);
            this.cmbKagitPara.TabIndex = 1;
            this.cmbKagitPara.SelectedIndexChanged += new System.EventHandler(this.cmbKagitPara_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bozuk Para: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kağıt Para: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(21, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(441, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "KUMBARAYA ATMAK İSTEDİĞİNİZ PARAYI SEÇİNİZ";
            // 
            // btnParaAt
            // 
            this.btnParaAt.Location = new System.Drawing.Point(25, 149);
            this.btnParaAt.Name = "btnParaAt";
            this.btnParaAt.Size = new System.Drawing.Size(218, 50);
            this.btnParaAt.TabIndex = 5;
            this.btnParaAt.Text = "Para At";
            this.btnParaAt.UseVisualStyleBackColor = true;
            this.btnParaAt.Click += new System.EventHandler(this.btnParaAt_Click);
            // 
            // btnParaKatla
            // 
            this.btnParaKatla.Location = new System.Drawing.Point(259, 149);
            this.btnParaKatla.Name = "btnParaKatla";
            this.btnParaKatla.Size = new System.Drawing.Size(208, 50);
            this.btnParaKatla.TabIndex = 6;
            this.btnParaKatla.Text = "Para Katla";
            this.btnParaKatla.UseVisualStyleBackColor = true;
            this.btnParaKatla.Click += new System.EventHandler(this.btnParaKatla_Click);
            // 
            // btnSalla
            // 
            this.btnSalla.Location = new System.Drawing.Point(25, 205);
            this.btnSalla.Name = "btnSalla";
            this.btnSalla.Size = new System.Drawing.Size(442, 57);
            this.btnSalla.TabIndex = 7;
            this.btnSalla.Text = "SALLA";
            this.btnSalla.UseVisualStyleBackColor = true;
            this.btnSalla.Click += new System.EventHandler(this.btnSalla_Click);
            // 
            // btnKumbarayiKir
            // 
            this.btnKumbarayiKir.Location = new System.Drawing.Point(25, 268);
            this.btnKumbarayiKir.Name = "btnKumbarayiKir";
            this.btnKumbarayiKir.Size = new System.Drawing.Size(442, 55);
            this.btnKumbarayiKir.TabIndex = 8;
            this.btnKumbarayiKir.Text = "KUMBARAYI KIR!!!";
            this.btnKumbarayiKir.UseVisualStyleBackColor = true;
            this.btnKumbarayiKir.Click += new System.EventHandler(this.btnKumbarayiKir_Click);
            // 
            // lbKumbara
            // 
            this.lbKumbara.FormattingEnabled = true;
            this.lbKumbara.ItemHeight = 20;
            this.lbKumbara.Location = new System.Drawing.Point(546, 61);
            this.lbKumbara.Name = "lbKumbara";
            this.lbKumbara.Size = new System.Drawing.Size(223, 324);
            this.lbKumbara.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(542, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "KUMBARA: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(418, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "KUMBARANIN İÇİNDEKİ PARALARIN TOPLAM HACMİ: ";
            // 
            // lblToplamHacim
            // 
            this.lblToplamHacim.AutoSize = true;
            this.lblToplamHacim.Location = new System.Drawing.Point(445, 345);
            this.lblToplamHacim.Name = "lblToplamHacim";
            this.lblToplamHacim.Size = new System.Drawing.Size(18, 20);
            this.lblToplamHacim.TabIndex = 12;
            this.lblToplamHacim.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(405, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "KUMBARANIN İÇİNDEKİ PARALARIN FAZLA HACMİ: ";
            // 
            // lblFazlaHacim
            // 
            this.lblFazlaHacim.AutoSize = true;
            this.lblFazlaHacim.Location = new System.Drawing.Point(445, 375);
            this.lblFazlaHacim.Name = "lblFazlaHacim";
            this.lblFazlaHacim.Size = new System.Drawing.Size(18, 20);
            this.lblFazlaHacim.TabIndex = 14;
            this.lblFazlaHacim.Text = "0";
            // 
            // lblBirikenParaMiktari
            // 
            this.lblBirikenParaMiktari.AutoSize = true;
            this.lblBirikenParaMiktari.Location = new System.Drawing.Point(635, 26);
            this.lblBirikenParaMiktari.Name = "lblBirikenParaMiktari";
            this.lblBirikenParaMiktari.Size = new System.Drawing.Size(40, 20);
            this.lblBirikenParaMiktari.TabIndex = 15;
            this.lblBirikenParaMiktari.Text = "0 TL";
            // 
            // PiggyBankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 413);
            this.Controls.Add(this.lblBirikenParaMiktari);
            this.Controls.Add(this.lblFazlaHacim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblToplamHacim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbKumbara);
            this.Controls.Add(this.btnKumbarayiKir);
            this.Controls.Add(this.btnSalla);
            this.Controls.Add(this.btnParaKatla);
            this.Controls.Add(this.btnParaAt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKagitPara);
            this.Controls.Add(this.cmbBozukPara);
            this.Name = "PiggyBankForm";
            this.Text = "Piggy Bank";
            this.Load += new System.EventHandler(this.PiggyBankForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBozukPara;
        private System.Windows.Forms.ComboBox cmbKagitPara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnParaAt;
        private System.Windows.Forms.Button btnParaKatla;
        private System.Windows.Forms.Button btnSalla;
        private System.Windows.Forms.Button btnKumbarayiKir;
        private System.Windows.Forms.ListBox lbKumbara;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblToplamHacim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFazlaHacim;
        private System.Windows.Forms.Label lblBirikenParaMiktari;
    }
}

