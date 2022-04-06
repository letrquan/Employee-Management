
namespace EmployeeManagementApp
{
    partial class from
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtWorkHours = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.dtpNewSalaryDate = new System.Windows.Forms.DateTimePicker();
            this.lbToDate = new System.Windows.Forms.Label();
            this.lbFromDate = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.btnFilterSalary = new System.Windows.Forms.Button();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.grvSalary = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtWorkHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.txtWorkHours);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Controls.Add(this.dtpNewSalaryDate);
            this.panel2.Controls.Add(this.lbToDate);
            this.panel2.Controls.Add(this.lbFromDate);
            this.panel2.Controls.Add(this.dtpToDate);
            this.panel2.Controls.Add(this.btnFilterSalary);
            this.panel2.Controls.Add(this.dtpFromDate);
            this.panel2.Controls.Add(this.grvSalary);
            this.panel2.Location = new System.Drawing.Point(165, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(953, 518);
            this.panel2.TabIndex = 12;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(238, 90);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Update Workhours:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(138, 37);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtWorkHours
            // 
            this.txtWorkHours.Location = new System.Drawing.Point(3, 37);
            this.txtWorkHours.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.txtWorkHours.Name = "txtWorkHours";
            this.txtWorkHours.Size = new System.Drawing.Size(129, 27);
            this.txtWorkHours.TabIndex = 15;
            this.txtWorkHours.BindingContextChanged += new System.EventHandler(this.txtWorkHours_BindingContextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "New Salary with select date: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(138, 90);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 29);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dtpNewSalaryDate
            // 
            this.dtpNewSalaryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNewSalaryDate.Location = new System.Drawing.Point(3, 90);
            this.dtpNewSalaryDate.Name = "dtpNewSalaryDate";
            this.dtpNewSalaryDate.Size = new System.Drawing.Size(129, 27);
            this.dtpNewSalaryDate.TabIndex = 12;
            this.dtpNewSalaryDate.Value = new System.DateTime(2021, 10, 30, 0, 0, 0, 0);
            // 
            // lbToDate
            // 
            this.lbToDate.AutoSize = true;
            this.lbToDate.Location = new System.Drawing.Point(721, 67);
            this.lbToDate.Name = "lbToDate";
            this.lbToDate.Size = new System.Drawing.Size(28, 20);
            this.lbToDate.TabIndex = 11;
            this.lbToDate.Text = "To:";
            // 
            // lbFromDate
            // 
            this.lbFromDate.AutoSize = true;
            this.lbFromDate.Location = new System.Drawing.Point(586, 67);
            this.lbFromDate.Name = "lbFromDate";
            this.lbFromDate.Size = new System.Drawing.Size(46, 20);
            this.lbFromDate.TabIndex = 10;
            this.lbFromDate.Text = "From:";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(721, 90);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(129, 27);
            this.dtpToDate.TabIndex = 9;
            this.dtpToDate.Value = new System.DateTime(2021, 10, 30, 0, 0, 0, 0);
            // 
            // btnFilterSalary
            // 
            this.btnFilterSalary.Location = new System.Drawing.Point(856, 88);
            this.btnFilterSalary.Name = "btnFilterSalary";
            this.btnFilterSalary.Size = new System.Drawing.Size(94, 29);
            this.btnFilterSalary.TabIndex = 8;
            this.btnFilterSalary.Text = "Filter";
            this.btnFilterSalary.UseVisualStyleBackColor = true;
            this.btnFilterSalary.Click += new System.EventHandler(this.btnFilterSalary_Click);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(586, 90);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(129, 27);
            this.dtpFromDate.TabIndex = 6;
            this.dtpFromDate.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // grvSalary
            // 
            this.grvSalary.AllowUserToAddRows = false;
            this.grvSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvSalary.Location = new System.Drawing.Point(3, 123);
            this.grvSalary.Name = "grvSalary";
            this.grvSalary.ReadOnly = true;
            this.grvSalary.RowHeadersWidth = 51;
            this.grvSalary.RowTemplate.Height = 29;
            this.grvSalary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvSalary.Size = new System.Drawing.Size(947, 392);
            this.grvSalary.TabIndex = 0;
            this.grvSalary.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvSalary_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(588, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 41);
            this.label3.TabIndex = 17;
            this.label3.Text = "SALARY";
            // 
            // from
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Name = "from";
            this.Size = new System.Drawing.Size(1300, 650);
            this.Load += new System.EventHandler(this.from_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtWorkHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grvSalary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbToDate;
        private System.Windows.Forms.Label lbFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Button btnFilterSalary;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DateTimePicker dtpNewSalaryDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.NumericUpDown txtWorkHours;
        private System.Windows.Forms.Button btnDelete;
    }
}
