using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace English_learner.Forms
{
    public partial class DictionaryOpenForm : Form
    {
        bool forLearnForm = false;

        public List<string> SelectedDictionaries { get; private set; } = new List<string> { };

        public DictionaryOpenForm(bool forLearnFrom)
        {
            InitializeComponent();
            loadAllDatas();
            if (forLearnFrom)
            {
                tableLayoutPanel5.RowCount = 1;
                deleteButton.Visible = false;
                createButton.Visible = false;
                this.forLearnForm = true;
            }
            if (forLearnFrom)
                listBox.SelectionMode = SelectionMode.MultiExtended;
            else
                listBox.SelectionMode = SelectionMode.One;
        }

        #region Нажатие кнопок
        private void openButton_Click(object sender, EventArgs e)
        {
            SelectedDictionaries.Clear();
            if (true)
            {

            }
            if (listBox.SelectedItem != null)
            {
                foreach (string str in listBox.SelectedItems)
                    SelectedDictionaries.Add(str);
                Close();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                DialogResult dr = MessageBox.Show($"Do you really want to delete '{listBox.SelectedItem}'?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (SelectedDictionaries.Count != 0 && listBox.SelectedItem.ToString() == SelectedDictionaries[0])
                        SelectedDictionaries.Clear();
                    Storage.deleteTxtFile(listBox.SelectedItem.ToString());
                    foreach (string str in listBox.SelectedItems)
                        SelectedDictionaries.Add(str);
                    loadAllDatas();
                }
            }
        }

        private void listBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && !forLearnForm)
                deleteButton_Click(null, null);
            else if (e.KeyCode == Keys.Enter)
                openButton_Click(null, null);
        }

        private void listBox_DoubleClick(object sender, EventArgs e)
        {
            openButton_Click(null, null);
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            DictionaryCreateForm writeDictionaryCreateForm = new DictionaryCreateForm(); // экземпляр формы создания словаря
            writeDictionaryCreateForm.ShowDialog(); // показываем его как showDialog, тоесть текющее выпонение кода останавливается. Выполняется код уже в новооткрытой форме
            loadAllDatas();
        }
        #endregion

        private void loadAllDatas() // загружаем все данные в listBox
        {
            List<string> dictNamesList = Storage.getDictNamesList(); // получаем список имен txt файлов

            listBox.Items.Clear(); // очищаем listBox
            foreach (var name in dictNamesList) // и заполняем listBox
                listBox.Items.Add(name);
        }
    }
}
