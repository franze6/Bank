namespace Bank
{
    partial class DealForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dealDateTB = new System.Windows.Forms.TextBox();
            this.clientFioTB = new System.Windows.Forms.TextBox();
            this.employFioTB = new System.Windows.Forms.TextBox();
            this.dealTypeTB = new System.Windows.Forms.TextBox();
            this.scopeNumTB = new System.Windows.Forms.TextBox();
            this.dealSumTB = new System.Windows.Forms.TextBox();
            this.collectorFioCB = new System.Windows.Forms.ComboBox();
            this.isAppeal = new System.Windows.Forms.CheckBox();
            this.isClose = new System.Windows.Forms.CheckBox();
            this.saveB = new System.Windows.Forms.Button();
            this.scopeCB = new System.Windows.Forms.ComboBox();
            this.datePick = new System.Windows.Forms.DateTimePicker();
            this.finishPersentL = new System.Windows.Forms.Label();
            this.finishPersentValueL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО коллектора:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ФИО клиента:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "ФИО сотрудника:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Обращение:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 177);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "№ счета в банке:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 95);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Тип сделки:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 135);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Дата сделки:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 218);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Сумма сделки:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(438, 89);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Флаг завершения:";
            // 
            // dealDateTB
            // 
            this.dealDateTB.Location = new System.Drawing.Point(176, 131);
            this.dealDateTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dealDateTB.Name = "dealDateTB";
            this.dealDateTB.ReadOnly = true;
            this.dealDateTB.Size = new System.Drawing.Size(252, 26);
            this.dealDateTB.TabIndex = 9;
            // 
            // clientFioTB
            // 
            this.clientFioTB.Location = new System.Drawing.Point(176, 9);
            this.clientFioTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clientFioTB.Name = "clientFioTB";
            this.clientFioTB.ReadOnly = true;
            this.clientFioTB.Size = new System.Drawing.Size(252, 26);
            this.clientFioTB.TabIndex = 10;
            // 
            // employFioTB
            // 
            this.employFioTB.Location = new System.Drawing.Point(176, 49);
            this.employFioTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.employFioTB.Name = "employFioTB";
            this.employFioTB.ReadOnly = true;
            this.employFioTB.Size = new System.Drawing.Size(252, 26);
            this.employFioTB.TabIndex = 11;
            // 
            // dealTypeTB
            // 
            this.dealTypeTB.Location = new System.Drawing.Point(176, 91);
            this.dealTypeTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dealTypeTB.Name = "dealTypeTB";
            this.dealTypeTB.ReadOnly = true;
            this.dealTypeTB.Size = new System.Drawing.Size(252, 26);
            this.dealTypeTB.TabIndex = 12;
            // 
            // scopeNumTB
            // 
            this.scopeNumTB.Location = new System.Drawing.Point(176, 172);
            this.scopeNumTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.scopeNumTB.Name = "scopeNumTB";
            this.scopeNumTB.ReadOnly = true;
            this.scopeNumTB.Size = new System.Drawing.Size(252, 26);
            this.scopeNumTB.TabIndex = 13;
            // 
            // dealSumTB
            // 
            this.dealSumTB.Location = new System.Drawing.Point(176, 214);
            this.dealSumTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dealSumTB.Name = "dealSumTB";
            this.dealSumTB.ReadOnly = true;
            this.dealSumTB.Size = new System.Drawing.Size(252, 26);
            this.dealSumTB.TabIndex = 14;
            // 
            // collectorFioCB
            // 
            this.collectorFioCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.collectorFioCB.FormattingEnabled = true;
            this.collectorFioCB.Location = new System.Drawing.Point(596, 9);
            this.collectorFioCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.collectorFioCB.Name = "collectorFioCB";
            this.collectorFioCB.Size = new System.Drawing.Size(250, 28);
            this.collectorFioCB.TabIndex = 15;
            // 
            // isAppeal
            // 
            this.isAppeal.AutoSize = true;
            this.isAppeal.Enabled = false;
            this.isAppeal.Location = new System.Drawing.Point(596, 54);
            this.isAppeal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.isAppeal.Name = "isAppeal";
            this.isAppeal.Size = new System.Drawing.Size(211, 24);
            this.isAppeal.TabIndex = 16;
            this.isAppeal.Text = "Связано с обращением";
            this.isAppeal.UseVisualStyleBackColor = true;
            this.isAppeal.CheckedChanged += new System.EventHandler(this.isAppeal_CheckedChanged);
            // 
            // isClose
            // 
            this.isClose.AutoSize = true;
            this.isClose.Enabled = false;
            this.isClose.Location = new System.Drawing.Point(596, 88);
            this.isClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.isClose.Name = "isClose";
            this.isClose.Size = new System.Drawing.Size(181, 24);
            this.isClose.TabIndex = 17;
            this.isClose.Text = "Сделка завершена";
            this.isClose.UseVisualStyleBackColor = true;
            // 
            // saveB
            // 
            this.saveB.Location = new System.Drawing.Point(438, 198);
            this.saveB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(408, 35);
            this.saveB.TabIndex = 18;
            this.saveB.Text = "Сохранить изменения";
            this.saveB.UseVisualStyleBackColor = true;
            this.saveB.Click += new System.EventHandler(this.saveB_Click);
            // 
            // scopeCB
            // 
            this.scopeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scopeCB.FormattingEnabled = true;
            this.scopeCB.Location = new System.Drawing.Point(176, 168);
            this.scopeCB.Name = "scopeCB";
            this.scopeCB.Size = new System.Drawing.Size(252, 28);
            this.scopeCB.TabIndex = 20;
            this.scopeCB.Visible = false;
            // 
            // datePick
            // 
            this.datePick.Enabled = false;
            this.datePick.Location = new System.Drawing.Point(176, 131);
            this.datePick.Name = "datePick";
            this.datePick.Size = new System.Drawing.Size(252, 26);
            this.datePick.TabIndex = 21;
            this.datePick.Value = new System.DateTime(2020, 6, 26, 14, 31, 56, 0);
            this.datePick.Visible = false;
            // 
            // finishPersentL
            // 
            this.finishPersentL.AutoSize = true;
            this.finishPersentL.Location = new System.Drawing.Point(442, 135);
            this.finishPersentL.Name = "finishPersentL";
            this.finishPersentL.Size = new System.Drawing.Size(320, 30);
            this.finishPersentL.TabIndex = 22;
            this.finishPersentL.Text = "Итоговый процент сделки:";
            this.finishPersentL.Visible = false;
            // 
            // finishPersentValueL
            // 
            this.finishPersentValueL.AutoSize = true;
            this.finishPersentValueL.Location = new System.Drawing.Point(702, 135);
            this.finishPersentValueL.Name = "finishPersentValueL";
            this.finishPersentValueL.Size = new System.Drawing.Size(60, 20);
            this.finishPersentValueL.TabIndex = 23;
            this.finishPersentValueL.Text = "label11";
            this.finishPersentValueL.Visible = false;
            // 
            // DealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 254);
            this.Controls.Add(this.finishPersentValueL);
            this.Controls.Add(this.finishPersentL);
            this.Controls.Add(this.datePick);
            this.Controls.Add(this.scopeCB);
            this.Controls.Add(this.saveB);
            this.Controls.Add(this.isClose);
            this.Controls.Add(this.isAppeal);
            this.Controls.Add(this.collectorFioCB);
            this.Controls.Add(this.dealSumTB);
            this.Controls.Add(this.scopeNumTB);
            this.Controls.Add(this.dealTypeTB);
            this.Controls.Add(this.employFioTB);
            this.Controls.Add(this.clientFioTB);
            this.Controls.Add(this.dealDateTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DealForm";
            this.Text = "Сделка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox dealDateTB;
        private System.Windows.Forms.TextBox clientFioTB;
        private System.Windows.Forms.TextBox employFioTB;
        private System.Windows.Forms.TextBox dealTypeTB;
        private System.Windows.Forms.TextBox scopeNumTB;
        private System.Windows.Forms.TextBox dealSumTB;
        private System.Windows.Forms.ComboBox collectorFioCB;
        private System.Windows.Forms.CheckBox isAppeal;
        private System.Windows.Forms.CheckBox isClose;
        private System.Windows.Forms.Button saveB;
        private System.Windows.Forms.ComboBox scopeCB;
        private System.Windows.Forms.DateTimePicker datePick;
        private System.Windows.Forms.Label finishPersentL;
        private System.Windows.Forms.Label finishPersentValueL;
    }
}