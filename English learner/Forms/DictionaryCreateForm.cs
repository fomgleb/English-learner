using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace English_learner.Forms
{
    public partial class DictionaryCreateForm : Form
    {
        readonly string[] prohibitedSymbols = { "#", "%", "&", "{", "}", "\\", "<", ">", "*", "?", "/", "$", "!", "'", "\"", ":", "@", "+", "`", "|", "=" }; // Массив запрещённых символов
        string newSelectedDictionary = null;
        public DictionaryCreateForm()
        {
            InitializeComponent();
        }

        #region Buttons clicking
        private void createButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "") // если в поле пусто
            {
                DialogResult dr = MessageBox.Show("Text box is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // выдаем ошибку
                return; // прекращаем работу метода
            }
            if (nameTextBox.ForeColor != Color.Red) // Если цвет текста в TextBox не красный то
            {
                List<string> dictNamesList = Storage.getDictNamesList(); // Берём список имён файлов что находятся в mainDir
                foreach (var name in dictNamesList) // проходимся по каждому элементу в dictNamesList
                    if (name == nameTextBox.Text) // если такое уже есть
                    {
                        DialogResult dr = MessageBox.Show("This name already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // выводим mistake
                        nameTextBox.Text = "";
                        return;
                    }
                Storage.createTxtFile(nameTextBox.Text); // create txt file
                newSelectedDictionary = nameTextBox.Text; // делаем выбраным то что в nameTextBox
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

        private void nameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                createButton_Click(null, null);
            else if (e.KeyCode == Keys.Escape)
                Close();
        }
        #endregion

        private void nameTextBox_TextChanged(object sender, EventArgs e) // если текст был изменён
        {
            foreach (var prohibitedSymbol in prohibitedSymbols) // проходимся по списку запрещенных символов 18+
                foreach (var nameSymbol in nameTextBox.Text) // и по символам в nameTextBox
                    if (nameSymbol.ToString() == prohibitedSymbol) // если символы совпадают
                    {
                        nameTextBox.ForeColor = Color.Red; // то хана, красный
                        return; // and switch off the method
                    }
                    else
                        nameTextBox.ForeColor = Color.Black; // else forecolor is black
        }

        
    }
}
