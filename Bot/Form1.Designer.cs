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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AddWindow = new System.Windows.Forms.Button();
            this.enter = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.LeftWindow = new System.Windows.Forms.Button();
            this.RigthWindow = new System.Windows.Forms.Button();
            this.BackWebBrowser = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox_search = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Fa1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.93703F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.06297F));
            this.tableLayoutPanel2.Controls.Add(this.AddWindow, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.enter, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.richTextBox_search, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(616, 113);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // AddWindow
            // 
            this.AddWindow.BackColor = System.Drawing.Color.CornflowerBlue;
            this.AddWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddWindow.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddWindow.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.AddWindow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.AddWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.AddWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddWindow.ForeColor = System.Drawing.Color.White;
            this.AddWindow.Location = new System.Drawing.Point(461, 40);
            this.AddWindow.Margin = new System.Windows.Forms.Padding(0);
            this.AddWindow.Name = "AddWindow";
            this.AddWindow.Size = new System.Drawing.Size(155, 73);
            this.AddWindow.TabIndex = 1;
            this.AddWindow.Text = "Добавить вкладку";
            this.AddWindow.UseVisualStyleBackColor = false;
            this.AddWindow.Click += new System.EventHandler(this.AddWindow_Click);
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.CornflowerBlue;
            this.enter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.enter.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.enter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.enter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enter.ForeColor = System.Drawing.Color.White;
            this.enter.Location = new System.Drawing.Point(461, 0);
            this.enter.Margin = new System.Windows.Forms.Padding(0);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(155, 40);
            this.enter.TabIndex = 1;
            this.enter.Text = "ENTER";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 211F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.BackWebBrowser, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(461, 73);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.LeftWindow, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.RigthWindow, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(250, 35);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(211, 38);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // LeftWindow
            // 
            this.LeftWindow.BackColor = System.Drawing.Color.CornflowerBlue;
            this.LeftWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftWindow.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LeftWindow.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.LeftWindow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.LeftWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.LeftWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeftWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftWindow.ForeColor = System.Drawing.Color.White;
            this.LeftWindow.Location = new System.Drawing.Point(0, 0);
            this.LeftWindow.Margin = new System.Windows.Forms.Padding(0);
            this.LeftWindow.Name = "LeftWindow";
            this.LeftWindow.Size = new System.Drawing.Size(105, 38);
            this.LeftWindow.TabIndex = 0;
            this.LeftWindow.Text = "<";
            this.LeftWindow.UseVisualStyleBackColor = false;
            this.LeftWindow.Click += new System.EventHandler(this.LeftWindow_Click);
            // 
            // RigthWindow
            // 
            this.RigthWindow.BackColor = System.Drawing.Color.CornflowerBlue;
            this.RigthWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RigthWindow.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RigthWindow.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.RigthWindow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.RigthWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.RigthWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RigthWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RigthWindow.ForeColor = System.Drawing.Color.White;
            this.RigthWindow.Location = new System.Drawing.Point(105, 0);
            this.RigthWindow.Margin = new System.Windows.Forms.Padding(0);
            this.RigthWindow.Name = "RigthWindow";
            this.RigthWindow.Size = new System.Drawing.Size(106, 38);
            this.RigthWindow.TabIndex = 1;
            this.RigthWindow.Text = ">";
            this.RigthWindow.UseVisualStyleBackColor = false;
            this.RigthWindow.Click += new System.EventHandler(this.RigthWindow_Click);
            // 
            // BackWebBrowser
            // 
            this.BackWebBrowser.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackWebBrowser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BackWebBrowser.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BackWebBrowser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.BackWebBrowser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.BackWebBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackWebBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackWebBrowser.ForeColor = System.Drawing.Color.White;
            this.BackWebBrowser.Location = new System.Drawing.Point(250, 0);
            this.BackWebBrowser.Margin = new System.Windows.Forms.Padding(0);
            this.BackWebBrowser.Name = "BackWebBrowser";
            this.BackWebBrowser.Size = new System.Drawing.Size(211, 35);
            this.BackWebBrowser.TabIndex = 2;
            this.BackWebBrowser.Text = "Back";
            this.BackWebBrowser.UseVisualStyleBackColor = false;
            this.BackWebBrowser.Click += new System.EventHandler(this.BackWebBrowser_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // richTextBox_search
            // 
            this.richTextBox_search.BackColor = System.Drawing.Color.White;
            this.richTextBox_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_search.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_search.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBox_search.Name = "richTextBox_search";
            this.richTextBox_search.Size = new System.Drawing.Size(461, 40);
            this.richTextBox_search.TabIndex = 4;
            this.richTextBox_search.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = global::Bot.Properties.Resources.fbImg;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(616, 407);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 116);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(601, 73);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.Fa1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 35);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(250, 38);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // Fa1
            // 
            this.Fa1.Location = new System.Drawing.Point(3, 3);
            this.Fa1.Name = "Fa1";
            this.Fa1.Size = new System.Drawing.Size(44, 23);
            this.Fa1.TabIndex = 0;
            this.Fa1.Text = "Fa1";
            this.Fa1.UseVisualStyleBackColor = true;
            this.Fa1.Click += new System.EventHandler(this.Fa1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(616, 407);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "FarmBot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button AddWindow;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button LeftWindow;
        private System.Windows.Forms.Button RigthWindow;
        private System.Windows.Forms.Button BackWebBrowser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox richTextBox_search;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button Fa1;
    }
}

