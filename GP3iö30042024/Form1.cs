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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "select * from poller";
            mtd.lbyukle(listBox1,sql);
            mtd.dgvyukle(dataGridView1);
        }
        metodlar mtd =new metodlar();

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string polno = listBox1.SelectedValue.ToString();
            string sql = "select * from doktorlar where polno='"+polno+"'";
            mtd.lbyukle(listBox2,sql);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string doktorno = listBox2.SelectedValue.ToString();
            string tarih=dateTimePicker1.Value.ToShortDateString();
            string sql = "select * from saatler where saatno not in (select saatno from randevular where doktorno='"+doktorno+"' and tarih='"+tarih+"')";
            mtd.lbyukle(listBox3,sql);
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            string hasta = txtHastaAd.Text;
            string tc = txtHastaTc.Text;
            string doktorno = listBox2.SelectedValue.ToString();
            string tarih = dateTimePicker1.Value.ToShortDateString();
            string saatno = listBox3.SelectedValue.ToString();
            mtd.randevual(hasta,tc,doktorno,tarih,saatno);
            mtd.dgvyukle(dataGridView1);
        }
    }
}
