﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void programmerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

            this.tableAdapterManager.UpdateAll(this.database1DataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            //Form1Window.InitializeComponent();
           

            //Thread.Sleep(3000);

            //Form1Window.Dispose();

            //Form1Window.progressBar1.Increment(10);

            /*
            Thread.Sleep(1000);
            progressBar1.Increment(20);
            Thread.Sleep(1000);
            progressBar1.Increment(10);
            Thread.Sleep(1000);
            progressBar1.Increment(50);
            Thread.Sleep(1000);
            progressBar1.Increment(10);
            */


            // TODO: This line of code loads data into the 'database1DataSet1.Task' table. You can move, or remove it, as needed.
            this.taskTableAdapter.Fill(this.database1DataSet1.Task);
            // TODO: This line of code loads data into the 'database1DataSet1.Sprint' table. You can move, or remove it, as needed.
            this.sprintTableAdapter.Fill(this.database1DataSet1.Sprint);
            // TODO: This line of code loads data into the 'database1DataSet1.Programmer' table. You can move, or remove it, as needed.
            this.programmerTableAdapter.Fill(this.database1DataSet1.Programmer);
            // TODO: This line of code loads data into the 'database1DataSet1.Story' table. You can move, or remove it, as needed.
            this.storyTableAdapter.Fill(this.database1DataSet1.Story);
            // TODO: This line of code loads data into the 'database1DataSet1.Programmer' table. You can move, or remove it, as needed.

        }

        private void storyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.storyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet1);

        }

        private void addMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Programmer progWindow = new Programmer();
            progWindow.Show();
        }

        private void newSprintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSprint NewSprintWindow = new NewSprint();
            NewSprintWindow.Show();
        }

        private void teamSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void storyBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }



    }
}
