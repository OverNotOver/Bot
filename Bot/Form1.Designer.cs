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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button_enter = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.weather_button = new System.Windows.Forms.Button();
            this.button_google = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.richTextBox_search = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonAddWin = new System.Windows.Forms.Button();
            this.richTextBox_text = new System.Windows.Forms.RichTextBox();
            this.buttonChat = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox_text, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(443, 453);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.93703F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.06297F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.button_enter, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.richTextBox_search, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(443, 126);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // button_enter
            // 
            this.button_enter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_enter.Location = new System.Drawing.Point(331, 0);
            this.button_enter.Margin = new System.Windows.Forms.Padding(0);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(112, 44);
            this.button_enter.TabIndex = 1;
            this.button_enter.Text = "ENTER";
            this.button_enter.UseVisualStyleBackColor = true;
            this.button_enter.Click += new System.EventHandler(this.button_enter_Click_1);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.weather_button, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button_google, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.buttonChat, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 44);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(331, 82);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // weather_button
            // 
            this.weather_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weather_button.Location = new System.Drawing.Point(0, 0);
            this.weather_button.Margin = new System.Windows.Forms.Padding(0);
            this.weather_button.Name = "weather_button";
            this.weather_button.Size = new System.Drawing.Size(165, 41);
            this.weather_button.TabIndex = 0;
            this.weather_button.Text = "ПОГОДА";
            this.weather_button.UseVisualStyleBackColor = true;
            this.weather_button.Click += new System.EventHandler(this.weather_button_Click);
            // 
            // button_google
            // 
            this.button_google.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_google.Location = new System.Drawing.Point(0, 41);
            this.button_google.Margin = new System.Windows.Forms.Padding(0);
            this.button_google.Name = "button_google";
            this.button_google.Size = new System.Drawing.Size(165, 41);
            this.button_google.TabIndex = 1;
            this.button_google.Text = "GOOGLE";
            this.button_google.UseVisualStyleBackColor = true;
            this.button_google.Click += new System.EventHandler(this.button_google_Click_1);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.buttonRight, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.buttonLeft, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.buttonBack, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(165, 41);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(166, 41);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // buttonRight
            // 
            this.buttonRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRight.Location = new System.Drawing.Point(110, 0);
            this.buttonRight.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(56, 41);
            this.buttonRight.TabIndex = 1;
            this.buttonRight.Text = ">";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLeft.Location = new System.Drawing.Point(55, 0);
            this.buttonLeft.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(55, 41);
            this.buttonLeft.TabIndex = 0;
            this.buttonLeft.Text = "<";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBack.Location = new System.Drawing.Point(0, 0);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(55, 41);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // richTextBox_search
            // 
            this.richTextBox_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_search.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_search.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBox_search.Name = "richTextBox_search";
            this.richTextBox_search.Size = new System.Drawing.Size(331, 44);
            this.richTextBox_search.TabIndex = 4;
            this.richTextBox_search.Text = "";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.button4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.buttonAddWin, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(331, 44);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(112, 82);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 40);
            this.button4.TabIndex = 0;
            this.button4.Text = "СПИЗДИТЬ";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // buttonAddWin
            // 
            this.buttonAddWin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddWin.Location = new System.Drawing.Point(0, 40);
            this.buttonAddWin.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddWin.Name = "buttonAddWin";
            this.buttonAddWin.Size = new System.Drawing.Size(112, 42);
            this.buttonAddWin.TabIndex = 1;
            this.buttonAddWin.Text = "+WIN";
            this.buttonAddWin.UseVisualStyleBackColor = true;
            this.buttonAddWin.Click += new System.EventHandler(this.buttonAddWin_Click);
            // 
            // richTextBox_text
            // 
            this.richTextBox_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_text.Location = new System.Drawing.Point(0, 126);
            this.richTextBox_text.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBox_text.Name = "richTextBox_text";
            this.richTextBox_text.Size = new System.Drawing.Size(443, 327);
            this.richTextBox_text.TabIndex = 1;
            this.richTextBox_text.Text = "";
            // 
            // buttonChat
            // 
            this.buttonChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChat.Location = new System.Drawing.Point(165, 0);
            this.buttonChat.Margin = new System.Windows.Forms.Padding(0);
            this.buttonChat.Name = "buttonChat";
            this.buttonChat.Size = new System.Drawing.Size(166, 41);
            this.buttonChat.TabIndex = 3;
            this.buttonChat.Text = "Чат";
            this.buttonChat.UseVisualStyleBackColor = true;
            this.buttonChat.Click += new System.EventHandler(this.buttonChat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 453);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button_enter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button weather_button;
        private System.Windows.Forms.RichTextBox richTextBox_search;
        private System.Windows.Forms.RichTextBox richTextBox_text;
        private System.Windows.Forms.Button button_google;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonAddWin;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonChat;
    }
}

