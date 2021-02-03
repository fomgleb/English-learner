namespace English_learner.Forms
{
    partial class WriteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createOrOpenButton = new System.Windows.Forms.ToolStripMenuItem();
            this.showHideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.englishTextBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.russianTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.enterLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.contentTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dictionaryToolStripMenuItem
            // 
            this.dictionaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createOrOpenButton,
            this.showHideToolStripMenuItem});
            this.dictionaryToolStripMenuItem.Name = "dictionaryToolStripMenuItem";
            this.dictionaryToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.dictionaryToolStripMenuItem.Text = "Dictionary";
            // 
            // createOrOpenButton
            // 
            this.createOrOpenButton.Name = "createOrOpenButton";
            this.createOrOpenButton.Size = new System.Drawing.Size(180, 22);
            this.createOrOpenButton.Text = "Create or Open";
            this.createOrOpenButton.Click += new System.EventHandler(this.createOrOpenButton_Click);
            // 
            // showHideToolStripMenuItem
            // 
            this.showHideToolStripMenuItem.Checked = true;
            this.showHideToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showHideToolStripMenuItem.Name = "showHideToolStripMenuItem";
            this.showHideToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showHideToolStripMenuItem.Text = "Show dictionary";
            this.showHideToolStripMenuItem.Click += new System.EventHandler(this.showHideToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.dictionaryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1191, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.enterLabel, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(589, 466);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.englishTextBox, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(583, 199);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(211, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "In English";
            // 
            // englishTextBox
            // 
            this.englishTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.englishTextBox.Enabled = false;
            this.englishTextBox.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.englishTextBox.Location = new System.Drawing.Point(3, 48);
            this.englishTextBox.Name = "englishTextBox";
            this.englishTextBox.Size = new System.Drawing.Size(577, 148);
            this.englishTextBox.TabIndex = 1;
            this.englishTextBox.Text = "Create or open a dictionary";
            this.englishTextBox.Click += new System.EventHandler(this.englishTextBox_Click);
            this.englishTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.russianAndEnglishTextBox_KeyDown);
            this.englishTextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.englishTextBox_PreviewKeyDown);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.russianTextBox, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 208);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(583, 199);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // russianTextBox
            // 
            this.russianTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.russianTextBox.Enabled = false;
            this.russianTextBox.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.russianTextBox.Location = new System.Drawing.Point(3, 48);
            this.russianTextBox.Name = "russianTextBox";
            this.russianTextBox.Size = new System.Drawing.Size(577, 148);
            this.russianTextBox.TabIndex = 2;
            this.russianTextBox.Text = "Создай или открой словарь";
            this.russianTextBox.Click += new System.EventHandler(this.russianTextBox_Click);
            this.russianTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.russianAndEnglishTextBox_KeyDown);
            this.russianTextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.englishTextBox_PreviewKeyDown);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(207, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "In Russian";
            // 
            // enterLabel
            // 
            this.enterLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.enterLabel.AutoSize = true;
            this.enterLabel.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterLabel.Location = new System.Drawing.Point(119, 431);
            this.enterLabel.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(350, 35);
            this.enterLabel.TabIndex = 4;
            this.enterLabel.Text = "Press Enter to continue";
            this.enterLabel.Visible = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1191, 472);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.contentTextBox, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(598, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(590, 466);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // contentTextBox
            // 
            this.contentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentTextBox.Location = new System.Drawing.Point(3, 3);
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(584, 460);
            this.contentTextBox.TabIndex = 0;
            this.contentTextBox.TabStop = false;
            this.contentTextBox.Text = "Download...";
            this.contentTextBox.TextChanged += new System.EventHandler(this.contentTextBox_TextChanged);
            // 
            // WriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 496);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(393, 312);
            this.Name = "WriteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Write";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WriteForm_FormClosed);
            this.Shown += new System.EventHandler(this.WriteForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem dictionaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createOrOpenButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox englishTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox russianTextBox;
        private System.Windows.Forms.Label enterLabel;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ToolStripMenuItem showHideToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.RichTextBox contentTextBox;
    }
}