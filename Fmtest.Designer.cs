﻿
namespace Practicasemana11
{
    partial class Fmtest
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
            this.btntest = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btntest
            // 
            this.btntest.Location = new System.Drawing.Point(268, 198);
            this.btntest.Name = "btntest";
            this.btntest.Size = new System.Drawing.Size(164, 43);
            this.btntest.TabIndex = 0;
            this.btntest.Text = "Test";
            this.btntest.UseSelectable = true;
            this.btntest.Click += new System.EventHandler(this.btntest_Click);
            // 
            // Fmtest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntest);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Fmtest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fmtest";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btntest;
    }
}