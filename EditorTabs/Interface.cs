using System;
using WeAreDevs_API;
using System.Windows.Forms;
using System.Linq;
using System.IO;

namespace EditorTabs
{
    public partial class Interface : Form
    {
        ExploitAPI WeAreDevs = new ExploitAPI();

        public Interface() => InitializeComponent();

        private void Interface_Load(object sender, EventArgs e) => AddTab("Output", "This is an output tab, you cannot type here.", true);

        public TextBox GetEditor() => EditorTabs.SelectedTab.Controls.Cast<TextBox>().FirstOrDefault(x => x is TextBox);

        public void AddTab(string Header, string Text = "@ataridiscord on socials.", bool ReadOnly = false)
        {
            if (EditorTabs.Controls.Count != 7)
            {
                TabPage Tab = new TabPage { Text = Header };

                TextBox _TextBox = new TextBox
                {
                    Text = Text,
                    Multiline = true,
                    ReadOnly = ReadOnly,
                    Dock = DockStyle.Fill, // Fills entirety of tab page, saves us having to resize manually to a fixed width and height.
                    Parent = Tab,
                };

                EditorTabs.TabPages.Add(Tab);
                EditorTabs.SelectedTab = Tab;
            }
        }

        private void AddTabButton_Click(object sender, EventArgs e) => AddTab($"Script {EditorTabs.Controls.Count}.lua");

        private void RemoveTabButton_Click(object sender, EventArgs e)
        {
            if (EditorTabs.SelectedIndex != 0)
            {
                EditorTabs.Controls.Remove(EditorTabs.SelectedTab);

                foreach (TabPage _Tab in EditorTabs.Controls)
                {
                    if (_Tab.Text != "Output")
                        _Tab.Text = $"Script {EditorTabs.Controls.IndexOf(_Tab)}.lua";
                }
            }
        }

        public void ExecutionHandler(object sender, EventArgs e)
        {
            if (EditorTabs.SelectedIndex != 0)
            {
                switch (((Button)sender).Name)
                {
                    case "Execute":
                        WeAreDevs.SendLuaScript(GetEditor().Text);
                        break;
                    case "Clear":
                        GetEditor().Clear();
                        break;
                    case "OpenFile":
                        {
                            OpenFileDialog _OpenFileDialog = new OpenFileDialog
                            {
                                Title = "Executor - Open File",
                                Filter = "Script Files (*.lua, *.txt)|*.lua;*.txt",
                            };

                            if (_OpenFileDialog.ShowDialog() == DialogResult.OK)
                                GetEditor().Text = File.ReadAllText(_OpenFileDialog.FileName);
                            break;
                        }
                    case "SaveFile":
                        {
                            SaveFileDialog _SaveFileDialog = new SaveFileDialog
                            {
                                Title = "Executor - Save File",
                                Filter = "Script Files (*.lua, *.txt)|*.lua;*.txt",
                            };

                            if (_SaveFileDialog.ShowDialog() == DialogResult.OK)
                                File.WriteAllText(EditorTabs.SelectedTab.Text, GetEditor().Text);
                            break;
                        }
                    case "ExecuteFile":
                        {
                            OpenFileDialog _OpenFileDialog = new OpenFileDialog
                            {
                                Title = "Executor - Execute File",
                                Filter = "Script Files (*.lua, *.txt)|*.lua;*.txt",
                            };

                            if (_OpenFileDialog.ShowDialog() == DialogResult.OK)
                                WeAreDevs.SendLuaScript(File.ReadAllText(_OpenFileDialog.FileName));
                            break;
                        }
                    case "Attach":
                        WeAreDevs.LaunchExploit();
                        break;
                }
            }
        }
    }
}
