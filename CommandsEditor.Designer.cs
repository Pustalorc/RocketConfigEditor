namespace Persiafighter.Programs.RocketConfigEditor
{
    partial class CommandsEditor
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
            this.Commands = new System.Windows.Forms.ListBox();
            this.Desc1 = new System.Windows.Forms.Label();
            this.CAlias = new System.Windows.Forms.Button();
            this.ECommand = new System.Windows.Forms.CheckBox();
            this.CPriority = new System.Windows.Forms.ComboBox();
            this.Desc2 = new System.Windows.Forms.Label();
            this.Desc3 = new System.Windows.Forms.Label();
            this.CNamespace = new System.Windows.Forms.TextBox();
            this.RemComm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.OpenFold = new System.Windows.Forms.Button();
            this.SExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Commands
            // 
            this.Commands.FormattingEnabled = true;
            this.Commands.Location = new System.Drawing.Point(12, 25);
            this.Commands.Name = "Commands";
            this.Commands.Size = new System.Drawing.Size(104, 173);
            this.Commands.TabIndex = 0;
            this.Commands.SelectedIndexChanged += new System.EventHandler(this.Commands_SelectedIndexChanged);
            // 
            // Desc1
            // 
            this.Desc1.AutoSize = true;
            this.Desc1.Location = new System.Drawing.Point(12, 9);
            this.Desc1.Name = "Desc1";
            this.Desc1.Size = new System.Drawing.Size(62, 13);
            this.Desc1.TabIndex = 1;
            this.Desc1.Text = "Commands:";
            // 
            // CAlias
            // 
            this.CAlias.Location = new System.Drawing.Point(12, 204);
            this.CAlias.Name = "CAlias";
            this.CAlias.Size = new System.Drawing.Size(76, 23);
            this.CAlias.TabIndex = 2;
            this.CAlias.Text = "Create Alias";
            this.CAlias.UseVisualStyleBackColor = true;
            this.CAlias.Click += new System.EventHandler(this.CAlias_Click);
            // 
            // ECommand
            // 
            this.ECommand.AutoSize = true;
            this.ECommand.Location = new System.Drawing.Point(122, 54);
            this.ECommand.Name = "ECommand";
            this.ECommand.Size = new System.Drawing.Size(109, 17);
            this.ECommand.TabIndex = 3;
            this.ECommand.Text = "Enable Command";
            this.ECommand.UseVisualStyleBackColor = true;
            this.ECommand.CheckedChanged += new System.EventHandler(this.ECommand_CheckedChanged);
            // 
            // CPriority
            // 
            this.CPriority.FormattingEnabled = true;
            this.CPriority.Location = new System.Drawing.Point(122, 90);
            this.CPriority.Name = "CPriority";
            this.CPriority.Size = new System.Drawing.Size(91, 21);
            this.CPriority.TabIndex = 4;
            this.CPriority.SelectedIndexChanged += new System.EventHandler(this.CPriority_SelectedIndexChanged);
            // 
            // Desc2
            // 
            this.Desc2.AutoSize = true;
            this.Desc2.Location = new System.Drawing.Point(122, 74);
            this.Desc2.Name = "Desc2";
            this.Desc2.Size = new System.Drawing.Size(91, 13);
            this.Desc2.TabIndex = 5;
            this.Desc2.Text = "Command Priority:";
            // 
            // Desc3
            // 
            this.Desc3.AutoSize = true;
            this.Desc3.Location = new System.Drawing.Point(122, 159);
            this.Desc3.Name = "Desc3";
            this.Desc3.Size = new System.Drawing.Size(67, 13);
            this.Desc3.TabIndex = 6;
            this.Desc3.Text = "Namespace:";
            // 
            // CNamespace
            // 
            this.CNamespace.Location = new System.Drawing.Point(122, 175);
            this.CNamespace.Name = "CNamespace";
            this.CNamespace.Size = new System.Drawing.Size(290, 20);
            this.CNamespace.TabIndex = 7;
            this.CNamespace.TextChanged += new System.EventHandler(this.CNamespace_TextChanged);
            // 
            // RemComm
            // 
            this.RemComm.Location = new System.Drawing.Point(94, 204);
            this.RemComm.Name = "RemComm";
            this.RemComm.Size = new System.Drawing.Size(108, 23);
            this.RemComm.TabIndex = 8;
            this.RemComm.Text = "Remove Command";
            this.RemComm.UseVisualStyleBackColor = true;
            this.RemComm.Click += new System.EventHandler(this.RemComm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Warning: Do NOT edit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "the namespace unless";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "you know what you are";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "doing!";
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "OpenFile";
            // 
            // OpenFold
            // 
            this.OpenFold.Location = new System.Drawing.Point(158, 12);
            this.OpenFold.Name = "OpenFold";
            this.OpenFold.Size = new System.Drawing.Size(166, 23);
            this.OpenFold.TabIndex = 29;
            this.OpenFold.Text = "Select Different Permissions File";
            this.OpenFold.UseVisualStyleBackColor = true;
            this.OpenFold.Click += new System.EventHandler(this.OpenFold_Click);
            // 
            // SExit
            // 
            this.SExit.Location = new System.Drawing.Point(330, 12);
            this.SExit.Name = "SExit";
            this.SExit.Size = new System.Drawing.Size(82, 23);
            this.SExit.TabIndex = 28;
            this.SExit.Text = "Save And Exit";
            this.SExit.UseVisualStyleBackColor = true;
            this.SExit.Click += new System.EventHandler(this.SExit_Click);
            // 
            // CommandsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 238);
            this.Controls.Add(this.OpenFold);
            this.Controls.Add(this.SExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemComm);
            this.Controls.Add(this.CNamespace);
            this.Controls.Add(this.Desc3);
            this.Controls.Add(this.Desc2);
            this.Controls.Add(this.CPriority);
            this.Controls.Add(this.ECommand);
            this.Controls.Add(this.CAlias);
            this.Controls.Add(this.Desc1);
            this.Controls.Add(this.Commands);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CommandsEditor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CommandsEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Commands;
        private System.Windows.Forms.Label Desc1;
        private System.Windows.Forms.Button CAlias;
        private System.Windows.Forms.CheckBox ECommand;
        private System.Windows.Forms.ComboBox CPriority;
        private System.Windows.Forms.Label Desc2;
        private System.Windows.Forms.Label Desc3;
        private System.Windows.Forms.TextBox CNamespace;
        private System.Windows.Forms.Button RemComm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.Button OpenFold;
        private System.Windows.Forms.Button SExit;
    }
}