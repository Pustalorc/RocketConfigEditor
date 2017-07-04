using Rocket.Core.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Persiafighter.Programs.RocketConfigEditor
{
    public partial class CommandsEditor : Form
    {
        private string FilePath = "";
        private CommandsMemory _mem;
        private bool _controlled = false;
        public CommandsEditor(string fp)
        {
            InitializeComponent();
            CPriority.Items.AddRange(Enum.GetValues(typeof(CommandPriority)).Cast<CommandPriority>().ToList().ConvertAll(k => k.ToString()).ToArray());
            CPriority.SelectedIndex = 0;

            if (FilePath == "")
            {
                OpenFile.Filter = "Rocket Commands|" + Rocket.Core.Environment.CommandsFile;
                if (OpenFile.ShowDialog() == DialogResult.OK)
                {
                    _mem = new CommandsMemory(OpenFile.FileName);
                    Text = "Editing: " + OpenFile.FileName;
                    _mem._rc.CommandMappings.ForEach(k => Commands.Items.Add(k.Name));
                    Commands.SelectedIndex = Commands.Items.Count > 0 ? 0 : -1;
                    RefreshCommandData();
                    return;
                }
                else
                {
                    Load += (s, e) => Close();
                    return;
                }
            }
            _mem = new CommandsMemory(FilePath);
            Text = "Editing: " + FilePath;
            _mem._rc.CommandMappings.ForEach(k => Commands.Items.Add(k.Name));
            Commands.SelectedIndex = Commands.Items.Count > 0 ? 0 : -1;
            RefreshCommandData();
        }

        private void RefreshCommandData()
        {
            if (Commands.SelectedItem == null)
            {
                CAlias.Enabled = false;
                RemComm.Enabled = false;
                ECommand.Enabled = false;
                CPriority.Enabled = false;
                CNamespace.Enabled = false;
                return;
            }
            CAlias.Enabled = true;
            RemComm.Enabled = true;
            ECommand.Enabled = true;
            CPriority.Enabled = true;
            CNamespace.Enabled = true;
            _controlled = true;
            CommandMapping c = _mem._rc.CommandMappings.Find(k => k.Name == Commands.SelectedItem.ToString());
            ECommand.Checked = c.Enabled;
            CPriority.SelectedIndex = CPriority.Items.IndexOf(c.Priority.ToString());
            CNamespace.Text = c.Class;
            _controlled = false;
        }

        private void Commands_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshCommandData();
        }

        private void SExit_Click(object sender, EventArgs e)
        {
            _mem.Save();
            Close();
        }

        private void CAlias_Click(object sender, EventArgs e)
        {
            if (Commands.SelectedItem == null)
                return;
            CommandMapping original = _mem._rc.CommandMappings.Find(k => k.Name == Commands.SelectedItem.ToString());
            string input = Microsoft.VisualBasic.Interaction.InputBox("Please specify the permission to add.", "New Permission", "");
            if (input == "")
                return;
            var i = _mem._rc.CommandMappings.Find(k => k.Name == input);
            if (i != null)
                MessageBox.Show("A command or alias \"" + input + "\" already exists! Please specify a different alias.");
            else
            {
                CommandMapping newone = new CommandMapping(input, original.Class, original.Enabled, original.Priority);
                _mem._rc.CommandMappings.Add(newone);
                Commands.Items.Add(newone.Name);
                Commands.SelectedItem = newone.Name;
            }
        }

        private void RemComm_Click(object sender, EventArgs e)
        {
            if (Commands.SelectedItem == null)
                return;
            CommandMapping target = _mem._rc.CommandMappings.Find(k => k.Name == Commands.SelectedItem.ToString());
            _mem._rc.CommandMappings.Remove(target);
            Commands.Items.Remove(target.Name);
            Commands.SelectedIndex = Commands.Items.Count > 0 ? 0 : -1;
        }

        private void ECommand_CheckedChanged(object sender, EventArgs e)
        {
            if (!_controlled)
            {
                if (Commands.SelectedItem == null)
                    return;
                CommandMapping p = _mem._rc.CommandMappings.Find(k => k.Name == Commands.SelectedItem.ToString());
                var index = _mem._rc.CommandMappings.IndexOf(p);
                p.Enabled = ECommand.Checked;
                _mem._rc.CommandMappings[index] = p;
            }
        }

        private void CPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_controlled)
            {
                if (Commands.SelectedItem == null)
                    return;
                CommandMapping p = _mem._rc.CommandMappings.Find(k => k.Name == Commands.SelectedItem.ToString());
                var index = _mem._rc.CommandMappings.IndexOf(p);
                p.Priority = Enum.GetValues(typeof(CommandPriority)).Cast<CommandPriority>().ToList().Find(k => k.ToString() == CPriority.SelectedItem.ToString());
                _mem._rc.CommandMappings[index] = p;
            }
        }

        private void CNamespace_TextChanged(object sender, EventArgs e)
        {
            if (!_controlled)
            {
                if (Commands.SelectedItem == null)
                    return;
                CommandMapping p = _mem._rc.CommandMappings.Find(k => k.Name == Commands.SelectedItem.ToString());
                var index = _mem._rc.CommandMappings.IndexOf(p);
                p.Class = CNamespace.Text;
                _mem._rc.CommandMappings[index] = p;
            }
        }

        private void OpenFold_Click(object sender, EventArgs e)
        {
            OpenFile.Filter = "Rocket Commands|" + Rocket.Core.Environment.CommandsFile;
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                _mem.Load(OpenFile.FileName);
                Text = "Editing: " + OpenFile.FileName;
                Commands.Items.Clear();
                _mem._rc.CommandMappings.ForEach(k => Commands.Items.Add(k.Name));
                Commands.SelectedIndex = Commands.Items.Count > 0 ? 0 : -1;
                RefreshCommandData();
            }
        }

        private void Github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://persiafighter.github.io/");
        }

        private void CClipboard_Click(object sender, EventArgs e)
        {
            _mem.CopyToClipboard();
        }
    }
}
