﻿
namespace WinToolkit
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.regedit_button = new System.Windows.Forms.Button();
            this.perfmon = new System.Windows.Forms.Button();
            this.asd_button = new System.Windows.Forms.Button();
            this.gpedit_button = new System.Windows.Forms.Button();
            this.cmd = new System.Windows.Forms.Button();
            this.pshell = new System.Windows.Forms.Button();
            this.taskman = new System.Windows.Forms.Button();
            this.compmgmt = new System.Windows.Forms.Button();
            this.cmd_admin = new System.Windows.Forms.Button();
            this.pshell_admin = new System.Windows.Forms.Button();
            this.sniptool = new System.Windows.Forms.Button();
            this.eventviewer = new System.Windows.Forms.Button();
            this.notepad = new System.Windows.Forms.Button();
            this.diskmgmt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // regedit_button
            // 
            this.regedit_button.Location = new System.Drawing.Point(12, 12);
            this.regedit_button.Name = "regedit_button";
            this.regedit_button.Size = new System.Drawing.Size(100, 50);
            this.regedit_button.TabIndex = 0;
            this.regedit_button.Text = "Registry Editor";
            this.regedit_button.UseVisualStyleBackColor = true;
            this.regedit_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // perfmon
            // 
            this.perfmon.Location = new System.Drawing.Point(330, 12);
            this.perfmon.Name = "perfmon";
            this.perfmon.Size = new System.Drawing.Size(100, 50);
            this.perfmon.TabIndex = 6;
            this.perfmon.Text = "Resource Monitor";
            this.perfmon.UseVisualStyleBackColor = true;
            this.perfmon.Click += new System.EventHandler(this.perfmon_Click);
            // 
            // asd_button
            // 
            this.asd_button.Location = new System.Drawing.Point(224, 12);
            this.asd_button.Name = "asd_button";
            this.asd_button.Size = new System.Drawing.Size(100, 50);
            this.asd_button.TabIndex = 7;
            this.asd_button.Text = "Control Panel";
            this.asd_button.UseVisualStyleBackColor = true;
            this.asd_button.Click += new System.EventHandler(this.asd_button_Click);
            // 
            // gpedit_button
            // 
            this.gpedit_button.Location = new System.Drawing.Point(118, 12);
            this.gpedit_button.Name = "gpedit_button";
            this.gpedit_button.Size = new System.Drawing.Size(100, 50);
            this.gpedit_button.TabIndex = 8;
            this.gpedit_button.Text = "Group Policy Editor";
            this.gpedit_button.UseVisualStyleBackColor = true;
            this.gpedit_button.Click += new System.EventHandler(this.button9_Click);
            // 
            // cmd
            // 
            this.cmd.Location = new System.Drawing.Point(118, 68);
            this.cmd.Name = "cmd";
            this.cmd.Size = new System.Drawing.Size(100, 25);
            this.cmd.TabIndex = 15;
            this.cmd.Text = "Command Prompt";
            this.cmd.UseVisualStyleBackColor = true;
            this.cmd.Click += new System.EventHandler(this.cmd_Click);
            // 
            // pshell
            // 
            this.pshell.Location = new System.Drawing.Point(224, 68);
            this.pshell.Name = "pshell";
            this.pshell.Size = new System.Drawing.Size(100, 25);
            this.pshell.TabIndex = 14;
            this.pshell.Text = "PowerShell";
            this.pshell.UseVisualStyleBackColor = true;
            this.pshell.Click += new System.EventHandler(this.pshell_Click);
            // 
            // taskman
            // 
            this.taskman.Location = new System.Drawing.Point(330, 68);
            this.taskman.Name = "taskman";
            this.taskman.Size = new System.Drawing.Size(100, 50);
            this.taskman.TabIndex = 13;
            this.taskman.Text = "Task Manager";
            this.taskman.UseVisualStyleBackColor = true;
            this.taskman.Click += new System.EventHandler(this.taskman_Click);
            // 
            // compmgmt
            // 
            this.compmgmt.Location = new System.Drawing.Point(12, 68);
            this.compmgmt.Name = "compmgmt";
            this.compmgmt.Size = new System.Drawing.Size(100, 50);
            this.compmgmt.TabIndex = 9;
            this.compmgmt.Text = "Computer Management";
            this.compmgmt.UseVisualStyleBackColor = true;
            this.compmgmt.Click += new System.EventHandler(this.compmgmt_Click);
            // 
            // cmd_admin
            // 
            this.cmd_admin.Location = new System.Drawing.Point(118, 93);
            this.cmd_admin.Name = "cmd_admin";
            this.cmd_admin.Size = new System.Drawing.Size(100, 25);
            this.cmd_admin.TabIndex = 16;
            this.cmd_admin.Text = "CMD (Admin)";
            this.cmd_admin.UseVisualStyleBackColor = true;
            this.cmd_admin.Click += new System.EventHandler(this.cmd_admin_Click);
            // 
            // pshell_admin
            // 
            this.pshell_admin.Location = new System.Drawing.Point(224, 93);
            this.pshell_admin.Name = "pshell_admin";
            this.pshell_admin.Size = new System.Drawing.Size(100, 25);
            this.pshell_admin.TabIndex = 17;
            this.pshell_admin.Text = "pShell (Admin)";
            this.pshell_admin.UseVisualStyleBackColor = true;
            this.pshell_admin.Click += new System.EventHandler(this.pshell_admin_Click);
            // 
            // sniptool
            // 
            this.sniptool.Location = new System.Drawing.Point(118, 124);
            this.sniptool.Name = "sniptool";
            this.sniptool.Size = new System.Drawing.Size(100, 50);
            this.sniptool.TabIndex = 18;
            this.sniptool.Text = "System Information (msinfo32)";
            this.sniptool.UseVisualStyleBackColor = true;
            this.sniptool.Click += new System.EventHandler(this.sniptool_Click);
            // 
            // eventviewer
            // 
            this.eventviewer.Location = new System.Drawing.Point(330, 124);
            this.eventviewer.Name = "eventviewer";
            this.eventviewer.Size = new System.Drawing.Size(100, 50);
            this.eventviewer.TabIndex = 19;
            this.eventviewer.Text = "Event Viewer";
            this.eventviewer.UseVisualStyleBackColor = true;
            this.eventviewer.Click += new System.EventHandler(this.eventviewer_Click);
            // 
            // notepad
            // 
            this.notepad.Location = new System.Drawing.Point(224, 124);
            this.notepad.Name = "notepad";
            this.notepad.Size = new System.Drawing.Size(100, 50);
            this.notepad.TabIndex = 20;
            this.notepad.Text = "Notepad";
            this.notepad.UseVisualStyleBackColor = true;
            this.notepad.Click += new System.EventHandler(this.notepad_Click);
            // 
            // diskmgmt
            // 
            this.diskmgmt.Location = new System.Drawing.Point(12, 124);
            this.diskmgmt.Name = "diskmgmt";
            this.diskmgmt.Size = new System.Drawing.Size(100, 50);
            this.diskmgmt.TabIndex = 21;
            this.diskmgmt.Text = "Disk Management";
            this.diskmgmt.UseVisualStyleBackColor = true;
            this.diskmgmt.Click += new System.EventHandler(this.diskmgmt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 186);
            this.Controls.Add(this.diskmgmt);
            this.Controls.Add(this.notepad);
            this.Controls.Add(this.eventviewer);
            this.Controls.Add(this.sniptool);
            this.Controls.Add(this.pshell_admin);
            this.Controls.Add(this.cmd_admin);
            this.Controls.Add(this.cmd);
            this.Controls.Add(this.pshell);
            this.Controls.Add(this.taskman);
            this.Controls.Add(this.compmgmt);
            this.Controls.Add(this.gpedit_button);
            this.Controls.Add(this.asd_button);
            this.Controls.Add(this.perfmon);
            this.Controls.Add(this.regedit_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Windows Toolkit v1.1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button regedit_button;
        private System.Windows.Forms.Button perfmon;
        private System.Windows.Forms.Button asd_button;
        private System.Windows.Forms.Button gpedit_button;
        private System.Windows.Forms.Button cmd;
        private System.Windows.Forms.Button pshell;
        private System.Windows.Forms.Button taskman;
        private System.Windows.Forms.Button compmgmt;
        private System.Windows.Forms.Button cmd_admin;
        private System.Windows.Forms.Button pshell_admin;
        private System.Windows.Forms.Button sniptool;
        private System.Windows.Forms.Button eventviewer;
        private System.Windows.Forms.Button notepad;
        private System.Windows.Forms.Button diskmgmt;
    }
}

