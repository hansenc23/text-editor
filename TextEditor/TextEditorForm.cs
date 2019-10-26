using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
 
    public partial class TextEditorForm : Form
    {
        private LoginForm loginForm;
        
        private bool saved = false;
        private string currentPath = "";
        public TextEditorForm(User user)
        {
            InitializeComponent();
            toolStripLabel1.Text = user.Username;


            //check the user type
            if (user.User_Type.Equals("View"))
            {
                richTextBox1.Enabled = false;
            }

            this.Text = "Untitled - Textpad";

            
        }


        private void TextEditorForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            
            Application.Exit();
 
        }

        private void CutToolStripButton1_Click(object sender, EventArgs e)
        {
            CutToolStripMenuItem_Click(sender, e);
        }

        private void PasteToolStripButton3_Click(object sender, EventArgs e)
        {
            PasteToolStripMenuItem_Click(sender, e);
        }

        private void CopyToolStripButton2_Click(object sender, EventArgs e)
        {
            CopyToolStripMenuItem_Click(sender, e);
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // check if text is currently selected in the text box.   
            if (richTextBox1.SelectedText != "")
                richTextBox1.Cut();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // check if there is any text in the Clipboard to paste into the rich text box.
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
       
                richTextBox1.Paste();
            }
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // check if text is selected in the text box.   
            if (richTextBox1.SelectionLength > 0)
                richTextBox1.Copy();
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPath = "";
            this.Text = "*" + "Untitled";
            richTextBox1.ResetText();
        }

        private void NewToolStripButton_Click(object sender, EventArgs e)
        {
            NewToolStripMenuItem_Click(sender, e);
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //filter rtf files
            openFileDialog1.Filter = "RTF Files|*.rtf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //load rtf file
                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    string filename = Path.GetFileName(openFileDialog1.FileName);
                    currentPath = openFileDialog1.FileName;
                    this.Text = filename;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

         
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "RTF Files|*.rtf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
            
                richTextBox1.SaveFile(saveFileDialog1.FileName);
                string filename = Path.GetFileName(saveFileDialog1.FileName);
                this.Text = filename;
                currentPath = saveFileDialog1.FileName;
            }
        }

        private void RichTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            saved = false;
            if (saved == false && currentPath.Equals(""))
            {

                //this.Text = "*" + Path.GetFileName(currentPath);
                this.Text = "*" + "Untitled - Textpad";

            }
            else if(saved == false)
            {
                this.Text = "*" + Path.GetFileName(currentPath);
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                saved = true;
                if (saved == true)
                {
                    this.Text = Path.GetFileName(currentPath);
                }
                richTextBox1.SaveFile(currentPath);
            }
            catch(Exception ex)
            {
                SaveAsToolStripMenuItem_Click(sender, e);
            }
            
        }

        private void BoldToolStripButton_Click(object sender, EventArgs e)
        {



            if (!richTextBox1.SelectionFont.Bold)
                textIterator("bold");
            else
                textIterator("unbold");

            

        }

        
        private void ItalicToolStripButton_Click(object sender, EventArgs e)
        {


            if (!richTextBox1.SelectionFont.Italic)
                textIterator("italic");
            else
                textIterator("non-italic");

            

        }

        private void UnderlineToolStripButton_Click(object sender, EventArgs e)
        {


            if (!richTextBox1.SelectionFont.Underline)
                textIterator("underline");
            else
                textIterator("de-underline");
        }


        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            loginForm = new LoginForm();
            
            loginForm.ShowDialog();
        }

        

        private void FontSizeToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            float size = Convert.ToSingle(((ToolStripComboBox)sender).Text); //get the selected font size

            textIterator("size");
        }

        private void OpenToolStripButton_Click(object sender, EventArgs e)
        {
            OpenToolStripMenuItem_Click(sender, e);
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveToolStripMenuItem_Click(sender, e);
        }

        private void SaveAsToolStripButton_Click(object sender, EventArgs e)
        {
            SaveAsToolStripMenuItem_Click(sender, e);
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            AboutToolStripMenuItem_Click(sender, e);
        }

        private void bold(string option)
        {

        }
        private void textIterator(string option)
        {
            try
            {
                int selectionStart = richTextBox1.SelectionStart;
                int selectionLength = richTextBox1.SelectionLength;

                if(selectionLength > 0)
                {
                    using (RichTextBox TempText = new RichTextBox())
                    {
                        TempText.SelectedRtf = richTextBox1.SelectedRtf;
                        //iterate through each selected character
                        for(int i = 0; i < selectionLength; i++)
                        {
                            TempText.Select(i, 1);
                            switch (option)
                            {
                                case "bold":
                                    TempText.SelectionFont = new Font(TempText.SelectionFont, TempText.SelectionFont.Style | FontStyle.Bold);
                                    break;
                                case "unbold":
                                    TempText.SelectionFont = new Font(TempText.SelectionFont, TempText.SelectionFont.Style & ~FontStyle.Bold);
                                    break;
                                case "italic":
                                    TempText.SelectionFont = new Font(TempText.SelectionFont, TempText.SelectionFont.Style | FontStyle.Italic);
                                    break;
                                case "non-italic":
                                    TempText.SelectionFont = new Font(TempText.SelectionFont, TempText.SelectionFont.Style & ~FontStyle.Italic);
                                    break;
                                case "underline":
                                    TempText.SelectionFont = new Font(TempText.SelectionFont, TempText.SelectionFont.Style | FontStyle.Underline);
                                    break;
                                case "de-underline":
                                    TempText.SelectionFont = new Font(TempText.SelectionFont, TempText.SelectionFont.Style & ~FontStyle.Underline);
                                    break;
                                case "size":
                                    TempText.SelectionFont = new Font(TempText.SelectionFont.Name, Convert.ToInt32(fontSizeToolStripComboBox.Text), TempText.SelectionFont.Style);
                                    break;
                            }
                        }
                        TempText.Select(0, selectionLength);
                        richTextBox1.SelectedRtf = TempText.SelectedRtf;
                        richTextBox1.Select(selectionStart, selectionLength);
                    }
                }
                else
                {

                    switch (option)
                    {
                        case "bold":
                            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Bold);
                            break;
                        case "unbold":
                            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style & ~FontStyle.Bold);
                            break;
                        case "italic":
                            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Italic);
                            break;
                        case "non-italic":
                            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style & ~FontStyle.Italic);
                            break;
                        case "underline":
                            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Underline);
                            break;
                        case "de-underline":
                            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style & ~FontStyle.Underline);
                            break;
                        case "size":
                            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.Name, Convert.ToInt32(fontSizeToolStripComboBox.Text), richTextBox1.SelectionFont.Style);
                            break;
                    }
  
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


        private void TextEditorForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.B)
            {
                MessageBox.Show("print clicked");
            }
        }
        


        
    }
}
