using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace English_learner.Forms
{
    public partial class LearnForm : Form
    {
        public bool closed = false;
        public bool backed = false;
        private int currentSentenceNum = 0;
        private List<string> englishPart = new List<string> { };
        private List<string> russianPart = new List<string> { };

        public LearnForm()
        {
            InitializeComponent();

            allTheNecessaryManipulatesWithText(Storage.getContentFromTxtFile(Dictionary.Selected)); // все необходимые манипуляции со строками
            checkWhetherDictionaryIsSelected();
            uploadDataToTextBoxes();
        }


        #region Strings Manipulation
        private void allTheNecessaryManipulatesWithText(string text)
        {
            cutStringsIntoTwoParts(randomizeStrings(cutTextIntoStrings(text)));
        }

        private List<string> cutTextIntoStrings(string text)
        {
            if (text != null)
            {
                text += "\n";

                List<string> allStringsList = new List<string> { };
                string currentSentence = "";
                foreach (var symbol in text)
                {
                    if (symbol == '\n' || symbol == '\r')
                    {
                        allStringsList.Add(currentSentence);
                        currentSentence = "";
                    }
                    else
                        currentSentence += symbol;
                }

                bool again = true;
                while (again == true && allStringsList.Count > 0)
                {
                    foreach (var item in allStringsList)
                    {
                        if (item == "")
                        {
                            allStringsList.Remove(item);
                            again = true;
                            break;
                        }
                        else
                            again = false;
                    }
                }

                return allStringsList;
            }
            else return null;
        }

        public List<string> randomizeStrings(List<string> stringsList)
        {
            if (stringsList != null)
            {
                Random random = new Random();
                for (int i = stringsList.Count - 1; i >= 1; i--)
                {
                    int j = random.Next(i + 1);

                    var tmp = stringsList[j];
                    stringsList[j] = stringsList[i];
                    stringsList[i] = tmp;
                }
                return stringsList;
            }
            else return null;
        }

        private void cutStringsIntoTwoParts(List<string> stringsList)
        {
            englishPart.Clear();
            russianPart.Clear();
            foreach (var oneString in stringsList)
            {
                string[] fullSentence = oneString.Split('=');
                englishPart.Add(fullSentence[0].Remove(fullSentence[0].Length - 1));
                russianPart.Add(fullSentence[1].Remove(0, 1));
            }
        }
        #endregion



        private void checkWhetherDictionaryIsSelected()
        {
            if (Dictionary.Selected != null)
            {
                if (currentSentenceNum == 0)
                {
                    backButton.Enabled = false;
                    russianTextBox.Enabled = true;
                }
                else
                    backButton.Enabled = true;

                checkButton.Enabled = true;
                englishTextBox.Enabled = true;
                russianTextBox.Enabled = true;

                englishTextBox.ForeColor = Color.Black;

                englishTextBox.Text = "";
                rightTextBox.Enabled = true;
                Text = $"learn - {Dictionary.Selected}";
            }
            else
            {
                backButton.Enabled = false;
                russianTextBox.Enabled = false;
                checkButton.Enabled = false;
                englishTextBox.ForeColor = Color.FromArgb(109, 109, 109);
                englishTextBox.Enabled = false;
                englishTextBox.Text = "Open a dictionary";
                russianTextBox.Text = "Открой словарь";
                rightTextBox.Enabled = false;
                Text = "learn";
                visibleRightTextBox(false);
            }
        }

        private void uploadDataToTextBoxes()
        {
            if (Dictionary.Selected != null)
            {
                if (Storage.getContentFromTxtFile(Dictionary.Selected) == "")
                {
                    englishTextBox.Text = "The current dictionary is empty";  
                    russianTextBox.Text = "Текущий словарь пуст";
                    englishTextBox.Enabled = false;
                    russianTextBox.Enabled = false;
                    backButton.Enabled = false;
                    checkButton.Enabled = false;
                    return;
                }
                russianTextBox.Text = russianPart[currentSentenceNum];
                englishTextBox.Text = "";
            }
        }




        private void LearnForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            closed = true;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backed = true;
            Close();
        }

        private void visibleRightTextBox(bool visible)
        {
            if (visible)
            {
                tableLayoutPanel7.Visible = true;
                tableLayoutPanel1.RowCount = 3;
            }
            else
            {
                tableLayoutPanel7.Visible = false;
                tableLayoutPanel1.RowCount = 2;
            }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if (checkButton.Text == "Check")
            {
                string rightText = englishPart[currentSentenceNum];
                if (englishTextBox.Text == rightText)
                {
                    englishTextBox.ForeColor = Color.Green;
                    checkButton.Text = "Next";
                }
                else
                {
                    englishTextBox.ForeColor = Color.Red;
                    visibleRightTextBox(true);
                }
                visibleRightTextBox(true);
                rightTextBox.Text = englishPart[currentSentenceNum];
            }
            else if (englishTextBox.Text == "")
            {
                DialogResult dr = MessageBox.Show("Text box is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (currentSentenceNum == russianPart.Count - 1)
            {
                DialogResult dr = MessageBox.Show("Congratulations", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dictionary.Selected = null;
                checkWhetherDictionaryIsSelected();
            }
            else if (checkButton.Text == "Next")
            {
                if (currentSentenceNum == 0)
                    backButton.Enabled = true;
                currentSentenceNum += 1;
                uploadDataToTextBoxes();
                englishTextBox.ForeColor = Color.Black;
                checkButton.Text = "Check";
                visibleRightTextBox(false);
                
            }
        }

        private void openWriteFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteForm writeForm = new WriteForm();
            writeForm.Show();
        }

        private void createOrOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DictionaryOpenForm dictionaryOpenForm = new DictionaryOpenForm(true);
            dictionaryOpenForm.ShowDialog();

            allTheNecessaryManipulatesWithText(Storage.getContentFromTxtFile(Dictionary.Selected));
            checkWhetherDictionaryIsSelected();
            uploadDataToTextBoxes();
            englishTextBox.Focus();
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("en-US"));
        }

        private void LearnForm_Shown(object sender, EventArgs e)
        {
            englishTextBox.Focus();
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("en-US"));
        }

        private void englishTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // если был нажат enter
            {
                e.Handled = true; // enter не напечатается
                checkButton_Click(null, null);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            currentSentenceNum -= 1;
            uploadDataToTextBoxes();
            if (currentSentenceNum == 0)
                backButton.Enabled = false;
        }
    }
}
