
namespace OpenJob
{
    partial class Main
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
            this.добавитьОрганизациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сруктурыОрганизацийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.персоналToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.объектыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.штатноеРасписаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.организацииToolStripMenuItem,
            this.персоналToolStripMenuItem,
            this.объектыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // организацииToolStripMenuItem
            // 
            this.организацииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьОрганизациюToolStripMenuItem,
            this.сруктурыОрганизацийToolStripMenuItem});
            this.организацииToolStripMenuItem.Name = "организацииToolStripMenuItem";
            this.организацииToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.организацииToolStripMenuItem.Text = "Организации";
            // 
            // добавитьОрганизациюToolStripMenuItem
            // 
            this.добавитьОрганизациюToolStripMenuItem.Name = "добавитьОрганизациюToolStripMenuItem";
            this.добавитьОрганизациюToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.добавитьОрганизациюToolStripMenuItem.Text = "Организации";
            this.добавитьОрганизациюToolStripMenuItem.Click += new System.EventHandler(this.добавитьОрганизациюToolStripMenuItem_Click);
            // 
            // сруктурыОрганизацийToolStripMenuItem
            // 
            this.сруктурыОрганизацийToolStripMenuItem.Name = "сруктурыОрганизацийToolStripMenuItem";
            this.сруктурыОрганизацийToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.сруктурыОрганизацийToolStripMenuItem.Text = "Сруктуры организаций";
            this.сруктурыОрганизацийToolStripMenuItem.Click += new System.EventHandler(this.сруктурыОрганизацийToolStripMenuItem_Click);
            // 
            // персоналToolStripMenuItem
            // 
            this.персоналToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.штатноеРасписаниеToolStripMenuItem});
            this.персоналToolStripMenuItem.Name = "персоналToolStripMenuItem";
            this.персоналToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.персоналToolStripMenuItem.Text = "Персонал";
            // 
            // объектыToolStripMenuItem
            // 
            this.объектыToolStripMenuItem.Name = "объектыToolStripMenuItem";
            this.объектыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.объектыToolStripMenuItem.Text = "Объекты";
            // 
            // штатноеРасписаниеToolStripMenuItem
            // 
            this.штатноеРасписаниеToolStripMenuItem.Name = "штатноеРасписаниеToolStripMenuItem";
            this.штатноеРасписаниеToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.штатноеРасписаниеToolStripMenuItem.Text = "Штатное расписание";
            this.штатноеРасписаниеToolStripMenuItem.Click += new System.EventHandler(this.штатноеРасписаниеToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "OSJob Администратор";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem организацииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьОрганизациюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem персоналToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem объектыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сруктурыОрганизацийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem штатноеРасписаниеToolStripMenuItem;
    }
}

