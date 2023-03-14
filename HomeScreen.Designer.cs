using System.Windows.Forms;

namespace Employee_Details
{
    partial class HomeScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.HS_dataGridView = new System.Windows.Forms.DataGridView();
            this.HS_addButton = new System.Windows.Forms.Button();
            this.HS_updateButton = new System.Windows.Forms.Button();
            this.HS_deleteButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.search_nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.search_ExperienceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.search_JobTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.search_emailTextBox = new System.Windows.Forms.TextBox();
            this.search_LocationTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mem_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_experience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.HS_dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HS_dataGridView
            // 
            this.HS_dataGridView.AllowUserToDeleteRows = false;
            this.HS_dataGridView.AllowUserToResizeColumns = false;
            this.HS_dataGridView.AllowUserToResizeRows = false;
            this.HS_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HS_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.HS_dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.HS_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HS_dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.HS_dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HS_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.HS_dataGridView.ColumnHeadersHeight = 30;
            this.HS_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.mem_name,
            this.DGV_email,
            this.DGV_title,
            this.DGV_experience,
            this.DGV_location});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.HS_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.HS_dataGridView.EnableHeadersVisualStyles = false;
            this.HS_dataGridView.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.HS_dataGridView.Location = new System.Drawing.Point(19, 228);
            this.HS_dataGridView.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.HS_dataGridView.MultiSelect = false;
            this.HS_dataGridView.Name = "HS_dataGridView";
            this.HS_dataGridView.ReadOnly = true;
            this.HS_dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HS_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.HS_dataGridView.RowHeadersVisible = false;
            this.HS_dataGridView.RowTemplate.Height = 30;
            this.HS_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HS_dataGridView.ShowEditingIcon = false;
            this.HS_dataGridView.Size = new System.Drawing.Size(695, 282);
            this.HS_dataGridView.TabIndex = 0;
            this.HS_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HS_dataGridView_CellContentClick);
            // 
            // HS_addButton
            // 
            this.HS_addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HS_addButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HS_addButton.BackColor = System.Drawing.Color.ForestGreen;
            this.HS_addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HS_addButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HS_addButton.Location = new System.Drawing.Point(727, 228);
            this.HS_addButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.HS_addButton.MinimumSize = new System.Drawing.Size(117, 35);
            this.HS_addButton.Name = "HS_addButton";
            this.HS_addButton.Size = new System.Drawing.Size(117, 35);
            this.HS_addButton.TabIndex = 1;
            this.HS_addButton.Text = "Add New";
            this.HS_addButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.HS_addButton.UseVisualStyleBackColor = false;
            this.HS_addButton.Click += new System.EventHandler(this.HS_addButton_Click);
            // 
            // HS_updateButton
            // 
            this.HS_updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HS_updateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HS_updateButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.HS_updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HS_updateButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HS_updateButton.Location = new System.Drawing.Point(727, 272);
            this.HS_updateButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.HS_updateButton.MinimumSize = new System.Drawing.Size(117, 35);
            this.HS_updateButton.Name = "HS_updateButton";
            this.HS_updateButton.Size = new System.Drawing.Size(117, 35);
            this.HS_updateButton.TabIndex = 2;
            this.HS_updateButton.Text = "Update";
            this.HS_updateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.HS_updateButton.UseVisualStyleBackColor = false;
            this.HS_updateButton.Click += new System.EventHandler(this.HS_updateButton_Click);
            // 
            // HS_deleteButton
            // 
            this.HS_deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HS_deleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HS_deleteButton.BackColor = System.Drawing.Color.Red;
            this.HS_deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HS_deleteButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HS_deleteButton.Location = new System.Drawing.Point(727, 316);
            this.HS_deleteButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.HS_deleteButton.MinimumSize = new System.Drawing.Size(117, 35);
            this.HS_deleteButton.Name = "HS_deleteButton";
            this.HS_deleteButton.Size = new System.Drawing.Size(117, 35);
            this.HS_deleteButton.TabIndex = 3;
            this.HS_deleteButton.Text = "Delete";
            this.HS_deleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.HS_deleteButton.UseVisualStyleBackColor = false;
            this.HS_deleteButton.Click += new System.EventHandler(this.HS_deleteButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.resetButton);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.search_LocationTextBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.search_emailTextBox);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.search_nameTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.search_ExperienceTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.search_JobTitle);
            this.panel1.Location = new System.Drawing.Point(21, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 150);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(234, 67);
            this.label11.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 19);
            this.label11.TabIndex = 31;
            this.label11.Text = "(in years)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // search_nameTextBox
            // 
            this.search_nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.search_nameTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_nameTextBox.Location = new System.Drawing.Point(106, 17);
            this.search_nameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.search_nameTextBox.Name = "search_nameTextBox";
            this.search_nameTextBox.Size = new System.Drawing.Size(193, 26);
            this.search_nameTextBox.TabIndex = 26;
            this.search_nameTextBox.WordWrap = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "Experience:";
            // 
            // search_ExperienceTextBox
            // 
            this.search_ExperienceTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.search_ExperienceTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_ExperienceTextBox.Location = new System.Drawing.Point(106, 64);
            this.search_ExperienceTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.search_ExperienceTextBox.Name = "search_ExperienceTextBox";
            this.search_ExperienceTextBox.Size = new System.Drawing.Size(128, 26);
            this.search_ExperienceTextBox.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "Job Title:";
            // 
            // search_JobTitle
            // 
            this.search_JobTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.search_JobTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_JobTitle.Location = new System.Drawing.Point(106, 107);
            this.search_JobTitle.Name = "search_JobTitle";
            this.search_JobTitle.Size = new System.Drawing.Size(193, 26);
            this.search_JobTitle.TabIndex = 29;
            this.search_JobTitle.WordWrap = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(349, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 32;
            this.label3.Text = "Email:";
            // 
            // search_emailTextBox
            // 
            this.search_emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.search_emailTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_emailTextBox.Location = new System.Drawing.Point(418, 17);
            this.search_emailTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.search_emailTextBox.Name = "search_emailTextBox";
            this.search_emailTextBox.Size = new System.Drawing.Size(192, 26);
            this.search_emailTextBox.TabIndex = 33;
            // 
            // search_LocationTextBox
            // 
            this.search_LocationTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.search_LocationTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_LocationTextBox.Location = new System.Drawing.Point(418, 66);
            this.search_LocationTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.search_LocationTextBox.Name = "search_LocationTextBox";
            this.search_LocationTextBox.Size = new System.Drawing.Size(192, 26);
            this.search_LocationTextBox.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(349, 70);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 19);
            this.label10.TabIndex = 35;
            this.label10.Text = "Location:";
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchButton.Location = new System.Drawing.Point(663, 21);
            this.searchButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.searchButton.MinimumSize = new System.Drawing.Size(117, 35);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(117, 35);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // topPanel
            // 
            this.topPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.topPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.topPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.topPanel.Controls.Add(this.label8);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(863, 49);
            this.topPanel.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(328, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(207, 45);
            this.label8.TabIndex = 4;
            this.label8.Text = "Dashboard";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetButton
            // 
            this.resetButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resetButton.BackColor = System.Drawing.Color.Orchid;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.resetButton.Location = new System.Drawing.Point(663, 74);
            this.resetButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.resetButton.MinimumSize = new System.Drawing.Size(117, 35);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(117, 35);
            this.resetButton.TabIndex = 36;
            this.resetButton.Text = "Reset";
            this.resetButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 41;
            // 
            // mem_name
            // 
            this.mem_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mem_name.HeaderText = "Name";
            this.mem_name.Name = "mem_name";
            this.mem_name.ReadOnly = true;
            this.mem_name.Width = 67;
            // 
            // DGV_email
            // 
            this.DGV_email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DGV_email.HeaderText = "Email";
            this.DGV_email.Name = "DGV_email";
            this.DGV_email.ReadOnly = true;
            // 
            // DGV_title
            // 
            this.DGV_title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DGV_title.HeaderText = "Job Title";
            this.DGV_title.Name = "DGV_title";
            this.DGV_title.ReadOnly = true;
            // 
            // DGV_experience
            // 
            this.DGV_experience.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DGV_experience.FillWeight = 30F;
            this.DGV_experience.HeaderText = "Experience (years)";
            this.DGV_experience.Name = "DGV_experience";
            this.DGV_experience.ReadOnly = true;
            this.DGV_experience.Width = 143;
            // 
            // DGV_location
            // 
            this.DGV_location.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DGV_location.HeaderText = "Location";
            this.DGV_location.Name = "DGV_location";
            this.DGV_location.ReadOnly = true;
            this.DGV_location.Width = 82;
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 522);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HS_deleteButton);
            this.Controls.Add(this.HS_updateButton);
            this.Controls.Add(this.HS_addButton);
            this.Controls.Add(this.HS_dataGridView);
            this.Name = "HomeScreen";
            this.Text = "HomeScreen";
            ((System.ComponentModel.ISupportInitialize)(this.HS_dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView HS_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Name;
        private Button HS_addButton;
        private Button HS_updateButton;
        private Button HS_deleteButton;
        private Panel panel1;
        private Label label11;
        private TextBox search_nameTextBox;
        private Label label1;
        private Label label2;
        private TextBox search_ExperienceTextBox;
        private Label label4;
        private TextBox search_JobTitle;
        private Label label3;
        private TextBox search_emailTextBox;
        private TextBox search_LocationTextBox;
        private Label label10;
        private Button searchButton;
        private Panel topPanel;
        private Label label8;
        private Button resetButton;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn mem_name;
        private DataGridViewTextBoxColumn DGV_email;
        private DataGridViewTextBoxColumn DGV_title;
        private DataGridViewTextBoxColumn DGV_experience;
        private DataGridViewTextBoxColumn DGV_location;
    }
}