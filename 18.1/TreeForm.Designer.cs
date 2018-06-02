namespace _18._1
{
    partial class TreeForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintFirstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintSecondToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuickInitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.ClearToolStripMenuItem,
            this.QuickInitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(846, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.PrintFirstToolStripMenuItem,
            this.PrintSecondToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.файлToolStripMenuItem.Text = "файл";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.OpenToolStripMenuItem.Text = "открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.SaveToolStripMenuItem.Text = "сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // PrintFirstToolStripMenuItem
            // 
            this.PrintFirstToolStripMenuItem.Name = "PrintFirstToolStripMenuItem";
            this.PrintFirstToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.PrintFirstToolStripMenuItem.Text = "печать 1";
            this.PrintFirstToolStripMenuItem.Click += new System.EventHandler(this.PrintFirstToolStripMenuItem_Click);
            // 
            // PrintSecondToolStripMenuItem
            // 
            this.PrintSecondToolStripMenuItem.Name = "PrintSecondToolStripMenuItem";
            this.PrintSecondToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.PrintSecondToolStripMenuItem.Text = "печать 2";
            this.PrintSecondToolStripMenuItem.Click += new System.EventHandler(this.PrintSecondToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Текстовый документ(*.txt)|*.txt|Все файлы|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Текстовый документ(*.txt)|*.txt|Все файлы|*.*";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddBtn,
            this.RemoveBtn,
            this.ChangeBtn});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(148, 76);
            // 
            // AddBtn
            // 
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(147, 24);
            this.AddBtn.Text = "Добавить";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(147, 24);
            this.RemoveBtn.Text = "Удалить";
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(147, 24);
            this.ChangeBtn.Text = "Изменить";
            this.ChangeBtn.Click += new System.EventHandler(this.ChangeBtn_Click);
            // 
            // ClearToolStripMenuItem
            // 
            this.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem";
            this.ClearToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.ClearToolStripMenuItem.Text = "очистить";
            this.ClearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // QuickInitToolStripMenuItem
            // 
            this.QuickInitToolStripMenuItem.Name = "QuickInitToolStripMenuItem";
            this.QuickInitToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.QuickInitToolStripMenuItem.Text = "быстрое создание";
            this.QuickInitToolStripMenuItem.Click += new System.EventHandler(this.QuickInitToolStripMenuItem_Click);
            // 
            // TreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 511);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "TreeForm";
            this.Text = "TreeForm";
            this.Load += new System.EventHandler(this.TreeForm_Load);
            this.ResizeEnd += new System.EventHandler(this.TreeForm_ResizeEnd);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TreeForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TreeForm_MouseDown);
            this.Resize += new System.EventHandler(this.TreeForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AddBtn;
        private System.Windows.Forms.ToolStripMenuItem RemoveBtn;
        private System.Windows.Forms.ToolStripMenuItem ChangeBtn;
        private System.Windows.Forms.ToolStripMenuItem PrintFirstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrintSecondToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuickInitToolStripMenuItem;
    }
}

