using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Data;
using Microsoft.Xrm.Sdk.Messages;
using JsonSerializer = System.Text.Json.JsonSerializer;
using System.Data.SqlClient;

namespace TestConnexion
{
    public abstract class Model
    {
         
        public int id = 0;
        private string sql = "";



        private Dictionary<string, T> ObjectToDictionary<T>(object obj)
        {
            var json = JsonConvert.SerializeObject(obj);
            var dico = JsonConvert.DeserializeObject<Dictionary<string, T>>(json);
            return dico;
        }
        //private dynamic DictionaryToObject(Dictionary<String, object> dico)
        //{
        //    dynamic obj = dico.Aggregate(new ExpandoObject() as IDictionary<string, Object>,
        //                    (a, p) => { a.Add(p); return a; });
        //    return obj;
        //}


        private dynamic DictionaryToObject(IDictionary<String, Object> dictionary)
        {
            var expandoObj = new ExpandoObject();
            var expandoObjCollection = (ICollection<KeyValuePair<String, Object>>)expandoObj;

            foreach (var keyValuePair in dictionary)
            {
                expandoObjCollection.Add(keyValuePair);
            }
            dynamic eoDynamic = expandoObj;
            return eoDynamic;
        }

        public int save(string procName=null)
        {
            
                int a = 0;
            Dictionary<string, string> dico = new Dictionary<string, string>();
            dico = ObjectToDictionary<string>(this);
            int nombre = dico.Count();
            List<string> champs = Connexion.getChamps_table(this.GetType().Name);
            //Console.WriteLine(nombre);
            if (procName == null)
            {
                if (id == 0)
                {
                    string requete = "Insert into " + this.GetType().Name + "(";
                        foreach (KeyValuePair<string, string> d in dico)
                    {
                        a++;
                        if (a < nombre - 1)
                        {
                            requete += d.Key + ",";
                        }
                        else if (a == nombre - 1)
                            requete += d.Key;
                    }
                    a = 0;
                    requete += ") values('";
                    foreach (KeyValuePair<string, string> keyValuePair in dico)
                    {
                        a++;
                        if (a < nombre - 1)
                        {
                            requete += keyValuePair.Value + "','";
                        }
                        else if (a == nombre - 1)
                            requete += keyValuePair.Value + "');";

                    }
                    //Console.WriteLine(a);
                    id++;
                    //foreach (KeyValuePair<string, string> d in dico)
                    //{
                    //    Console.WriteLine("{0} : {1}", d.Key, d.Value);
                    //}
                    return Connexion.IUD(requete);
                }
                else
                {
                    string requete = "Update " + this.GetType().Name + " set ";
                    foreach (KeyValuePair<string, string> keyValuePair in dico)
                    {
                        if (a < nombre - 2)
                        {
                            requete += keyValuePair.Key + " = '" + keyValuePair.Value + "', ";
                        }
                        else if (a == nombre - 2)
                            requete += keyValuePair.Key + " = '" + keyValuePair.Value;
                        a++;
                    }
                    //foreach (KeyValuePair<string, string> keyValuePair in dico)
                    //{
                    //    requete += keyValuePair.Value + ",";
                    //}
                    //requete += "' where " + champs[0] + "='" + dico.FirstOrDefault().Value + "'";
                    requete += "' where " + Connexion.getChamps_table(this.GetType().Name).FirstOrDefault() + "='" + dico.FirstOrDefault().Value + "'";
                   // Console.WriteLine(requete);

                    return Connexion.IUD(requete);
                }
            }
            else
            {
                if(Connexion.GetCommand().Connection is MySqlConnection)
                {
                    MySqlCommand cmd = (MySqlCommand)Connexion.GetCommand();
                    cmd.CommandText = procName;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    //Console.WriteLine(dico[champs[0]]);
                    for (int i = 0, j = 1; i < champs.Count; i++, j++)
                        cmd.Parameters.AddWithValue(champs[i], dico[champs[i]]);
                    return cmd.ExecuteNonQuery();
                }
                else
                {
                    //for (int i = 0; i <= champs.Count-1; i++)
                    //{
                    //    Console.WriteLine(champs[i]);

                    //    //Console.WriteLine(dico[champs[i]]);
                    //}
                    //foreach (string key in dico.Keys)
                    //{
                    //    Console.WriteLine(key);
                    //}
                    SqlCommand cmd = (SqlCommand)Connexion.GetCommand();
                    cmd.CommandText = procName;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    //Console.WriteLine("here");
                    //Console.WriteLine(dico[champs[4]]);
                    for (int i = 0; i < champs.Count; i++)
                        cmd.Parameters.AddWithValue(champs[i], dico[champs[i]]);
                    return cmd.ExecuteNonQuery();
                    //return 0;
                }
                //id++;
            }
           // return 0;
        }

