using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;


namespace ChurchFinanceManager
{
    class SQLManager
    {
        private string sqlConnectionStr = @"Data Source=d:\users\harold\documents\finance.sqlite; Version=3;";
        public Exception error = null;
        public List<SQLiteParameter> paramArray = new List<SQLiteParameter>();
        public DataTable ExecQuery(string Query)
        {
            
            DataTable dt = new DataTable();
            SQLiteConnection con = new SQLiteConnection(sqlConnectionStr);
         
            try
            {
                error = null;
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = con;
                cmd.CommandText = Query;
                if (paramArray.Count > 0)
                    foreach (SQLiteParameter p in paramArray)
                        cmd.Parameters.Add(p);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                
                dt.Load(rdr);
                rdr.Close();
            }
            catch (Exception ex)
            {
                if (!String.IsNullOrEmpty(ex.Message))
                {
                    error = ex;
                    Console.WriteLine(error.Message);
                }
                    
            }
            finally
            {
             
                con.Close();
            }

            return dt;
            
        }
        public void AddParam (string name, object value){
            SQLiteParameter param = new SQLiteParameter(name, value);
            paramArray.Add(param);
        }
    }

}
