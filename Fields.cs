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
    public partial class Fields : UserControl
    {
        public Fields()
        {
            InitializeComponent();
        }

        private RowModel row;
        public RowModel Row
        {
            set
            {
                row = value;
                if (row != null)
                {
                    isKey.Checked = row.IsKey;
                    valtype.Text = row.Type;
                    name.Text = row.Name;
                }

            }
            get => row;
        }

        public bool IsEmpty()
        {
            return String.IsNullOrWhiteSpace(name.Text)
                && String.IsNullOrWhiteSpace(valtype.Text);
        }

        private void isKey_CheckedChanged(object sender, EventArgs e)
        {
            if (Row == null) Row = new RowModel();
            Row.IsKey = isKey.Checked;
        }

        private void valtype_TextChanged(object sender, EventArgs e)
        {
            if (Row == null) Row = new RowModel();
            Row.Type = valtype.Text;
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            if (Row == null) Row = new RowModel();
            Row.Name = name.Text;
        }
    }
}
