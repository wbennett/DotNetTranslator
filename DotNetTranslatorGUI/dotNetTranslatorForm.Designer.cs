namespace DotNetTranslatorGUI
{
    partial class dotNetTranslatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dotNetTranslatorForm));
            this.openVBButton = new System.Windows.Forms.Button();
            this.instructionsLabel = new System.Windows.Forms.TextBox();
            this.getVBFilesDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveCSFilesDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // openVBButton
            // 
            this.openVBButton.Location = new System.Drawing.Point(169, 104);
            this.openVBButton.Name = "openVBButton";
            this.openVBButton.Size = new System.Drawing.Size(140, 39);
            this.openVBButton.TabIndex = 2;
            this.openVBButton.Text = "Select VB files";
            this.openVBButton.UseVisualStyleBackColor = true;
            this.openVBButton.Click += new System.EventHandler(this.openVBButton_Click);
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instructionsLabel.Enabled = false;
            this.instructionsLabel.Location = new System.Drawing.Point(59, 39);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.ReadOnly = true;
            this.instructionsLabel.Size = new System.Drawing.Size(401, 15);
            this.instructionsLabel.TabIndex = 3;
            this.instructionsLabel.Text = "The Dot Net Translator converts VB.NET code into C# code.";
            // 
            // getVBFilesDialog
            // 
            this.getVBFilesDialog.DefaultExt = "vb";
            this.getVBFilesDialog.Filter = "VB.NET files|*.vb";
            this.getVBFilesDialog.Multiselect = true;
            this.getVBFilesDialog.Title = "Select .vb files";
            // 
            // saveCSFilesDialog
            // 
            this.saveCSFilesDialog.Description = "Choose Directory to save .cs files";
            // 
            // dotNetTranslatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(486, 234);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.openVBButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dotNetTranslatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dot Net Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openVBButton;
        private System.Windows.Forms.TextBox instructionsLabel;
        private System.Windows.Forms.OpenFileDialog getVBFilesDialog;
        private System.Windows.Forms.FolderBrowserDialog saveCSFilesDialog;
    }
}

