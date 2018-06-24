namespace WandS
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbdata = new System.Windows.Forms.TextBox();
            this.btncalc = new System.Windows.Forms.Button();
            this.label_answer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbdata
            // 
            this.tbdata.Location = new System.Drawing.Point(107, 22);
            this.tbdata.Name = "tbdata";
            this.tbdata.Size = new System.Drawing.Size(100, 20);
            this.tbdata.TabIndex = 0;
            // 
            // btncalc
            // 
            this.btncalc.Location = new System.Drawing.Point(24, 75);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(75, 23);
            this.btncalc.TabIndex = 1;
            this.btncalc.Text = "Calculate";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // label_answer
            // 
            this.label_answer.AutoSize = true;
            this.label_answer.Location = new System.Drawing.Point(24, 122);
            this.label_answer.Name = "label_answer";
            this.label_answer.Size = new System.Drawing.Size(51, 13);
            this.label_answer.TabIndex = 2;
            this.label_answer.Text = "Answer =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter array";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 147);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_answer);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.tbdata);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbdata;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Label label_answer;
        private System.Windows.Forms.Label label2;
    }
}

