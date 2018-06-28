using Rocket.API.Serialisation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace Persiafighter.Programs.RocketConfigEditor
{
    public partial class PermissionsEditor : Form
    {
        private PermissionsMemory _mem;
        private bool _controlled;
        private string _oldid;
        private bool _fs;
        public PermissionsEditor(string FilePath, bool FileSystem = true)
        {
            InitializeComponent();

            if (!FileSystem)
            {
                OpenFold.Enabled = false;
                _fs = FileSystem;
                _mem = new PermissionsMemory();
                Text = "Editing: Local GUI";
                _oldid = _mem._rp.DefaultGroup;
                DefGroup.Text = _mem._rp.DefaultGroup;
                _mem._rp.Groups.ForEach(k => GroupIDS.Items.Add(k.Id));
                GroupIDS.SelectedIndex = GroupIDS.Items.Count > 0 ? 0 : -1;
                RefreshGroupData();
                return;
            }

            if (FilePath == "")
            {
                OpenRocket.Filter = "Rocket Permissions|" + Rocket.Core.Environment.PermissionFile;
                if (OpenRocket.ShowDialog() == DialogResult.OK)
                {
                    _mem = new PermissionsMemory(OpenRocket.FileName);
                    Text = "Editing: " + OpenRocket.FileName;
                    _oldid = _mem._rp.DefaultGroup;
                    DefGroup.Text = _mem._rp.DefaultGroup;
                    _mem._rp.Groups.ForEach(k => GroupIDS.Items.Add(k.Id));
                    GroupIDS.SelectedIndex = GroupIDS.Items.Count > 0 ? 0 : -1;
                    RefreshGroupData();
                    return;
                }
                else
                {
                    Load += (s, e) => Close();
                    return;
                }
            }
            _mem = new PermissionsMemory(FilePath);
            Text = "Editing: " + FilePath;
            _oldid = _mem._rp.DefaultGroup;
            DefGroup.Text = _mem._rp.DefaultGroup;
            _mem._rp.Groups.ForEach(k => GroupIDS.Items.Add(k.Id));
            GroupIDS.SelectedIndex = GroupIDS.Items.Count > 0 ? 0 : -1;
            RefreshGroupData();
        }

        private void AddGroup_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Please specify a new ID for a permission group.", "New Permission Group", "");
            if (input == "")
                return;
            var res = _mem._rp.Groups.Find(k => k.Id == input);
            if (res != null)
                MessageBox.Show("A permission group with ID " + input + " already exists. Please specify a different ID.");
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
            _controlled = true;
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
            _controlled = false;
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
                return;
            var i = p.Permissions.Find(k => k.Name == input);
            if (i != null)
                MessageBox.Show("The permission " + input + " already exists. Please specify a different permission.");
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
            if (!_fs)
                _mem.Save();
            else
                _mem.CopyToClipboard();
            Close();
        }

        private void OpenFold_Click(object sender, EventArgs e)
        {
            OpenRocket.Filter = "Rocket Permissions|" + Rocket.Core.Environment.PermissionFile;
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
            if (DefGroup.Text == "")
                DefGroup.Text = _oldid;
            if (GroupIDS.SelectedItem == null)
                return;
            var ind = GroupIDS.Items.IndexOf(DefGroup.Text);
            if (ind != -1)
                DefGroup.Text = _oldid;
            RocketPermissionsGroup p = _mem._rp.Groups.Find(k => k.Id == _oldid);
            var index = _mem._rp.Groups.IndexOf(p);
            string oldid = p.Id;
            p.Id = DefGroup.Text;
            _mem._rp.Groups[index] = p;
            GroupIDS.Items[GroupIDS.Items.IndexOf(oldid)] = DefGroup.Text;
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
            _oldid = DefGroup.Text;
        }

        private void DName_TextChanged(object sender, EventArgs e)
        {
            if (!_controlled)
            {
                if (GroupIDS.SelectedItem == null)
                    return;
                RocketPermissionsGroup p = _mem._rp.Groups.Find(k => k.Id == GroupIDS.SelectedItem.ToString());
                var index = _mem._rp.Groups.IndexOf(p);
                p.DisplayName = DName.Text;
                _mem._rp.Groups[index] = p;
            }
        }

        private void Prefix_TextChanged(object sender, EventArgs e)
        {
            if (!_controlled)
            {
                if (GroupIDS.SelectedItem == null)
                    return;
                RocketPermissionsGroup p = _mem._rp.Groups.Find(k => k.Id == GroupIDS.SelectedItem.ToString());
                var index = _mem._rp.Groups.IndexOf(p);
                p.Prefix = Prefix.Text;
                _mem._rp.Groups[index] = p;
            }
        }

        private void Suffix_TextChanged(object sender, EventArgs e)
        {
            if (!_controlled)
            {
                if (GroupIDS.SelectedItem == null)
                    return;
                RocketPermissionsGroup p = _mem._rp.Groups.Find(k => k.Id == GroupIDS.SelectedItem.ToString());
                var index = _mem._rp.Groups.IndexOf(p);
                p.Suffix = Suffix.Text;
                _mem._rp.Groups[index] = p;
            }
        }

        private void CColor_TextChanged(object sender, EventArgs e)
        {
            if (!_controlled)
            {
                if (GroupIDS.SelectedItem == null)
                    return;
                RocketPermissionsGroup p = _mem._rp.Groups.Find(k => k.Id == GroupIDS.SelectedItem.ToString());
                var index = _mem._rp.Groups.IndexOf(p);
                p.Color = CColor.Text;
                _mem._rp.Groups[index] = p;
            }
        }

        private void PGroup_TextChanged(object sender, EventArgs e)
        {
            if (!_controlled)
            {
                if (GroupIDS.SelectedItem == null)
                    return;
                RocketPermissionsGroup p = _mem._rp.Groups.Find(k => k.Id == GroupIDS.SelectedItem.ToString());
                var index = _mem._rp.Groups.IndexOf(p);
                p.ParentGroup = PGroup.Text;
                _mem._rp.Groups[index] = p;
            }
        }

        private void Priority_ValueChanged(object sender, EventArgs e)
        {
            if (!_controlled)
            {
                if (GroupIDS.SelectedItem == null)
                    return;
                RocketPermissionsGroup p = _mem._rp.Groups.Find(k => k.Id == GroupIDS.SelectedItem.ToString());
                var index = _mem._rp.Groups.IndexOf(p);
                p.Priority = (short)Priority.Value;
                _mem._rp.Groups[index] = p;
            }
        }

        private void CClipboard_Click(object sender, EventArgs e)
        {
            _mem.CopyToClipboard();
        }
    }
}
