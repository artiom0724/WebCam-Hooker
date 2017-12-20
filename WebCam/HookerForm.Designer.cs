namespace WebCam
{
    partial class HookerForm
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
            this.hideMode = new System.Windows.Forms.CheckBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fileSize = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSize)).BeginInit();
            this.SuspendLayout();
            // 
            // hideMode
            // 
            this.hideMode.AutoSize = true;
            this.hideMode.Location = new System.Drawing.Point(12, 23);
            this.hideMode.Name = "hideMode";
            this.hideMode.Size = new System.Drawing.Size(89, 17);
            this.hideMode.TabIndex = 0;
            this.hideMode.Text = "Hidden mode";
            this.hideMode.UseVisualStyleBackColor = true;
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(54, 76);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(135, 20);
            this.emailText.TabIndex = 1;
            this.emailText.Text = "a_0_7@mail.ru";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "E-mail";
            // 
            // fileSize
            // 
            this.fileSize.Location = new System.Drawing.Point(54, 46);
            this.fileSize.Maximum = new decimal(new int[] {
            1048576,
            0,
            0,
            0});
            this.fileSize.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.fileSize.Name = "fileSize";
            this.fileSize.Size = new System.Drawing.Size(61, 20);
            this.fileSize.TabIndex = 3;
            this.fileSize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save and run hooks";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.HideProgramButtonClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SaveSettingsButtonClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Size";
            // 
            // HookerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 144);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fileSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.hideMode);
            this.Name = "HookerForm";
            this.Text = "Hooker";
            this.Load += new System.EventHandler(this.HookerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox hideMode;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown fileSize;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}

