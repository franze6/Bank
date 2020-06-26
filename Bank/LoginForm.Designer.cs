namespace Bank
{
    partial class LoginForm
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
            this.startWorkB = new System.Windows.Forms.Button();
            this.emlpoyListCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startWorkB
            // 
            this.startWorkB.Location = new System.Drawing.Point(9, 86);
            this.startWorkB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startWorkB.Name = "startWorkB";
            this.startWorkB.Size = new System.Drawing.Size(453, 32);
            this.startWorkB.TabIndex = 0;
            this.startWorkB.Text = "Начать работу";
            this.startWorkB.UseVisualStyleBackColor = true;
            this.startWorkB.Click += new System.EventHandler(this.startWorkB_Click);
            // 
            // emlpoyListCB
            // 
            this.emlpoyListCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.emlpoyListCB.FormattingEnabled = true;
            this.emlpoyListCB.Location = new System.Drawing.Point(9, 47);
            this.emlpoyListCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emlpoyListCB.Name = "emlpoyListCB";
            this.emlpoyListCB.Size = new System.Drawing.Size(454, 21);
            this.emlpoyListCB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добро пожаловать!\r\nНеобходимо выбрать ваше ФИО:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 127);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emlpoyListCB);
            this.Controls.Add(this.startWorkB);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startWorkB;
        private System.Windows.Forms.ComboBox emlpoyListCB;
        private System.Windows.Forms.Label label1;
    }
}

