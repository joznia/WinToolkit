using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WinToolkit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void RegEdit() // Define a function for Registry Editor
        {
            Process regEdit = new Process();            // Start a new process and call it regEdit
            regEdit.StartInfo.FileName = "regedit.exe"; // Pathname to file, in this case it is regedit.exe, found in windir
            regEdit.Start();                            // Start the process
        }
        public void GpoEdit() // Define a function for Group Policy Editor
        {
            Process groupEdit = new Process();                  // Start a new process and call it groupEdit
            groupEdit.StartInfo.FileName = "cmd.exe";           // To open the GPO editor we need to use cmd with arguments
            groupEdit.StartInfo.Arguments = "/c gpedit.msc";    // Open gpedit.msc
            groupEdit.Start();                                  // Start the process
        }
        public void ControlPanel() // Define a function for Control Panel
        {
            Process cPanel = new Process();                  // Start a new process and call it controlPanel
            cPanel.StartInfo.FileName = "cmd.exe";           // To open the GPO editor we need to use cmd with arguments
            cPanel.Start();                                  // Start the process
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegEdit();
        }

        // Group Policy button
        private void button9_Click(object sender, EventArgs e)
        {
            GpoEdit();
        }

        // Control Panel button
        private void asd_button_Click(object sender, EventArgs e)
        {
            ControlPanel();
        }
    }
}
