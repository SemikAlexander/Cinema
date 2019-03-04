namespace Cinema
{
    partial class EditMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMovie));
            this.EditRec = new System.Windows.Forms.Button();
            this.Hall = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Duration = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Name_Movie = new System.Windows.Forms.TextBox();
            this.Genre = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AgeRestrictions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MinWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditRec
            // 
            this.EditRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditRec.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditRec.Location = new System.Drawing.Point(12, 257);
            this.EditRec.Name = "EditRec";
            this.EditRec.Size = new System.Drawing.Size(92, 31);
            this.EditRec.TabIndex = 44;
            this.EditRec.Text = "Изменить";
            this.EditRec.UseVisualStyleBackColor = true;
            this.EditRec.Click += new System.EventHandler(this.EditRec_Click);
            // 
            // Hall
            // 
            this.Hall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hall.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Hall.FormattingEnabled = true;
            this.Hall.Location = new System.Drawing.Point(221, 186);
            this.Hall.Name = "Hall";
            this.Hall.Size = new System.Drawing.Size(164, 25);
            this.Hall.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(122, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = "Зал показа";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(109, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "Цена билета";
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price.Location = new System.Drawing.Point(221, 217);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(164, 23);
            this.Price.TabIndex = 40;
            this.Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Price_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(105, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Длительность";
            // 
            // Duration
            // 
            this.Duration.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Duration.Location = new System.Drawing.Point(221, 64);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(164, 23);
            this.Duration.TabIndex = 38;
            this.Duration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Duration_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(135, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Название";
            // 
            // Name_Movie
            // 
            this.Name_Movie.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_Movie.Location = new System.Drawing.Point(221, 35);
            this.Name_Movie.Name = "Name_Movie";
            this.Name_Movie.Size = new System.Drawing.Size(164, 23);
            this.Name_Movie.TabIndex = 36;
            // 
            // Genre
            // 
            this.Genre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Genre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Genre.FormattingEnabled = true;
            this.Genre.Location = new System.Drawing.Point(221, 93);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(164, 25);
            this.Genre.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(163, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Жанр";
            // 
            // Country
            // 
            this.Country.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Country.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Country.FormattingEnabled = true;
            this.Country.Location = new System.Drawing.Point(221, 124);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(164, 25);
            this.Country.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(149, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Страна";
            // 
            // AgeRestrictions
            // 
            this.AgeRestrictions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgeRestrictions.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.AgeRestrictions.FormattingEnabled = true;
            this.AgeRestrictions.Location = new System.Drawing.Point(221, 155);
            this.AgeRestrictions.Name = "AgeRestrictions";
            this.AgeRestrictions.Size = new System.Drawing.Size(164, 25);
            this.AgeRestrictions.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Возрастное ограничение";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.MinWindow});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(397, 24);
            this.menuStrip1.TabIndex = 45;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MinWindow
            // 
            this.MinWindow.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MinWindow.Image = ((System.Drawing.Image)(resources.GetObject("MinWindow.Image")));
            this.MinWindow.Name = "MinWindow";
            this.MinWindow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MinWindow.Size = new System.Drawing.Size(28, 20);
            this.MinWindow.Click += new System.EventHandler(this.MinWindow_Click);
            // 
            // EditMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 300);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.EditRec);
            this.Controls.Add(this.Hall);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Duration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Name_Movie);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AgeRestrictions);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditMovie";
            this.Load += new System.EventHandler(this.EditMovie_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditRec;
        private System.Windows.Forms.ComboBox Hall;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Duration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Name_Movie;
        private System.Windows.Forms.ComboBox Genre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Country;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox AgeRestrictions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MinWindow;
    }
}