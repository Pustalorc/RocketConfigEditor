namespace Persiafighter.Programs.RocketConfigEditor
{
    partial class Editor
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
            this.DefGroup = new System.Windows.Forms.TextBox();
            this.Desc2 = new System.Windows.Forms.Label();
            this.GroupIDS = new System.Windows.Forms.ListBox();
            this.AddGroup = new System.Windows.Forms.Button();
            this.RemoveGroup = new System.Windows.Forms.Button();
            this.Desc3 = new System.Windows.Forms.Label();
            this.DName = new System.Windows.Forms.TextBox();
            this.Desc4 = new System.Windows.Forms.Label();
            this.Prefix = new System.Windows.Forms.TextBox();
            this.Suffix = new System.Windows.Forms.TextBox();
            this.Desc5 = new System.Windows.Forms.Label();
            this.CColor = new System.Windows.Forms.TextBox();
            this.Desc6 = new System.Windows.Forms.Label();
            this.PGroup = new System.Windows.Forms.TextBox();
            this.Desc7 = new System.Windows.Forms.Label();
            this.Desc8 = new System.Windows.Forms.Label();
            this.RemPerm = new System.Windows.Forms.Button();
            this.AddPerm = new System.Windows.Forms.Button();
            this.Permissions = new System.Windows.Forms.ListBox();
            this.Desc9 = new System.Windows.Forms.Label();
            this.RemMem = new System.Windows.Forms.Button();
            this.AddMem = new System.Windows.Forms.Button();
            this.Members = new System.Windows.Forms.ListBox();
            this.Desc10 = new System.Windows.Forms.Label();
            this.SExit = new System.Windows.Forms.Button();
            this.OpenFold = new System.Windows.Forms.Button();
            this.Desc11 = new System.Windows.Forms.Label();
            this.Github = new System.Windows.Forms.LinkLabel();
            this.Priority = new System.Windows.Forms.NumericUpDown();
            this.Cooldown = new System.Windows.Forms.NumericUpDown();
            this.Desc12 = new System.Windows.Forms.Label();
            this.OpenRocket = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Priority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cooldown)).BeginInit();
            this.SuspendLayout();
            // 
            // Desc1
            // 
            this.Desc1.AutoSize = true;
            this.Desc1.Location = new System.Drawing.Point(12, 15);
            this.Desc1.Name = "Desc1";
            this.Desc1.Size = new System.Drawing.Size(76, 13);
            this.Desc1.TabIndex = 0;
            this.Desc1.Text = "Default Group:";
            // 
            // DefGroup
            // 
            this.DefGroup.Location = new System.Drawing.Point(94, 12);
            this.DefGroup.Name = "DefGroup";
            this.DefGroup.Size = new System.Drawing.Size(126, 20);
            this.DefGroup.TabIndex = 1;
            this.DefGroup.TextChanged += new System.EventHandler(this.DefGroup_TextChanged);
            // 
            // Desc2
            // 
            this.Desc2.AutoSize = true;
            this.Desc2.Location = new System.Drawing.Point(12, 44);
            this.Desc2.Name = "Desc2";
            this.Desc2.Size = new System.Drawing.Size(44, 13);
            this.Desc2.TabIndex = 2;
            this.Desc2.Text = "Groups:";
            // 
            // GroupIDS
            // 
            this.GroupIDS.FormattingEnabled = true;
            this.GroupIDS.Location = new System.Drawing.Point(12, 60);
            this.GroupIDS.Name = "GroupIDS";
            this.GroupIDS.Size = new System.Drawing.Size(98, 225);
            this.GroupIDS.Sorted = true;
            this.GroupIDS.TabIndex = 3;
            this.GroupIDS.SelectedIndexChanged += new System.EventHandler(this.GroupIDS_SelectedIndexChanged);
            // 
            // AddGroup
            // 
            this.AddGroup.Location = new System.Drawing.Point(12, 291);
            this.AddGroup.Name = "AddGroup";
            this.AddGroup.Size = new System.Drawing.Size(34, 23);
            this.AddGroup.TabIndex = 4;
            this.AddGroup.Text = "Add";
            this.AddGroup.UseVisualStyleBackColor = true;
            this.AddGroup.Click += new System.EventHandler(this.AddGroup_Click);
            // 
            // RemoveGroup
            // 
            this.RemoveGroup.Location = new System.Drawing.Point(52, 291);
            this.RemoveGroup.Name = "RemoveGroup";
            this.RemoveGroup.Size = new System.Drawing.Size(58, 23);
            this.RemoveGroup.TabIndex = 5;
            this.RemoveGroup.Text = "Remove";
            this.RemoveGroup.UseVisualStyleBackColor = true;
            this.RemoveGroup.Click += new System.EventHandler(this.RemoveGroup_Click);
            // 
            // Desc3
            // 
            this.Desc3.AutoSize = true;
            this.Desc3.Location = new System.Drawing.Point(113, 44);
            this.Desc3.Name = "Desc3";
            this.Desc3.Size = new System.Drawing.Size(75, 13);
            this.Desc3.TabIndex = 6;
            this.Desc3.Text = "Display Name:";
            // 
            // DName
            // 
            this.DName.Location = new System.Drawing.Point(116, 60);
            this.DName.Name = "DName";
            this.DName.Size = new System.Drawing.Size(104, 20);
            this.DName.TabIndex = 7;
            // 
            // Desc4
            // 
            this.Desc4.AutoSize = true;
            this.Desc4.Location = new System.Drawing.Point(113, 83);
            this.Desc4.Name = "Desc4";
            this.Desc4.Size = new System.Drawing.Size(36, 13);
            this.Desc4.TabIndex = 8;
            this.Desc4.Text = "Prefix:";
            // 
            // Prefix
            // 
            this.Prefix.Location = new System.Drawing.Point(116, 99);
            this.Prefix.Name = "Prefix";
            this.Prefix.Size = new System.Drawing.Size(104, 20);
            this.Prefix.TabIndex = 9;
            // 
            // Suffix
            // 
            this.Suffix.Location = new System.Drawing.Point(116, 138);
            this.Suffix.Name = "Suffix";
            this.Suffix.Size = new System.Drawing.Size(104, 20);
            this.Suffix.TabIndex = 11;
            // 
            // Desc5
            // 
            this.Desc5.AutoSize = true;
            this.Desc5.Location = new System.Drawing.Point(113, 122);
            this.Desc5.Name = "Desc5";
            this.Desc5.Size = new System.Drawing.Size(36, 13);
            this.Desc5.TabIndex = 10;
            this.Desc5.Text = "Suffix:";
            // 
            // CColor
            // 
            this.CColor.Location = new System.Drawing.Point(116, 177);
            this.CColor.Name = "CColor";
            this.CColor.Size = new System.Drawing.Size(104, 20);
            this.CColor.TabIndex = 13;
            // 
            // Desc6
            // 
            this.Desc6.AutoSize = true;
            this.Desc6.Location = new System.Drawing.Point(113, 161);
            this.Desc6.Name = "Desc6";
            this.Desc6.Size = new System.Drawing.Size(59, 13);
            this.Desc6.TabIndex = 12;
            this.Desc6.Text = "Chat Color:";
            // 
            // PGroup
            // 
            this.PGroup.Location = new System.Drawing.Point(116, 216);
            this.PGroup.Name = "PGroup";
            this.PGroup.Size = new System.Drawing.Size(104, 20);
            this.PGroup.TabIndex = 15;
            // 
            // Desc7
            // 
            this.Desc7.AutoSize = true;
            this.Desc7.Location = new System.Drawing.Point(113, 200);
            this.Desc7.Name = "Desc7";
            this.Desc7.Size = new System.Drawing.Size(73, 13);
            this.Desc7.TabIndex = 14;
            this.Desc7.Text = "Parent Group:";
            // 
            // Desc8
            // 
            this.Desc8.AutoSize = true;
            this.Desc8.Location = new System.Drawing.Point(113, 239);
            this.Desc8.Name = "Desc8";
            this.Desc8.Size = new System.Drawing.Size(41, 13);
            this.Desc8.TabIndex = 16;
            this.Desc8.Text = "Priority:";
            // 
            // RemPerm
            // 
            this.RemPerm.Location = new System.Drawing.Point(346, 316);
            this.RemPerm.Name = "RemPerm";
            this.RemPerm.Size = new System.Drawing.Size(58, 23);
            this.RemPerm.TabIndex = 21;
            this.RemPerm.Text = "Remove";
            this.RemPerm.UseVisualStyleBackColor = true;
            this.RemPerm.Click += new System.EventHandler(this.RemPerm_Click);
            // 
            // AddPerm
            // 
            this.AddPerm.Location = new System.Drawing.Point(226, 316);
            this.AddPerm.Name = "AddPerm";
            this.AddPerm.Size = new System.Drawing.Size(34, 23);
            this.AddPerm.TabIndex = 20;
            this.AddPerm.Text = "Add";
            this.AddPerm.UseVisualStyleBackColor = true;
            this.AddPerm.Click += new System.EventHandler(this.AddPerm_Click);
            // 
            // Permissions
            // 
            this.Permissions.FormattingEnabled = true;
            this.Permissions.Location = new System.Drawing.Point(226, 60);
            this.Permissions.Name = "Permissions";
            this.Permissions.Size = new System.Drawing.Size(178, 212);
            this.Permissions.Sorted = true;
            this.Permissions.TabIndex = 19;
            this.Permissions.SelectedIndexChanged += new System.EventHandler(this.Permissions_SelectedIndexChanged);
            // 
            // Desc9
            // 
            this.Desc9.AutoSize = true;
            this.Desc9.Location = new System.Drawing.Point(226, 44);
            this.Desc9.Name = "Desc9";
            this.Desc9.Size = new System.Drawing.Size(65, 13);
            this.Desc9.TabIndex = 18;
            this.Desc9.Text = "Permissions:";
            // 
            // RemMem
            // 
            this.RemMem.Location = new System.Drawing.Point(513, 316);
            this.RemMem.Name = "RemMem";
            this.RemMem.Size = new System.Drawing.Size(58, 23);
            this.RemMem.TabIndex = 25;
            this.RemMem.Text = "Remove";
            this.RemMem.UseVisualStyleBackColor = true;
            this.RemMem.Click += new System.EventHandler(this.RemMem_Click);
            // 
            // AddMem
            // 
            this.AddMem.Location = new System.Drawing.Point(410, 316);
            this.AddMem.Name = "AddMem";
            this.AddMem.Size = new System.Drawing.Size(34, 23);
            this.AddMem.TabIndex = 24;
            this.AddMem.Text = "Add";
            this.AddMem.UseVisualStyleBackColor = true;
            this.AddMem.Click += new System.EventHandler(this.AddMem_Click);
            // 
            // Members
            // 
            this.Members.FormattingEnabled = true;
            this.Members.Location = new System.Drawing.Point(410, 60);
            this.Members.Name = "Members";
            this.Members.Size = new System.Drawing.Size(161, 251);
            this.Members.Sorted = true;
            this.Members.TabIndex = 23;
            // 
            // Desc10
            // 
            this.Desc10.AutoSize = true;
            this.Desc10.Location = new System.Drawing.Point(407, 44);
            this.Desc10.Name = "Desc10";
            this.Desc10.Size = new System.Drawing.Size(53, 13);
            this.Desc10.TabIndex = 22;
            this.Desc10.Text = "Members:";
            // 
            // SExit
            // 
            this.SExit.Location = new System.Drawing.Point(489, 12);
            this.SExit.Name = "SExit";
            this.SExit.Size = new System.Drawing.Size(82, 23);
            this.SExit.TabIndex = 26;
            this.SExit.Text = "Save And Exit";
            this.SExit.UseVisualStyleBackColor = true;
            this.SExit.Click += new System.EventHandler(this.SExit_Click);
            // 
            // OpenFold
            // 
            this.OpenFold.Location = new System.Drawing.Point(317, 12);
            this.OpenFold.Name = "OpenFold";
            this.OpenFold.Size = new System.Drawing.Size(166, 23);
            this.OpenFold.TabIndex = 27;
            this.OpenFold.Text = "Select Different Permissions File";
            this.OpenFold.UseVisualStyleBackColor = true;
            this.OpenFold.Click += new System.EventHandler(this.OpenFold_Click);
            // 
            // Desc11
            // 
            this.Desc11.AutoSize = true;
            this.Desc11.Location = new System.Drawing.Point(9, 321);
            this.Desc11.Name = "Desc11";
            this.Desc11.Size = new System.Drawing.Size(153, 13);
            this.Desc11.TabIndex = 28;
            this.Desc11.Text = "Programmed And Designed by:";
            // 
            // Github
            // 
            this.Github.AutoSize = true;
            this.Github.Location = new System.Drawing.Point(162, 321);
            this.Github.Name = "Github";
            this.Github.Size = new System.Drawing.Size(64, 13);
            this.Github.TabIndex = 29;
            this.Github.TabStop = true;
            this.Github.Text = "persiafighter";
            this.Github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Github_LinkClicked);
            // 
            // Priority
            // 
            this.Priority.Location = new System.Drawing.Point(116, 255);
            this.Priority.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.Priority.Minimum = new decimal(new int[] {
            32768,
            0,
            0,
            -2147483648});
            this.Priority.Name = "Priority";
            this.Priority.Size = new System.Drawing.Size(104, 20);
            this.Priority.TabIndex = 30;
            // 
            // Cooldown
            // 
            this.Cooldown.Location = new System.Drawing.Point(229, 291);
            this.Cooldown.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.Cooldown.Name = "Cooldown";
            this.Cooldown.Size = new System.Drawing.Size(175, 20);
            this.Cooldown.TabIndex = 32;
            this.Cooldown.ValueChanged += new System.EventHandler(this.Cooldown_ValueChanged);
            // 
            // Desc12
            // 
            this.Desc12.AutoSize = true;
            this.Desc12.Location = new System.Drawing.Point(226, 275);
            this.Desc12.Name = "Desc12";
            this.Desc12.Size = new System.Drawing.Size(57, 13);
            this.Desc12.TabIndex = 31;
            this.Desc12.Text = "Cooldown:";
            // 
            // OpenRocket
            // 
            this.OpenRocket.FileName = "Permissions.Configuration.xml";
            this.OpenRocket.Filter = "Xml Files|*.xml";
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 343);
            this.Controls.Add(this.Cooldown);
            this.Controls.Add(this.Desc12);
            this.Controls.Add(this.Priority);
            this.Controls.Add(this.Github);
            this.Controls.Add(this.Desc11);
            this.Controls.Add(this.OpenFold);
            this.Controls.Add(this.SExit);
            this.Controls.Add(this.RemMem);
            this.Controls.Add(this.AddMem);
            this.Controls.Add(this.Members);
            this.Controls.Add(this.Desc10);
            this.Controls.Add(this.RemPerm);
            this.Controls.Add(this.AddPerm);
            this.Controls.Add(this.Permissions);
            this.Controls.Add(this.Desc9);
            this.Controls.Add(this.Desc8);
            this.Controls.Add(this.PGroup);
            this.Controls.Add(this.Desc7);
            this.Controls.Add(this.CColor);
            this.Controls.Add(this.Desc6);
            this.Controls.Add(this.Suffix);
            this.Controls.Add(this.Desc5);
            this.Controls.Add(this.Prefix);
            this.Controls.Add(this.Desc4);
            this.Controls.Add(this.DName);
            this.Controls.Add(this.Desc3);
            this.Controls.Add(this.RemoveGroup);
            this.Controls.Add(this.AddGroup);
            this.Controls.Add(this.GroupIDS);
            this.Controls.Add(this.Desc2);
            this.Controls.Add(this.DefGroup);
            this.Controls.Add(this.Desc1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Editor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            ((System.ComponentModel.ISupportInitialize)(this.Priority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cooldown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Desc1;
        private System.Windows.Forms.TextBox DefGroup;
        private System.Windows.Forms.Label Desc2;
        private System.Windows.Forms.ListBox GroupIDS;
        private System.Windows.Forms.Button AddGroup;
        private System.Windows.Forms.Button RemoveGroup;
        private System.Windows.Forms.Label Desc3;
        private System.Windows.Forms.TextBox DName;
        private System.Windows.Forms.Label Desc4;
        private System.Windows.Forms.TextBox Prefix;
        private System.Windows.Forms.TextBox Suffix;
        private System.Windows.Forms.Label Desc5;
        private System.Windows.Forms.TextBox CColor;
        private System.Windows.Forms.Label Desc6;
        private System.Windows.Forms.TextBox PGroup;
        private System.Windows.Forms.Label Desc7;
        private System.Windows.Forms.Label Desc8;
        private System.Windows.Forms.Button RemPerm;
        private System.Windows.Forms.Button AddPerm;
        private System.Windows.Forms.ListBox Permissions;
        private System.Windows.Forms.Label Desc9;
        private System.Windows.Forms.Button RemMem;
        private System.Windows.Forms.Button AddMem;
        private System.Windows.Forms.ListBox Members;
        private System.Windows.Forms.Label Desc10;
        private System.Windows.Forms.Button SExit;
        private System.Windows.Forms.Button OpenFold;
        private System.Windows.Forms.Label Desc11;
        private System.Windows.Forms.LinkLabel Github;
        private System.Windows.Forms.NumericUpDown Priority;
        private System.Windows.Forms.NumericUpDown Cooldown;
        private System.Windows.Forms.Label Desc12;
        private System.Windows.Forms.OpenFileDialog OpenRocket;
    }
}