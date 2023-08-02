namespace Park
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
            this.labelJenis = new System.Windows.Forms.Label();
            this.cmbJenis = new System.Windows.Forms.ComboBox();
            this.txtKarcis = new System.Windows.Forms.TextBox();
            this.labelKarcis = new System.Windows.Forms.Label();
            this.labelHarga = new System.Windows.Forms.Label();
            this.labelHargaOutput = new System.Windows.Forms.Label();
            this.labelNoPolisi = new System.Windows.Forms.Label();
            this.txtNoPolisi = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.lvPark = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBuat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelJenis
            // 
            this.labelJenis.AutoSize = true;
            this.labelJenis.Location = new System.Drawing.Point(8, 20);
            this.labelJenis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelJenis.Name = "labelJenis";
            this.labelJenis.Size = new System.Drawing.Size(143, 19);
            this.labelJenis.TabIndex = 0;
            this.labelJenis.Text = "Jenis Kendaraan: ";
            this.labelJenis.Click += new System.EventHandler(this.labelJenis_Click);
            // 
            // cmbJenis
            // 
            this.cmbJenis.BackColor = System.Drawing.SystemColors.Window;
            this.cmbJenis.CausesValidation = false;
            this.cmbJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJenis.FormattingEnabled = true;
            this.cmbJenis.Items.AddRange(new object[] {
            "MOTOR",
            "MINI BUS",
            "TRUK",
            "BUS"});
            this.cmbJenis.Location = new System.Drawing.Point(149, 16);
            this.cmbJenis.Name = "cmbJenis";
            this.cmbJenis.Size = new System.Drawing.Size(146, 27);
            this.cmbJenis.TabIndex = 1;
            this.cmbJenis.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmbJenis.TextChanged += new System.EventHandler(this.cmbJenis_TextChanged);
            // 
            // txtKarcis
            // 
            this.txtKarcis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKarcis.Location = new System.Drawing.Point(517, 20);
            this.txtKarcis.Name = "txtKarcis";
            this.txtKarcis.Size = new System.Drawing.Size(132, 27);
            this.txtKarcis.TabIndex = 2;
            this.txtKarcis.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelKarcis
            // 
            this.labelKarcis.AutoSize = true;
            this.labelKarcis.Location = new System.Drawing.Point(394, 24);
            this.labelKarcis.Name = "labelKarcis";
            this.labelKarcis.Size = new System.Drawing.Size(81, 19);
            this.labelKarcis.TabIndex = 3;
            this.labelKarcis.Text = "No Karcis";
            this.labelKarcis.Click += new System.EventHandler(this.labelKarcis_Click);
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.Location = new System.Drawing.Point(394, 63);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(118, 19);
            this.labelHarga.TabIndex = 4;
            this.labelHarga.Text = "Harga/jam: Rp.";
            this.labelHarga.Click += new System.EventHandler(this.labelHarga_Click);
            // 
            // labelHargaOutput
            // 
            this.labelHargaOutput.AutoSize = true;
            this.labelHargaOutput.Location = new System.Drawing.Point(518, 63);
            this.labelHargaOutput.Name = "labelHargaOutput";
            this.labelHargaOutput.Size = new System.Drawing.Size(15, 19);
            this.labelHargaOutput.TabIndex = 5;
            this.labelHargaOutput.Text = "-";
            this.labelHargaOutput.Click += new System.EventHandler(this.labelHargaOutput_Click);
            // 
            // labelNoPolisi
            // 
            this.labelNoPolisi.AutoSize = true;
            this.labelNoPolisi.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoPolisi.Location = new System.Drawing.Point(12, 114);
            this.labelNoPolisi.Name = "labelNoPolisi";
            this.labelNoPolisi.Size = new System.Drawing.Size(92, 19);
            this.labelNoPolisi.TabIndex = 6;
            this.labelNoPolisi.Text = "NO POLISI";
            this.labelNoPolisi.Click += new System.EventHandler(this.labelNoPolisi_Click);
            // 
            // txtNoPolisi
            // 
            this.txtNoPolisi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNoPolisi.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoPolisi.Location = new System.Drawing.Point(16, 161);
            this.txtNoPolisi.MaxLength = 10;
            this.txtNoPolisi.Name = "txtNoPolisi";
            this.txtNoPolisi.Size = new System.Drawing.Size(739, 145);
            this.txtNoPolisi.TabIndex = 7;
            this.txtNoPolisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNoPolisi.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSimpan.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(289, 312);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(466, 56);
            this.btnSimpan.TabIndex = 8;
            this.btnSimpan.Text = "SIMPAN";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvPark
            // 
            this.lvPark.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvPark.FullRowSelect = true;
            this.lvPark.GridLines = true;
            this.lvPark.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvPark.HideSelection = false;
            this.lvPark.Location = new System.Drawing.Point(16, 374);
            this.lvPark.Name = "lvPark";
            this.lvPark.Size = new System.Drawing.Size(739, 441);
            this.lvPark.TabIndex = 10;
            this.lvPark.UseCompatibleStateImageBehavior = false;
            this.lvPark.View = System.Windows.Forms.View.Details;
            this.lvPark.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            this.lvPark.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvPark_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No Karcis";
            this.columnHeader1.Width = 86;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "No Polisi";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 127;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Jenis";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 105;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Waktu";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 229;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Status";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 104;
            // 
            // btnBuat
            // 
            this.btnBuat.BackColor = System.Drawing.Color.Yellow;
            this.btnBuat.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuat.Location = new System.Drawing.Point(16, 312);
            this.btnBuat.Name = "btnBuat";
            this.btnBuat.Size = new System.Drawing.Size(267, 56);
            this.btnBuat.TabIndex = 12;
            this.btnBuat.Text = "Buat Karcis Baru";
            this.btnBuat.UseVisualStyleBackColor = false;
            this.btnBuat.Click += new System.EventHandler(this.btnBuat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(181, 840);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 42);
            this.label2.TabIndex = 14;
            this.label2.Text = "Wisma Agung Barokah";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(517, 110);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 27);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Waktu Masuk: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(767, 906);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuat);
            this.Controls.Add(this.lvPark);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtNoPolisi);
            this.Controls.Add(this.labelNoPolisi);
            this.Controls.Add(this.labelHargaOutput);
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.labelKarcis);
            this.Controls.Add(this.txtKarcis);
            this.Controls.Add(this.cmbJenis);
            this.Controls.Add(this.labelJenis);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplikasi Parkir";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelJenis;
        private System.Windows.Forms.ComboBox cmbJenis;
        private System.Windows.Forms.TextBox txtKarcis;
        private System.Windows.Forms.Label labelKarcis;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.Label labelHargaOutput;
        private System.Windows.Forms.Label labelNoPolisi;
        private System.Windows.Forms.TextBox txtNoPolisi;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.ListView lvPark;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnBuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
    }
}

