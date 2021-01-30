using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace English_learner.Forms
{
    public partial class WriteDictionaryCreateForm : Form
    {
        readonly string[] prohibitedSymbols = {"#","%","&","{","}","\\","<",">","*","?","/","$","!","'", "\"", ":", "@", "+", "`", "|", "=" }; // Массив запрещённых символов
        public WriteDictionaryCreateForm()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                DialogResult dr = MessageBox.Show("Text box is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (nameTextBox.ForeColor != Color.Red) // Если цвет текста в TextBox не красный то
            {
                Storage.createMainDir();
                List<string> dictList = Storage.getDictList(); // Берём список имён файлов что находятся в mainDir
                foreach (var name in dictList)
                    if (name == nameTextBox.Text + ".txt")
                    {
                        DialogResult dr = MessageBox.Show("This name already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        nameTextBox.Text = "";
                        return;
                    }
                Storage.createTxtFile(nameTextBox.Text);
                Close();
            }
            else
            {
                DialogResult dr = MessageBox.Show("Prohibited symbols!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nameTextBox.Text = "";
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            foreach (var prohibitedSymbol in prohibitedSymbols)
                foreach (var nameSymbol in nameTextBox.Text)
                    if (nameSymbol.ToString() == prohibitedSymbol)
                    {
                        nameTextBox.ForeColor = Color.Red;
                        return;
                    }
                    else
                        nameTextBox.ForeColor = Color.Black;
        }

        public string getCreatedDict()
        {
            if (nameTextBox.ForeColor != Color.Red)
                return nameTextBox.Text;
            else
                return "";
        }
    }
}
