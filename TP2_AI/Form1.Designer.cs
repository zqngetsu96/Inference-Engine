namespace TP2_AI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.ForwardChaining = new MetroFramework.Controls.MetroRadioButton();
            this.BackwardChaining = new MetroFramework.Controls.MetroRadioButton();
            this.ChainingBox = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.NoTrace = new MetroFramework.Controls.MetroRadioButton();
            this.YesTrace = new MetroFramework.Controls.MetroRadioButton();
            this.StartButton = new MetroFramework.Controls.MetroTile();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.GoalTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.NonBut = new MetroFramework.Controls.MetroRadioButton();
            this.YesBut = new MetroFramework.Controls.MetroRadioButton();
            this.BcDialog = new System.Windows.Forms.OpenFileDialog();
            this.BfDialog = new System.Windows.Forms.OpenFileDialog();
            this.BcPath = new System.Windows.Forms.TextBox();
            this.BfPath = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.BcBrowse = new MetroFramework.Controls.MetroButton();
            this.BfBrowse = new MetroFramework.Controls.MetroButton();
            this.TraceText = new System.Windows.Forms.TextBox();
            this.Saturate = new MetroFramework.Controls.MetroCheckBox();
            this.ChainingBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(7, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(219, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Veillez choisir un type de chainage : ";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(7, 193);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(256, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Voulez vous sauvegarder un fichier trace? :";
            // 
            // ForwardChaining
            // 
            this.ForwardChaining.AutoSize = true;
            this.ForwardChaining.Checked = true;
            this.ForwardChaining.Location = new System.Drawing.Point(6, 18);
            this.ForwardChaining.Name = "ForwardChaining";
            this.ForwardChaining.Size = new System.Drawing.Size(114, 15);
            this.ForwardChaining.TabIndex = 6;
            this.ForwardChaining.TabStop = true;
            this.ForwardChaining.Text = "ForwardChaining";
            this.ForwardChaining.UseSelectable = true;
            this.ForwardChaining.CheckedChanged += new System.EventHandler(this.Chaining_Changed);
            // 
            // BackwardChaining
            // 
            this.BackwardChaining.AutoSize = true;
            this.BackwardChaining.Location = new System.Drawing.Point(126, 19);
            this.BackwardChaining.Name = "BackwardChaining";
            this.BackwardChaining.Size = new System.Drawing.Size(122, 15);
            this.BackwardChaining.TabIndex = 7;
            this.BackwardChaining.Text = "BackwardChaining";
            this.BackwardChaining.UseSelectable = true;
            // 
            // ChainingBox
            // 
            this.ChainingBox.Controls.Add(this.BackwardChaining);
            this.ChainingBox.Controls.Add(this.ForwardChaining);
            this.ChainingBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChainingBox.Location = new System.Drawing.Point(244, 66);
            this.ChainingBox.Name = "ChainingBox";
            this.ChainingBox.Size = new System.Drawing.Size(260, 40);
            this.ChainingBox.TabIndex = 14;
            this.ChainingBox.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.NoTrace);
            this.groupBox3.Controls.Add(this.YesTrace);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(298, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(108, 40);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // NoTrace
            // 
            this.NoTrace.AutoSize = true;
            this.NoTrace.Location = new System.Drawing.Point(54, 18);
            this.NoTrace.Name = "NoTrace";
            this.NoTrace.Size = new System.Drawing.Size(46, 15);
            this.NoTrace.TabIndex = 7;
            this.NoTrace.Text = "Non";
            this.NoTrace.UseSelectable = true;
            // 
            // YesTrace
            // 
            this.YesTrace.AutoSize = true;
            this.YesTrace.Checked = true;
            this.YesTrace.Location = new System.Drawing.Point(6, 18);
            this.YesTrace.Name = "YesTrace";
            this.YesTrace.Size = new System.Drawing.Size(42, 15);
            this.YesTrace.TabIndex = 6;
            this.YesTrace.TabStop = true;
            this.YesTrace.Text = "Oui";
            this.YesTrace.UseSelectable = true;
            this.YesTrace.CheckedChanged += new System.EventHandler(this.TraceSave_Changed);
            // 
            // StartButton
            // 
            this.StartButton.ActiveControl = null;
            this.StartButton.Location = new System.Drawing.Point(522, 179);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(105, 77);
            this.StartButton.TabIndex = 16;
            this.StartButton.Text = "Start";
            this.StartButton.UseSelectable = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(7, 233);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(35, 19);
            this.metroLabel5.TabIndex = 17;
            this.metroLabel5.Text = "But :";
            // 
            // GoalTextBox
            // 
            // 
            // 
            // 
            this.GoalTextBox.CustomButton.Image = null;
            this.GoalTextBox.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.GoalTextBox.CustomButton.Name = "";
            this.GoalTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.GoalTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.GoalTextBox.CustomButton.TabIndex = 1;
            this.GoalTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.GoalTextBox.CustomButton.UseSelectable = true;
            this.GoalTextBox.CustomButton.Visible = false;
            this.GoalTextBox.Lines = new string[0];
            this.GoalTextBox.Location = new System.Drawing.Point(60, 233);
            this.GoalTextBox.MaxLength = 32767;
            this.GoalTextBox.Name = "GoalTextBox";
            this.GoalTextBox.PasswordChar = '\0';
            this.GoalTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.GoalTextBox.SelectedText = "";
            this.GoalTextBox.SelectionLength = 0;
            this.GoalTextBox.SelectionStart = 0;
            this.GoalTextBox.ShortcutsEnabled = true;
            this.GoalTextBox.Size = new System.Drawing.Size(146, 23);
            this.GoalTextBox.TabIndex = 18;
            this.GoalTextBox.UseSelectable = true;
            this.GoalTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.GoalTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(277, 233);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(69, 19);
            this.metroLabel6.TabIndex = 19;
            this.metroLabel6.Text = "NonBut?  :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.NonBut);
            this.groupBox4.Controls.Add(this.YesBut);
            this.groupBox4.Location = new System.Drawing.Point(352, 225);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(112, 34);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            // 
            // NonBut
            // 
            this.NonBut.AutoSize = true;
            this.NonBut.Checked = true;
            this.NonBut.Location = new System.Drawing.Point(60, 14);
            this.NonBut.Name = "NonBut";
            this.NonBut.Size = new System.Drawing.Size(46, 15);
            this.NonBut.TabIndex = 1;
            this.NonBut.TabStop = true;
            this.NonBut.Text = "Non";
            this.NonBut.UseSelectable = true;
            // 
            // YesBut
            // 
            this.YesBut.AutoSize = true;
            this.YesBut.Location = new System.Drawing.Point(6, 14);
            this.YesBut.Name = "YesBut";
            this.YesBut.Size = new System.Drawing.Size(42, 15);
            this.YesBut.TabIndex = 0;
            this.YesBut.Text = "Oui";
            this.YesBut.UseSelectable = true;
            // 
            // BcDialog
            // 
            this.BcDialog.Filter = "Textfiles|*.txt|All files|*.*";
            this.BcDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.BcFileChosen);
            // 
            // BfDialog
            // 
            this.BfDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.BfFileChosen);
            // 
            // BcPath
            // 
            this.BcPath.Location = new System.Drawing.Point(244, 114);
            this.BcPath.Name = "BcPath";
            this.BcPath.ReadOnly = true;
            this.BcPath.Size = new System.Drawing.Size(220, 20);
            this.BcPath.TabIndex = 21;
            // 
            // BfPath
            // 
            this.BfPath.Location = new System.Drawing.Point(244, 160);
            this.BfPath.Name = "BfPath";
            this.BfPath.ReadOnly = true;
            this.BfPath.Size = new System.Drawing.Size(220, 20);
            this.BfPath.TabIndex = 22;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(7, 114);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(226, 19);
            this.metroLabel2.TabIndex = 23;
            this.metroLabel2.Text = "Choisissez la base de connaissances : ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(7, 160);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(170, 19);
            this.metroLabel3.TabIndex = 24;
            this.metroLabel3.Text = "Choisissez la base des faits :";
            // 
            // BcBrowse
            // 
            this.BcBrowse.Location = new System.Drawing.Point(470, 114);
            this.BcBrowse.Name = "BcBrowse";
            this.BcBrowse.Size = new System.Drawing.Size(34, 23);
            this.BcBrowse.TabIndex = 25;
            this.BcBrowse.Text = "...";
            this.BcBrowse.UseSelectable = true;
            this.BcBrowse.Click += new System.EventHandler(this.BcBrowse_Click);
            // 
            // BfBrowse
            // 
            this.BfBrowse.Location = new System.Drawing.Point(470, 157);
            this.BfBrowse.Name = "BfBrowse";
            this.BfBrowse.Size = new System.Drawing.Size(34, 23);
            this.BfBrowse.TabIndex = 26;
            this.BfBrowse.Text = "...";
            this.BfBrowse.UseSelectable = true;
            this.BfBrowse.Click += new System.EventHandler(this.BfBrowse_Click);
            // 
            // TraceText
            // 
            this.TraceText.BackColor = System.Drawing.Color.MistyRose;
            this.TraceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TraceText.Location = new System.Drawing.Point(23, 277);
            this.TraceText.Multiline = true;
            this.TraceText.Name = "TraceText";
            this.TraceText.ReadOnly = true;
            this.TraceText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TraceText.Size = new System.Drawing.Size(481, 140);
            this.TraceText.TabIndex = 27;
            // 
            // Saturate
            // 
            this.Saturate.AutoSize = true;
            this.Saturate.Location = new System.Drawing.Point(522, 66);
            this.Saturate.Name = "Saturate";
            this.Saturate.Size = new System.Drawing.Size(81, 15);
            this.Saturate.TabIndex = 28;
            this.Saturate.Text = "Saturer BF?";
            this.Saturate.UseSelectable = true;
            this.Saturate.CheckedChanged += new System.EventHandler(this.Saturate_CheckedChanged);
            // 
            // Form1
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.BackImagePadding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.BackMaxSize = 100;
            this.ClientSize = new System.Drawing.Size(643, 428);
            this.Controls.Add(this.Saturate);
            this.Controls.Add(this.TraceText);
            this.Controls.Add(this.BfBrowse);
            this.Controls.Add(this.BcBrowse);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.BfPath);
            this.Controls.Add(this.BcPath);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.GoalTextBox);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ChainingBox);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "              Artificial Intelligence ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ChainingBox.ResumeLayout(false);
            this.ChainingBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroRadioButton ForwardChaining;
        private MetroFramework.Controls.MetroRadioButton BackwardChaining;
        private System.Windows.Forms.GroupBox ChainingBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroRadioButton NoTrace;
        private MetroFramework.Controls.MetroRadioButton YesTrace;
        private MetroFramework.Controls.MetroTile StartButton;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox GoalTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroRadioButton NonBut;
        private MetroFramework.Controls.MetroRadioButton YesBut;
        private System.Windows.Forms.OpenFileDialog BcDialog;
        private System.Windows.Forms.OpenFileDialog BfDialog;
        private System.Windows.Forms.TextBox BcPath;
        private System.Windows.Forms.TextBox BfPath;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton BcBrowse;
        private MetroFramework.Controls.MetroButton BfBrowse;
        private System.Windows.Forms.TextBox TraceText;
        private MetroFramework.Controls.MetroCheckBox Saturate;
    }
}

