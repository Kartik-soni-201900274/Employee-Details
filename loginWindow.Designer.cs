using MaterialSkin;
using MaterialSkin.Controls;
using System;

namespace Employee_Details
{
    partial class loginWindow
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
            MaterialSkin.Controls.MaterialCard materialCard1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginWindow));
            this.passwordTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.usernameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.loginButton = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorUsername = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.passwordTooltip = new System.Windows.Forms.ToolTip(this.components);
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            materialCard1.AllowDrop = true;
            resources.ApplyResources(materialCard1, "materialCard1");
            materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            materialCard1.Controls.Add(this.passwordTextBox);
            materialCard1.Controls.Add(this.usernameTextBox);
            materialCard1.Controls.Add(this.loginButton);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard1_Paint_1);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.AllowPromptAsInput = false;
            resources.ApplyResources(this.passwordTextBox, "passwordTextBox");
            this.passwordTextBox.AnimateReadOnly = false;
            this.passwordTextBox.AsciiOnly = false;
            this.passwordTextBox.BeepOnError = false;
            this.passwordTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.passwordTextBox.Depth = 0;
            this.passwordTextBox.HidePromptOnLeave = false;
            this.passwordTextBox.HideSelection = true;
            this.passwordTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.passwordTextBox.LeadingIcon = null;
            this.passwordTextBox.Mask = "";
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '●';
            this.passwordTextBox.PromptChar = '_';
            this.passwordTextBox.ReadOnly = false;
            this.passwordTextBox.RejectInputOnFirstFailure = false;
            this.passwordTextBox.ResetOnPrompt = true;
            this.passwordTextBox.ResetOnSpace = true;
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.SelectionLength = 0;
            this.passwordTextBox.SelectionStart = 0;
            this.passwordTextBox.ShortcutsEnabled = true;
            this.passwordTextBox.SkipLiterals = true;
            this.passwordTextBox.TabStop = false;
            this.passwordTextBox.Tag = "";
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.passwordTooltip.SetToolTip(this.passwordTextBox, resources.GetString("passwordTextBox.ToolTip"));
            this.passwordTextBox.TrailingIcon = global::Employee_Details.Properties.Resources.Visible;
            this.passwordTextBox.UseAccent = false;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.ValidatingType = null;
            this.passwordTextBox.Click += new System.EventHandler(this.passwordTextBox_Click);
            this.passwordTextBox.Leave += new System.EventHandler(this.passwordTextBox_Leave);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this.usernameTextBox, "usernameTextBox");
            this.usernameTextBox.AnimateReadOnly = false;
            this.usernameTextBox.BackColor = System.Drawing.Color.White;
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextBox.Depth = 0;
            this.usernameTextBox.LeadingIcon = global::Employee_Details.Properties.Resources.User;
            this.usernameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.TabStop = false;
            this.usernameTextBox.TrailingIcon = null;
            this.usernameTextBox.UseAccent = false;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged_1);
            this.usernameTextBox.Leave += new System.EventHandler(this.usernameTextBox_Leave);
            // 
            // loginButton
            // 
            resources.ApplyResources(this.loginButton, "loginButton");
            this.loginButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.loginButton.Depth = 0;
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.loginButton.FlatAppearance.BorderSize = 6;
            this.loginButton.ForeColor = System.Drawing.Color.Red;
            this.loginButton.HighEmphasis = true;
            this.loginButton.Icon = null;
            this.loginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginButton.Name = "loginButton";
            this.loginButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.loginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.loginButton.UseAccentColor = false;
            this.loginButton.UseCompatibleTextRendering = true;
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::Employee_Details.Properties.Resources.smirhsLogo;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // errorUsername
            // 
            this.errorUsername.ContainerControl = this;
            // 
            // errorPassword
            // 
            this.errorPassword.ContainerControl = this;
            // 
            // loginWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.Color.Red;
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(materialCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "loginWindow";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialMaskedTextBox passwordTextBox;
        private MaterialSkin.Controls.MaterialTextBox usernameTextBox;        private MaterialSkin.Controls.MaterialButton loginButton;
        private System.Windows.Forms.ErrorProvider errorUsername;
        private System.Windows.Forms.ErrorProvider errorPassword;
        private System.Windows.Forms.ToolTip passwordTooltip;
    }
}

