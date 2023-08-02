using Park;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Park

{
    internal class ClsKoneksi
    {
        public static OdbcCommand dml;
        public static OdbcDataReader dr;
        public static OdbcConnection koneksi;

        public void BukaKoneksi()
        {
            koneksi = new OdbcConnection("DSN=dbpendaftaran");
            koneksi.Open();
        }
    }
}

//public partial class Form1 : Form
//{
//    OdbcCommand dml;
//    OdbcDataReader dr;

//    private void Bersih()
//    {
//        txtNoAnggota.Text = "";
//        txtNamaAnggota.Text = "";
//        txtTelepon.Text = "";

//        btnSimpan.Text = "Simpan";
//        txtNoAnggota.Enabled = true;
//    }

//    public Form1()
//    

//    private void button2_Click(object sender, EventArgs e)
//    {
//        if (txtNoAnggota.Text == "")
//        {
//            MessageBox.Show("Pilih data terlebih dahulu", "PESAN", MessageBoxButtons.OK, MessageBoxIcon.Information);
//        }
//        else
//        {
//            String sql = string.Format("DELETE FROM anggota WHERE no_anggota = '{0}'", txtNoAnggota.Text);
//            dml = new OdbcCommand(sql, ClsKoneksi.koneksi);
//            dml.ExecuteNonQuery();

//            MessageBox.Show("Data telah dihapus", "PESAN", MessageBoxButtons.OK, MessageBoxIcon.Information);

//            tampil_data();
//            Bersih();
//        }

//    }
//    private void tampil_data()
//    {
//        string sql = "SELECT * FROM anggota";
//        dml = new OdbcCommand(sql, ClsKoneksi.koneksi);
//        dr = dml.ExecuteReader();

//        if (dr.HasRows)
//        {
//            lvAnggota.Items.Clear();
//            while (dr.Read())
//            {
//                ListViewItem Data = lvAnggota.Items.Add(dr.GetString(0));
//                Data.SubItems.Add(dr.GetString(1));
//                Data.SubItems.Add(dr.GetString(2));

//            }
//        }
//        else
//        {
//            lvAnggota.Items.Clear();
//        }
//    }

//    private void cari_data()
//    {

//        string sql = string.Format("SELECT * FROM anggota WHERE {0} LIKE '%{1}%'", cmbCari.Text, txtCari.Text);
//        dml = new OdbcCommand(sql, ClsKoneksi.koneksi);
//        dr = dml.ExecuteReader();

//        if (dr.HasRows)
//        {
//            lvAnggota.Items.Clear();
//            while (dr.Read())
//            {
//                ListViewItem Data = lvAnggota.Items.Add(dr.GetString(0));
//                Data.SubItems.Add(dr.GetString(1));
//                Data.SubItems.Add(dr.GetString(2));

//            }
//        }
//        else
//        {
//            lvAnggota.Items.Clear();
//        }
//    }

//    private void Form1_Load(object sender, EventArgs e)
//    {
//        ClsKoneksi ambilKoneksi = new ClsKoneksi();
//        ambilKoneksi.BukaKoneksi();

//        tampil_data();
//    }

//    private void btnSimpan_Click(object sender, EventArgs e)
//    {
//        if (txtNoAnggota.Text == "" || txtNamaAnggota.Text == "" || txtTelepon.Text == "")
//        {
//            MessageBox.Show("Data tidak boleh kosong!", "PESAN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
//        }
//        else
//        {
//            if (btnSimpan.Text == "Simpan")
//            {
//                String sql;
//                sql = string.Format("SELECT * FROM anggota WHERE no_anggota = ' {0}'", txtNoAnggota.Text);
//                dml = new OdbcCommand(sql, ClsKoneksi.koneksi);
//                dr = dml.ExecuteReader();

//                if (dr.HasRows)
//                {
//                    MessageBox.Show("Input dengan data sama sudah ada", "PESAN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
//                }
//                else
//                {
//                    sql = string.Format("INSERT INTO anggota VALUES ('{0}','{1}','{2}')", txtNoAnggota.Text, txtNamaAnggota.Text, txtTelepon.Text);
//                    dml = new OdbcCommand(sql, ClsKoneksi.koneksi);
//                    dml.ExecuteNonQuery();
//                    Bersih();
//                    tampil_data();
//                    MessageBox.Show("Data bershasil ditambahkan", "PESAN", MessageBoxButtons.OK, MessageBoxIcon.Information);

//                }
//            }
//            // akhir if text == simpan
//            else
//            {
//                string sql = string.Format("UPDATE anggota SET nama_anggota = '{0}', telepon = '{1}' WHERE no_anggota = '{2}'", txtNamaAnggota.Text, txtTelepon.Text, txtNoAnggota.Text);

//                dml = new OdbcCommand(sql, ClsKoneksi.koneksi);
//                dml.ExecuteNonQuery();

//                MessageBox.Show("Data bershasil diubah", "PESAN", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                Bersih();
//                tampil_data();
//            }
//        }
//    }

//    private void lvAnggota_MouseClick(object sender, MouseEventArgs e)
//    {
//        txtNoAnggota.Text = lvAnggota.SelectedItems[0].Text;
//        txtNamaAnggota.Text = lvAnggota.SelectedItems[0].SubItems[1].Text;
//        txtTelepon.Text = lvAnggota.SelectedItems[0].SubItems[2].Text;

//        btnSimpan.Text = "Ubah data";
//        txtNoAnggota.Enabled = false;
//    }

//    private void btnBatal_Click(object sender, EventArgs e)
//    {
//        Bersih();
//    }

//    private void txtCari_TextChanged(object sender, EventArgs e)
//    {
//        cari_data();
//    }
//}