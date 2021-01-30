using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using English_learner.Forms;

namespace English_learner.Forms
{
    public partial class WriteForm : Form
    {
        string selectedItem = "";
        public WriteForm()
        {
            InitializeComponent();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteDictionaryCreateForm writeDictionaryCreateForm = new WriteDictionaryCreateForm();
            writeDictionaryCreateForm.ShowDialog();
            selectedItem = writeDictionaryCreateForm.getCreatedDict();
            if (selectedItem != "")
            {
                englishTextBox.Enabled = true;
                englishTextBox.Text = "";
                russianTextBox.Enabled = true;
                russianTextBox.Text = "";
                enterLabel.Visible = true;
                Text = "Write - " + selectedItem;
            }
        }
    }
}
