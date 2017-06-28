using Rocket.API.Serialisation;
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
    public partial class Editor : Form
    {
        internal Memory _mem;
        public Editor(string FilePath)
        {
            InitializeComponent();
            _mem = new Memory(FilePath);
            Text = "Editing: " + FilePath;
            DefGroup.Text = _mem._rp.DefaultGroup;
            _mem._rp.Groups.ForEach(k => GroupIDS.Items.Add(k.Id));
            GroupIDS.SelectedIndex = GroupIDS.Items.Count > 0 ? 0 : -1;
            RefreshGroupData();
        }

        private void AddGroup_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Please specify a new ID for a permission group.", "New Permission Group", "");
            if (input == "")
            {
                return;
            }
            var res = _mem._rp.Groups.Find(k => k.Id == input);
            if (res != null)
            {
                MessageBox.Show("A permission group with ID " + input + " already exists. Please specify a different ID.");
                return;
            }
            else
            {
                res = new RocketPermissionsGroup(input, input, _mem._rp.DefaultGroup, new List<string>(), new List<Permission>(), "white");
                _mem._rp.Groups.Add(res);
                GroupIDS.Items.Add(res.Id);
                GroupIDS.SelectedItem = res.Id;
            }
        }

        private void GroupIDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGroupData();
        }

        private void RefreshGroupData()
        {
            if (GroupIDS.SelectedItem == null)
            {
                DName.Text = "";
                DName.Enabled = false;
                Prefix.Text = "";
                Prefix.Enabled = false;
                Suffix.Text = "";
                Suffix.Enabled = false;
                CColor.Text = "";
                CColor.Enabled = false;
                PGroup.Text = "";
                PGroup.Enabled = false;
                Priority.Value = 0;
                Priority.Enabled = false;
                Cooldown.Value = 0;
                Cooldown.Enabled = false;
                Permissions.Items.Clear();
                Permissions.Enabled = false;
                AddPerm.Enabled = false;
                RemPerm.Enabled = false;
                Members.Items.Clear();
                Members.Enabled = false;
                AddMem.Enabled = false;
                RemMem.Enabled = false;
                RemoveGroup.Enabled = false;
                return;
            }
            DName.Enabled = true;
            Prefix.Enabled = true;
            Suffix.Enabled = true;
            CColor.Enabled = true;
            PGroup.Enabled = true;
            Priority.Enabled = true;
            Cooldown.Enabled = true;
            Permissions.Enabled = true;
            AddPerm.Enabled = true;
            RemPerm.Enabled = true;
            Members.Enabled = true;
            AddMem.Enabled = true;
            RemMem.Enabled = true;
            RemoveGroup.Enabled = true;
            RocketPermissionsGroup p = _mem._rp.Groups.Find(k => k.Id == GroupIDS.SelectedItem.ToString());
            DName.Text = p.DisplayName;
            Prefix.Text = p.Prefix;
            Suffix.Text = p.Suffix;
            CColor.Text = p.Color;
            PGroup.Text = p.ParentGroup;
            Priority.Value = p.Priority;
            Permissions.Items.Clear();
            p.Permissions.ForEach(k => Permissions.Items.Add(k.Name));
            if (Permissions.SelectedItem != null)
            {
                var i = p.Permissions.Find(k => k.Name == Permissions.SelectedItem.ToString());
                if (i == null)
                {
                    return;
                }
                Cooldown.Value = i.Cooldown;
                Members.Items.Clear();
                p.Members.ForEach(k => Members.Items.Add(k));
            }
            if (GroupIDS.SelectedItem.ToString() == DefGroup.Text)
            {
                AddMem.Enabled = false;
                RemMem.Enabled = false;
                RemoveGroup.Enabled = false;
            }
        }

        private void RemoveGroup_Click(object sender, EventArgs e)
        {
            if (GroupIDS.SelectedItem == null)
                return;
            RocketPermissionsGroup p = _mem._rp.Groups.Find(k => k.Id == GroupIDS.SelectedItem.ToString());
            _mem._rp.Groups.Remove(p);
            GroupIDS.Items.Remove(p.Id);
            GroupIDS.SelectedIndex = GroupIDS.Items.Count > 0 ? 0 : -1;
        }

        private void Permissions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GroupIDS.SelectedItem == null)
                return;
            RocketPermissionsGroup p = _mem._rp.Groups.Find(k => k.Id == GroupIDS.SelectedItem.ToString());
            if (Permissions.SelectedItem == null)
            {
                Cooldown.Enabled = false;
                RemPerm.Enabled = false;
                return;
            }
            Cooldown.Enabled = true;
            RemPerm.Enabled = true;
            var i = p.Permissions.Find(k => k.Name == Permissions.SelectedItem.ToString());
            Cooldown.Value = i.Cooldown;
        }

        private void AddPerm_Click(object sender, EventArgs e)
        {
            if (GroupIDS.SelectedItem == null)
                return;
            RocketPermissionsGroup p = _mem._rp.Groups.Find(k => k.Id == GroupIDS.SelectedItem.ToString());
            string input = Microsoft.VisualBasic.Interaction.InputBox("Please specify the permission to add.", "New Permission", "");
            if (input == "")
            {
                return;
            }
            var i = p.Permissions.Find(k => k.Name == input);
            if (i != null)
            {
                MessageBox.Show("The permission " + input + " already exists. Please specify a different permission.");
                return;
            }
            else
            {
                var index = _mem._rp.Groups.IndexOf(p);
                i = new Permission(input);
                p.Permissions.Add(i);
                _mem._rp.Groups[index] = p;
                Permissions.Items.Add(i.Name);
            }
        }

        private void Github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://persiafighter.github.io/");
        }

        private void Cooldown_ValueChanged(object sender, EventArgs e)
        {
            if (GroupIDS.SelectedItem == null)
                return;
            RocketPermissionsGroup p = _mem._rp.Groups.Find(k => k.Id == GroupIDS.SelectedItem.ToString());
            if (Permissions.SelectedItem == null)
                return;
            var i = p.Permissions.Find(k => k.Name == Permissions.SelectedItem.ToString());
            var index = _mem._rp.Groups.IndexOf(p);
            var ind = p.Permissions.IndexOf(i);
            i.Cooldown = Convert.ToUInt32(Cooldown.Value);
            p.Permissions[ind] = i;
            _mem._rp.Groups[index] = p;
        }

        private void RemPerm_Click(object sender, EventArgs e)
        {
            if (GroupIDS.SelectedItem == null)
                return;
            RocketPermissionsGroup p = _mem._rp.Groups.Find(k => k.Id == GroupIDS.SelectedItem.ToString());
            if (Permissions.SelectedItem == null)
                return;
            var i = p.Permissions.Find(k => k.Name == Permissions.SelectedItem.ToString());
            var index = _mem._rp.Groups.IndexOf(p);
            p.Permissions.Remove(i);
            _mem._rp.Groups[index] = p;
            Permissions.Items.Remove(i.Name);
            Permissions.SelectedIndex = Permissions.Items.Count > 0 ? 0 : -1;
        }

        private void AddMem_Click(object sender, EventArgs e)
        {
            if (GroupIDS.SelectedItem == null)
                return;
            RocketPermissionsGroup p = _mem._rp.Groups.Find(k => k.Id == GroupIDS.SelectedItem.ToString());
            string input = Microsoft.VisualBasic.Interaction.InputBox("Please specify the steam64id of the player to add.", "New Member", "");
            if (input == "")
            {
                return;
            }
            var i = p.Members.Find(k => k == input);
            if (i != null)
            {
                MessageBox.Show("The player " + input + " already is in the group. Please specify a different member.");
                return;
            }
            else
            {
                bool IsSteam64 = ulong.TryParse(input, out ulong kek);
                if (!IsSteam64)
                {
                    MessageBox.Show("\"" + input + "\" is not a steam64id, please try again.");
                    return;
                }
                var index = _mem._rp.Groups.IndexOf(p);
                i = input;
                p.Members.Add(i);
                _mem._rp.Groups[index] = p;
                Members.Items.Add(i);
            }
        }

        private void RemMem_Click(object sender, EventArgs e)
        {
            if (GroupIDS.SelectedItem == null)
                return;
            RocketPermissionsGroup p = _mem._rp.Groups.Find(k => k.Id == GroupIDS.SelectedItem.ToString());
            if (Members.SelectedItem == null)
                return;
            string i = p.Members.Find(k => k == Members.SelectedItem.ToString());
            var index = _mem._rp.Groups.IndexOf(p);
            p.Members.Remove(i);
            _mem._rp.Groups[index] = p;
            Members.Items.Remove(i);
            Members.SelectedIndex = Members.Items.Count > 0 ? 0 : -1;
        }

        private void SExit_Click(object sender, EventArgs e)
        {
            _mem._rp.DefaultGroup = DefGroup.Text;
            _mem.Save();
            Environment.Exit(0);
        }

        private void OpenFold_Click(object sender, EventArgs e)
        {
            if (OpenRocket.ShowDialog() == DialogResult.OK)
            {
                _mem.Load(OpenRocket.FileName);
                Text = "Editing: " + OpenRocket.FileName;
                DefGroup.Text = _mem._rp.DefaultGroup;
                GroupIDS.Items.Clear();
                _mem._rp.Groups.ForEach(k => GroupIDS.Items.Add(k.Id));
                GroupIDS.SelectedIndex = GroupIDS.Items.Count > 0 ? 0 : -1;
                RefreshGroupData();
            }
        }

        private void DefGroup_TextChanged(object sender, EventArgs e)
        {
            if (GroupIDS.SelectedItem == null)
                return;
            if (GroupIDS.SelectedItem.ToString() == DefGroup.Text)
            {
                AddMem.Enabled = false;
                RemMem.Enabled = false;
                RemoveGroup.Enabled = false;
            }
            else
            {
                AddMem.Enabled = true;
                RemMem.Enabled = true;
                RemoveGroup.Enabled = true;
            }
        }
    }
}
