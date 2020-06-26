namespace Bank
{
    partial class AppealList
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
            this.appealListTable = new System.Windows.Forms.DataGridView();
            this.fioClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioEmploy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.appealListTable)).BeginInit();
            this.SuspendLayout();
            // 
            // appealListTable
            // 
            this.appealListTable.AllowUserToAddRows = false;
            this.appealListTable.AllowUserToDeleteRows = false;
            this.appealListTable.AllowUserToOrderColumns = true;
            this.appealListTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.appealListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appealListTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fioClient,
            this.fioEmploy,
            this.type,
            this.date,
            this.mark});
            this.appealListTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appealListTable.Location = new System.Drawing.Point(0, 0);
            this.appealListTable.Name = "appealListTable";
            this.appealListTable.ReadOnly = true;
            this.appealListTable.RowHeadersWidth = 50;
            this.appealListTable.RowTemplate.Height = 28;
            this.appealListTable.Size = new System.Drawing.Size(1121, 586);
            this.appealListTable.TabIndex = 0;
            this.appealListTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appealListTable_CellContentClick);
            // 
            // fioClient
            // 
            this.fioClient.HeaderText = "ФИО клиента";
            this.fioClient.MinimumWidth = 8;
            this.fioClient.Name = "fioClient";
            this.fioClient.ReadOnly = true;
            // 
            // fioEmploy
            // 
            this.fioEmploy.HeaderText = "ФИО сотрудника";
            this.fioEmploy.MinimumWidth = 8;
            this.fioEmploy.Name = "fioEmploy";
            this.fioEmploy.ReadOnly = true;
            // 
            // type
            // 
            this.type.HeaderText = "Тип обращения";
            this.type.MinimumWidth = 8;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Дата обращения";
            this.date.MinimumWidth = 8;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // mark
            // 
            this.mark.HeaderText = "Оценка обслуживания";
            this.mark.MinimumWidth = 8;
            this.mark.Name = "mark";
            this.mark.ReadOnly = true;
            // 
            // AppealList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 586);
            this.Controls.Add(this.appealListTable);
            this.Name = "AppealList";
            this.Text = "AppealList";
            ((System.ComponentModel.ISupportInitialize)(this.appealListTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView appealListTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioEmploy;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn mark;
    }
}