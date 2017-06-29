using Rocket.Core.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                return;
            CommandMapping c = _mem._rc.CommandMappings.Find(k => k.Name == Commands.SelectedItem.ToString());
            ECommand.Checked = c.Enabled;
            CPriority.SelectedIndex = CPriority.Items.IndexOf(c.Priority.ToString());
            CNamespace.Text = c.Class;
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
            if (!_controlled)
            {

            }
        }

        private void RemComm_Click(object sender, EventArgs e)
        {

        }

        private void ECommand_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CPriority_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CNamespace_TextChanged(object sender, EventArgs e)
        {

        }

        private void OpenFold_Click(object sender, EventArgs e)
        {

        }
    }
}
