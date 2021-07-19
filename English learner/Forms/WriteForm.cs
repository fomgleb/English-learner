using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading;

namespace English_learner.Forms
{
    public partial class WriteForm : Form
    {
        public bool closed = false;
        public bool backed = false;
        private string selectedDictionary;
        public WriteForm(string selectedDictionary)
        {
            InitializeComponent();
            this.selectedDictionary = selectedDictionary;
            updateDatas();
        }

        #region Нажатие кнопок
        private void createOrOpenButton_Click(object sender, EventArgs e)
        {
            DictionaryOpenForm dictionaryOpenForm = new DictionaryOpenForm(false); // экземпляр формы открытия словаря
            dictionaryOpenForm.ShowDialog(); // показываем его как showDialog, тоесть текющее выпонение кода останавливается. Выполняется код уже в новооткрытой форме

            if (dictionaryOpenForm.SelectedDictionaries.Count != 0)
                selectedDictionary = dictionaryOpenForm.SelectedDictionaries[0]; // обновить выбраную директротию
            updateDatas(); // обновить данные

            englishTextBox.Focus(); // фокусируем на englishTextBox
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("en-US")); // переключение якыка клавиатуры на Английский
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backed = true;
            Close();
        }

        private void WriteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            closed = true;
        }

        private void showHideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tableLayoutPanel5.Visible == false)
            {
                showHideToolStripMenuItem.Checked = true;
                tableLayoutPanel5.Visible = true;
                tableLayoutPanel4.ColumnCount = 2;
            }
            else
            {
                showHideToolStripMenuItem.Checked = false;
                tableLayoutPanel5.Visible = false;
                tableLayoutPanel4.ColumnCount = 1;
            }
        }
        #endregion

        #region Изменение языка клавиатуры
        private void englishTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                if (russianTextBox.Focused)
                    InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("en-US"));
                else if (englishTextBox.Focused)
                    InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("ru-RU"));
            }
        }

        private void englishTextBox_Click(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("en-US"));
        }

        private void russianTextBox_Click(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("ru-RU"));
        }
        #endregion


        private void russianAndEnglishTextBox_KeyDown(object sender, KeyEventArgs e) // нажатие клавиши на клавиатуре на text boxes
        {
            if (e.KeyCode == Keys.Enter) // если был нажат enter
            {
                e.Handled = true; // enter не напечатается
                if (englishTextBox.Text == "" || russianTextBox.Text == "") // если english and russian Textboxes are empty
                {
                    DialogResult dr = MessageBox.Show("Fill in both text boxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // вызаваем окно с ошибкой
                }
                else
                {
                    contentTextBox.Text += $"\n{englishTextBox.Text} = {russianTextBox.Text}"; // добавляем в contentTextBox контент что написан в text боксах
                    if (contentTextBox.Text[0] == '\n' || contentTextBox.Text[0] == '\n')
                        contentTextBox.Text = contentTextBox.Text.Remove(0, 1);
                    englishTextBox.Text = ""; // очищаем их
                    russianTextBox.Text = "";
                    updateDatas(); // обновляем данные в contentTextBox
                    englishTextBox.Focus(); // фокусируемся на englishTextBox
                    InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("en-US")); // переключение якыка клавиатуры на Английский
                }
            }
        }        

        private void updateDatas() // обновление данных в contentTextBox
        {
            try
            {
                contentTextBox.Text = Storage.getContentFromTxtFile(selectedDictionary); // загружаем данные из txt file в contentTextBox
                contentTextBox.SelectionStart = contentTextBox.TextLength; // устанавливаем курсор в конец contentTextBox
                contentTextBox.ScrollToCaret(); // прокручивает скролл туда где курсор
                Text = "Write - " + selectedDictionary; // добавляет в название формы, имя выбраной директории
            }
            catch (Exception)
            {
                
            }
            
        }

        private void WriteForm_Shown(object sender, EventArgs e) // при появлении формы
        {
            updateDatas(); // обновление данных в contentTextBox
        }

        private void contentTextBox_TextChanged(object sender, EventArgs e) // если текст в contentTextBox меняется
        {
            Storage.addNewContentToTxtFile(selectedDictionary, contentTextBox.Text); // сохраняем это в txt file
        }
    }
}
