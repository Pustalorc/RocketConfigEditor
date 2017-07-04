namespace Persiafighter.Programs.RocketConfigEditor
{
    partial class Main
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
            this.Desc1 = new System.Windows.Forms.Label();
            this.OPerms = new System.Windows.Forms.Button();
            this.OCommands = new System.Windows.Forms.Button();
            this.Github = new System.Windows.Forms.LinkLabel();
            this.Desc2 = new System.Windows.Forms.Label();
            this.AFind = new System.Windows.Forms.CheckBox();
            this.Desc3 = new System.Windows.Forms.Label();
            this.Desc4 = new System.Windows.Forms.Label();
            this.Desc5 = new System.Windows.Forms.Label();
            this.NotFileSystem = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Desc1
            // 
            this.Desc1.AutoSize = true;
            this.Desc1.Location = new System.Drawing.Point(12, 9);
            this.Desc1.Name = "Desc1";
            this.Desc1.Size = new System.Drawing.Size(218, 13);
            this.Desc1.TabIndex = 0;
            this.Desc1.Text = "Please Select One Of The Following To Edit:";
            // 
            // OPerms
            // 
            this.OPerms.Location = new System.Drawing.Point(15, 25);
            this.OPerms.Name = "OPerms";
            this.OPerms.Size = new System.Drawing.Size(91, 23);
            this.OPerms.TabIndex = 1;
            this.OPerms.Text = "Permissions File";
            this.OPerms.UseVisualStyleBackColor = true;
            this.OPerms.Click += new System.EventHandler(this.OPerms_Click);
            // 
            // OCommands
            // 
            this.OCommands.Location = new System.Drawing.Point(15, 54);
            this.OCommands.Name = "OCommands";
            this.OCommands.Size = new System.Drawing.Size(91, 23);
            this.OCommands.TabIndex = 2;
            this.OCommands.Text = "Commands File";
            this.OCommands.UseVisualStyleBackColor = true;
            this.OCommands.Click += new System.EventHandler(this.OCommands_Click);
            // 
            // Github
            // 
            this.Github.AutoSize = true;
            this.Github.Location = new System.Drawing.Point(165, 151);
            this.Github.Name = "Github";
            this.Github.Size = new System.Drawing.Size(64, 13);
            this.Github.TabIndex = 31;
            this.Github.TabStop = true;
            this.Github.Text = "persiafighter";
            this.Github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Github_LinkClicked);
            // 
            // Desc2
            // 
            this.Desc2.AutoSize = true;
            this.Desc2.Location = new System.Drawing.Point(12, 151);
            this.Desc2.Name = "Desc2";
            this.Desc2.Size = new System.Drawing.Size(153, 13);
            this.Desc2.TabIndex = 30;
            this.Desc2.Text = "Programmed And Designed by:";
            // 
            // AFind
            // 
            this.AFind.AutoSize = true;
            this.AFind.Location = new System.Drawing.Point(15, 83);
            this.AFind.Name = "AFind";
            this.AFind.Size = new System.Drawing.Size(130, 17);
            this.AFind.TabIndex = 32;
            this.AFind.Text = "Automatically Find File";
            this.AFind.UseVisualStyleBackColor = true;
            // 
            // Desc3
            // 
            this.Desc3.AutoSize = true;
            this.Desc3.Location = new System.Drawing.Point(12, 103);
            this.Desc3.Name = "Desc3";
            this.Desc3.Size = new System.Drawing.Size(207, 13);
            this.Desc3.TabIndex = 33;
            this.Desc3.Text = "Disclaimer: selecting the option above can";
            // 
            // Desc4
            // 
            this.Desc4.AutoSize = true;
            this.Desc4.Location = new System.Drawing.Point(12, 116);
            this.Desc4.Name = "Desc4";
            this.Desc4.Size = new System.Drawing.Size(214, 13);
            this.Desc4.TabIndex = 34;
            this.Desc4.Text = "make the program unresponsive until the file";
            // 
            // Desc5
            // 
            this.Desc5.AutoSize = true;
            this.Desc5.Location = new System.Drawing.Point(12, 129);
            this.Desc5.Name = "Desc5";
            this.Desc5.Size = new System.Drawing.Size(47, 13);
            this.Desc5.TabIndex = 35;
            this.Desc5.Text = "is found.";
            // 
            // NotFileSystem
            // 
            this.NotFileSystem.AutoSize = true;
            this.NotFileSystem.Location = new System.Drawing.Point(112, 42);
            this.NotFileSystem.Name = "NotFileSystem";
            this.NotFileSystem.Size = new System.Drawing.Size(124, 17);
            this.NotFileSystem.TabIndex = 36;
            this.NotFileSystem.Text = "Don\'t Use Filesystem";
            this.NotFileSystem.UseVisualStyleBackColor = true;
            this.NotFileSystem.CheckedChanged += new System.EventHandler(this.NotFileSystem_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 171);
            this.Controls.Add(this.NotFileSystem);
            this.Controls.Add(this.Desc5);
            this.Controls.Add(this.Desc4);
            this.Controls.Add(this.Desc3);
            this.Controls.Add(this.AFind);
            this.Controls.Add(this.Github);
            this.Controls.Add(this.Desc2);
            this.Controls.Add(this.OCommands);
            this.Controls.Add(this.OPerms);
            this.Controls.Add(this.Desc1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rocket Companion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Desc1;
        private System.Windows.Forms.Button OPerms;
        private System.Windows.Forms.Button OCommands;
        private System.Windows.Forms.LinkLabel Github;
        private System.Windows.Forms.Label Desc2;
        private System.Windows.Forms.CheckBox AFind;
        private System.Windows.Forms.Label Desc3;
        private System.Windows.Forms.Label Desc4;
        private System.Windows.Forms.Label Desc5;
        private System.Windows.Forms.CheckBox NotFileSystem;
    }
}