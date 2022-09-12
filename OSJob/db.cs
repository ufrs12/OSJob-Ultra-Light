using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using OSJob;

namespace OpenJob
{
    class ComboItem
    {
        public int Id { get; set; }
        public string Text { get; set; }
    }
    
    public class Db_class
    {
        static private SQLiteConnection DB;
        public BindingSource _bsTypes;

        static public BindingSource Bs(string sel)
        {
            BindingSource _bsTypes;
            _bsTypes = new BindingSource();
            _bsTypes.DataSource = typeof(ComboItem);
            try
            {
                using (DB = new SQLiteConnection("Data Source=OSJob.db;foreign keys=true;Version=3"))
                using (SQLiteCommand cmd = DB.CreateCommand())
                {
                    cmd.CommandText = sel;
                    DB.OpenAsync();
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var ci = new ComboItem
                            {
                                Id = reader.GetInt32(0),
                                Text = reader.GetString(1)
                            };
                            
                            _bsTypes.Add(ci);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return (_bsTypes);
        }
        static public DataSet Ds(string sel)
        {

            DB = new SQLiteConnection("Data Source=OSJob.db;foreign keys=true;Version=3");
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sel, DB);
            DataSet res = new DataSet();
            //MessageBox.Show(sel);
            adapter.Fill(res, "table1");
            return res;
        }
        static public string Del(string tab, string id)
        {
            try
            {
                DB = new SQLiteConnection("Data Source=OSJob.db; Version=3");
                SQLiteCommand CMD = DB.CreateCommand();
                CMD.CommandText = "PRAGMA foreign_keys = ON; DELETE FROM " + tab + " WHERE id=@id";
                CMD.Parameters.AddWithValue("@id", id);
                DB.Open();
                string s = "Удалено записей: " + Convert.ToString(CMD.ExecuteNonQuery());
                DB.Close();
                return (s);
            }
            catch (Exception ex)
            {
                return("Ошибка базы данных:" + ex.Message);
            }
}
        static public void Upd(string q)
        {
            DB = new SQLiteConnection("Data Source=OSJob.db; Version=3");
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = q;
            DB.Open();
            CMD.ExecuteNonQuery();
            DB.Close();
        }
        static public string Ins(string q)
        {
            try 
            {
                DB = new SQLiteConnection("Data Source=OSJob.db; Version=3");
                SQLiteCommand CMD = DB.CreateCommand();
                CMD.CommandText = "PRAGMA foreign_keys = ON;" + q;
                DB.Open();
                string s ="Добавлено записей: " + Convert.ToString(CMD.ExecuteNonQuery());
                DB.Close();
                return (s);
            }
            catch (Exception ex)
            {
                return("Ошибка базы данных:" + q + ex.Message);
            }
        }
    }
}
