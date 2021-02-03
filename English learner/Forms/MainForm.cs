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

namespace English_learner
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void writeButton_Click(object sender, EventArgs e)
        {
            DictionaryOpenForm dictionaryOpenForm = new DictionaryOpenForm(); // открываем форму с открытием dictionary
            Visible = false;
            dictionaryOpenForm.ShowDialog();

            WriteForm writeForm = new WriteForm();
            writeForm.ShowDialog();
            if (writeForm.backed)
                Visible = true;
            else if (writeForm.closed)
                Close();
        }

        private void learnButton_Click(object sender, EventArgs e)
        {
            DictionaryOpenForm dictionaryOpenForm = new DictionaryOpenForm(true);
            Visible = false;
            dictionaryOpenForm.ShowDialog();

            LearnForm learnForm = new LearnForm();
            learnForm.ShowDialog();
            if (learnForm.backed)
                Visible = true;
            else if (learnForm.closed)
                Close();
        }
    }
}
