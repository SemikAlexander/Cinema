namespace Cinema
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddRecord = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Panel();
            this.EditRecord = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Panel();
            this.Statistics = new System.Windows.Forms.Button();
            this.stat = new System.Windows.Forms.Panel();
            this.FindButton = new System.Windows.Forms.Button();
            this.find = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.MainTable = new System.Windows.Forms.DataGridView();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MinWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tables_from_BD = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DeleteRow = new System.Windows.Forms.Button();
            this.Data = new System.Windows.Forms.TextBox();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddRecord
            // 
            this.AddRecord.FlatAppearance.BorderSize = 0;
            this.AddRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRecord.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.AddRecord.ForeColor = System.Drawing.Color.Black;
            this.AddRecord.Image = ((System.Drawing.Image)(resources.GetObject("AddRecord.Image")));
            this.AddRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddRecord.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AddRecord.Location = new System.Drawing.Point(10, 7);
            this.AddRecord.Name = "AddRecord";
            this.AddRecord.Size = new System.Drawing.Size(142, 45);
            this.AddRecord.TabIndex = 6;
            this.AddRecord.Text = "        Добавить";
            this.AddRecord.UseVisualStyleBackColor = true;
            this.AddRecord.Click += new System.EventHandler(this.AddRecord_Click_1);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(-2, 7);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(14, 45);
            this.add.TabIndex = 5;
            // 
            // EditRecord
            // 
            this.EditRecord.FlatAppearance.BorderSize = 0;
            this.EditRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditRecord.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.EditRecord.ForeColor = System.Drawing.Color.Black;
            this.EditRecord.Image = ((System.Drawing.Image)(resources.GetObject("EditRecord.Image")));
            this.EditRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditRecord.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EditRecord.Location = new System.Drawing.Point(10, 58);
            this.EditRecord.Name = "EditRecord";
            this.EditRecord.Size = new System.Drawing.Size(142, 45);
            this.EditRecord.TabIndex = 8;
            this.EditRecord.Text = "        Изменить";
            this.EditRecord.UseVisualStyleBackColor = true;
            this.EditRecord.Click += new System.EventHandler(this.EditRecord_Click_1);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(-2, 58);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(14, 45);
            this.edit.TabIndex = 7;
            // 
            // Statistics
            // 
            this.Statistics.FlatAppearance.BorderSize = 0;
            this.Statistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Statistics.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Statistics.ForeColor = System.Drawing.Color.Black;
            this.Statistics.Image = ((System.Drawing.Image)(resources.GetObject("Statistics.Image")));
            this.Statistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Statistics.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Statistics.Location = new System.Drawing.Point(10, 109);
            this.Statistics.Name = "Statistics";
            this.Statistics.Size = new System.Drawing.Size(142, 45);
            this.Statistics.TabIndex = 12;
            this.Statistics.Text = "Статистика";
            this.Statistics.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Statistics.UseVisualStyleBackColor = true;
            this.Statistics.Click += new System.EventHandler(this.Statistics_Click_1);
            // 
            // stat
            // 
            this.stat.Location = new System.Drawing.Point(-2, 109);
            this.stat.Name = "stat";
            this.stat.Size = new System.Drawing.Size(14, 45);
            this.stat.TabIndex = 11;
            // 
            // FindButton
            // 
            this.FindButton.FlatAppearance.BorderSize = 0;
            this.FindButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.FindButton.ForeColor = System.Drawing.Color.Black;
            this.FindButton.Image = ((System.Drawing.Image)(resources.GetObject("FindButton.Image")));
            this.FindButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FindButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FindButton.Location = new System.Drawing.Point(10, 160);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(142, 45);
            this.FindButton.TabIndex = 14;
            this.FindButton.Text = "        Поиск";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(-2, 160);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(14, 45);
            this.find.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Controls.Add(this.find);
            this.panel5.Controls.Add(this.FindButton);
            this.panel5.Controls.Add(this.stat);
            this.panel5.Controls.Add(this.Statistics);
            this.panel5.Controls.Add(this.edit);
            this.panel5.Controls.Add(this.EditRecord);
            this.panel5.Controls.Add(this.add);
            this.panel5.Controls.Add(this.AddRecord);
            this.panel5.Location = new System.Drawing.Point(0, 24);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(155, 523);
            this.panel5.TabIndex = 10;
            // 
            // MainTable
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainTable.Location = new System.Drawing.Point(161, 31);
            this.MainTable.Name = "MainTable";
            this.MainTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MainTable.Size = new System.Drawing.Size(803, 386);
            this.MainTable.TabIndex = 12;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MinWindow
            // 
            this.MinWindow.Image = ((System.Drawing.Image)(resources.GetObject("MinWindow.Image")));
            this.MinWindow.Name = "MinWindow";
            this.MinWindow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MinWindow.Size = new System.Drawing.Size(28, 20);
            this.MinWindow.Click += new System.EventHandler(this.MinWindow_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.MinWindow});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(976, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tables_from_BD
            // 
            this.tables_from_BD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tables_from_BD.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tables_from_BD.FormattingEnabled = true;
            this.tables_from_BD.Items.AddRange(new object[] {
            "Фильмы",
            "Билеты",
            "Жанры",
            "Страны",
            "Залы",
            "Возрастные ограничения"});
            this.tables_from_BD.Location = new System.Drawing.Point(402, 423);
            this.tables_from_BD.Name = "tables_from_BD";
            this.tables_from_BD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tables_from_BD.Size = new System.Drawing.Size(195, 25);
            this.tables_from_BD.TabIndex = 13;
            this.tables_from_BD.SelectedIndexChanged += new System.EventHandler(this.tables_from_BD_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(174, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Показать  данные с таблицы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(181, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Код поля";
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ID.Location = new System.Drawing.Point(262, 449);
            this.ID.Name = "ID";
            this.ID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ID.Size = new System.Drawing.Size(139, 23);
            this.ID.TabIndex = 16;
            this.ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label3.Location = new System.Drawing.Point(186, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Тип поля";
            // 
            // Type
            // 
            this.Type.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Type.FormattingEnabled = true;
            this.Type.Location = new System.Drawing.Point(262, 478);
            this.Type.Name = "Type";
            this.Type.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Type.Size = new System.Drawing.Size(139, 25);
            this.Type.TabIndex = 19;
            this.Type.SelectedIndexChanged += new System.EventHandler(this.Type_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label4.Location = new System.Drawing.Point(155, 509);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Данные поля";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(776, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 45);
            this.button1.TabIndex = 22;
            this.button1.Text = "  Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteRow
            // 
            this.DeleteRow.FlatAppearance.BorderSize = 0;
            this.DeleteRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteRow.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.DeleteRow.ForeColor = System.Drawing.Color.Black;
            this.DeleteRow.Image = ((System.Drawing.Image)(resources.GetObject("DeleteRow.Image")));
            this.DeleteRow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteRow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DeleteRow.Location = new System.Drawing.Point(776, 469);
            this.DeleteRow.Name = "DeleteRow";
            this.DeleteRow.Size = new System.Drawing.Size(188, 45);
            this.DeleteRow.TabIndex = 23;
            this.DeleteRow.Text = "        Удалить по полю";
            this.DeleteRow.UseVisualStyleBackColor = true;
            this.DeleteRow.Click += new System.EventHandler(this.DeleteRow_Click);
            // 
            // Data
            // 
            this.Data.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Data.Location = new System.Drawing.Point(262, 509);
            this.Data.Name = "Data";
            this.Data.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Data.Size = new System.Drawing.Size(139, 23);
            this.Data.TabIndex = 24;
            this.Data.Visible = false;
            this.Data.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Data_KeyPress);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 547);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.DeleteRow);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tables_from_BD);
            this.Controls.Add(this.MainTable);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuyOrBookingTicket";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddRecord;
        private System.Windows.Forms.Panel add;
        private System.Windows.Forms.Button EditRecord;
        private System.Windows.Forms.Panel edit;
        private System.Windows.Forms.Button Statistics;
        private System.Windows.Forms.Panel stat;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Panel find;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView MainTable;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MinWindow;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox tables_from_BD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DeleteRow;
        private System.Windows.Forms.TextBox Data;


    }
}