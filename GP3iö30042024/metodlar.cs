using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//ekle

namespace GP3iö30042024
{
    internal class metodlar
    {
        SqlConnection bag = new SqlConnection("server=DESKTOP-MJGGV3B;initial catalog=hastanerandevu;integrated security=true");
        public void lbyukle(ListBox lb,string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, bag);
            DataTable dt = new DataTable();
            da.Fill(dt);
            lb.DataSource = dt;
            lb.DisplayMember = dt.Columns[1].ColumnName;//"polno","doktorno,"saatno
            lb.ValueMember = dt.Columns[0].ColumnName;// "polno". . . ;
        }public void dgvyukle(DataGridView dgv)
        {
            string sql = "select randevular.randevuno,randevular.hasta,randevular.tc,randevular.doktorno,randevular.tarih,saatler.saatler from randevular INNER JOIN saatler on randevular.saatno=saatler.saatno";
            SqlDataAdapter da = new SqlDataAdapter(sql, bag);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            dgv.Columns[0].HeaderText = "Randevu No";
            dgv.Columns[1].HeaderText = "Hastaa Adı";
            dgv.Columns[2].HeaderText = "Hasta TC";
            dgv.Columns[3].HeaderText = "Doktor NO";
            dgv.Columns[4].HeaderText = "Randevu Tarih ";
            
            
            
        }
        public void randevual(string hasta,string tc,string doktorno,string tarih,string saatno)
        {
            string sql = "insert into randevular (hasta,tc,doktorno,tarih,saatno) values ('" + hasta + "','" + tc + "','" + doktorno + "','" + tarih + "','" + saatno + "')";
            SqlCommand cmd = new SqlCommand(sql,bag);
            bag.Open();
            cmd.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Kaydedildi","Randevu Kayıt",MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk);
            
        }

    }
}
