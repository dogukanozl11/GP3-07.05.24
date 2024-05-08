using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GP3iö30042024
{
    public partial class Form1 : Form
    {
        SqlConnection bag = new SqlConnection("server=DESKTOP-MJGGV3B;initial catalog=hastanerandevu;integrated security=true");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "select * from poller";
            mtd.lbyukle(lstPoliklinik, sql);
            mtd.dgvyukle(dataGridView1);
        }
        metodlar mtd = new metodlar();

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string polno = lstPoliklinik.SelectedValue.ToString();
            string sql = "select * from doktorlar where polno='" + polno + "'";
            mtd.lbyukle(lstDoktorlar, sql);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string doktorno = lstDoktorlar.SelectedValue.ToString();
            string tarih = dateTimePicker1.Value.ToShortDateString();
            string sql = "select * from saatler where saatno not in (select saatno from randevular where doktorno='" + doktorno + "' and tarih='" + tarih + "')";
            mtd.lbyukle(lstSaat, sql);
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            string hasta = txtHastaAd.Text;
            string tc = txtHastaTc.Text;
            string doktorno = lstDoktorlar.SelectedValue.ToString();
            string tarih = dateTimePicker1.Value.ToShortDateString();
            string saatno = lstSaat.SelectedValue.ToString();
            mtd.randevual(hasta, tc, doktorno, tarih, saatno);
            mtd.dgvyukle(dataGridView1);
        }

        private void btnRandevuSil_Click(object sender, EventArgs e)
        {


            DialogResult karar = new DialogResult();
            karar = MessageBox.Show("Seçilen Randevuyu Silmek İstediğinize Emin Misiniz ? ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (karar == DialogResult.Yes)
            {
                bag.Open();
                SqlCommand sil = new SqlCommand("delete from randevular where randevuno=@ranno", bag);
                sil.Parameters.AddWithValue("@ranno", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                sil.ExecuteNonQuery();
                bag.Close();
                mtd.dgvyukle(dataGridView1);
            }
            else if (karar == DialogResult.No)
            {
                MessageBox.Show("Randevu Silme İşlemi İptal Edildi.", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }



        }
    }
}
