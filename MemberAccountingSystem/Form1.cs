using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemberAccountingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void memberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.memberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mASDatabaseDataSet);

        }

        private void MASForm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mASDatabaseDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.mASDatabaseDataSet.Member);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.memberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mASDatabaseDataSet);
        }
    }
}
