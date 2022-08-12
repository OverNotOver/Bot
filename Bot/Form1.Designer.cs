namespace Bot
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
            this.button_google = new System.Windows.Forms.Button();
            this.button_enter = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_google
            // 
            this.button_google.Location = new System.Drawing.Point(150, 135);
            this.button_google.Name = "button_google";
            this.button_google.Size = new System.Drawing.Size(146, 136);
            this.button_google.TabIndex = 0;
            this.button_google.Text = "GOOGLE";
            this.button_google.UseVisualStyleBackColor = true;
            this.button_google.Click += new System.EventHandler(this.button_google_Click);
            // 
            // button_enter
            // 
            this.button_enter.Location = new System.Drawing.Point(320, 135);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(150, 136);
            this.button_enter.TabIndex = 1;
            this.button_enter.Text = "ENTER";
            this.button_enter.UseVisualStyleBackColor = true;
            this.button_enter.Click += new System.EventHandler(this.button_enter_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(320, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_enter);
            this.Controls.Add(this.button_google);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_google;
        private System.Windows.Forms.Button button_enter;
        private System.Windows.Forms.TextBox textBox1;
    }
}

