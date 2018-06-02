namespace _18._1
{
    partial class QuickCreate
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
            this.GetN = new System.Windows.Forms.NumericUpDown();
            this.GetK = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GetN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetK)).BeginInit();
            this.SuspendLayout();
            // 
            // OkBtn
            // 
            this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBtn.Location = new System.Drawing.Point(27, 59);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 31);
            this.OkBtn.TabIndex = 0;
            this.OkBtn.Text = "ок";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(155, 59);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 31);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "отмена";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "N = ";
            // 
            // GetN
            // 
            this.GetN.Location = new System.Drawing.Point(67, 12);
            this.GetN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GetN.Name = "GetN";
            this.GetN.Size = new System.Drawing.Size(49, 22);
            this.GetN.TabIndex = 3;
            this.GetN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // GetK
            // 
            this.GetK.Location = new System.Drawing.Point(181, 12);
            this.GetK.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.GetK.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GetK.Name = "GetK";
            this.GetK.Size = new System.Drawing.Size(49, 22);
            this.GetK.TabIndex = 5;
            this.GetK.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "K = ";
            // 
            // QuickCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 108);
            this.Controls.Add(this.GetK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GetN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Name = "QuickCreate";
            this.Text = "QuickCreate";
            ((System.ComponentModel.ISupportInitialize)(this.GetN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown GetN;
        private System.Windows.Forms.NumericUpDown GetK;
        private System.Windows.Forms.Label label2;
    }
}