using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Persiafighter.Programs.RocketConfigEditor
{
    public partial class Main : Form
    {
        private string FilePath = "";
        public Main()
        {
            InitializeComponent();
        }
        private void Github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://persiafighter.github.io/");
        }
        private void OPerms_Click(object sender, EventArgs e)
        {
            Hide();
            if (AFind.Checked)
            {
                SearchLocal(Rocket.Core.Environment.PermissionFile);
                if (FilePath == "")
                {
                    Search(Rocket.Core.Environment.PermissionFile);
                }
            }
            new PermissionsEditor(FilePath).ShowDialog();
            FilePath = "";
            Show();
        }

        private void SearchLocal(string file)
        {
            try
            {
                foreach (string s in Directory.GetFiles(file))
                {
                    FilePath = s;
                    return;
                }
                if (FilePath == "")
                {
                    Scan(Directory.GetCurrentDirectory(), file);
                }
            }
            catch (Exception) { }
        }

        private void Search(string file)
        {
            foreach (string s in Directory.GetLogicalDrives())
            {
                try
                {
                    foreach (string d in Directory.GetFiles(s, file))
                    {
                        FilePath = d;
                        return;
                    }
                    if (FilePath == "")
                    {
                        Scan(s, file);
                    }
                    else if (FilePath != "")
                    {
                        return;
                    }
                }
                catch (Exception) { }
            }
            return;
        }

        private void Scan(string sDir, string file)
        {
            foreach (string d in Directory.GetDirectories(sDir))
            {
                try
                {
                    foreach (string s in Directory.GetFiles(d, file))
                    {
                        FilePath = s;
                        return;
                    }
                    if (FilePath == "")
                    {
                        Scan(d, file);
                    }
                    else if (FilePath != "")
                    {
                        return;
                    }
                }
                catch (Exception) { }
            }
        }

        private void OCommands_Click(object sender, EventArgs e)
        {
            Hide();
            if (AFind.Checked)
            {
                SearchLocal(Rocket.Core.Environment.CommandsFile);
                if (FilePath == "")
                {
                    Search(Rocket.Core.Environment.CommandsFile);
                }
            }
            new CommandsEditor(FilePath).ShowDialog();
            FilePath = "";
            Show();
        }
    }
}
