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
    public partial class FormAddRow : Form
    {
        RowModel row;

        public FormAddRow(RowModel row)
        {
            InitializeComponent();
            this.row = row;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (fields1.IsEmpty())
            {
                MessageBox.Show("Fill required");
            }
            else
            {
                row.IsKey = fields1.Row.IsKey;
                row.Name = fields1.Row.Name;
                row.Type = fields1.Row.Type;
            }

            Close();
        }
    }
}
