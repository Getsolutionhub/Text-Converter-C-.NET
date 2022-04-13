using System.Windows.Forms;
using System.Text.RegularExpressions;
using System;

namespace getsolutionhubDemo
{
    public partial class textCoverter : Form
    {
        public textCoverter()
        {
            InitializeComponent();
        }
        public void wordCharSpacesCounter()
        {
            //Character counting start here
            int charCount = mainTxtBox.Text.Length;

            //Words counting start here
            int wordCount = 0;
            Regex regex = new Regex("\\s+");
            foreach (Match match in regex.Matches(mainTxtBox.Text))
            {
                wordCount++;
                if (mainTxtBox.Text.Length < 1)
                {
                    wordCount = 0;
                }
            }

            //Spaces counting start here
            int numSpace = 0;
            foreach (char c in mainTxtBox.Text.ToCharArray())
            {
                if (c == ' ')
                {
                    numSpace++;
                }
            }
            wordLetterCounter.Text = "Words : " + wordCount + " , Characters : " + charCount + " , Spaces : " + numSpace;
        }
        private void mainTxtBox_KeyUp(object sender, KeyEventArgs e)
        {
            previewTxtBox.Text = mainTxtBox.Text;
            //Words: 0 , Characters: 0 , Spaces: 0

            wordCharSpacesCounter();
        }
        //ClearTextBoxes method start here
        public void clearTextBoxes()
        {
            mainTxtBox.Clear();
            previewTxtBox.Clear();
            wordLetterCounter.Text = "Words : 0 , Characters : 0 , Spaces : 0";
        }
        private void clearBtn_Click(object sender, System.EventArgs e)
        {
            //Creating clearTextBoxes() method for clear box textboxes text
            clearTextBoxes();
        }
        //UPPERCASE button start here
        private void uppercaseBtn_Click(object sender, System.EventArgs e)
        {
            if (mainTxtBox.Text != "")
            {
                string str = mainTxtBox.Text;
                previewTxtBox.Text = str.ToUpper();
            }
            else
            {
                MessageBox.Show("Please Enter text in the textbox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        //lower  button start here
        private void lowercaseBtn_Click(object sender, System.EventArgs e)
        {
            if (mainTxtBox.Text != "")
            {
                string str = mainTxtBox.Text;
                previewTxtBox.Text = str.ToLower();
            }
            else
            {
                MessageBox.Show("Please Enter text in the textbox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rmSpaceBtn_Click(object sender, System.EventArgs e)
        {
            int  strLen = mainTxtBox.Text.Length;
            for(int i=0;i<=strLen;i++)
            {
                string rm = mainTxtBox.Text.Replace("  ", " ");
                mainTxtBox.Text = rm;
                previewTxtBox.Text=rm;
            }


        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            if (mainTxtBox.Text != "")
            {
                Clipboard.SetText(previewTxtBox.Text);
            }
            else
            {
                MessageBox.Show("Please Enter text in the textbox.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void pasteBtn_Click(object sender, EventArgs e)
        {
            previewTxtBox.Clear();
            mainTxtBox.Clear();
            mainTxtBox.Text=Clipboard.GetText();
            wordCharSpacesCounter();
        }
    }
}
