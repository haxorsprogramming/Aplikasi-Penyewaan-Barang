using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AplikasiManajemenPenyewaanBarang
{
    class DatabaseClass
    {
        public static MySqlConnection CONN_DB = new MySqlConnection("server=localhost;database=dbs_tahfiz_al_hafiz;uid=root;pwd=;");

        public static void BUKA_KONEKSI()
        {
            Boolean status = true;
            try
            {
                DatabaseClass.CONN_DB.Open();
                status = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal !!!");
                status = false;
            }
            return;
        }
    }
}
