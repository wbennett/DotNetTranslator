namespace DotNetTranslatorUI
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtConvert = new System.Windows.Forms.Button();
            this.rdbToVB = new System.Windows.Forms.RadioButton();
            this.rdbToCSharp = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtFrom);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtTo);
            this.splitContainer1.Size = new System.Drawing.Size(1270, 689);
            this.splitContainer1.SplitterDistance = 587;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbToCSharp);
            this.panel1.Controls.Add(this.rdbToVB);
            this.panel1.Controls.Add(this.txtConvert);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 689);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1270, 38);
            this.panel1.TabIndex = 0;
            // 
            // txtFrom
            // 
            this.txtFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFrom.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrom.Location = new System.Drawing.Point(0, 0);
            this.txtFrom.Multiline = true;
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(587, 689);
            this.txtFrom.TabIndex = 0;
            // 
            // txtTo
            // 
            this.txtTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTo.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTo.Location = new System.Drawing.Point(0, 0);
            this.txtTo.Multiline = true;
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(679, 689);
            this.txtTo.TabIndex = 1;
            // 
            // txtConvert
            // 
            this.txtConvert.Location = new System.Drawing.Point(12, 6);
            this.txtConvert.Name = "txtConvert";
            this.txtConvert.Size = new System.Drawing.Size(75, 23);
            this.txtConvert.TabIndex = 0;
            this.txtConvert.Text = "Convert";
            this.txtConvert.UseVisualStyleBackColor = true;
            this.txtConvert.Click += new System.EventHandler(this.txtConvert_Click);
            // 
            // rdbToVB
            // 
            this.rdbToVB.AutoSize = true;
            this.rdbToVB.Location = new System.Drawing.Point(224, 9);
            this.rdbToVB.Name = "rdbToVB";
            this.rdbToVB.Size = new System.Drawing.Size(95, 17);
            this.rdbToVB.TabIndex = 1;
            this.rdbToVB.Text = "To VisualBasic";
            this.rdbToVB.UseVisualStyleBackColor = true;
            // 
            // rdbToCSharp
            // 
            this.rdbToCSharp.AutoSize = true;
            this.rdbToCSharp.Checked = true;
            this.rdbToCSharp.Location = new System.Drawing.Point(144, 9);
            this.rdbToCSharp.Name = "rdbToCSharp";
            this.rdbToCSharp.Size = new System.Drawing.Size(74, 17);
            this.rdbToCSharp.TabIndex = 2;
            this.rdbToCSharp.TabStop = true;
            this.rdbToCSharp.Text = "To Csharp";
            this.rdbToCSharp.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 727);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Converter for C# and VisualBasic";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbToCSharp;
        private System.Windows.Forms.RadioButton rdbToVB;
        private System.Windows.Forms.Button txtConvert;
    }
}

