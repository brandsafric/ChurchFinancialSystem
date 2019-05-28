using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ChurchFinanceManager
{
    static class FinanceDbManager
    {

        public enum QueryMode { SELECT_ALL, SELECT_PARAM, SELECT_ONE, CREATE, UPDATE, DELETE };
        public static DataTable BasicQuery(QueryMode mode, string tableName, Param uniqueId = null, QueryBuilder custom = null, params Param[] @params)
        {
            DataTable dt = new DataTable();
            SQLManager sql = new SQLManager();
            QueryBuilder qb = new QueryBuilder();
            custom = custom ?? new QueryBuilder();
            switch (mode)
            {
                case QueryMode.SELECT_ALL:
                    dt = sql.ExecQuery(qb.SelectAll(tableName).Custom(custom.ToString()).ToString());
                    break;
                case QueryMode.SELECT_ONE:
                    if (uniqueId == null) break;
                    dt = sql.ExecQuery(qb.SelectAll(tableName).Where(uniqueId.name).EqualsTo(uniqueId.value).Custom(custom.ToString()).ToString());
                    break;
                case QueryMode.CREATE:
                    if (@params.Length == 0) break;
                    foreach (Param p in @params)
                        sql.AddParam(p.name, p.value);

                    sql.ExecQuery(qb.InsertInto(tableName, @params).Custom(custom.ToString()).ToString());
                    break;
                case QueryMode.UPDATE:
                    if (@params.Length == 0) break;
                    if (uniqueId == null) break;

                    foreach (Param p in @params)
                        sql.AddParam(p.name, p.value);
                    sql.ExecQuery(qb.Update(tableName, @params).Where(uniqueId.name).EqualsTo(uniqueId.value).Custom(custom.ToString()).ToString());
                    break;
                case QueryMode.DELETE:
                    if (uniqueId == null) break;
                    sql.ExecQuery(qb.Delete(tableName).Where(uniqueId.name).EqualsTo(uniqueId.value).Custom(custom.ToString()).ToString());
                    break;
            }
            return dt;
        }

        public static DataTable CustomQuery(QueryBuilder query, params Param[] @params)
        {
            DataTable dt = new DataTable();
            SQLManager sql = new SQLManager();
            if(@params.Length > 0)
            foreach (Param p in @params)
                sql.AddParam(p.name, p.value);
           
            dt = sql.ExecQuery(query.ToString());
                           
            return dt;
        }

    }

    public  class Param{
        public  string name;
        public  object value;
        public Param(string n,object v)
        {
            name = n;
            value = v;
        }
    }
}
