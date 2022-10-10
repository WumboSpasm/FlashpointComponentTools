﻿namespace FlashpointInstaller
{
    partial class Finish
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
            this.RunOnClose = new System.Windows.Forms.CheckBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RunOnClose
            // 
            this.RunOnClose.AutoSize = true;
            this.RunOnClose.Checked = true;
            this.RunOnClose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RunOnClose.Location = new System.Drawing.Point(12, 42);
            this.RunOnClose.Name = "RunOnClose";
            this.RunOnClose.Size = new System.Drawing.Size(144, 19);
            this.RunOnClose.TabIndex = 1;
            this.RunOnClose.Text = "Run Flashpoint on exit";
            this.RunOnClose.UseVisualStyleBackColor = true;
            // 
            // Close
            // 
            this.CloseButton.Location = new System.Drawing.Point(217, 39);
            this.CloseButton.Name = "Close";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.Exit);
            // 
            // Message
            // 
            this.Message.Location = new System.Drawing.Point(12, 9);
            this.Message.Margin = new System.Windows.Forms.Padding(0);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(280, 20);
            this.Message.TabIndex = 3;
            this.Message.Text = "Flashpoint Infinity has been successfully installed.";
            this.Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Finish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 73);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.RunOnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Finish";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Installation Complete";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exit);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CheckBox RunOnClose;
        private Button CloseButton;
        private Label Message;
    }
}