        public dynamic find(string procName = null)
        {
            Dictionary<string, object> dico = new Dictionary<string, object>();
            Dictionary<string, string> ch = new Dictionary<string, string>();
            ch = ObjectToDictionary<string>(this);
            if (procName == null)
            {
                sql = "select * from " + this.GetType().Name + " where " + Connexion.getChamps_table(this.GetType().Name).FirstOrDefault() + "='" + ch.FirstOrDefault().Value + "';";
                Console.WriteLine(sql);
                //string typ = this.GetType().Name;
                MySqlDataReader Dr = (MySqlDataReader)Connexion.Select(sql);
                var jsonString = JsonSerializer.Serialize(Dr);

                // Deserialize
                var obj = JsonSerializer.Deserialize<object>(jsonString);
                //var objResponse1 = JsonConvert.DeserializeObject<List<RetrieveMultipleResponse>>(Dr);
                //ch = Connection.getChamps_table(this.GetType().Name);
                dico = ObjectToDictionary<object>(obj);
                //int nombre = ch.Count;

                /*-------------------------------optionnel--------------------------------*/

                //foreach (KeyValuePair<string, object> keyValuePair in dico)
                //{
                //    Console.WriteLine("{0}: {1}  ", keyValuePair.Key, keyValuePair.Value);
                //}
                //LE.Add(new this.GetType().Name(Dr.GetInt32(0), Dr.GetString(1), Dr.GetString(2), Dr.GetString(3)));
                Dr.Close();

                return DictionaryToObject(dico);
            }
            else
            {

                //MySqlCommand cmd = (MySqlCommand)Connexion.GetCommand();
                //cmd.CommandText = procName;
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Clear();
                ////Console.WriteLine(dico[champs[0]]);
                //for (int i = 0, j = 1; i < champs.Count; i++, j++)
                //    cmd.Parameters.AddWithValue(champs[i], dico[champs[i]]);
                ////id++;
                //return cmd.ExecuteNonQuery();
                return DictionaryToObject(dico);
            }
            }

        public int delete()
        {
            //dynamic objet = null;
            //if (id != 0)
            //{
                //objet = find();

                Dictionary<string, string> dico = ObjectToDictionary<string>(this);
            //foreach (KeyValuePair<string, string> d in dico)
            //{
            //    Console.WriteLine("{0} : {1}", d.Key, d.Value);
            //}
            //sql = "delete from " + this.GetType().Name + " where " + Connexion.getChamps_table(this.GetType().Name).FirstOrDefault().Key + "='" + dico.FirstOrDefault().Value+"';";
            sql = "delete from " + this.GetType().Name + " where " + Connexion.getChamps_table(this.GetType().Name).FirstOrDefault()+ "='" + dico.FirstOrDefault().Value + "';";
            Console.WriteLine(sql);
                return Connexion.IUD(sql);
            //}
            //return 0;
        }

