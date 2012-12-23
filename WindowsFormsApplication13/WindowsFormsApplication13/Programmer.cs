using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication13
{
    public partial class Programmer : Form
    {
        public Programmer()
        {
            InitializeComponent();
        }

        private void programmerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.programmerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet1);
            this.tableAdapterManager.ProgrammerTableAdapter.GetData();
            //var a = database1DataSet1.GetChanges();
            DataManager.update_programmer_name(3, "asd");

        }

        private void Programmer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Programmer' table. You can move, or remove it, as needed.
            this.programmerTableAdapter.Fill(this.database1DataSet1.Programmer);

        }
    }
}
