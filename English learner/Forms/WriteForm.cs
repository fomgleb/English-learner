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
        public WriteForm()
        {
            InitializeComponent();
            checkSelectedDictionary();
        }

        #region Нажатие кнопок
        private void createOrOpenButton_Click(object sender, EventArgs e)
        {
            DictionaryOpenForm writeDictionaryOpenForm = new DictionaryOpenForm(); // экземпляр формы открытия словаря
            writeDictionaryOpenForm.ShowDialog(); // показываем его как showDialog, тоесть текющее выпонение кода останавливается. Выполняется код уже в новооткрытой форме
            checkSelectedDictionary(); // проверить выбраный словарь
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

        private void checkSelectedDictionary()
        {
            if (Dictionary.Selected != null) // если какой-то словарь выбран
            {
                englishTextBox.Enabled = true; // врубаем всё
                englishTextBox.Text = "";
                russianTextBox.Enabled = true;
                russianTextBox.Text = "";
                enterLabel.Visible = true;
                Text = "Write - " + Dictionary.Selected;
                contentTextBox.Enabled = true;
                tableLayoutPanel5.Visible = true;
                tableLayoutPanel4.ColumnCount = 2;
                showHideToolStripMenuItem.Checked = true;
                uploadDataToContentTextBox();
            }
            else // иначе
            {
                englishTextBox.Enabled = false; // вырубаем
                englishTextBox.Text = "Create or open a dictionary";
                russianTextBox.Enabled = false;
                russianTextBox.Text = "Создай или открой словарь";
                enterLabel.Visible = false;
                Text = "Write";
                contentTextBox.Enabled = false;
                tableLayoutPanel5.Visible = false;
                tableLayoutPanel4.ColumnCount = 1;
                showHideToolStripMenuItem.Checked = false;
            }
        }

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
                    Storage.addContentToTxtFile(Dictionary.Selected, $"{englishTextBox.Text} = {russianTextBox.Text}"); // добавляем в txt file контент что написать в text боксах
                    englishTextBox.Text = ""; // очищаем их
                    russianTextBox.Text = "";
                    uploadDataToContentTextBox(); // обноволяем данные в contentTextBox
                    englishTextBox.Focus(); // фокусируемся на englishTextBox
                    InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("en-US")); // переключение якыка клавиатуры на Английский
                }
            }
        }        

        private void uploadDataToContentTextBox() // обновление данных в contentTextBox
        {
            contentTextBox.Text = Storage.getContentFromTxtFile(Dictionary.Selected); // загружаем данные из txt file в contentTextBox
            contentTextBox.SelectionStart = contentTextBox.TextLength; // устанавливаем курсор в конец contentTextBox
            contentTextBox.ScrollToCaret(); // прокручивает скролл туда где курсор
        }

        private void WriteForm_Shown(object sender, EventArgs e) // при появлении формы
        {
            uploadDataToContentTextBox(); // обновление данных в contentTextBox
        }

        private void contentTextBox_TextChanged(object sender, EventArgs e) // если текст в contentTextBox меняется
        {
            Storage.addNewContentToTxtFile(Dictionary.Selected, contentTextBox.Text); // сохраняем это в txt file
        }
    }
}