        public List<dynamic> All()
        {
            List<dynamic> L = new List<dynamic>();
            Dictionary<string, object> dic= new Dictionary<string, object>(); ;
            IDataReader data = Connexion.Select("select * from " + this.GetType().Name + " ;");
            Dictionary<string, string> dico = new Dictionary<string, string>();
            //dico = Connexion.getChamps_table(this.GetType().Name);
            int nbr = data.FieldCount;
            //int i=0;
            while (data.Read())
            {
                //L.Add(data.GetString(i));
                //i++;
                for(int i=0; i<nbr;i++)
                {
                    
                    dic.Add(data.GetName(i), data.GetValue(i));
                }
                L.Add( DictionaryToObject(dic));
                dic.Clear();
                
            }
            return L;

            //while (Dr.Read())
            //    LE.Add(new Etudiant(Dr.GetInt32(0), Dr.GetString(1), Dr.GetString(2), Dr.GetString(3)));
            //Dr.Close();
            //return LE;
            //List<dynamic> L = new List<dynamic>();
            //string requete = "select * from " + this.GetType().Name;
            //IDataReader Data = (IDataReader)Connexion.Select(requete);
            //var jsonString = JsonSerializer.Serialize(Data);
            //// Deserialize
            //var obj = JsonSerializer.Deserialize<object>(jsonString);
            //Dictionary<string, object> dico = ObjectToDictionary<object>(obj);
            //foreach (KeyValuePair<string, Object> keyValuePair in dico)
            //{
            //    L.Add(keyValuePair.Value);
            //    Console.WriteLine(keyValuePair.Value);
            //}
            //return L;
        }

        //public static List<dynamic> All<T>()
        //{
        //    List<dynamic> data_list = new List<dynamic>();

        //    string class_name = typeof(T).Name;
        //    IDataReader data_reader = Connexion.Select("select * from " + class_name + ";");
        //    while (data_reader.Read())
        //    {
        //        for (int i = 0; i < data_reader.FieldCount; i++)
        //        {

        //            data_list.Add((dynamic)data_reader.GetValue(i));

        //        }

        //    }
        //    data_reader.Close();
        //    return data_list;

        //}

        //public static List<dynamic> all<T>()
        //{
        //    List<dynamic> L = new List<dynamic>();
        //    string requete = "select * from " + GetType().Name;
        //    MySqlDataReader Data = (MySqlDataReader)Connection.Select(requete);
        //    Dictionary<string, object> dico = ObjectToDictionary<object>(Data);
        //    foreach (KeyValuePair<string, object> keyValuePair in dico)
        //    {
        //        L.Add(keyValuePair.Value);
        //    }
        //    return L;
        //}
        //public static List<List<dynamic>> All<T>()
        //{
        //    List<List<dynamic>> data_list = new List<List<dynamic>>();

        //    string class_name = typeof(T).Name;
        //    IDataReader data_reader = Connexion.Select("select * from " + class_name + ";");

        //    while (data_reader.Read())
        //    {
        //        List<dynamic> temp_list = new List<dynamic>();

        //        for (int i = 0; i < data_reader.FieldCount; i++)
        //        {
        //            temp_list.Add(data_reader.GetValue(i));

        //        }
        //        data_list.Add((dynamic)temp_list);
        //    }
        //    data_reader.Close();
        //    return data_list;

        //}
        public static List<dynamic> All<T>(T table) where T:Model
        {
            List<dynamic> L = new List<dynamic>();
            string sql = "select * from " + table.GetType().Name + " ;";
            Console.WriteLine(sql);
            IDataReader data= Connexion.Select(sql);
            Dictionary<string, object> dic = new Dictionary<string, object>();
            //List<object> list = new List<object>();
            //list = Connexion.getChamps_table(typeof(T).Name);
            
            int nbr = data.FieldCount;
            //int i=0;
            while (data.Read())
            {
                //L.Add(data.GetString(i));
                //i++;
                for (int i = 0; i < nbr; i++)
                {
                    dic.Add(data.GetName(i), data.GetValue(i));
                }
                L.Add( table.DictionaryToObject(dic));
                dic.Clear();

            }
            return L;

            //while (Dr.Read())
            //    LE.Add(new Etudiant(Dr.GetInt32(0), Dr.GetString(1), Dr.GetString(2), Dr.GetString(3)));
            //Dr.Close();
            //return LE;
            //List<dynamic> L = new List<dynamic>();
            //string requete = "select * from " + this.GetType().Name;
            //IDataReader Data = (IDataReader)Connexion.Select(requete);
            //var jsonString = JsonSerializer.Serialize(Data);
            //// Deserialize
            //var obj = JsonSerializer.Deserialize<object>(jsonString);
            //Dictionary<string, object> dico = ObjectToDictionary<object>(obj);
            //foreach (KeyValuePair<string, Object> keyValuePair in dico)
            //{
            //    L.Add(keyValuePair.Value);
            //    Console.WriteLine(keyValuePair.Value);
            //}
            //return L;
        }

