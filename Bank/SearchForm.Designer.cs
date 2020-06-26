namespace Bank
{
    partial class SearchForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.fioTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.saveB = new System.Windows.Forms.Button();
            this.clientTypeTB = new System.Windows.Forms.ComboBox();
            this.clientSpecTB = new System.Windows.Forms.ComboBox();
            this.adressTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.resetB = new System.Windows.Forms.Button();
            this.startVisitB = new System.Windows.Forms.Button();
            this.creadTB = new System.Windows.Forms.MaskedTextBox();
            this.phoneTB = new System.Windows.Forms.MaskedTextBox();
            this.viewAppealB = new System.Windows.Forms.Button();
            this.viewDealB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО:";
            // 
            // fioTB
            // 
            this.fioTB.Location = new System.Drawing.Point(70, 9);
            this.fioTB.Name = "fioTB";
            this.fioTB.Size = new System.Drawing.Size(286, 26);
            this.fioTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Паспорт:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Телефон:";
            // 
            // searchB
            // 
            this.searchB.Location = new System.Drawing.Point(472, 48);
            this.searchB.Name = "searchB";
            this.searchB.Size = new System.Drawing.Size(122, 35);
            this.searchB.TabIndex = 6;
            this.searchB.Text = "Поиск";
            this.searchB.UseVisualStyleBackColor = true;
            this.searchB.Click += new System.EventHandler(this.searchB_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Тип клиента:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Вид клиента:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Адрес:";
            // 
            // saveB
            // 
            this.saveB.Enabled = false;
            this.saveB.Location = new System.Drawing.Point(10, 255);
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(584, 32);
            this.saveB.TabIndex = 11;
            this.saveB.Text = "Сохранить изменения";
            this.saveB.UseVisualStyleBackColor = true;
            this.saveB.Click += new System.EventHandler(this.saveB_Click);
            // 
            // clientTypeTB
            // 
            this.clientTypeTB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientTypeTB.Enabled = false;
            this.clientTypeTB.FormattingEnabled = true;
            this.clientTypeTB.Location = new System.Drawing.Point(120, 105);
            this.clientTypeTB.Name = "clientTypeTB";
            this.clientTypeTB.Size = new System.Drawing.Size(236, 28);
            this.clientTypeTB.TabIndex = 12;
            // 
            // clientSpecTB
            // 
            this.clientSpecTB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientSpecTB.Enabled = false;
            this.clientSpecTB.FormattingEnabled = true;
            this.clientSpecTB.Location = new System.Drawing.Point(120, 143);
            this.clientSpecTB.Name = "clientSpecTB";
            this.clientSpecTB.Size = new System.Drawing.Size(236, 28);
            this.clientSpecTB.TabIndex = 13;
            // 
            // adressTB
            // 
            this.adressTB.Enabled = false;
            this.adressTB.Location = new System.Drawing.Point(80, 185);
            this.adressTB.Name = "adressTB";
            this.adressTB.Size = new System.Drawing.Size(520, 26);
            this.adressTB.TabIndex = 14;
            // 
            // emailTB
            // 
            this.emailTB.Enabled = false;
            this.emailTB.Location = new System.Drawing.Point(80, 214);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(224, 26);
            this.emailTB.TabIndex = 15;
            // 
            // resetB
            // 
            this.resetB.Location = new System.Drawing.Point(472, 89);
            this.resetB.Name = "resetB";
            this.resetB.Size = new System.Drawing.Size(122, 32);
            this.resetB.TabIndex = 16;
            this.resetB.Text = "Сбросить";
            this.resetB.UseVisualStyleBackColor = true;
            this.resetB.Click += new System.EventHandler(this.resetB_Click);
            // 
            // startVisitB
            // 
            this.startVisitB.Enabled = false;
            this.startVisitB.Location = new System.Drawing.Point(10, 297);
            this.startVisitB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startVisitB.Name = "startVisitB";
            this.startVisitB.Size = new System.Drawing.Size(208, 62);
            this.startVisitB.TabIndex = 17;
            this.startVisitB.Text = "Начать визит клиента";
            this.startVisitB.UseVisualStyleBackColor = true;
            this.startVisitB.Click += new System.EventHandler(this.startVisitB_Click);
            // 
            // creadTB
            // 
            this.creadTB.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.creadTB.Location = new System.Drawing.Point(448, 9);
            this.creadTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.creadTB.Mask = "0000 000000";
            this.creadTB.Name = "creadTB";
            this.creadTB.Size = new System.Drawing.Size(148, 26);
            this.creadTB.TabIndex = 18;
            this.creadTB.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // phoneTB
            // 
            this.phoneTB.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.phoneTB.Location = new System.Drawing.Point(104, 49);
            this.phoneTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phoneTB.Mask = "+0 (000) 000-00-00";
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(176, 26);
            this.phoneTB.TabIndex = 19;
            this.phoneTB.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // viewAppealB
            // 
            this.viewAppealB.Enabled = false;
            this.viewAppealB.Location = new System.Drawing.Point(230, 297);
            this.viewAppealB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewAppealB.Name = "viewAppealB";
            this.viewAppealB.Size = new System.Drawing.Size(182, 62);
            this.viewAppealB.TabIndex = 20;
            this.viewAppealB.Text = "Обращения";
            this.viewAppealB.UseVisualStyleBackColor = true;
            this.viewAppealB.Click += new System.EventHandler(this.viewAppealB_Click);
            // 
            // viewDealB
            // 
            this.viewDealB.Enabled = false;
            this.viewDealB.Location = new System.Drawing.Point(420, 297);
            this.viewDealB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewDealB.Name = "viewDealB";
            this.viewDealB.Size = new System.Drawing.Size(165, 62);
            this.viewDealB.TabIndex = 21;
            this.viewDealB.Text = "Сделки";
            this.viewDealB.UseVisualStyleBackColor = true;
            this.viewDealB.Click += new System.EventHandler(this.viewDealB_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 369);
            this.Controls.Add(this.viewDealB);
            this.Controls.Add(this.viewAppealB);
            this.Controls.Add(this.phoneTB);
            this.Controls.Add(this.creadTB);
            this.Controls.Add(this.startVisitB);
            this.Controls.Add(this.resetB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.adressTB);
            this.Controls.Add(this.clientSpecTB);
            this.Controls.Add(this.clientTypeTB);
            this.Controls.Add(this.saveB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fioTB);
            this.Controls.Add(this.label1);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fioTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button searchB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button saveB;
        private System.Windows.Forms.ComboBox clientTypeTB;
        private System.Windows.Forms.ComboBox clientSpecTB;
        private System.Windows.Forms.TextBox adressTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Button resetB;
        private System.Windows.Forms.Button startVisitB;
        private System.Windows.Forms.MaskedTextBox creadTB;
        private System.Windows.Forms.MaskedTextBox phoneTB;
        private System.Windows.Forms.Button viewAppealB;
        private System.Windows.Forms.Button viewDealB;
    }
}