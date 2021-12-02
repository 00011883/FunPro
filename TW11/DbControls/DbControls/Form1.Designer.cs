﻿namespace DbControls
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
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label dobLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label gradeLevelLabel;
            System.Windows.Forms.Label countryIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            this.dbDataSet = new DbControls.dbDataSet();
            this.tbTeacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbTeacherTableAdapter = new DbControls.dbDataSetTableAdapters.tbTeacherTableAdapter();
            this.tableAdapterManager = new DbControls.dbDataSetTableAdapters.TableAdapterManager();
            this.tbCountryTableAdapter = new DbControls.dbDataSetTableAdapters.tbCountryTableAdapter();
            this.tbTeacherBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tbTeacherBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.dobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbCountryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbNewIsActive = new System.Windows.Forms.CheckBox();
            this.tbxNewPhone = new System.Windows.Forms.TextBox();
            this.dtpNewDob = new System.Windows.Forms.DateTimePicker();
            this.tbxNewLastName = new System.Windows.Forms.TextBox();
            this.tbxNewFirstName = new System.Windows.Forms.TextBox();
            this.nudNewGrade = new System.Windows.Forms.NumericUpDown();
            this.cbxNewCountry = new System.Windows.Forms.ComboBox();
            this.tbCountryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxFilter = new System.Windows.Forms.TextBox();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            dobLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            gradeLevelLabel = new System.Windows.Forms.Label();
            countryIdLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTeacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTeacherBindingNavigator)).BeginInit();
            this.tbTeacherBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCountryBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCountryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(249, 61);
            firstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(57, 13);
            firstNameLabel.TabIndex = 4;
            firstNameLabel.Text = "first Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(249, 84);
            lastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(57, 13);
            lastNameLabel.TabIndex = 6;
            lastNameLabel.Text = "last Name:";
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Location = new System.Drawing.Point(249, 108);
            dobLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new System.Drawing.Size(28, 13);
            dobLabel.TabIndex = 8;
            dobLabel.Text = "dob:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(249, 130);
            phoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(40, 13);
            phoneLabel.TabIndex = 10;
            phoneLabel.Text = "phone:";
            // 
            // gradeLevelLabel
            // 
            gradeLevelLabel.AutoSize = true;
            gradeLevelLabel.Location = new System.Drawing.Point(249, 152);
            gradeLevelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            gradeLevelLabel.Name = "gradeLevelLabel";
            gradeLevelLabel.Size = new System.Drawing.Size(66, 13);
            gradeLevelLabel.TabIndex = 12;
            gradeLevelLabel.Text = "grade Level:";
            // 
            // countryIdLabel
            // 
            countryIdLabel.AutoSize = true;
            countryIdLabel.Location = new System.Drawing.Point(249, 199);
            countryIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            countryIdLabel.Name = "countryIdLabel";
            countryIdLabel.Size = new System.Drawing.Size(57, 13);
            countryIdLabel.TabIndex = 16;
            countryIdLabel.Text = "country Id:";
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbTeacherBindingSource
            // 
            this.tbTeacherBindingSource.DataMember = "tbTeacher";
            this.tbTeacherBindingSource.DataSource = this.dbDataSet;
            this.tbTeacherBindingSource.CurrentChanged += new System.EventHandler(this.tbTeacherBindingSource_CurrentChanged);
            // 
            // tbTeacherTableAdapter
            // 
            this.tbTeacherTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbCountryTableAdapter = this.tbCountryTableAdapter;
            this.tableAdapterManager.tbTeacherTableAdapter = this.tbTeacherTableAdapter;
            this.tableAdapterManager.UpdateOrder = DbControls.dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbCountryTableAdapter
            // 
            this.tbCountryTableAdapter.ClearBeforeFill = true;
            // 
            // tbTeacherBindingNavigator
            // 
            this.tbTeacherBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbTeacherBindingNavigator.BindingSource = this.tbTeacherBindingSource;
            this.tbTeacherBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbTeacherBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbTeacherBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tbTeacherBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tbTeacherBindingNavigatorSaveItem});
            this.tbTeacherBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbTeacherBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbTeacherBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbTeacherBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbTeacherBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbTeacherBindingNavigator.Name = "tbTeacherBindingNavigator";
            this.tbTeacherBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbTeacherBindingNavigator.Size = new System.Drawing.Size(896, 27);
            this.tbTeacherBindingNavigator.TabIndex = 0;
            this.tbTeacherBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tbTeacherBindingNavigatorSaveItem
            // 
            this.tbTeacherBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbTeacherBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbTeacherBindingNavigatorSaveItem.Image")));
            this.tbTeacherBindingNavigatorSaveItem.Name = "tbTeacherBindingNavigatorSaveItem";
            this.tbTeacherBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.tbTeacherBindingNavigatorSaveItem.Text = "Save Data";
            this.tbTeacherBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbTeacherBindingNavigatorSaveItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.tbTeacherBindingSource;
            this.listBox1.DisplayMember = "lastName";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(89, 89);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(156, 173);
            this.listBox1.TabIndex = 1;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbTeacherBindingSource, "firstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(318, 59);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(151, 20);
            this.firstNameTextBox.TabIndex = 5;
            this.firstNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.firstNameTextBox_Validating);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbTeacherBindingSource, "lastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(318, 82);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(151, 20);
            this.lastNameTextBox.TabIndex = 7;
            // 
            // dobDateTimePicker
            // 
            this.dobDateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.dobDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbTeacherBindingSource, "dob", true));
            this.dobDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dobDateTimePicker.Location = new System.Drawing.Point(318, 104);
            this.dobDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dobDateTimePicker.Name = "dobDateTimePicker";
            this.dobDateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.dobDateTimePicker.TabIndex = 9;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbTeacherBindingSource, "phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(318, 127);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(151, 20);
            this.phoneTextBox.TabIndex = 11;
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.isActiveCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tbTeacherBindingSource, "isActive", true));
            this.isActiveCheckBox.Location = new System.Drawing.Point(247, 173);
            this.isActiveCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(87, 20);
            this.isActiveCheckBox.TabIndex = 15;
            this.isActiveCheckBox.Text = "Active";
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbTeacherBindingSource, "gradeLevel", true));
            this.numericUpDown1.Location = new System.Drawing.Point(318, 150);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(150, 20);
            this.numericUpDown1.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbTeacherBindingSource, "countryId", true));
            this.comboBox1.DataSource = this.tbCountryBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(318, 197);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.ValueMember = "Id";
            // 
            // tbCountryBindingSource
            // 
            this.tbCountryBindingSource.DataMember = "tbCountry";
            this.tbCountryBindingSource.DataSource = this.dbDataSet;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(89, 267);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(35, 19);
            this.btnFirst.TabIndex = 20;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(129, 267);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(35, 19);
            this.btnPrevious.TabIndex = 20;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(169, 267);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(35, 19);
            this.btnNext.TabIndex = 20;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(209, 267);
            this.btnLast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(35, 19);
            this.btnLast.TabIndex = 20;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(412, 239);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 19);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(352, 239);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 19);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(label5);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.chbNewIsActive);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.tbxNewPhone);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(this.dtpNewDob);
            this.groupBox1.Controls.Add(this.cbxNewCountry);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(this.nudNewGrade);
            this.groupBox1.Controls.Add(this.tbxNewLastName);
            this.groupBox1.Controls.Add(label6);
            this.groupBox1.Controls.Add(this.tbxNewFirstName);
            this.groupBox1.Location = new System.Drawing.Point(523, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 243);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new user";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(5, 168);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(57, 13);
            label1.TabIndex = 16;
            label1.Text = "country Id:";
            // 
            // chbNewIsActive
            // 
            this.chbNewIsActive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbNewIsActive.Location = new System.Drawing.Point(3, 142);
            this.chbNewIsActive.Margin = new System.Windows.Forms.Padding(2);
            this.chbNewIsActive.Name = "chbNewIsActive";
            this.chbNewIsActive.Size = new System.Drawing.Size(87, 20);
            this.chbNewIsActive.TabIndex = 15;
            this.chbNewIsActive.Text = "Active";
            this.chbNewIsActive.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(5, 121);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(66, 13);
            label2.TabIndex = 12;
            label2.Text = "grade Level:";
            // 
            // tbxNewPhone
            // 
            this.tbxNewPhone.Location = new System.Drawing.Point(74, 96);
            this.tbxNewPhone.Margin = new System.Windows.Forms.Padding(2);
            this.tbxNewPhone.Name = "tbxNewPhone";
            this.tbxNewPhone.Size = new System.Drawing.Size(151, 20);
            this.tbxNewPhone.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(5, 99);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(40, 13);
            label3.TabIndex = 10;
            label3.Text = "phone:";
            // 
            // dtpNewDob
            // 
            this.dtpNewDob.CustomFormat = "dd-MM-yyyy";
            this.dtpNewDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNewDob.Location = new System.Drawing.Point(74, 73);
            this.dtpNewDob.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNewDob.Name = "dtpNewDob";
            this.dtpNewDob.Size = new System.Drawing.Size(151, 20);
            this.dtpNewDob.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(5, 77);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(28, 13);
            label4.TabIndex = 8;
            label4.Text = "dob:";
            // 
            // tbxNewLastName
            // 
            this.tbxNewLastName.Location = new System.Drawing.Point(74, 51);
            this.tbxNewLastName.Margin = new System.Windows.Forms.Padding(2);
            this.tbxNewLastName.Name = "tbxNewLastName";
            this.tbxNewLastName.Size = new System.Drawing.Size(151, 20);
            this.tbxNewLastName.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(5, 53);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(57, 13);
            label5.TabIndex = 6;
            label5.Text = "last Name:";
            // 
            // tbxNewFirstName
            // 
            this.tbxNewFirstName.Location = new System.Drawing.Point(74, 28);
            this.tbxNewFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.tbxNewFirstName.Name = "tbxNewFirstName";
            this.tbxNewFirstName.Size = new System.Drawing.Size(151, 20);
            this.tbxNewFirstName.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(5, 30);
            label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(57, 13);
            label6.TabIndex = 4;
            label6.Text = "first Name:";
            // 
            // nudNewGrade
            // 
            this.nudNewGrade.Location = new System.Drawing.Point(74, 119);
            this.nudNewGrade.Margin = new System.Windows.Forms.Padding(2);
            this.nudNewGrade.Name = "nudNewGrade";
            this.nudNewGrade.Size = new System.Drawing.Size(150, 20);
            this.nudNewGrade.TabIndex = 18;
            // 
            // cbxNewCountry
            // 
            this.cbxNewCountry.DataSource = this.tbCountryBindingSource1;
            this.cbxNewCountry.DisplayMember = "Name";
            this.cbxNewCountry.FormattingEnabled = true;
            this.cbxNewCountry.Location = new System.Drawing.Point(74, 166);
            this.cbxNewCountry.Margin = new System.Windows.Forms.Padding(2);
            this.cbxNewCountry.Name = "cbxNewCountry";
            this.cbxNewCountry.Size = new System.Drawing.Size(151, 21);
            this.cbxNewCountry.TabIndex = 19;
            this.cbxNewCountry.ValueMember = "Id";
            // 
            // tbCountryBindingSource1
            // 
            this.tbCountryBindingSource1.DataMember = "tbCountry";
            this.tbCountryBindingSource1.DataSource = this.dbDataSet;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(150, 203);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxFilter
            // 
            this.tbxFilter.Location = new System.Drawing.Point(89, 61);
            this.tbxFilter.Name = "tbxFilter";
            this.tbxFilter.Size = new System.Drawing.Size(156, 20);
            this.tbxFilter.TabIndex = 24;
            this.tbxFilter.TextChanged += new System.EventHandler(this.tbxFilter_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 366);
            this.Controls.Add(this.tbxFilter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(dobLabel);
            this.Controls.Add(this.dobDateTimePicker);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(gradeLevelLabel);
            this.Controls.Add(this.isActiveCheckBox);
            this.Controls.Add(countryIdLabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tbTeacherBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTeacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTeacherBindingNavigator)).EndInit();
            this.tbTeacherBindingNavigator.ResumeLayout(false);
            this.tbTeacherBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCountryBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCountryBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource tbTeacherBindingSource;
        private dbDataSetTableAdapters.tbTeacherTableAdapter tbTeacherTableAdapter;
        private dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbTeacherBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tbTeacherBindingNavigatorSaveItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.DateTimePicker dobDateTimePicker;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private dbDataSetTableAdapters.tbCountryTableAdapter tbCountryTableAdapter;
        private System.Windows.Forms.BindingSource tbCountryBindingSource;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbNewIsActive;
        private System.Windows.Forms.TextBox tbxNewPhone;
        private System.Windows.Forms.DateTimePicker dtpNewDob;
        private System.Windows.Forms.ComboBox cbxNewCountry;
        private System.Windows.Forms.NumericUpDown nudNewGrade;
        private System.Windows.Forms.TextBox tbxNewLastName;
        private System.Windows.Forms.TextBox tbxNewFirstName;
        private System.Windows.Forms.BindingSource tbCountryBindingSource1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxFilter;
    }
}

