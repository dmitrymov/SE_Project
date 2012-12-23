namespace WindowsFormsApplication13
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 500D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(30D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 500D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, 480D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(6D, 400D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(9D, 400D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(12D, 380D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(15D, 310D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(18D, 270D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(21D, 240D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(24D, 200D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(27D, 140D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(30D, 50D);
            this.database1DataSet1 = new WindowsFormsApplication13.Database1DataSet1();
            this.storyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storyTableAdapter = new WindowsFormsApplication13.Database1DataSet1TableAdapters.StoryTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication13.Database1DataSet1TableAdapters.TableAdapterManager();
            this.storyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.storyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.programmerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programmerTableAdapter = new WindowsFormsApplication13.Database1DataSet1TableAdapters.ProgrammerTableAdapter();
            this.sprintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sprintTableAdapter = new WindowsFormsApplication13.Database1DataSet1TableAdapters.SprintTableAdapter();
            this.storyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.taskDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnProgramerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProgramerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnExpectedWorkingHouers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnActualWorkingHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRisk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.teamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeMamberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sprintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSprintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSprintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskTableAdapter = new WindowsFormsApplication13.Database1DataSet1TableAdapters.TaskTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storyBindingNavigator)).BeginInit();
            this.storyBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programmerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprintBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storyDataGridView)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storyBindingSource
            // 
            this.storyBindingSource.DataMember = "Story";
            this.storyBindingSource.DataSource = this.database1DataSet1;
            // 
            // storyTableAdapter
            // 
            this.storyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DateTableAdapter = null;
            this.tableAdapterManager.ProgrammerTableAdapter = null;
            this.tableAdapterManager.SprintTableAdapter = null;
            this.tableAdapterManager.Story_In_SprintTableAdapter = null;
            this.tableAdapterManager.StoryTableAdapter = this.storyTableAdapter;
            this.tableAdapterManager.TaskTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication13.Database1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Work_hoursTableAdapter = null;
            // 
            // storyBindingNavigator
            // 
            this.storyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.storyBindingNavigator.BindingSource = this.storyBindingSource;
            this.storyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.storyBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.storyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.storyBindingNavigatorSaveItem});
            this.storyBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.storyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.storyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.storyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.storyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.storyBindingNavigator.Name = "storyBindingNavigator";
            this.storyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.storyBindingNavigator.Size = new System.Drawing.Size(1055, 25);
            this.storyBindingNavigator.TabIndex = 0;
            this.storyBindingNavigator.Text = "bindingNavigator1";
            this.storyBindingNavigator.RefreshItems += new System.EventHandler(this.storyBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // storyBindingNavigatorSaveItem
            // 
            this.storyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.storyBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("storyBindingNavigatorSaveItem.Image")));
            this.storyBindingNavigatorSaveItem.Name = "storyBindingNavigatorSaveItem";
            this.storyBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.storyBindingNavigatorSaveItem.Text = "Save Data";
            this.storyBindingNavigatorSaveItem.Click += new System.EventHandler(this.storyBindingNavigatorSaveItem_Click);
            // 
            // programmerBindingSource
            // 
            this.programmerBindingSource.DataMember = "Programmer";
            this.programmerBindingSource.DataSource = this.database1DataSet1;
            // 
            // programmerTableAdapter
            // 
            this.programmerTableAdapter.ClearBeforeFill = true;
            // 
            // sprintBindingSource
            // 
            this.sprintBindingSource.DataMember = "Sprint";
            this.sprintBindingSource.DataSource = this.database1DataSet1;
            // 
            // sprintTableAdapter
            // 
            this.sprintTableAdapter.ClearBeforeFill = true;
            // 
            // storyDataGridView
            // 
            this.storyDataGridView.AutoGenerateColumns = false;
            this.storyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.storyDataGridView.DataSource = this.storyBindingSource;
            this.storyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storyDataGridView.Location = new System.Drawing.Point(3, 3);
            this.storyDataGridView.Name = "storyDataGridView";
            this.storyDataGridView.Size = new System.Drawing.Size(1041, 485);
            this.storyDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Story_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Story_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 73;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Story_Owner";
            this.dataGridViewTextBoxColumn2.HeaderText = "Story_Owner";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Story_Current_Sprint";
            this.dataGridViewTextBoxColumn3.HeaderText = "Story_Current_Sprint";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 129;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Story_Demo_DES";
            this.dataGridViewTextBoxColumn4.HeaderText = "Story_Demo_DES";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 118;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Story_Description";
            this.dataGridViewTextBoxColumn5.HeaderText = "Story_Description";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Story_Priority";
            this.dataGridViewTextBoxColumn6.HeaderText = "Story_Priority";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Story_Work_Status";
            this.dataGridViewTextBoxColumn7.HeaderText = "Story_Work_Status";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 49);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1055, 517);
            this.tabControl.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.storyDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1047, 491);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stories";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.taskDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1047, 491);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tasks";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // taskDataGridView
            // 
            this.taskDataGridView.AutoGenerateColumns = false;
            this.taskDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.taskDataGridView.DataSource = this.taskBindingSource;
            this.taskDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskDataGridView.Location = new System.Drawing.Point(3, 3);
            this.taskDataGridView.Name = "taskDataGridView";
            this.taskDataGridView.Size = new System.Drawing.Size(957, 465);
            this.taskDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Task_ID";
            this.dataGridViewTextBoxColumn8.HeaderText = "Task_ID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Task_Story_ID";
            this.dataGridViewTextBoxColumn9.HeaderText = "Task_Story_ID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Task_Priority";
            this.dataGridViewTextBoxColumn10.HeaderText = "Task_Priority";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Task_Description";
            this.dataGridViewTextBoxColumn11.HeaderText = "Task_Description";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Task_Ovner";
            this.dataGridViewTextBoxColumn12.HeaderText = "Task_Ovner";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataMember = "Task";
            this.taskBindingSource.DataSource = this.database1DataSet1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chart1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1047, 491);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sprint Proggress";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 20;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.PointDepth = 30;
            chartArea1.Area3DStyle.PointGapDepth = 10;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(40, 22);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Expected";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Real";
            series2.Points.Add(dataPoint3);
            series2.Points.Add(dataPoint4);
            series2.Points.Add(dataPoint5);
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series2.Points.Add(dataPoint11);
            series2.Points.Add(dataPoint12);
            series2.Points.Add(dataPoint13);
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(896, 401);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1047, 491);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Story Proggress";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1047, 491);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Summery";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnProgramerId,
            this.ColumnProgramerName,
            this.ColumnExpectedWorkingHouers,
            this.ColumnActualWorkingHours,
            this.ColumnRisk});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(957, 465);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnProgramerId
            // 
            this.ColumnProgramerId.HeaderText = "Column1";
            this.ColumnProgramerId.Name = "ColumnProgramerId";
            this.ColumnProgramerId.ReadOnly = true;
            this.ColumnProgramerId.Visible = false;
            // 
            // ColumnProgramerName
            // 
            this.ColumnProgramerName.HeaderText = "Name";
            this.ColumnProgramerName.Name = "ColumnProgramerName";
            this.ColumnProgramerName.ReadOnly = true;
            // 
            // ColumnExpectedWorkingHouers
            // 
            this.ColumnExpectedWorkingHouers.HeaderText = "Expected Working Houers";
            this.ColumnExpectedWorkingHouers.Name = "ColumnExpectedWorkingHouers";
            this.ColumnExpectedWorkingHouers.ReadOnly = true;
            // 
            // ColumnActualWorkingHours
            // 
            this.ColumnActualWorkingHours.HeaderText = "Actual Working Hours";
            this.ColumnActualWorkingHours.Name = "ColumnActualWorkingHours";
            this.ColumnActualWorkingHours.ReadOnly = true;
            // 
            // ColumnRisk
            // 
            this.ColumnRisk.HeaderText = "Risk";
            this.ColumnRisk.Name = "ColumnRisk";
            this.ColumnRisk.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teamToolStripMenuItem,
            this.sprintToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1055, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // teamToolStripMenuItem
            // 
            this.teamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMemberToolStripMenuItem,
            this.removeMamberToolStripMenuItem,
            this.teamSettingsToolStripMenuItem});
            this.teamToolStripMenuItem.Name = "teamToolStripMenuItem";
            this.teamToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.teamToolStripMenuItem.Text = "Team";
            // 
            // addMemberToolStripMenuItem
            // 
            this.addMemberToolStripMenuItem.Name = "addMemberToolStripMenuItem";
            this.addMemberToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addMemberToolStripMenuItem.Text = "Add member";
            this.addMemberToolStripMenuItem.Click += new System.EventHandler(this.addMemberToolStripMenuItem_Click);
            // 
            // removeMamberToolStripMenuItem
            // 
            this.removeMamberToolStripMenuItem.Name = "removeMamberToolStripMenuItem";
            this.removeMamberToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.removeMamberToolStripMenuItem.Text = "Remove mamber";
            // 
            // teamSettingsToolStripMenuItem
            // 
            this.teamSettingsToolStripMenuItem.Name = "teamSettingsToolStripMenuItem";
            this.teamSettingsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.teamSettingsToolStripMenuItem.Text = "Team settings";
            this.teamSettingsToolStripMenuItem.Click += new System.EventHandler(this.teamSettingsToolStripMenuItem_Click);
            // 
            // sprintToolStripMenuItem
            // 
            this.sprintToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSprintToolStripMenuItem,
            this.editSprintToolStripMenuItem});
            this.sprintToolStripMenuItem.Name = "sprintToolStripMenuItem";
            this.sprintToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.sprintToolStripMenuItem.Text = "Sprint";
            // 
            // newSprintToolStripMenuItem
            // 
            this.newSprintToolStripMenuItem.Name = "newSprintToolStripMenuItem";
            this.newSprintToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newSprintToolStripMenuItem.Text = "New Sprint";
            this.newSprintToolStripMenuItem.Click += new System.EventHandler(this.newSprintToolStripMenuItem_Click);
            // 
            // editSprintToolStripMenuItem
            // 
            this.editSprintToolStripMenuItem.Name = "editSprintToolStripMenuItem";
            this.editSprintToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.editSprintToolStripMenuItem.Text = "Edit Sprint";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowOptionsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // windowOptionsToolStripMenuItem
            // 
            this.windowOptionsToolStripMenuItem.Name = "windowOptionsToolStripMenuItem";
            this.windowOptionsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.windowOptionsToolStripMenuItem.Text = "Window options";
            // 
            // taskTableAdapter
            // 
            this.taskTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 566);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.storyBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "2";
            this.Load += new System.EventHandler(this.Form1_Load);
          
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storyBindingNavigator)).EndInit();
            this.storyBindingNavigator.ResumeLayout(false);
            this.storyBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programmerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprintBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storyDataGridView)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taskDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource storyBindingSource;
        private Database1DataSet1TableAdapters.StoryTableAdapter storyTableAdapter;
        private Database1DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator storyBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton storyBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource programmerBindingSource;
        private Database1DataSet1TableAdapters.ProgrammerTableAdapter programmerTableAdapter;
        private System.Windows.Forms.BindingSource sprintBindingSource;
        private Database1DataSet1TableAdapters.SprintTableAdapter sprintTableAdapter;
        private System.Windows.Forms.DataGridView storyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem teamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeMamberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sprintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSprintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSprintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowOptionsToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.BindingSource taskBindingSource;
        private Database1DataSet1TableAdapters.TaskTableAdapter taskTableAdapter;
        private System.Windows.Forms.DataGridView taskDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.ToolStripMenuItem teamSettingsToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProgramerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProgramerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnExpectedWorkingHouers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnActualWorkingHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRisk;

    }
}

