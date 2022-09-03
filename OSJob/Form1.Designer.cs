namespace OSJob
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.организацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.организацииToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.структурыОрганизацийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.штатноеРасписаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.организацииToolStripMenuItem,
            this.сотрудникиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // организацииToolStripMenuItem
            // 
            this.организацииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.организацииToolStripMenuItem1,
            this.структурыОрганизацийToolStripMenuItem});
            this.организацииToolStripMenuItem.Name = "организацииToolStripMenuItem";
            this.организацииToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.организацииToolStripMenuItem.Text = "Организации";
            // 
            // организацииToolStripMenuItem1
            // 
            this.организацииToolStripMenuItem1.Name = "организацииToolStripMenuItem1";
            this.организацииToolStripMenuItem1.Size = new System.Drawing.Size(207, 22);
            this.организацииToolStripMenuItem1.Text = "Организации";
            this.организацииToolStripMenuItem1.Click += new System.EventHandler(this.организацииToolStripMenuItem1_Click);
            // 
            // структурыОрганизацийToolStripMenuItem
            // 
            this.структурыОрганизацийToolStripMenuItem.Name = "структурыОрганизацийToolStripMenuItem";
            this.структурыОрганизацийToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.структурыОрганизацийToolStripMenuItem.Text = "Структуры организаций";
            this.структурыОрганизацийToolStripMenuItem.Click += new System.EventHandler(this.структурыОрганизацийToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.штатноеРасписаниеToolStripMenuItem});
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            // 
            // штатноеРасписаниеToolStripMenuItem
            // 
            this.штатноеРасписаниеToolStripMenuItem.Name = "штатноеРасписаниеToolStripMenuItem";
            this.штатноеРасписаниеToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.штатноеРасписаниеToolStripMenuItem.Text = "Штатное расписание";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Администратор OSJob Ultra Light";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem организацииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem организацииToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem структурыОрганизацийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem штатноеРасписаниеToolStripMenuItem;
    }
}

