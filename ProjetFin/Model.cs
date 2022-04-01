using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Dynamic;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace ProjetFin
{
    abstract class Model
    {
        public int id = 0;
        private string sql = "";
       public Dictionary<string, T> ObjectToDictionary<T>(object obj)
        {
            var json = JsonConvert.SerializeObject(obj);
            var dico = JsonConvert.DeserializeObject<Dictionary<string, T>>(json);
            return dico;
        }
        private dynamic DictionaryToObject(Dictionary<String, object> dico)

        {
            dynamic obj = dico.Aggregate(new ExpandoObject() as IDictionary<string, Object>,
                            (a, p) => { a.Add(p); return a; });
            return obj;
        }
        public int save()
        {
            Dictionary<string, string> dico = new Dictionary<string, string>();
            dico = ObjectToDictionary<string>(this);
            if (id == 0) {
                string req = "insert into " + this.GetType() + " values ( ";
                foreach (KeyValuePair<string, string> champs in dico)
                {
                    req += champs.Value + ", ";
                }
                req += " );";
                return Connexion.IUD(req);
            }
            else
            {
                string req = "update " + this.GetType() + " set ";
                foreach (KeyValuePair<string, string> champs in dico)
                {
                    req += champs.Key + " = " + champs.Value + ", ";
                }
                req += "where id = " + dico["id"] + " );";
                return Connexion.IUD(req);
            }
        }
        public dynamic find()
        {

            Dictionary<string, object> dico = new Dictionary<string, object>();
            Dictionary<string, string> ch = new Dictionary<string, string>();
            ch = ObjectToDictionary<string>(this);
            sql = "select * from " + this.GetType().Name + " where id=" + ch["id"];
            MySqlDataReader Dr = (MySqlDataReader)Connexion.Select(sql);
            //ch = Connection.getChamps_table(this.GetType().Name);
            dico = ObjectToDictionary<T>(Dr);
            //int nombre = ch.Count;

            /*-------------------------------optionnel--------------------------------*/

            foreach (KeyValuePair<string, Object> keyValuePair in dico)
            {
                Console.WriteLine("{0}: {1}  ", keyValuePair.Key, keyValuePair.Value);
            }
            //LE.Add(new this.GetType().Name(Dr.GetInt32(0), Dr.GetString(1), Dr.GetString(2), Dr.GetString(3)));
            Dr.Close();

            return DictionaryToObject(dico);
        }

        public int delete()
        {
            dynamic objet = null;
            if (id != 0)
            {
                objet = find();

                Dictionary<string, object> dico = ObjectToDictionary(objet);
                sql = "delete from " + this.GetType().Name + "where id ="+ dico["id"];
                return Connexion.IUD(sql);
            }
            return 0;
        }

        public List<dynamic> All()
        {
            List<dynamic> L = new List<dynamic>();
            string requete = "select * from " + this.GetType().Name;
            MySqlDataReader Data = (MySqlDataReader)Connexion.Select(requete);
            Dictionary<string, object> dico = ObjectToDictionary(Data);
            foreach (KeyValuePair<string, Object> keyValuePair in dico)
            {
                L.Add(keyValuePair.Value);
            }
            return L;
        }

        public static List<dynamic> all<T>()
        {
            List<dynamic> L = new List<dynamic>();
            string requete = "select * from " + T.ToString();
            MySqlDataReader Data = (MySqlDataReader)Connexion.Select(requete);
            Dictionary<string, object> dico = ObjectToDictionary(Data);
            foreach (KeyValuePair<string, Object> keyValuePair in dico)
            {
                L.Add(keyValuePair.Value);
            }
            return L;
        }

        public List<dynamic> Select(Dictionary<string, object> dico)
        {
            List<dynamic> L = new List<dynamic>();
            string requete = "select * from " + this.GetType().Name + "where id =" + dico["id"];
            MySqlDataReader Data = (MySqlDataReader)Connexion.Select(requete);
            Dictionary<string, object> dico = ObjectToDictionary(Data);
            foreach (KeyValuePair<string, Object> keyValuePair in dico)
            {
                L.Add(keyValuePair.Value);
            }
            return L;
        }

        public static List<dynamic> select<T>(Dictionary<string, object> dico)
        {
            List<dynamic> L = new List<dynamic>();
            string requete = "select * from " + T.ToString() + "where id =" + dico["id"];
            MySqlDataReader Data = (MySqlDataReader)Connexion.Select(requete);
            Dictionary<string, object> dico = ObjectToDictionary(Data);
            foreach (KeyValuePair<string, Object> keyValuePair in dico)
            {
                L.Add(keyValuePair.Value);
            }
            return L;
        }

    }
}
