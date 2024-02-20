using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YurtKayıtSistemi
{
    public class SqlBaglantim
    {

        public SqlConnection Baglanti()
        {

            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-MV2GLCC\\SQLEXPRESS;Initial Catalog=DbYurtOtomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
