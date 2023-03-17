using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Analytics_TestCase
{
    public partial class DbEditor : Form
    {
        Dictionary<string, TableModel> tableModels;

        public DbEditor()
        {
            InitializeComponent();

            // Model
            allFields = new Dictionary<int, Fields>();
            allFields.Add(0, fields1);
            allFields.Add(1, fields2);
            allFields.Add(2, fields3);
            allFields.Add(3, fields4);
            allFields.Add(4, fields5);
            allFields.Add(5, fields6);
            allFields.Add(6, fields7);
            allFields.Add(7, fields8);
            allFields.Add(8, fields9);
            allFields.Add(9, fields10);
            allFields.Add(10, fields11);
            allFields.Add(11, fields12);
            allFields.Add(12, fields14);
            allFields.Add(13, fields16);

            tableModels = new Dictionary<string, TableModel>();
            // Model
        }

        /// <summary>
        /// Loads tablenames
        /// </summary>
        private void DbEditor_Load(object sender, EventArgs e)
        {

            var sql = $@"SELECT TABLE_NAME
                        FROM INFORMATION_SCHEMA.TABLES
                        WHERE TABLE_TYPE = 'BASE TABLE'";

            var data = DBWorker.DoQuery(sql);

            if (data == null || data.Count == 0)
            {
                MessageBox.Show("Troubles with connection. Try another database");
            }

            var tableNames = new List<TreeNode>();

            foreach (var d in data)
            {
                string name = (string)d[0];
                tableNames.Add(new TreeNode(name));
                tableModels.Add(name, new TableModel(name));
            }

            treeViewTableNames.Nodes.AddRange(tableNames.ToArray());

        }

        private void treeViewTableNames_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var tableName = e.Node.Text;

            FillRows(tableName);

        }

        /// <summary>
        /// Fills rows
        /// Connects to DataBase if table is not downloaded already
        /// To force sync with DB pass false as checkIfEmpty
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="checkIfEmpty">Check if table is already loaded</param>
        private void FillRows(string tableName, bool checkIfEmpty = true)
        {
            ClearAndHideFields();

            var model = tableModels[tableName];

            model.Init(tableName, checkIfEmpty);

            tableNameLabel.Text = tableName;

            var rows = model.Rows;

            for (int i = 0; i < model.NumOfRows(); i++)
            {
                allFields[i].Row = rows[i];
                allFields[i].Visible = true;
            }
        }

        /// <summary>
        /// For proper view refresh the fields before inserting value
        /// </summary>
        private void ClearAndHideFields()
        {
            foreach (var f in allFields.Values)
            {
                f.Row = new RowModel();
                f.Visible = false;
            }
        }

        /// <summary>
        /// Create DataTable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            var newTable = new TableModel();
            new FormCreateTable(newTable).ShowDialog();

            try
            {
                DBWorker.DoQuery(newTable.CreateScriptBuilder());
                treeViewTableNames.Nodes.Add(newTable.CurrentTableName);
                tableModels.Add(newTable.CurrentTableName, newTable);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Drops table
        /// </summary>
        private void buttonDelete_Click(object sender, EventArgs e)
        {

            String query = $@"DROP TABLE {tableModels[tableNameLabel.Text]}";
            try
            {
                DBWorker.DoQuery(query);
                tableModels.Remove(tableNameLabel.Text);
                treeViewTableNames.SelectedNode.Remove();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + "\n Consider granting permissions");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Renames table
        /// </summary>
        private void buttonRename_Click(object sender, EventArgs e)
        {
            string oldName = new String(tableNameLabel.Text.ToCharArray());

            new FormRenameTable(tableNameLabel).ShowDialog();

            try
            {
                DBWorker.DoNonQuery($"exec sp_rename {oldName}, {tableNameLabel.Text}");

                UpdateTableModelAndView(oldName);
            }
            catch (SqlException)
            {
                tableNameLabel.Text = oldName;
                MessageBox.Show("Unable to alter name");
            }
        }

        /// <summary>
        /// Updates tree node text and model entity
        /// </summary>
        /// <param name="oldName">Old table name</param>
        private void UpdateTableModelAndView(string oldName)
        {
            treeViewTableNames.SelectedNode.Text = tableNameLabel.Text;

            var newModel = tableModels[oldName];
            newModel.CurrentTableName = tableNameLabel.Text;

            tableModels.Add(tableNameLabel.Text, newModel);

            tableModels.Remove(oldName);
        }
    }
}
