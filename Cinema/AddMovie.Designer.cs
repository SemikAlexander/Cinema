namespace Cinema
{
    partial class AddMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMovie));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MinWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.restriction = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Genre = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.name_movie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.hall = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AddRec = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.TabIndex = 13;
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
            // restriction
            // 
            this.restriction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restriction.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.restriction.FormattingEnabled = true;
            this.restriction.Location = new System.Drawing.Point(221, 155);
            this.restriction.Name = "restriction";
            this.restriction.Size = new System.Drawing.Size(164, 25);
            this.restriction.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Возрастное ограничение";
            // 
            // country
            // 
            this.country.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.country.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.country.FormattingEnabled = true;
            this.country.Location = new System.Drawing.Point(221, 124);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(164, 25);
            this.country.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(149, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Страна";
            // 
            // Genre
            // 
            this.Genre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Genre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Genre.FormattingEnabled = true;
            this.Genre.Location = new System.Drawing.Point(221, 93);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(164, 25);
            this.Genre.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(163, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Жанр";
            // 
            // name_movie
            // 
            this.name_movie.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_movie.Location = new System.Drawing.Point(221, 35);
            this.name_movie.Name = "name_movie";
            this.name_movie.Size = new System.Drawing.Size(164, 23);
            this.name_movie.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(135, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Название";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(105, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Длительность";
            // 
            // duration
            // 
            this.duration.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.duration.Location = new System.Drawing.Point(221, 64);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(164, 23);
            this.duration.TabIndex = 23;
            this.duration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(109, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Цена билета";
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price.Location = new System.Drawing.Point(221, 217);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(164, 23);
            this.price.TabIndex = 25;
            this.price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_KeyPress);
            // 
            // hall
            // 
            this.hall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hall.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.hall.FormattingEnabled = true;
            this.hall.Location = new System.Drawing.Point(221, 186);
            this.hall.Name = "hall";
            this.hall.Size = new System.Drawing.Size(164, 25);
            this.hall.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(122, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Зал показа";
            // 
            // AddRec
            // 
            this.AddRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRec.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddRec.Location = new System.Drawing.Point(12, 282);
            this.AddRec.Name = "AddRec";
            this.AddRec.Size = new System.Drawing.Size(92, 31);
            this.AddRec.TabIndex = 29;
            this.AddRec.Text = "Добавить";
            this.AddRec.UseVisualStyleBackColor = true;
            this.AddRec.Click += new System.EventHandler(this.AddRec_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dateTimePicker1.Location = new System.Drawing.Point(221, 246);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(164, 23);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(112, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Дата показа";
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 325);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AddRec);
            this.Controls.Add(this.hall);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name_movie);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.country);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.restriction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMovie";
            this.Load += new System.EventHandler(this.AddMovie_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MinWindow;
        private System.Windows.Forms.ComboBox restriction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox country;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Genre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name_movie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox duration;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.ComboBox hall;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddRec;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
    }
}