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

        /// <summary>
        /// DEFINE FUNCTIONS
        /// </summary>

        public void RegEdit() // Define a function for Registry Editor
        {
            Process regEdit = new Process();            // Start a new process and call it regEdit
            regEdit.StartInfo.FileName = "regedit.exe"; // Pathname to file, in this case it is regedit.exe, found in windir
            regEdit.Start();                            // Start the process
        }
        public void GpoEdit() // Define a function for Group Policy Editor
        {
            Process groupEdit = new Process();                  // Start a new process and call it groupEdit
            groupEdit.StartInfo.FileName = "cmd.exe";           // To open the GPO editor we need to use Command Prompt with arguments
            groupEdit.StartInfo.Arguments = "/c gpedit.msc";    // Open gpedit.msc
            groupEdit.Start();                                  // Start the process
        }
        public void ControlPanel() // Define a function for Control Panel
        {
            Process cPanel = new Process();                  // Start a new process and call it cPanel
            cPanel.StartInfo.FileName = "control.exe";       // Open the Control panel, called control.exe, found in System32
            cPanel.Start();                                  // Start the process
        }

        public void ResourceMon() // Define a function for the Resource Monitor
        {
            Process resMon = new Process();                  // Start a new process and call it resMon
            resMon.StartInfo.FileName = "resmon.exe";        // Open the Resource Monitor, called resmon.exe, found in System32
            resMon.Start();                                  // Start the process
        }
        public void compMgmt() // Define a function for Computer Management (compmgmt.msc)
        {
            Process cMg = new Process();                  // Start a new process and call it cMg
            cMg.StartInfo.FileName = "cmd.exe";           // To open Computer Management we need to use Command Prompt with arguments, similar to GPOedit
            cMg.StartInfo.Arguments = "/c compmgmt.msc";  // Open gpedit.msc
            cMg.Start();                                  // Start the process
        }
        public void diskMgmt() // Define a function for Disk Management (diskmgmt.msc)
        {
            Process dMg = new Process();                  // Start a new process and call it dMg
            dMg.StartInfo.FileName = "cmd.exe";           // To open Disk Management we need to use Command Prompt with arguments, similar to GPOedit
            dMg.StartInfo.Arguments = "/c diskmgmt.msc";  // Open gpedit.msc
            dMg.Start();                                  // Start the process
        }
        public void cmdPrompt() // Define a function for Command Prompt
        {
            Process cmdP = new Process();                  // Start a new process and call it cmdP
            cmdP.StartInfo.FileName = "cmd.exe";           // Open cmd.exe, the command prompt
            cmdP.Start();                                  // Start the process
        }
        public void cmdAdmin() // Define a function for Command Prompt, but running as administrator
        {
            Process cmdA = new Process();                  // Start a new process and call it cmdP
            cmdA.StartInfo.FileName = "cmd.exe";           // Open cmd.exe, the command prompt
            cmdA.StartInfo.Verb = "runas";                 // Run as administrator
            cmdA.Start();                                  // Start the process
        }
        public void powerSH() // Define a function for PowerShell
        {
            Process pSH = new Process();                  // Start a new process and call it pSH
            pSH.StartInfo.FileName = "powershell.exe";    // Open powershell.exe
            pSH.Start();                                  // Start the process
        }
        public void powerA() // Define a function for PowerShell as admin
        {
            Process pA = new Process();                  // Start a new process and call it pA
            pA.StartInfo.FileName = "powershell.exe";    // Open powershell.exe
            pA.StartInfo.Verb = "runas";                 // Run as administrator
            pA.Start();                                  // Start the process
        }
        public void taskMan() // Define a function for Task Manager
        {
            Process taskM = new Process();                  // Start a new process and call it taskM
            taskM.StartInfo.FileName = "taskmgr.exe";       // Open taskmgr.exe, the executable for Task Manager
            taskM.Start();                                  // Start the process
        }
        public void msConf() // Define a function for msinfo32.
        {
            Process msC = new Process();                    // Start a new process and call it msC
            msC.StartInfo.FileName = "msinfo32.exe";        // Open msinfo32.exe
            msC.Start();                                    // Start the process  
        }
        /// <summary>
        /// ASSIGN BUTTONS TO FUNCTIONS
        /// </summary>

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

        private void perfmon_Click(object sender, EventArgs e)
        {
            ResourceMon();
        }

        private void compmgmt_Click(object sender, EventArgs e)
        {
            compMgmt();
        }

        private void cmd_Click(object sender, EventArgs e)
        {
            cmdPrompt();
        }

        private void cmd_admin_Click(object sender, EventArgs e)
        {
            cmdAdmin();
        }

        private void pshell_Click(object sender, EventArgs e)
        {
            powerSH();
        }

        private void pshell_admin_Click(object sender, EventArgs e)
        {
            powerA();
        }

        private void taskman_Click(object sender, EventArgs e)
        {
            taskMan();
        }

        private void sniptool_Click(object sender, EventArgs e)
        {
            msConf();
        }

        private void diskmgmt_Click(object sender, EventArgs e)
        {
            diskMgmt();
        }
    }
}
