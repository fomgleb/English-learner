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
    public partial class DictionaryOpenForm : Form
    {
        bool disabledCreateAndDeleteButtons = false;
        public DictionaryOpenForm()
        {
            InitializeComponent();
            loadAllDatas();
        }

        public DictionaryOpenForm(bool disabledCreateAndDeleteButtons)
        {
            InitializeComponent();
            loadAllDatas();
            if (disabledCreateAndDeleteButtons)
            {
                tableLayoutPanel5.RowCount = 1;
                deleteButton.Visible = false;
                createButton.Visible = false;
                this.disabledCreateAndDeleteButtons = true;
            }
        }

        #region Нажатие кнопок
        private void openButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                Dictionary.Selected = listBox.SelectedItem.ToString();
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
                    if (Dictionary.Selected == listBox.SelectedItem.ToString())
                        Dictionary.Selected = null;
                    Storage.deleteTxtFile(listBox.SelectedItem.ToString());
                    loadAllDatas();
                }
            }
        }

        private void listBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && !disabledCreateAndDeleteButtons)
                deleteButton_Click(null, null);
            else if (e.KeyCode == Keys.Enter)
                openButton_Click(null, null);
        }

        private void listBox_DoubleClick(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                Dictionary.Selected = listBox.SelectedItem.ToString();
                Close();
            }
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
