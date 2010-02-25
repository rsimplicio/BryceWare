namespace BryceWareEMR
{
    partial class BryceWareEMRMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            this.PatAcct = new System.Windows.Forms.Label();
            this.PatAcctBox = new System.Windows.Forms.TextBox();
            this.Generator = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PatAcct
            // 
            this.PatAcct.AutoSize = true;
            this.PatAcct.Location = new System.Drawing.Point(30, 22);
            this.PatAcct.Name = "PatAcct";
            this.PatAcct.Size = new System.Drawing.Size(83, 13);
            this.PatAcct.TabIndex = 0;
            this.PatAcct.Text = "Patient Account";
            // 
            // PatAcctBox
            // 
            this.PatAcctBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PatAcctBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.PatAcctBox.Location = new System.Drawing.Point(125, 21);
            this.PatAcctBox.Name = "PatAcctBox";
            this.PatAcctBox.ReadOnly = true;
            this.PatAcctBox.Size = new System.Drawing.Size(263, 20);
            this.PatAcctBox.TabIndex = 1;
            this.PatAcctBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Generator
            // 
            this.Generator.AutoSize = true;
            this.Generator.Location = new System.Drawing.Point(154, 66);
            this.Generator.Name = "Generator";
            this.Generator.Size = new System.Drawing.Size(0, 13);
            this.Generator.TabIndex = 2;
            this.Generator.Click += new System.EventHandler(this.label1_Click);
            // 
            // BryceWareEMRMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 140);
            this.Controls.Add(this.Generator);
            this.Controls.Add(this.PatAcctBox);
            this.Controls.Add(this.PatAcct);
            this.Name = "BryceWareEMRMain";
            this.Text = "BryceWare EMR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PatAcct;
        private System.Windows.Forms.TextBox PatAcctBox;
        private System.Windows.Forms.Label Generator;
    }
}

