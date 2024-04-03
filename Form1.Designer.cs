namespace конвертер_валют
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.comboBoxFrom = new System.Windows.Forms.ComboBox();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.comboBoxTo = new System.Windows.Forms.ComboBox();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(12, 29);
            this.textBoxFrom.Multiline = true;
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(100, 20);
            this.textBoxFrom.TabIndex = 0;
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Items.AddRange(new object[] {
            "USD",
            "GBP",
            "BYN",
            "RUB"});
            this.comboBoxFrom.Location = new System.Drawing.Point(12, 64);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(74, 21);
            this.comboBoxFrom.TabIndex = 1;
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(182, 29);
            this.textBoxTo.Multiline = true;
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(100, 20);
            this.textBoxTo.TabIndex = 2;
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.Items.AddRange(new object[] {
            "USD",
            "GBP",
            "BYN",
            "RUB"});
            this.comboBoxTo.Location = new System.Drawing.Point(182, 64);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(74, 21);
            this.comboBoxTo.TabIndex = 3;
            // 
            // ConvertButton
            // 
            this.ConvertButton.BackColor = System.Drawing.Color.Red;
            this.ConvertButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConvertButton.BackgroundImage")));
            this.ConvertButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConvertButton.Location = new System.Drawing.Point(118, 29);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(58, 56);
            this.ConvertButton.TabIndex = 4;
            this.ConvertButton.UseVisualStyleBackColor = false;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 113);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.comboBoxTo);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.comboBoxFrom);
            this.Controls.Add(this.textBoxFrom);
            this.Name = "Form1";
            this.Text = "конвертер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.ComboBox comboBoxFrom;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.ComboBox comboBoxTo;
        private System.Windows.Forms.Button ConvertButton;
    }
}

