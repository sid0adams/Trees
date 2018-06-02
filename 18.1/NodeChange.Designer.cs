namespace _18._1
{
    partial class NodeChange
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
            this.OkBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ValueBox = new System.Windows.Forms.NumericUpDown();
            this.IndexBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ValueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndexBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OkBtn
            // 
            this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBtn.Location = new System.Drawing.Point(12, 111);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 30);
            this.OkBtn.TabIndex = 0;
            this.OkBtn.Text = "ок";
            this.OkBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(144, 111);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 30);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "отмена";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "значение";
            // 
            // ValueBox
            // 
            this.ValueBox.Location = new System.Drawing.Point(165, 7);
            this.ValueBox.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.ValueBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ValueBox.Name = "ValueBox";
            this.ValueBox.Size = new System.Drawing.Size(54, 22);
            this.ValueBox.TabIndex = 3;
            this.ValueBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ValueBox.ValueChanged += new System.EventHandler(this.ValueBox_ValueChanged);
            // 
            // IndexBox
            // 
            this.IndexBox.Location = new System.Drawing.Point(165, 35);
            this.IndexBox.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.IndexBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.IndexBox.Name = "IndexBox";
            this.IndexBox.Size = new System.Drawing.Size(54, 22);
            this.IndexBox.TabIndex = 5;
            this.IndexBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.IndexBox.ValueChanged += new System.EventHandler(this.IndexBox_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "позиция";
            // 
            // NodeChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 153);
            this.Controls.Add(this.IndexBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ValueBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Name = "NodeChange";
            this.Text = "NodeChange";
            ((System.ComponentModel.ISupportInitialize)(this.ValueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndexBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ValueBox;
        private System.Windows.Forms.NumericUpDown IndexBox;
        private System.Windows.Forms.Label label2;
    }
}