namespace Bank
{
    partial class DealList
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
            this.dealListTable = new System.Windows.Forms.DataGridView();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eFio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishDeal = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isAppealExists = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dealScopeNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collectorFio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dealListTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dealListTable
            // 
            this.dealListTable.AllowUserToAddRows = false;
            this.dealListTable.AllowUserToDeleteRows = false;
            this.dealListTable.AllowUserToOrderColumns = true;
            this.dealListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dealListTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FIO,
            this.eFio,
            this.dealType,
            this.dealDate,
            this.dealSum,
            this.finishDeal,
            this.isAppealExists,
            this.dealScopeNum,
            this.collectorFio});
            this.dealListTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dealListTable.Location = new System.Drawing.Point(0, 0);
            this.dealListTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dealListTable.Name = "dealListTable";
            this.dealListTable.ReadOnly = true;
            this.dealListTable.RowHeadersWidth = 62;
            this.dealListTable.Size = new System.Drawing.Size(1416, 692);
            this.dealListTable.TabIndex = 0;
            this.dealListTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dealListTable_CellDoubleClick);
            // 
            // FIO
            // 
            this.FIO.HeaderText = "ФИО клиента";
            this.FIO.MinimumWidth = 8;
            this.FIO.Name = "FIO";
            this.FIO.ReadOnly = true;
            this.FIO.Width = 150;
            // 
            // eFio
            // 
            this.eFio.HeaderText = "ФИО сотрудника";
            this.eFio.MinimumWidth = 8;
            this.eFio.Name = "eFio";
            this.eFio.ReadOnly = true;
            this.eFio.Width = 150;
            // 
            // dealType
            // 
            this.dealType.HeaderText = "Тип сделки";
            this.dealType.MinimumWidth = 8;
            this.dealType.Name = "dealType";
            this.dealType.ReadOnly = true;
            this.dealType.Width = 150;
            // 
            // dealDate
            // 
            this.dealDate.HeaderText = "Дата сделки";
            this.dealDate.MinimumWidth = 8;
            this.dealDate.Name = "dealDate";
            this.dealDate.ReadOnly = true;
            this.dealDate.Width = 150;
            // 
            // dealSum
            // 
            this.dealSum.HeaderText = "Сумма сделки";
            this.dealSum.MinimumWidth = 8;
            this.dealSum.Name = "dealSum";
            this.dealSum.ReadOnly = true;
            this.dealSum.Width = 150;
            // 
            // finishDeal
            // 
            this.finishDeal.HeaderText = "Сделка завершена";
            this.finishDeal.MinimumWidth = 8;
            this.finishDeal.Name = "finishDeal";
            this.finishDeal.ReadOnly = true;
            this.finishDeal.Width = 150;
            // 
            // isAppealExists
            // 
            this.isAppealExists.HeaderText = "Обращение";
            this.isAppealExists.MinimumWidth = 8;
            this.isAppealExists.Name = "isAppealExists";
            this.isAppealExists.ReadOnly = true;
            this.isAppealExists.Width = 150;
            // 
            // dealScopeNum
            // 
            this.dealScopeNum.HeaderText = "Номер счета";
            this.dealScopeNum.MinimumWidth = 8;
            this.dealScopeNum.Name = "dealScopeNum";
            this.dealScopeNum.ReadOnly = true;
            this.dealScopeNum.Width = 150;
            // 
            // collectorFio
            // 
            this.collectorFio.HeaderText = "ФИО коллектора";
            this.collectorFio.MinimumWidth = 8;
            this.collectorFio.Name = "collectorFio";
            this.collectorFio.ReadOnly = true;
            this.collectorFio.Width = 150;
            // 
            // DealList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 692);
            this.Controls.Add(this.dealListTable);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DealList";
            this.Text = "Список сделок";
            ((System.ComponentModel.ISupportInitialize)(this.dealListTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dealListTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn eFio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealSum;
        private System.Windows.Forms.DataGridViewCheckBoxColumn finishDeal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isAppealExists;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealScopeNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn collectorFio;
    }
}