
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
            this.button3 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.compmgmt = new System.Windows.Forms.Button();
            this.cmd_admin = new System.Windows.Forms.Button();
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(224, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 50);
            this.button3.TabIndex = 14;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(330, 68);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 50);
            this.button10.TabIndex = 13;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 130);
            this.Controls.Add(this.cmd_admin);
            this.Controls.Add(this.cmd);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.compmgmt);
            this.Controls.Add(this.gpedit_button);
            this.Controls.Add(this.asd_button);
            this.Controls.Add(this.perfmon);
            this.Controls.Add(this.regedit_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Windows Toolkit";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button regedit_button;
        private System.Windows.Forms.Button perfmon;
        private System.Windows.Forms.Button asd_button;
        private System.Windows.Forms.Button gpedit_button;
        private System.Windows.Forms.Button cmd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button compmgmt;
        private System.Windows.Forms.Button cmd_admin;
    }
}

