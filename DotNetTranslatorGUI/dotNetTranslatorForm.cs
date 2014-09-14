using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DotNetTranslator.Business;
using System.IO;

namespace DotNetTranslatorGUI
{
    public partial class dotNetTranslatorForm : Form
    {
        public dotNetTranslatorForm()
        {
            InitializeComponent();
        }

        private void openVBButton_Click(object sender, EventArgs e)
        {

             
            if (getVBFilesDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveCSFilesDialog.ShowDialog() == DialogResult.OK)
                {
                    var csFilesNames = getVBFilesDialog.FileNames.Select(x => x.Replace(".vb", ".cs").Remove(0, x.LastIndexOf(@"\")).Insert(0, saveCSFilesDialog.SelectedPath)).ToArray();
                    if (csFilesNames.Length > 0)
                    {
                        for (int i = 0; i < getVBFilesDialog.FileNames.Length; i++)
                        {
                            if (File.Exists(csFilesNames[i]))
                            {
                                var overwriteFileMessage = MessageBox.Show(csFilesNames[i].Remove(0, csFilesNames[i].LastIndexOf(@"\") + 1) + " already exists. Would you like to overwrite it?", "File Exists", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                                if (overwriteFileMessage == DialogResult.Yes)
                                {
                                    File.Delete(csFilesNames[i]);
                                }
                                else if (overwriteFileMessage == DialogResult.No)
                                {
                                    var index = 0;
                                    string filename = null;
                                    do
                                    {
                                        index++;
                                        filename = csFilesNames[i].Insert(csFilesNames[i].LastIndexOf("."), string.Format("({0})", index));
                                    }
                                    while (File.Exists(filename));
                                    if (filename != null)
                                    {
                                        csFilesNames[i] = filename;
                                    }
                                }
                                else
                                {
                                    csFilesNames[i] = csFilesNames[i].Remove(0, csFilesNames[i].LastIndexOf(@"\")+1);
                                    continue;
                                }
                            }

                            try
                            {
                                using (var stream = Converter.ConvertVbtoCSharp(getVBFilesDialog.FileNames[i]))
                                using (var fileStream = new FileStream(csFilesNames[i], FileMode.CreateNew))
                                {
                                    stream.Seek(0, SeekOrigin.Begin);
                                    stream.CopyTo(fileStream);
                                }

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(string.Format("There was an error while converting file {0}. \n Exception: {1}", getVBFilesDialog.FileNames[i].Remove(0, getVBFilesDialog.FileNames[i].LastIndexOf(@"\") + 1), ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                        }

                        var message = "The following files where not converted:";
                        var error = false;
                        foreach (var filename in csFilesNames)
                        {
                            if (!File.Exists(filename))
                            {
                                message += "\n";
                                message += filename.Remove(0, filename.LastIndexOf(@"\") + 1);
                                error = true;
                            }
                        }

                        if (error)
                        {
                            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("All files converted successfully.", "Success");
                        }

                    }
                    else
                    {
                        MessageBox.Show("There was something wrong with the file names you selected. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }

            }


        }
    }
}
