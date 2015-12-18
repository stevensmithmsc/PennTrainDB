using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PennTrainDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void coursesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.coursesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.staffDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'staffDataSet.Req' table. You can move, or remove it, as needed.
            this.reqTableAdapter.Fill(this.staffDataSet.Req);
            // TODO: This line of code loads data into the 'staffDataSet.Sess' table. You can move, or remove it, as needed.
            this.sessTableAdapter.Fill(this.staffDataSet.Sess);
            // TODO: This line of code loads data into the 'staffDataSet.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.staffDataSet.Courses);

        }
    }
}
