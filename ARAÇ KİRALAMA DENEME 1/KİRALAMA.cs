using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ARAÇ_KİRALAMA_OTOMASYON
{
    




    internal class KİRALAMA
    {
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=projem;Integrated Security=True");
        DataTable tablo;
        public void ekle_sil_güncelle(SqlCommand komut, string sorgu)
        {
            con.Open();
            komut.Connection = con;
            komut.CommandText= sorgu;  
           komut.ExecuteNonQuery();
            con.Close();

        }
        public DataTable listele(SqlDataAdapter adtr,string sorgu )
        {
            tablo= new DataTable();
            adtr = new SqlDataAdapter(sorgu,con);
            adtr.Fill(tablo);
            return tablo;
        }




    }
}
