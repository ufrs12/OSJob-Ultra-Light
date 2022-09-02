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
                DB = new SQLiteConnection("Data Source=OpenJob.db;foreign keys=true;Version=3");
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sel, DB);
                DataSet res = new DataSet();
                adapter.Fill(res, "table1");
                return res;
        }
        static public void Del(string tab, string id)
        {
            DB = new SQLiteConnection("Data Source=OpenJob.db; Version=3");
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "PRAGMA foreign_keys = ON; DELETE FROM " + tab + " WHERE id=@id";
            CMD.Parameters.AddWithValue("@id", id);
            DB.Open();
            CMD.ExecuteNonQuery();
            DB.Close();
        }
        static public void Upd(string q)
        {
            DB = new SQLiteConnection("Data Source=OpenJob.db; Version=3");
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = q;
            DB.Open();
            CMD.ExecuteNonQuery();
            DB.Close();
        }
        static public void Ins(string q)
        {
            DB = new SQLiteConnection("Data Source=OpenJob.db; Version=3");
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = q;
            DB.Open();
            CMD.ExecuteNonQuery();
            DB.Close();
        }
    }
}
