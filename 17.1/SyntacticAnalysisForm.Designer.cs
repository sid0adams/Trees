namespace _18._1
{
    partial class SyntacticAnalysisForm
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
            this.Input = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(12, 46);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(368, 22);
            this.Input.TabIndex = 0;
            this.Input.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(386, 49);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(0, 17);
            this.Output.TabIndex = 1;
            // 
            // SyntacticAnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 123);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Name = "SyntacticAnalysisForm";
            this.Text = "Syntactic Analysis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Label Output;
    }
}

