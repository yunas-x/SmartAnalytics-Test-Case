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
    public partial class FormRenameTable : Form
    {
        public FormRenameTable(Label name)
        {
            InitializeComponent();
            textBoxName.Text = name.Text;
            this.name = name;
        }

        Label name;

        private void button1_Click(object sender, EventArgs e)
        {
            name.Text = textBoxName.Text;
            Close();
        }
    }
}
