namespace Cinema
{
    partial class Choise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choise));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ticket = new System.Windows.Forms.Button();
            this.movie = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(158, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.closeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.closeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("closeToolStripMenuItem.Image")));
            this.closeToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // Ticket
            // 
            this.Ticket.FlatAppearance.BorderSize = 0;
            this.Ticket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ticket.Image = ((System.Drawing.Image)(resources.GetObject("Ticket.Image")));
            this.Ticket.Location = new System.Drawing.Point(12, 27);
            this.Ticket.Name = "Ticket";
            this.Ticket.Size = new System.Drawing.Size(55, 44);
            this.Ticket.TabIndex = 1;
            this.Ticket.UseVisualStyleBackColor = true;
            this.Ticket.Click += new System.EventHandler(this.Ticket_Click);
            // 
            // movie
            // 
            this.movie.FlatAppearance.BorderSize = 0;
            this.movie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.movie.Image = ((System.Drawing.Image)(resources.GetObject("movie.Image")));
            this.movie.Location = new System.Drawing.Point(91, 27);
            this.movie.Name = "movie";
            this.movie.Size = new System.Drawing.Size(55, 44);
            this.movie.TabIndex = 2;
            this.movie.UseVisualStyleBackColor = true;
            this.movie.Click += new System.EventHandler(this.button1_Click);
            // 
            // Choise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(158, 88);
            this.Controls.Add(this.movie);
            this.Controls.Add(this.Ticket);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Choise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choise";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button Ticket;
        private System.Windows.Forms.Button movie;
    }
}