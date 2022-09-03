using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace OpenJob
{
    public class Db_class
    {
        static private SQLiteConnection DB;
        static public DataSet Ds(string sel)
        {
            DB = new SQLiteConnection("Data Source=OSJob.db;foreign keys=true;Version=3");
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sel, DB);
            DataSet res = new DataSet();
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
                return("Ошибка базы данных:" + ex.Message);
            }
        }
    }
}
