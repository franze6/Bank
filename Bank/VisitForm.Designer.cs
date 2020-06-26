namespace Bank
{
    partial class VisitForm
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
            this.typeVisitCB = new System.Windows.Forms.ComboBox();
            this.subTypeL = new System.Windows.Forms.Label();
            this.subTypeCB = new System.Windows.Forms.ComboBox();
            this.continueB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип визита:";
            // 
            // typeVisitCB
            // 
            this.typeVisitCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeVisitCB.FormattingEnabled = true;
            this.typeVisitCB.Items.AddRange(new object[] {
            "Обращение",
            "Сделка"});
            this.typeVisitCB.Location = new System.Drawing.Point(132, 10);
            this.typeVisitCB.Name = "typeVisitCB";
            this.typeVisitCB.Size = new System.Drawing.Size(186, 21);
            this.typeVisitCB.TabIndex = 1;
            this.typeVisitCB.SelectedIndexChanged += new System.EventHandler(this.typeVisitCB_SelectedIndexChanged);
            // 
            // subTypeL
            // 
            this.subTypeL.AutoSize = true;
            this.subTypeL.Location = new System.Drawing.Point(13, 46);
            this.subTypeL.Name = "subTypeL";
            this.subTypeL.Size = new System.Drawing.Size(11, 13);
            this.subTypeL.TabIndex = 2;
            this.subTypeL.Text = "*";
            this.subTypeL.Visible = false;
            // 
            // subTypeCB
            // 
            this.subTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subTypeCB.FormattingEnabled = true;
            this.subTypeCB.Location = new System.Drawing.Point(132, 43);
            this.subTypeCB.Name = "subTypeCB";
            this.subTypeCB.Size = new System.Drawing.Size(186, 21);
            this.subTypeCB.TabIndex = 3;
            this.subTypeCB.Visible = false;
            this.subTypeCB.SelectedIndexChanged += new System.EventHandler(this.subTypeCB_SelectedIndexChanged);
            // 
            // continueB
            // 
            this.continueB.Enabled = false;
            this.continueB.Location = new System.Drawing.Point(16, 80);
            this.continueB.Name = "continueB";
            this.continueB.Size = new System.Drawing.Size(302, 29);
            this.continueB.TabIndex = 4;
            this.continueB.Text = "Продолжить";
            this.continueB.UseVisualStyleBackColor = true;
            this.continueB.Click += new System.EventHandler(this.continueB_Click);
            // 
            // VisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 121);
            this.Controls.Add(this.continueB);
            this.Controls.Add(this.subTypeCB);
            this.Controls.Add(this.subTypeL);
            this.Controls.Add(this.typeVisitCB);
            this.Controls.Add(this.label1);
            this.Name = "VisitForm";
            this.Text = "VisitForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox typeVisitCB;
        private System.Windows.Forms.Label subTypeL;
        private System.Windows.Forms.ComboBox subTypeCB;
        private System.Windows.Forms.Button continueB;
    }
}