using System;
using System.Windows.Forms;

namespace Employee_Details
{
    partial class employeeRegd

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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Add_dateTimePickr = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Add_nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Add_LocationTextBox = new System.Windows.Forms.TextBox();
            this.Add_ExperienceTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Add_emailTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Add_PhoneTextBox = new System.Windows.Forms.TextBox();
            this.Add_JobTitle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Add_genderCombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Add_ageTextBox = new System.Windows.Forms.TextBox();
            this.Add_CancelButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Add_ClearButton = new System.Windows.Forms.Button();
            this.Add_BrowseButton = new System.Windows.Forms.Button();
            this.Add_PictureBox = new System.Windows.Forms.PictureBox();
            this.Add_SaveButton = new System.Windows.Forms.Button();
            this.Add_ResetButton = new System.Windows.Forms.Button();
            this.Email_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Add_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Email_errorProvider)).BeginInit();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.topPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bottomPanel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(877, 507);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bottomPanel
            // 
            this.bottomPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bottomPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bottomPanel.Controls.Add(this.panel4);
            this.bottomPanel.Controls.Add(this.Add_CancelButton);
            this.bottomPanel.Controls.Add(this.panel3);
            this.bottomPanel.Controls.Add(this.Add_SaveButton);
            this.bottomPanel.Controls.Add(this.Add_ResetButton);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomPanel.Location = new System.Drawing.Point(3, 55);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(0);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(871, 449);
            this.bottomPanel.TabIndex = 3;
            this.bottomPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // panel4
            // 
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.Add_dateTimePickr);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.Add_nameTextBox);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.Add_LocationTextBox);
            this.panel4.Controls.Add(this.Add_ExperienceTextBox);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.Add_emailTextBox);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.Add_PhoneTextBox);
            this.panel4.Controls.Add(this.Add_JobTitle);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.Add_genderCombo);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.Add_ageTextBox);
            this.panel4.Location = new System.Drawing.Point(185, 27);
            this.panel4.Margin = new System.Windows.Forms.Padding(15, 3, 10, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(666, 241);
            this.panel4.TabIndex = 27;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // Add_dateTimePickr
            // 
            this.Add_dateTimePickr.CustomFormat = "dd/MM/yyyy";
            this.Add_dateTimePickr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_dateTimePickr.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Add_dateTimePickr.Location = new System.Drawing.Point(409, 110);
            this.Add_dateTimePickr.Name = "Add_dateTimePickr";
            this.Add_dateTimePickr.Size = new System.Drawing.Size(200, 26);
            this.Add_dateTimePickr.TabIndex = 26;
            this.Add_dateTimePickr.Value = new System.DateTime(2023, 3, 14, 0, 0, 0, 0);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(182, 113);
            this.label12.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 19);
            this.label12.TabIndex = 25;
            this.label12.Text = "(in years)";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(465, 25);
            this.label11.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 19);
            this.label11.TabIndex = 24;
            this.label11.Text = "(in years)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Add_nameTextBox
            // 
            this.Add_nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add_nameTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_nameTextBox.Location = new System.Drawing.Point(69, 25);
            this.Add_nameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.Add_nameTextBox.Name = "Add_nameTextBox";
            this.Add_nameTextBox.Size = new System.Drawing.Size(193, 26);
            this.Add_nameTextBox.TabIndex = 1;
            this.Add_nameTextBox.WordWrap = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Experience:";
            // 
            // Add_LocationTextBox
            // 
            this.Add_LocationTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add_LocationTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_LocationTextBox.Location = new System.Drawing.Point(409, 148);
            this.Add_LocationTextBox.Name = "Add_LocationTextBox";
            this.Add_LocationTextBox.Size = new System.Drawing.Size(200, 26);
            this.Add_LocationTextBox.TabIndex = 8;
            // 
            // Add_ExperienceTextBox
            // 
            this.Add_ExperienceTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add_ExperienceTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_ExperienceTextBox.Location = new System.Drawing.Point(409, 22);
            this.Add_ExperienceTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.Add_ExperienceTextBox.Name = "Add_ExperienceTextBox";
            this.Add_ExperienceTextBox.Size = new System.Drawing.Size(56, 26);
            this.Add_ExperienceTextBox.TabIndex = 2;
            this.Add_ExperienceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.add_experiencetextbox_keypress);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(341, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "Location:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // Add_emailTextBox
            // 
            this.Add_emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add_emailTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_emailTextBox.Location = new System.Drawing.Point(70, 152);
            this.Add_emailTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.Add_emailTextBox.Name = "Add_emailTextBox";
            this.Add_emailTextBox.Size = new System.Drawing.Size(192, 26);
            this.Add_emailTextBox.TabIndex = 7;
            this.Add_emailTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.Add_Email_Validating);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(343, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Job Title:";
            // 
            // Add_PhoneTextBox
            // 
            this.Add_PhoneTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add_PhoneTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_PhoneTextBox.Location = new System.Drawing.Point(70, 194);
            this.Add_PhoneTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.Add_PhoneTextBox.MaxLength = 10;
            this.Add_PhoneTextBox.Name = "Add_PhoneTextBox";
            this.Add_PhoneTextBox.Size = new System.Drawing.Size(192, 26);
            this.Add_PhoneTextBox.TabIndex = 10;
            // 
            // Add_JobTitle
            // 
            this.Add_JobTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add_JobTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_JobTitle.Location = new System.Drawing.Point(408, 64);
            this.Add_JobTitle.Name = "Add_JobTitle";
            this.Add_JobTitle.Size = new System.Drawing.Size(201, 26);
            this.Add_JobTitle.TabIndex = 4;
            this.Add_JobTitle.WordWrap = false;
            this.Add_JobTitle.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Phone:";
            // 
            // Add_genderCombo
            // 
            this.Add_genderCombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add_genderCombo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_genderCombo.FormattingEnabled = true;
            this.Add_genderCombo.Location = new System.Drawing.Point(70, 67);
            this.Add_genderCombo.Margin = new System.Windows.Forms.Padding(0);
            this.Add_genderCombo.Name = "Add_genderCombo";
            this.Add_genderCombo.Size = new System.Drawing.Size(112, 27);
            this.Add_genderCombo.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(320, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Joining Date:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Age:";
            // 
            // Add_ageTextBox
            // 
            this.Add_ageTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add_ageTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_ageTextBox.Location = new System.Drawing.Point(70, 109);
            this.Add_ageTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.Add_ageTextBox.Name = "Add_ageTextBox";
            this.Add_ageTextBox.Size = new System.Drawing.Size(112, 26);
            this.Add_ageTextBox.TabIndex = 5;
            this.Add_ageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.add_agetextbox_keypress);
            // 
            // Add_CancelButton
            // 
            this.Add_CancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add_CancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Add_CancelButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Add_CancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Add_CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_CancelButton.Image = global::Employee_Details.Properties.Resources.Cancel;
            this.Add_CancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add_CancelButton.Location = new System.Drawing.Point(747, 313);
            this.Add_CancelButton.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.Add_CancelButton.Name = "Add_CancelButton";
            this.Add_CancelButton.Size = new System.Drawing.Size(100, 32);
            this.Add_CancelButton.TabIndex = 26;
            this.Add_CancelButton.Text = "Cancel";
            this.Add_CancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Add_CancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Add_CancelButton.UseVisualStyleBackColor = false;
            this.Add_CancelButton.Click += new System.EventHandler(this.Add_CancelButton_Click);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.Add_ClearButton);
            this.panel3.Controls.Add(this.Add_BrowseButton);
            this.panel3.Controls.Add(this.Add_PictureBox);
            this.panel3.Location = new System.Drawing.Point(17, 28);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 162);
            this.panel3.TabIndex = 25;
            // 
            // Add_ClearButton
            // 
            this.Add_ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_ClearButton.Location = new System.Drawing.Point(81, 128);
            this.Add_ClearButton.Margin = new System.Windows.Forms.Padding(50);
            this.Add_ClearButton.Name = "Add_ClearButton";
            this.Add_ClearButton.Size = new System.Drawing.Size(55, 25);
            this.Add_ClearButton.TabIndex = 17;
            this.Add_ClearButton.Text = "Clear";
            this.Add_ClearButton.UseVisualStyleBackColor = true;
            this.Add_ClearButton.Click += new System.EventHandler(this.Add_ClearButton_Click);
            // 
            // Add_BrowseButton
            // 
            this.Add_BrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_BrowseButton.Location = new System.Drawing.Point(16, 128);
            this.Add_BrowseButton.Margin = new System.Windows.Forms.Padding(50);
            this.Add_BrowseButton.Name = "Add_BrowseButton";
            this.Add_BrowseButton.Size = new System.Drawing.Size(55, 25);
            this.Add_BrowseButton.TabIndex = 16;
            this.Add_BrowseButton.Text = "Browse";
            this.Add_BrowseButton.UseVisualStyleBackColor = true;
            this.Add_BrowseButton.Click += new System.EventHandler(this.Add_BrowseButton_Click);
            // 
            // Add_PictureBox
            // 
            this.Add_PictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Add_PictureBox.Image = global::Employee_Details.Properties.Resources.userImg;
            this.Add_PictureBox.Location = new System.Drawing.Point(16, 8);
            this.Add_PictureBox.Margin = new System.Windows.Forms.Padding(50);
            this.Add_PictureBox.Name = "Add_PictureBox";
            this.Add_PictureBox.Size = new System.Drawing.Size(120, 109);
            this.Add_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Add_PictureBox.TabIndex = 15;
            this.Add_PictureBox.TabStop = false;
            // 
            // Add_SaveButton
            // 
            this.Add_SaveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add_SaveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Add_SaveButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Add_SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Add_SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_SaveButton.Image = global::Employee_Details.Properties.Resources.Save;
            this.Add_SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add_SaveButton.Location = new System.Drawing.Point(617, 313);
            this.Add_SaveButton.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.Add_SaveButton.Name = "Add_SaveButton";
            this.Add_SaveButton.Size = new System.Drawing.Size(100, 32);
            this.Add_SaveButton.TabIndex = 11;
            this.Add_SaveButton.Text = "Save";
            this.Add_SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Add_SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Add_SaveButton.UseVisualStyleBackColor = false;
            this.Add_SaveButton.Click += new System.EventHandler(this.Add_SaveButton_Click);
            // 
            // Add_ResetButton
            // 
            this.Add_ResetButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add_ResetButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Add_ResetButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Add_ResetButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Add_ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_ResetButton.Image = global::Employee_Details.Properties.Resources.Refresh;
            this.Add_ResetButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add_ResetButton.Location = new System.Drawing.Point(503, 313);
            this.Add_ResetButton.Margin = new System.Windows.Forms.Padding(0, 20, 15, 3);
            this.Add_ResetButton.Name = "Add_ResetButton";
            this.Add_ResetButton.Size = new System.Drawing.Size(84, 32);
            this.Add_ResetButton.TabIndex = 21;
            this.Add_ResetButton.Text = "Reset";
            this.Add_ResetButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Add_ResetButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Add_ResetButton.UseVisualStyleBackColor = false;
            this.Add_ResetButton.Click += new System.EventHandler(this.Add_ResetButton_Click);
            // 
            // Email_errorProvider
            // 
            this.Email_errorProvider.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(286, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(337, 45);
            this.label8.TabIndex = 4;
            this.label8.Text = "Add New Member";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topPanel
            // 
            this.topPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.topPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.topPanel.Controls.Add(this.label8);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topPanel.Location = new System.Drawing.Point(3, 3);
            this.topPanel.Margin = new System.Windows.Forms.Padding(0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(871, 49);
            this.topPanel.TabIndex = 4;
            // 
            // employeeRegd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(877, 507);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "employeeRegd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "employeeRegd";
            this.Load += new System.EventHandler(this.employeeRegd_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Add_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Email_errorProvider)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel bottomPanel;
        private Button Add_SaveButton;
        private Button Add_ResetButton;
        private Panel panel3;
        private Button Add_ClearButton;
        private Button Add_BrowseButton;
        private PictureBox Add_PictureBox;
        private Button Add_CancelButton;
        private Panel panel4;
        private TextBox Add_nameTextBox;
        private Label label1;
        private Label label2;
        private TextBox Add_LocationTextBox;
        private TextBox Add_ExperienceTextBox;
        private Label label10;
        private Label label3;
        private TextBox Add_emailTextBox;
        private Label label4;
        private TextBox Add_PhoneTextBox;
        private TextBox Add_JobTitle;
        private Label label9;
        private ComboBox Add_genderCombo;
        private Label label7;
        private Label label5;
        private Label label6;
        private TextBox Add_ageTextBox;
        private Label label11;
        private Label label12;
        private ErrorProvider Email_errorProvider;
        private DateTimePicker Add_dateTimePickr;
        private Panel topPanel;
        private Label label8;
    }
}