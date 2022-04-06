
namespace EmployeeManagementApp
{
    partial class frmDepartmentDetail
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTiltle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbDepartmentId = new System.Windows.Forms.Label();
            this.txtDepartmentID = new System.Windows.Forms.TextBox();
            this.lbDepartmentName = new System.Windows.Forms.Label();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.txtDepartmentBaseSalary = new System.Windows.Forms.MaskedTextBox();
            this.lbBaseSalary = new System.Windows.Forms.Label();
            this.lbManagerId = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboBoxManagerId = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.22727F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.77273F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel2.Controls.Add(this.txtTiltle, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(57, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(782, 85);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // txtTiltle
            // 
            this.txtTiltle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTiltle.AutoSize = true;
            this.txtTiltle.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTiltle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtTiltle.Location = new System.Drawing.Point(197, 23);
            this.txtTiltle.Name = "txtTiltle";
            this.txtTiltle.Size = new System.Drawing.Size(373, 38);
            this.txtTiltle.TabIndex = 0;
            this.txtTiltle.Text = "DEPARTMENT INFOMATION";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78F));
            this.tableLayoutPanel1.Controls.Add(this.lbDepartmentId, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDepartmentID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbDepartmentName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDepartmentName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDepartmentBaseSalary, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbBaseSalary, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbManagerId, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxManagerId, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(100, 119);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(673, 330);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lbDepartmentId
            // 
            this.lbDepartmentId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbDepartmentId.AutoSize = true;
            this.lbDepartmentId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDepartmentId.Location = new System.Drawing.Point(3, 32);
            this.lbDepartmentId.Name = "lbDepartmentId";
            this.lbDepartmentId.Size = new System.Drawing.Size(111, 20);
            this.lbDepartmentId.TabIndex = 0;
            this.lbDepartmentId.Text = "Department ID:";
            this.lbDepartmentId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDepartmentID
            // 
            this.txtDepartmentID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDepartmentID.Location = new System.Drawing.Point(248, 29);
            this.txtDepartmentID.Name = "txtDepartmentID";
            this.txtDepartmentID.Size = new System.Drawing.Size(324, 27);
            this.txtDepartmentID.TabIndex = 5;
            // 
            // lbDepartmentName
            // 
            this.lbDepartmentName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbDepartmentName.AutoSize = true;
            this.lbDepartmentName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDepartmentName.Location = new System.Drawing.Point(3, 117);
            this.lbDepartmentName.Name = "lbDepartmentName";
            this.lbDepartmentName.Size = new System.Drawing.Size(136, 20);
            this.lbDepartmentName.TabIndex = 2;
            this.lbDepartmentName.Text = "Department Name:";
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDepartmentName.Location = new System.Drawing.Point(248, 114);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(324, 27);
            this.txtDepartmentName.TabIndex = 7;
            // 
            // txtDepartmentBaseSalary
            // 
            this.txtDepartmentBaseSalary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDepartmentBaseSalary.Location = new System.Drawing.Point(250, 279);
            this.txtDepartmentBaseSalary.Mask = "000000000";
            this.txtDepartmentBaseSalary.Name = "txtDepartmentBaseSalary";
            this.txtDepartmentBaseSalary.Size = new System.Drawing.Size(321, 27);
            this.txtDepartmentBaseSalary.TabIndex = 11;
            this.txtDepartmentBaseSalary.ValidatingType = typeof(int);
            // 
            // lbBaseSalary
            // 
            this.lbBaseSalary.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbBaseSalary.AutoSize = true;
            this.lbBaseSalary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBaseSalary.Location = new System.Drawing.Point(3, 282);
            this.lbBaseSalary.Name = "lbBaseSalary";
            this.lbBaseSalary.Size = new System.Drawing.Size(87, 20);
            this.lbBaseSalary.TabIndex = 10;
            this.lbBaseSalary.Text = "Base Salary:";
            // 
            // lbManagerId
            // 
            this.lbManagerId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbManagerId.AutoSize = true;
            this.lbManagerId.Location = new System.Drawing.Point(3, 192);
            this.lbManagerId.Name = "lbManagerId";
            this.lbManagerId.Size = new System.Drawing.Size(141, 40);
            this.lbManagerId.TabIndex = 12;
            this.lbManagerId.Text = "Manager ID: (empty able)";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnCancel, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnSave, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(240, 470);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(381, 54);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Location = new System.Drawing.Point(238, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Location = new System.Drawing.Point(48, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboBoxManagerId
            // 
            this.comboBoxManagerId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxManagerId.FormattingEnabled = true;
            this.comboBoxManagerId.Location = new System.Drawing.Point(251, 195);
            this.comboBoxManagerId.Name = "comboBoxManagerId";
            this.comboBoxManagerId.Size = new System.Drawing.Size(319, 28);
            this.comboBoxManagerId.TabIndex = 13;
            // 
            // frmDepartmentDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 561);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "frmDepartmentDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDepartmentDetail";
            this.Load += new System.EventHandler(this.frmDepartmentDetail_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label txtTiltle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbDepartmentId;
        private System.Windows.Forms.TextBox txtDepartmentID;
        private System.Windows.Forms.Label lbDepartmentName;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.Label lbBaseSalary;
        private System.Windows.Forms.MaskedTextBox txtDepartmentBaseSalary;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbManagerId;
        private System.Windows.Forms.ComboBox comboBoxManagerId;
    }
}