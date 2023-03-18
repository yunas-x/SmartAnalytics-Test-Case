using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Analytics_TestCase
{
    public class TableModel
    {
        public const int NUM_ROWS = 14;

        private string tableName;

        /// <summary>
        /// Sets table name
        /// If value is null or empty (all-whitespace) string, raises exception
        /// </summary>
        public string CurrentTableName
        {
            get => tableName;
            set 
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Invalid name. Pass valid string");
                else
                {
                    tableName = value;
                }
            }
        }

        private RowModel[] rows;

        public RowModel[] Rows
        {
            private set
            {
                rows = new RowModel[NUM_ROWS];
                if (value != null && value.Length > 0)
                    value.CopyTo(rows, 0);
            }
            get
            {
                return rows;
            }
        }

        public TableModel(string name)
        {
            CurrentTableName = name;
            rows = new RowModel[NUM_ROWS];
        }

        public TableModel()
        {
            tableName = String.Empty;
            rows = new RowModel[NUM_ROWS];
        }

        public TableModel(string name, RowModel[] rows)
        {
            CurrentTableName = name;
            Rows = rows;
        }


        /// <summary>
        /// Initializes table from DataBase (if not already loaded)
        /// </summary>
        /// <param name="name">table name</param>
        public void Init(string name)
        {
            rows = new RowModel[NUM_ROWS];

            var sql = $@"SELECT COLUMN_NAME, DATA_TYPE
                        FROM INFORMATION_SCHEMA.COLUMNS
                        WHERE TABLE_NAME = '{tableName}'";

            var data = DBWorker.DoQuery(sql);

            var sqlKey = $@"select C.COLUMN_NAME FROM  
                        INFORMATION_SCHEMA.TABLE_CONSTRAINTS T  
                        JOIN INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE C  
                        ON C.CONSTRAINT_NAME=T.CONSTRAINT_NAME  
                        WHERE  
                        C.TABLE_NAME='{tableName}'
                        and T.CONSTRAINT_TYPE='PRIMARY KEY'";

            var dataKey = DBWorker.DoQuery(sqlKey);

            var i = 0;
            foreach (var d in data)
            {
                RowModel row = new RowModel((string)d[0],
                                            (string)d[1],
                                            isColumnAKey(d[0], dataKey));

                rows[i] = row;
                i++;
            }
        }

        public string CreateScriptBuilder()
        {
            if (String.IsNullOrEmpty(tableName))
                return String.Empty;

            var query = $"CREATE TABLE {tableName} (";

            foreach (var r in rows)
            {
                if (r != null)
                {
                    query += $"{r.Name} {r.Type}";

                    if (r.IsKey)
                        query += "PRIMARY KEY";

                    query += ", ";
                }

            }

            query += ");";

            return query;
        }

        public int NumOfRows()
        {
            int i = 0;
            foreach (var r in rows)
            {
                if (r != null)
                    i++;
            }

            return i;
        }

        private static bool isColumnAKey(object col, List<object[]> keyCols)
        {
            foreach (var o in keyCols)
            {
                if ((string)col == (string)o[0])
                    return true;
            }

            return false;
        }


        /// <summary>
        /// Adds row to table model
        /// </summary>
        /// <param name="row">Row to add</param>
        /// <returns>result of operation. True on success? otherwise false</returns>
        public bool AddRow(RowModel row)
        {
            int i = 0;
            while (rows[i] != null)
            {
                i++;
                if (i == NUM_ROWS)
                    return false;
            }
            rows[i] = row;

            return true;
        }

    }
}
