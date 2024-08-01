namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class LeaveRequestDetailApprovalProcessDialogForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.getLeaveRequestStatusResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getLeaveRequestStatusResultDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.getLeaveRequestStatusResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getLeaveRequestStatusResultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // getLeaveRequestStatusResultBindingSource
            // 
            this.getLeaveRequestStatusResultBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.GetLeaveRequestStatusResult);
            // 
            // getLeaveRequestStatusResultDataGridView
            // 
            this.getLeaveRequestStatusResultDataGridView.AllowUserToAddRows = false;
            this.getLeaveRequestStatusResultDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.getLeaveRequestStatusResultDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.getLeaveRequestStatusResultDataGridView.AutoGenerateColumns = false;
            this.getLeaveRequestStatusResultDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.getLeaveRequestStatusResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getLeaveRequestStatusResultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.getLeaveRequestStatusResultDataGridView.DataSource = this.getLeaveRequestStatusResultBindingSource;
            this.getLeaveRequestStatusResultDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.getLeaveRequestStatusResultDataGridView.Location = new System.Drawing.Point(0, 0);
            this.getLeaveRequestStatusResultDataGridView.Name = "getLeaveRequestStatusResultDataGridView";
            this.getLeaveRequestStatusResultDataGridView.ReadOnly = true;
            this.getLeaveRequestStatusResultDataGridView.Size = new System.Drawing.Size(648, 274);
            this.getLeaveRequestStatusResultDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn1.HeaderText = "تایید کننده";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Personnel1";
            this.dataGridViewTextBoxColumn2.HeaderText = "تایید کننده مجاز اول";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Personnel2";
            this.dataGridViewTextBoxColumn3.HeaderText = "تایید کننده مجاز دوم";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Order";
            this.dataGridViewTextBoxColumn4.HeaderText = "الویت";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn5.HeaderText = "وضعیت";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // LeaveRequestDetailApprovalProcessDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 274);
            this.Controls.Add(this.getLeaveRequestStatusResultDataGridView);
            this.Name = "LeaveRequestDetailApprovalProcessDialogForm";
            this.ShowIcon = false;
            this.Text = "وضعیت درخواست مرخصی در مراحل تایید";
            this.Load += new System.EventHandler(this.LeaveRequestDetailApprovalProcessDialogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getLeaveRequestStatusResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getLeaveRequestStatusResultDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource getLeaveRequestStatusResultBindingSource;
        private System.Windows.Forms.DataGridView getLeaveRequestStatusResultDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}