        //public List<dynamic> Select(Dictionary<string, object> dico)
        //{
        //    List<dynamic> L = new List<dynamic>();
        //    string requete = "select * from " + this.GetType().Name + " where " + Connexion.getChamps_table(this.GetType().Name).FirstOrDefault().Key + " = "+ dico.FirstOrDefault().Value + ";";
        //    MySqlDataReader Data = (MySqlDataReader)Connexion.Select(requete);
        //    Dictionary<string, object> dico2 = ObjectToDictionary<object>(Data);
        //    foreach (KeyValuePair<string, Object> keyValuePair in dico2)
        //    {
        //        L.Add(keyValuePair.Value);
        //    }
        //    return L;
        //}
        public List<dynamic> Select(Dictionary<string, object> dico)
        {
            List<dynamic> list = new List<dynamic>();
            Dictionary<string, object> dico2;
            dico2 = new Dictionary<string, object>();
            // Dictionary<string, object> dico = new Dictionary<string, object>();
            List<string> champs = Connexion.getChamps_table(this.GetType().Name);
            //for (int i = 0; i < champs.Count; i++)
            //    Console.WriteLine(champs[i]);
            string Requete = "select * from " + this.GetType().Name + " where " + champs.FirstOrDefault() + "='" + dico.FirstOrDefault().Value + "';";
            Console.WriteLine(Requete);
            IDataReader data = Connexion.Select(Requete);
            int nombre = data.FieldCount;

            while (data.Read())
            {
                for (int i = 0; i < nombre; i++)
                {
                    dico2.Add(data.GetName(i), data.GetValue(i));
                }
                list.Add(DictionaryToObject(dico2));
                dico2.Clear();
            }
            data.Close();
            return list;
        }
        public static List<dynamic> Select<T>(Dictionary<string, object> dico)
        {
            int test;
            int i = 1; //pour le comparer avec le compteur dico
            List<dynamic> data_list = new List<dynamic>();
            List<string> champs = Connexion.getChamps_table(typeof(T).Name);
            string sql = "select * from " + typeof(T).Name + " where ";
            //Console.WriteLine(sql);
            for (test = 0; test < dico.Count() && dico.ElementAt(test).Key != "id"; test++) ;
            if (test == dico.Count())
            {
                foreach (var d in dico)
                {

                    if (d.Value.GetType().ToString() == "System.String")
                    {
                        sql += d.Key + "=" + "\"" + d.Value + "\"";
                    }
                    else
                    {
                        sql += d.Key + "=" + d.Value;
                    }
                    if (i < dico.Count)
                    {
                        sql += " and ";
                        i++;
                    }
                }
            }
            else
            {
                sql += " id=" + dico.ElementAt(test).Value;
            }
            sql += ";";
            //Console.WriteLine(sql);
            IDataReader data_reader = Connexion.Select(sql);
            while (data_reader.Read())
            {
                List<dynamic> temp_list = new List<dynamic>();
                for (int k = 0; k < data_reader.FieldCount; k++)
                {
                    temp_list.Add(data_reader.GetValue(k));
                }
                data_list.Add(temp_list);
            }
            data_reader.Close();

            return data_list;
        }

        //public static List<dynamic> select<T>(Dictionary<string, object> dico)
        //{
        //    List<dynamic> L = new List<dynamic>();
        //    string requete = "select * from " + T.ToString() + "where id =" + dico["id"];
        //    MySqlDataReader Data = (MySqlDataReader)Connection.Select(requete);
        //    Dictionary<string, object> dico = ObjectToDictionary<object>(Data);
        //    foreach (KeyValuePair<string, Object> keyValuePair in dico)
        //    {
        //        L.Add(keyValuePair.Value);
        //    }
        //    return L;
        //}

        public static void Afficher(dynamic d)
        {
            foreach (var m in d)
            {
                foreach (var x in m)
                    Console.WriteLine(x);
            }
        }

        public static void Afficher(List<dynamic> l)
        {
            foreach (var m in l)
            {
                Console.WriteLine("===============================================");
                foreach (var x in m)
                    Console.WriteLine(x);
            }
        }


    }
}

