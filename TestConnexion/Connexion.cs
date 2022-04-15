using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;

namespace TestConnexion
{
   public class Connexion
    {
        static IDbConnection con = null;
        static IDbCommand cmd = null;
        public static void Connect(string dbname, string server, string user, string password)
        {

            try 
            {
                if (con == null)
                {

                    //con = new MySqlConnection("server = " + server + "; user id =" + user + "; database =" + dbname);
                    //cmd = new MySqlCommand();

                    con = new SqlConnection("Data Source =" + server + "; Initial Catalog =" + dbname + "; Integrated Security = True");
                    cmd = new SqlCommand();
                }
                if (con.State.ToString() == "Closed")
                {
                    con.Open();
                    cmd.Connection = con;
                }
            }
            catch
            {
                if (con == null)
                {
                    con = new MySqlConnection("server = " + server + "; user id =" + user + "; database =" + dbname);
                    cmd = new MySqlCommand();
                }
                if (con.State.ToString() == "Closed")
                {
                    con.Open();
                    cmd.Connection = con;
                }
            }
            finally
            {
                Console.WriteLine(con.State.ToString());
            }
        }
        public static IDbCommand GetCommand()
        {
            return cmd;
        }
        public static int IUD(string req)
        {
            cmd.CommandText = req;
            return cmd.ExecuteNonQuery();
        }
        public static IDataReader Select(string req)
        {
            cmd.CommandText = req;
            return cmd.ExecuteReader();
        }
        //public static IDataReader Select(string table, int idn = 0)
        //{
        //    cmd = new MySqlCommand("", (MySqlConnection)con);
        //    MySqlParameter p0 = new MySqlParameter(@table, @idn);
        //    MySqlParameter p1 = new MySqlParameter(@table, @idn);
        //    return cmd.ExecuteReader();
        //}

        //public static List<string> getChamps_table(string table)
        //{
        //    return champs;
        //}
        //public static Dictionary<string, string> getChamps_table(string table)
        //{
        //    Dictionary<string, string> dico = new Dictionary<string, string>();
        //    IDataReader reader = Select("select column_name, column_type " +
        //        "from information_schema.columns where table_name='"+table+"' and table_schema='"+con.Database+"';");

        //    while (reader.Read())
        //    {
        //        dico.Add(reader.GetString(0), reader.GetString(1));
        //    }
        //    reader.Close();
        //    //foreach (KeyValuePair<string, string> d in dico)
        //    //{
        //    //    Console.WriteLine("Clé: {0}, Type: {1}", d.Key, d.Value);
        //    //}
        //    return dico;
        //}
        public static List<string> getChamps_table(string table)
        {
            Dictionary<string, string> dico = new Dictionary<string, string>();
            List<string> list = new List<string>();
            if(con is MySqlConnection)
            {
                IDataReader reader = Select("select column_name, data_type " +
                    "from information_schema.columns where table_name='" + table + "' and table_schema='" + con.Database + "';");
                while (reader.Read())
                {
                    list.Add(reader.GetString(0));
                }
                reader.Close();
            }
            else
            {
                IDataReader reader = Select("select column_name, data_type " +
                    "from information_schema.columns where table_name='" + table + "' and table_catalog='" + con.Database + "';");
                while (reader.Read())
                {
                    list.Add(reader.GetString(0));
                }
                reader.Close();
            }

            //foreach (KeyValuePair<string, string> d in dico)
            //{
            //    Console.WriteLine("Clé: {0}, Type: {1}", d.Key, d.Value);
            //}
            return list;
        }


    }
}

