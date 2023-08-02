using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Park
{
    public partial class Form1 : Form
    {
        OdbcCommand dml;
        OdbcDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // BTN SIMPAN
            if (cmbJenis.Text == "" || txtNoPolisi.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong!", "PESAN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String sql;
                sql = string.Format("SELECT * FROM park WHERE karcis = '{0}'", txtKarcis.Text);
                dml = new OdbcCommand(sql, ClsKoneksi.koneksi);
                dr = dml.ExecuteReader();

                if (dr.HasRows)
                {
                    string status = "";
                    while (dr.Read())
                    {
                        status = dr.GetString(4);
                    }

                    if (status == "masuk") {
                        if (btnSimpan.Text == "SIMPAN") {
                            MessageBox.Show("Data kendaraan masuk sudah ada", "PESAN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        } else
                        {

                            keluarkan_kendaraan(txtKarcis.Text);
                        }
                        
                    }
                    
                }
                else
                {
                    if (btnSimpan.Text == "SIMPAN")
                    {
                        string waktu = BuatWaktu();
                        string status = "masuk";
                        sql = string.Format("INSERT INTO park VALUES ('{0}','{1}','{2}','{3}','{4}')",
                            txtKarcis.Text,
                            txtNoPolisi.Text,
                            cmbJenis.Text,
                            waktu,
                            status
                            ); ;
                        dml = new OdbcCommand(sql, ClsKoneksi.koneksi);
                        dml.ExecuteNonQuery();
                        Bersih();
                        tampil_data();
                        MessageBox.Show("Data bershasil ditambahkan", "PESAN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else {
                        // Fungsi untuk keluarin mobil
                        keluarkan_kendaraan(txtKarcis.Text);
                    }
                    

                }
            }
        }

        private void keluarkan_kendaraan(string karcis) {
            // Bagian merubah status keluar masuk kendaraan
            string sql = string.Format("UPDATE park SET status = '{0}' WHERE karcis = '{1}'", "keluar", karcis);
            dml = new OdbcCommand(sql, ClsKoneksi.koneksi);
            dml.ExecuteNonQuery();

            // Bagian mengambil kendaraan dengan karcis tertentu
            String sql2;
            sql2 = string.Format("SELECT * FROM park WHERE karcis = '{0}'", karcis);
            dml = new OdbcCommand(sql2, ClsKoneksi.koneksi);
            dr = dml.ExecuteReader();

            if (dr.HasRows)    
            {
                    // Bagian hitung selisih waktu
                    DateTime sekarang = DateTime.Now;
                    DateTime awal = DateTime.Parse(dr.GetString(3));
                    TimeSpan ts = sekarang - awal;

                    int selisih = (int)Math.Ceiling(ts.TotalHours);

                    string msgg = string.Format("Masuk: {0}\nKeluar: {1}\n\nDurasi parkir: {2} Jam\n\nHarga perjam: Rp. {3}\n---------------\nTotal harga parkir: Rp. {4}\n---------------", awal, sekarang, selisih, labelHargaOutput.Text, hitung_harga(int.Parse(labelHargaOutput.Text), selisih));
                    MessageBox.Show(msgg,"INFORMASI KELUAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                

            }

            //MessageBox.Show("Mobil telah dikeluarkan", "PESAN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Bersih();
            tampil_data();
        }

        private string hitung_harga(int perjam, int waktu) {
            return String.Format("{0:#,###,###.##}", perjam*waktu);
        }
        private void Bersih()
        {
            txtKarcis.Text = "";
            txtNoPolisi.Text = "";
            cmbJenis.SelectedItem = null;
        }
        private void tampil_data()
        {
            string sql = "SELECT * FROM park";
            dml = new OdbcCommand(sql, ClsKoneksi.koneksi);
            dr = dml.ExecuteReader();

            if (dr.HasRows)
            {
                lvPark.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem Data = lvPark.Items.Add(dr.GetString(0));
                    Data.SubItems.Add(dr.GetString(1));
                    Data.SubItems.Add(dr.GetString(2));
                    Data.SubItems.Add(dr.GetString(3));
                    Data.SubItems.Add(dr.GetString(4));


                }
            }
            else
            {
                lvPark.Items.Clear();
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            String sql;
            sql = string.Format("SELECT * FROM park WHERE no_polisi = '{0}'", txtNoPolisi.Text);
            dml = new OdbcCommand(sql, ClsKoneksi.koneksi);
            dr = dml.ExecuteReader();

            if (dr.HasRows)
            {

                // dr.GetString(0) = kode, 1 = no_polisi, 2 = jenis, 3 = waktu, 4 = status
                if (txtKarcis.Text == dr.GetString(0) && cmbJenis.Text == dr.GetString(2)) { 
                    ubah_simpan(true);
                }
            }
            else {
                ubah_simpan(false);
            }
        }

        private void labelNoPolisi_Click(object sender, EventArgs e)
        {

        }

        private void labelHargaOutput_Click(object sender, EventArgs e)
        {

        }

        private void labelHarga_Click(object sender, EventArgs e)
        {

        }

        private void labelKarcis_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelJenis_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private string BuatWaktu()
        {
            DateTime dateTime = dateTimePicker1.Value;
            string waktu = dateTime.ToString("MM/dd/yyyy hh:mm tt");

            //DateTime timee = DateTime.Parse(waktu);
            //string msg = string.Format("Time: {0}", timee.Day);
            //MessageBox.Show(msg, "PESAN", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return waktu;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClsKoneksi ambilKoneksi = new ClsKoneksi();
            ambilKoneksi.BukaKoneksi();

            tampil_data();
        }

        private void lvPark_MouseClick(object sender, MouseEventArgs e)
        {
            // ketika data di select
            txtKarcis.Text = lvPark.SelectedItems[0].Text;
            txtNoPolisi.Text = lvPark.SelectedItems[0].SubItems[1].Text;
            cmbJenis.Text = lvPark.SelectedItems[0].SubItems[2].Text;

            ubah_simpan(true);
            disabled();
        }

        private void disabled() {
            cmbJenis.Enabled = false;
            txtKarcis.Enabled = false;
            txtNoPolisi.Enabled = false;
        }

        private void enabled()
        {
            cmbJenis.Enabled = true;
            txtKarcis.Enabled = true;
            txtNoPolisi.Enabled = true;

            ubah_simpan(false);
        }

        private void btnBuat_Click(object sender, EventArgs e)
        {
            enabled();
            Bersih();
        }

        private void ubah_simpan(Boolean keluar) {
            if (keluar)
            {
                btnSimpan.Text = "KELUAR";
                btnSimpan.BackColor = Color.Blue;
                btnSimpan.ForeColor = Color.Black;
            }
            else {
                btnSimpan.Text = "SIMPAN";
                btnSimpan.BackColor = Color.FromArgb(0,192,0);
                btnSimpan.ForeColor = Color.White;
            }
        }

        private void cmbJenis_TextChanged(object sender, EventArgs e)
        {
            if (cmbJenis.Text == "MOTOR")
            {
                labelHargaOutput.Text = "3000";
            }
            else if (cmbJenis.Text == "MINI BUS")
            {
                labelHargaOutput.Text = "5000";
            }
            else if (cmbJenis.Text == "TRUK")
            {
                labelHargaOutput.Text = "7000";
            }
            else if (cmbJenis.Text == "BUS")
            {
                labelHargaOutput.Text = "10000";
            }
            else {
                labelHargaOutput.Text = "-";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
