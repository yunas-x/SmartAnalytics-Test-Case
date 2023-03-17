using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Analytics_TestCase
{
    public partial class FormCreateTable : Form
    {
        TableModel model;
        Dictionary<int, Fields> allFields;

        public FormCreateTable(TableModel model)
        {
            this.model = model;
            InitializeComponent();

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
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Enter name");
                return;
            }

            model.CurrentTableName = textBox1.Text;


            foreach (var v in allFields.Values)
            {
                if (!v.IsEmpty())
                {
                    model.AddRow(v.Row);
                }

            }


            Close();
        }
    }
}
