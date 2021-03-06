﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChurchFinanceManager
{
    public class QueryBuilder
    {
        string query;
        public QueryBuilder SelectAll(string tableName)
        {
            this.query += $"SELECT * FROM {tableName} ";
            return this;
        }
        public QueryBuilder Select(string tableName,params string[] columns)
        {
            string columnList = "";
            for (int i = 0; i < columns.Length; i++)
                columnList += $"{columns[i]}" + (i < columns.Length - 1 ? "," : "");
            this.query += $"SELECT {columnList} FROM {tableName} ";
            return this;
        }
        public QueryBuilder SelectMax(string columnName,string tableName)
        {

            this.query += $"SELECT {columnName} FROM  {tableName} ";
            return this;
        }
        public QueryBuilder InsertInto(string tableName, params Param[] @params)
        {
            if (@params.Length <= 0) return this;

            this.query += $"INSERT INTO {tableName}(";
            for (int i = 0; i < @params.Length; i++)
                this.query += $"{@params[i].name}" + (i< @params.Length -1?",":"");
            this.query += ") VALUES (";

            for (int i = 0; i < @params.Length; i++)
                this.query += $"@{@params[i].name}" + (i < @params.Length - 1 ? "," : "");

            this.query.Remove(this.query.Length - 1);
            this.query += ")";
            return this;
        }

        public QueryBuilder Update(string tableName, params Param[] @params)
        {
            if (@params.Length <= 0) return this;

            this.query += $"UPDATE {tableName} SET ";
            for (int i = 0; i < @params.Length; i++)
            {

                this.query += $"{@params[i].name} = @{@params[i].name}" + (i < @params.Length - 1 ? ", " : " ");
            }


            
            return this;
        }

        public QueryBuilder Delete(string tableName)
        {

            this.query += $"DELETE FROM {tableName} ";
          
            return this;
        }
        public QueryBuilder Where(string columnName)
        {
            this.query += $"WHERE {columnName} ";
            return this;
        }
        public QueryBuilder EqualsTo(object value)
        {
            this.query += $" = {value.ToString()} ";
            return this;
        }
        public QueryBuilder NotEqualsTo(object value)
        {
            this.query += $" != {value.ToString()} ";
            return this;
        }
        public QueryBuilder And(string columnName)
        {
            this.query += $"AND {columnName} ";
            return this;
        }
        public QueryBuilder BETWEEN(object valueMin, object valueMax)
        {
            this.query += $"BETWEEN {valueMin.ToString()} AND {valueMax.ToString()} ";
            return this;
        }

        public QueryBuilder Or(string columnName)
        {
            this.query += $"OR {columnName} ";
            return this;
        }

        public QueryBuilder Custom(string q)
        {
            this.query += $"{q} ";
            return this;
        }
        public QueryBuilder OrderBy(string columnName,bool isASC)
        {
            this.query += $"ORDER BY {columnName} " + (isASC ? "ASC" : "DESC") + " ";
            return this;
        }
        public QueryBuilder Limit(int l)
        {
            this.query += $"LIMIT {l} ";
            return this;
        }
        public QueryBuilder NotIn(QueryBuilder qb)
        {
            this.query += $"NOT IN ({qb.ToString()}) ";
            return this;
        }
        public QueryBuilder In(QueryBuilder qb)
        {
            this.query += $"IN ({qb.ToString()}) ";
            return this;
        }
        public QueryBuilder IsNull()
        {
            this.query += "IS NULL ";
            return this;
        }
        public override string ToString()
        {
            Console.WriteLine(query);
            return query;
        }

    }
}
