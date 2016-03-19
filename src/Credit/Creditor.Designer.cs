using System.CodeDom;
using System.Collections;
using  System.Resources;
namespace Credit
{
    partial class Creditor
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.kurs_aktualny_ = new System.Windows.Forms.TextBox();
      this.kurs_aktualny_all = new System.Windows.Forms.TextBox();
      this.mc_aktualny = new System.Windows.Forms.ComboBox();
      this.rok_aktualny = new System.Windows.Forms.ComboBox();
      this.rok_uruchomienia = new System.Windows.Forms.ComboBox();
      this.mc_uruchomienia = new System.Windows.Forms.ComboBox();
      this.Find = new System.Windows.Forms.Button();
      this.kalkulator_ = new System.Windows.Forms.TextBox();
      this.kurs_otwarcia_ = new System.Windows.Forms.TextBox();
      this.kalkulator_all = new System.Windows.Forms.TextBox();
      this.kurs_otwarcia_all = new System.Windows.Forms.TextBox();
      this.saldo_kapitalu_chf_aktualny = new System.Windows.Forms.TextBox();
      this.kurs_chf_aktualny = new System.Windows.Forms.TextBox();
      this.saldo_kap_pln = new System.Windows.Forms.TextBox();
      this.kwota_kredytu_chf = new System.Windows.Forms.TextBox();
      this.kurs_chf = new System.Windows.Forms.TextBox();
      this.okres_kredytowania = new System.Windows.Forms.TextBox();
      this.kwota_kredytu_pln = new System.Windows.Forms.TextBox();
      this.label19 = new System.Windows.Forms.Label();
      this.label18 = new System.Windows.Forms.Label();
      this.label17 = new System.Windows.Forms.Label();
      this.label16 = new System.Windows.Forms.Label();
      this.label15 = new System.Windows.Forms.Label();
      this.label14 = new System.Windows.Forms.Label();
      this.label13 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.BackColor = System.Drawing.SystemColors.HighlightText;
      this.groupBox1.Controls.Add(this.kurs_aktualny_);
      this.groupBox1.Controls.Add(this.kurs_aktualny_all);
      this.groupBox1.Controls.Add(this.mc_aktualny);
      this.groupBox1.Controls.Add(this.rok_aktualny);
      this.groupBox1.Controls.Add(this.rok_uruchomienia);
      this.groupBox1.Controls.Add(this.mc_uruchomienia);
      this.groupBox1.Controls.Add(this.Find);
      this.groupBox1.Controls.Add(this.kalkulator_);
      this.groupBox1.Controls.Add(this.kurs_otwarcia_);
      this.groupBox1.Controls.Add(this.kalkulator_all);
      this.groupBox1.Controls.Add(this.kurs_otwarcia_all);
      this.groupBox1.Controls.Add(this.saldo_kapitalu_chf_aktualny);
      this.groupBox1.Controls.Add(this.kurs_chf_aktualny);
      this.groupBox1.Controls.Add(this.saldo_kap_pln);
      this.groupBox1.Controls.Add(this.kwota_kredytu_chf);
      this.groupBox1.Controls.Add(this.kurs_chf);
      this.groupBox1.Controls.Add(this.okres_kredytowania);
      this.groupBox1.Controls.Add(this.kwota_kredytu_pln);
      this.groupBox1.Controls.Add(this.label19);
      this.groupBox1.Controls.Add(this.label18);
      this.groupBox1.Controls.Add(this.label17);
      this.groupBox1.Controls.Add(this.label16);
      this.groupBox1.Controls.Add(this.label15);
      this.groupBox1.Controls.Add(this.label14);
      this.groupBox1.Controls.Add(this.label13);
      this.groupBox1.Controls.Add(this.label11);
      this.groupBox1.Controls.Add(this.label9);
      this.groupBox1.Controls.Add(this.label10);
      this.groupBox1.Controls.Add(this.label8);
      this.groupBox1.Controls.Add(this.label7);
      this.groupBox1.Controls.Add(this.label6);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Location = new System.Drawing.Point(205, 14);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(883, 238);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      // 
      // kurs_aktualny_
      // 
      this.kurs_aktualny_.Location = new System.Drawing.Point(792, 165);
      this.kurs_aktualny_.Name = "kurs_aktualny_";
      this.kurs_aktualny_.Size = new System.Drawing.Size(85, 20);
      this.kurs_aktualny_.TabIndex = 42;
      // 
      // kurs_aktualny_all
      // 
      this.kurs_aktualny_all.Location = new System.Drawing.Point(674, 165);
      this.kurs_aktualny_all.Name = "kurs_aktualny_all";
      this.kurs_aktualny_all.Size = new System.Drawing.Size(100, 20);
      this.kurs_aktualny_all.TabIndex = 41;
      // 
      // mc_aktualny
      // 
      this.mc_aktualny.FormattingEnabled = true;
      this.mc_aktualny.Location = new System.Drawing.Point(501, 74);
      this.mc_aktualny.Name = "mc_aktualny";
      this.mc_aktualny.Size = new System.Drawing.Size(100, 21);
      this.mc_aktualny.TabIndex = 40;
      this.mc_aktualny.Text = "styczeń";
      // 
      // rok_aktualny
      // 
      this.rok_aktualny.FormattingEnabled = true;
      this.rok_aktualny.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
      this.rok_aktualny.Location = new System.Drawing.Point(501, 43);
      this.rok_aktualny.Name = "rok_aktualny";
      this.rok_aktualny.Size = new System.Drawing.Size(100, 21);
      this.rok_aktualny.TabIndex = 39;
      this.rok_aktualny.Text = "2016";
      // 
      // rok_uruchomienia
      // 
      this.rok_uruchomienia.FormattingEnabled = true;
      this.rok_uruchomienia.Items.AddRange(new object[] {
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011"});
      this.rok_uruchomienia.Location = new System.Drawing.Point(189, 100);
      this.rok_uruchomienia.Name = "rok_uruchomienia";
      this.rok_uruchomienia.Size = new System.Drawing.Size(100, 21);
      this.rok_uruchomienia.TabIndex = 38;
      this.rok_uruchomienia.Text = "2007";
      // 
      // mc_uruchomienia
      // 
      this.mc_uruchomienia.FormattingEnabled = true;
      this.mc_uruchomienia.Location = new System.Drawing.Point(189, 126);
      this.mc_uruchomienia.Name = "mc_uruchomienia";
      this.mc_uruchomienia.Size = new System.Drawing.Size(100, 21);
      this.mc_uruchomienia.TabIndex = 37;
      this.mc_uruchomienia.Text = "grudzień";
      // 
      // Find
      // 
      this.Find.Location = new System.Drawing.Point(722, 201);
      this.Find.Name = "Find";
      this.Find.Size = new System.Drawing.Size(75, 23);
      this.Find.TabIndex = 36;
      this.Find.Text = "Szukaj";
      this.Find.UseVisualStyleBackColor = true;
      this.Find.Click += new System.EventHandler(this.Find_Click);
      // 
      // kalkulator_
      // 
      this.kalkulator_.Location = new System.Drawing.Point(792, 126);
      this.kalkulator_.Name = "kalkulator_";
      this.kalkulator_.Size = new System.Drawing.Size(85, 20);
      this.kalkulator_.TabIndex = 35;
      // 
      // kurs_otwarcia_
      // 
      this.kurs_otwarcia_.Location = new System.Drawing.Point(792, 78);
      this.kurs_otwarcia_.Name = "kurs_otwarcia_";
      this.kurs_otwarcia_.Size = new System.Drawing.Size(85, 20);
      this.kurs_otwarcia_.TabIndex = 34;
      // 
      // kalkulator_all
      // 
      this.kalkulator_all.Location = new System.Drawing.Point(674, 126);
      this.kalkulator_all.Name = "kalkulator_all";
      this.kalkulator_all.Size = new System.Drawing.Size(100, 20);
      this.kalkulator_all.TabIndex = 33;
      // 
      // kurs_otwarcia_all
      // 
      this.kurs_otwarcia_all.Location = new System.Drawing.Point(674, 77);
      this.kurs_otwarcia_all.Name = "kurs_otwarcia_all";
      this.kurs_otwarcia_all.Size = new System.Drawing.Size(100, 20);
      this.kurs_otwarcia_all.TabIndex = 32;
      // 
      // saldo_kapitalu_chf_aktualny
      // 
      this.saldo_kapitalu_chf_aktualny.Location = new System.Drawing.Point(501, 206);
      this.saldo_kapitalu_chf_aktualny.Name = "saldo_kapitalu_chf_aktualny";
      this.saldo_kapitalu_chf_aktualny.Size = new System.Drawing.Size(100, 20);
      this.saldo_kapitalu_chf_aktualny.TabIndex = 31;
      // 
      // kurs_chf_aktualny
      // 
      this.kurs_chf_aktualny.Location = new System.Drawing.Point(501, 180);
      this.kurs_chf_aktualny.Name = "kurs_chf_aktualny";
      this.kurs_chf_aktualny.Size = new System.Drawing.Size(100, 20);
      this.kurs_chf_aktualny.TabIndex = 30;
      // 
      // saldo_kap_pln
      // 
      this.saldo_kap_pln.Location = new System.Drawing.Point(501, 154);
      this.saldo_kap_pln.Name = "saldo_kap_pln";
      this.saldo_kap_pln.Size = new System.Drawing.Size(100, 20);
      this.saldo_kap_pln.TabIndex = 29;
      // 
      // kwota_kredytu_chf
      // 
      this.kwota_kredytu_chf.Location = new System.Drawing.Point(189, 186);
      this.kwota_kredytu_chf.Name = "kwota_kredytu_chf";
      this.kwota_kredytu_chf.Size = new System.Drawing.Size(100, 20);
      this.kwota_kredytu_chf.TabIndex = 26;
      // 
      // kurs_chf
      // 
      this.kurs_chf.Location = new System.Drawing.Point(189, 159);
      this.kurs_chf.Name = "kurs_chf";
      this.kurs_chf.Size = new System.Drawing.Size(100, 20);
      this.kurs_chf.TabIndex = 25;
      // 
      // okres_kredytowania
      // 
      this.okres_kredytowania.Location = new System.Drawing.Point(189, 74);
      this.okres_kredytowania.Name = "okres_kredytowania";
      this.okres_kredytowania.Size = new System.Drawing.Size(100, 20);
      this.okres_kredytowania.TabIndex = 21;
      this.okres_kredytowania.Text = "360";
      // 
      // kwota_kredytu_pln
      // 
      this.kwota_kredytu_pln.Location = new System.Drawing.Point(189, 48);
      this.kwota_kredytu_pln.Name = "kwota_kredytu_pln";
      this.kwota_kredytu_pln.Size = new System.Drawing.Size(100, 20);
      this.kwota_kredytu_pln.TabIndex = 20;
      this.kwota_kredytu_pln.Text = "300000";
      // 
      // label19
      // 
      this.label19.AutoSize = true;
      this.label19.Location = new System.Drawing.Point(703, 149);
      this.label19.Name = "label19";
      this.label19.Size = new System.Drawing.Size(71, 13);
      this.label19.TabIndex = 19;
      this.label19.Text = "Kurs aktualny";
      // 
      // label18
      // 
      this.label18.AutoSize = true;
      this.label18.Location = new System.Drawing.Point(703, 104);
      this.label18.Name = "label18";
      this.label18.Size = new System.Drawing.Size(54, 13);
      this.label18.TabIndex = 18;
      this.label18.Text = "Kalkulator";
      // 
      // label17
      // 
      this.label17.AutoSize = true;
      this.label17.Location = new System.Drawing.Point(703, 51);
      this.label17.Name = "label17";
      this.label17.Size = new System.Drawing.Size(71, 13);
      this.label17.TabIndex = 17;
      this.label17.Text = "Kurs otwarcia";
      // 
      // label16
      // 
      this.label16.AutoSize = true;
      this.label16.Location = new System.Drawing.Point(703, 16);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(111, 13);
      this.label16.TabIndex = 16;
      this.label16.Text = "Saldo kapitału w PLN";
      // 
      // label15
      // 
      this.label15.AutoSize = true;
      this.label15.Location = new System.Drawing.Point(498, 16);
      this.label15.Name = "label15";
      this.label15.Size = new System.Drawing.Size(72, 13);
      this.label15.TabIndex = 15;
      this.label15.Text = "Stan aktualny";
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Location = new System.Drawing.Point(386, 210);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(100, 13);
      this.label14.TabIndex = 14;
      this.label14.Text = "Saldo kapitału CHF";
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(386, 159);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(100, 13);
      this.label13.TabIndex = 13;
      this.label13.Text = "Saldo kapitału PLN";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(386, 183);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(52, 13);
      this.label11.TabIndex = 11;
      this.label11.Text = "Kurs CHF";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.ForeColor = System.Drawing.Color.Red;
      this.label9.Location = new System.Drawing.Point(386, 77);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(43, 13);
      this.label9.TabIndex = 10;
      this.label9.Text = "Miesiąc";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.ForeColor = System.Drawing.Color.Red;
      this.label10.Location = new System.Drawing.Point(386, 51);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(27, 13);
      this.label10.TabIndex = 9;
      this.label10.Text = "Rok";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(186, 16);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(110, 13);
      this.label8.TabIndex = 8;
      this.label8.Text = "Uruchomienie kredytu";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(18, 189);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(99, 13);
      this.label7.TabIndex = 7;
      this.label7.Text = "Kwota kredytu CHF";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(18, 163);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(52, 13);
      this.label6.TabIndex = 6;
      this.label6.Text = "Kurs CHF";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.ForeColor = System.Drawing.Color.Red;
      this.label4.Location = new System.Drawing.Point(18, 135);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(43, 13);
      this.label4.TabIndex = 4;
      this.label4.Text = "Miesiąc";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.ForeColor = System.Drawing.Color.Red;
      this.label3.Location = new System.Drawing.Point(18, 109);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(27, 13);
      this.label3.TabIndex = 3;
      this.label3.Text = "Rok";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.ForeColor = System.Drawing.Color.Red;
      this.label2.Location = new System.Drawing.Point(18, 81);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(104, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Okres kredytowania ";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.ForeColor = System.Drawing.Color.Red;
      this.label1.Location = new System.Drawing.Point(18, 51);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(99, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Kwota kredytu PLN";
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(12, 258);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.Size = new System.Drawing.Size(1327, 405);
      this.dataGridView1.TabIndex = 1;
      // 
      // Creditor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(1351, 665);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.groupBox1);
      this.Name = "Creditor";
      this.Text = "Creditor";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.Creditor_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox kalkulator_;
        private System.Windows.Forms.TextBox kurs_otwarcia_;
        private System.Windows.Forms.TextBox kalkulator_all;
        private System.Windows.Forms.TextBox kurs_otwarcia_all;
        private System.Windows.Forms.TextBox saldo_kapitalu_chf_aktualny;
        private System.Windows.Forms.TextBox kurs_chf_aktualny;
        private System.Windows.Forms.TextBox saldo_kap_pln;
        private System.Windows.Forms.TextBox kwota_kredytu_chf;
        private System.Windows.Forms.TextBox kurs_chf;
        private System.Windows.Forms.TextBox okres_kredytowania;
        private System.Windows.Forms.TextBox kwota_kredytu_pln;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.ComboBox rok_uruchomienia;
        private System.Windows.Forms.ComboBox mc_uruchomienia;
        private System.Windows.Forms.ComboBox mc_aktualny;
        private System.Windows.Forms.ComboBox rok_aktualny;
        private System.Windows.Forms.TextBox kurs_aktualny_;
        private System.Windows.Forms.TextBox kurs_aktualny_all;
        private System.Windows.Forms.DataGridView dataGridView1;
  }
}

