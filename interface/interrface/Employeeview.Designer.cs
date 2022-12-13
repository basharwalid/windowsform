namespace interrface
{
    partial class Employeeview
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeUserNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeePasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNationalIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeePhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNationalityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBankingInforamtionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeGraduationStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.car_Rental_Database_VersionIIIDataSet = new interrface.Car_Rental_Database_VersionIIIDataSet();
            this.employeeTableAdapter = new interrface.Car_Rental_Database_VersionIIIDataSetTableAdapters.EmployeeTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_Rental_Database_VersionIIIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.employeeNameDataGridViewTextBoxColumn,
            this.employeeDepartmentDataGridViewTextBoxColumn,
            this.employeeEmailDataGridViewTextBoxColumn,
            this.employeeUserNameDataGridViewTextBoxColumn,
            this.employeePasswordDataGridViewTextBoxColumn,
            this.employeeGenderDataGridViewTextBoxColumn,
            this.employeeAgeDataGridViewTextBoxColumn,
            this.employeeNationalIDDataGridViewTextBoxColumn,
            this.employeePhoneNumberDataGridViewTextBoxColumn,
            this.employeeCountryDataGridViewTextBoxColumn,
            this.employeeCityDataGridViewTextBoxColumn,
            this.employeeAddressDataGridViewTextBoxColumn,
            this.employeeNationalityDataGridViewTextBoxColumn,
            this.employeeSalaryDataGridViewTextBoxColumn,
            this.employeeBankingInforamtionDataGridViewTextBoxColumn,
            this.employeeGraduationStateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(797, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.HeaderText = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            // 
            // employeeDepartmentDataGridViewTextBoxColumn
            // 
            this.employeeDepartmentDataGridViewTextBoxColumn.DataPropertyName = "EmployeeDepartment";
            this.employeeDepartmentDataGridViewTextBoxColumn.HeaderText = "EmployeeDepartment";
            this.employeeDepartmentDataGridViewTextBoxColumn.Name = "employeeDepartmentDataGridViewTextBoxColumn";
            // 
            // employeeEmailDataGridViewTextBoxColumn
            // 
            this.employeeEmailDataGridViewTextBoxColumn.DataPropertyName = "EmployeeEmail";
            this.employeeEmailDataGridViewTextBoxColumn.HeaderText = "EmployeeEmail";
            this.employeeEmailDataGridViewTextBoxColumn.Name = "employeeEmailDataGridViewTextBoxColumn";
            // 
            // employeeUserNameDataGridViewTextBoxColumn
            // 
            this.employeeUserNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeUserName";
            this.employeeUserNameDataGridViewTextBoxColumn.HeaderText = "EmployeeUserName";
            this.employeeUserNameDataGridViewTextBoxColumn.Name = "employeeUserNameDataGridViewTextBoxColumn";
            // 
            // employeePasswordDataGridViewTextBoxColumn
            // 
            this.employeePasswordDataGridViewTextBoxColumn.DataPropertyName = "EmployeePassword";
            this.employeePasswordDataGridViewTextBoxColumn.HeaderText = "EmployeePassword";
            this.employeePasswordDataGridViewTextBoxColumn.Name = "employeePasswordDataGridViewTextBoxColumn";
            // 
            // employeeGenderDataGridViewTextBoxColumn
            // 
            this.employeeGenderDataGridViewTextBoxColumn.DataPropertyName = "EmployeeGender";
            this.employeeGenderDataGridViewTextBoxColumn.HeaderText = "EmployeeGender";
            this.employeeGenderDataGridViewTextBoxColumn.Name = "employeeGenderDataGridViewTextBoxColumn";
            // 
            // employeeAgeDataGridViewTextBoxColumn
            // 
            this.employeeAgeDataGridViewTextBoxColumn.DataPropertyName = "EmployeeAge";
            this.employeeAgeDataGridViewTextBoxColumn.HeaderText = "EmployeeAge";
            this.employeeAgeDataGridViewTextBoxColumn.Name = "employeeAgeDataGridViewTextBoxColumn";
            // 
            // employeeNationalIDDataGridViewTextBoxColumn
            // 
            this.employeeNationalIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeNationalID";
            this.employeeNationalIDDataGridViewTextBoxColumn.HeaderText = "EmployeeNationalID";
            this.employeeNationalIDDataGridViewTextBoxColumn.Name = "employeeNationalIDDataGridViewTextBoxColumn";
            // 
            // employeePhoneNumberDataGridViewTextBoxColumn
            // 
            this.employeePhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "EmployeePhoneNumber";
            this.employeePhoneNumberDataGridViewTextBoxColumn.HeaderText = "EmployeePhoneNumber";
            this.employeePhoneNumberDataGridViewTextBoxColumn.Name = "employeePhoneNumberDataGridViewTextBoxColumn";
            // 
            // employeeCountryDataGridViewTextBoxColumn
            // 
            this.employeeCountryDataGridViewTextBoxColumn.DataPropertyName = "EmployeeCountry";
            this.employeeCountryDataGridViewTextBoxColumn.HeaderText = "EmployeeCountry";
            this.employeeCountryDataGridViewTextBoxColumn.Name = "employeeCountryDataGridViewTextBoxColumn";
            // 
            // employeeCityDataGridViewTextBoxColumn
            // 
            this.employeeCityDataGridViewTextBoxColumn.DataPropertyName = "EmployeeCity";
            this.employeeCityDataGridViewTextBoxColumn.HeaderText = "EmployeeCity";
            this.employeeCityDataGridViewTextBoxColumn.Name = "employeeCityDataGridViewTextBoxColumn";
            // 
            // employeeAddressDataGridViewTextBoxColumn
            // 
            this.employeeAddressDataGridViewTextBoxColumn.DataPropertyName = "EmployeeAddress";
            this.employeeAddressDataGridViewTextBoxColumn.HeaderText = "EmployeeAddress";
            this.employeeAddressDataGridViewTextBoxColumn.Name = "employeeAddressDataGridViewTextBoxColumn";
            // 
            // employeeNationalityDataGridViewTextBoxColumn
            // 
            this.employeeNationalityDataGridViewTextBoxColumn.DataPropertyName = "EmployeeNationality";
            this.employeeNationalityDataGridViewTextBoxColumn.HeaderText = "EmployeeNationality";
            this.employeeNationalityDataGridViewTextBoxColumn.Name = "employeeNationalityDataGridViewTextBoxColumn";
            // 
            // employeeSalaryDataGridViewTextBoxColumn
            // 
            this.employeeSalaryDataGridViewTextBoxColumn.DataPropertyName = "EmployeeSalary";
            this.employeeSalaryDataGridViewTextBoxColumn.HeaderText = "EmployeeSalary";
            this.employeeSalaryDataGridViewTextBoxColumn.Name = "employeeSalaryDataGridViewTextBoxColumn";
            // 
            // employeeBankingInforamtionDataGridViewTextBoxColumn
            // 
            this.employeeBankingInforamtionDataGridViewTextBoxColumn.DataPropertyName = "EmployeeBankingInforamtion";
            this.employeeBankingInforamtionDataGridViewTextBoxColumn.HeaderText = "EmployeeBankingInforamtion";
            this.employeeBankingInforamtionDataGridViewTextBoxColumn.Name = "employeeBankingInforamtionDataGridViewTextBoxColumn";
            // 
            // employeeGraduationStateDataGridViewTextBoxColumn
            // 
            this.employeeGraduationStateDataGridViewTextBoxColumn.DataPropertyName = "EmployeeGraduationState";
            this.employeeGraduationStateDataGridViewTextBoxColumn.HeaderText = "EmployeeGraduationState";
            this.employeeGraduationStateDataGridViewTextBoxColumn.Name = "employeeGraduationStateDataGridViewTextBoxColumn";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.car_Rental_Database_VersionIIIDataSet;
            // 
            // car_Rental_Database_VersionIIIDataSet
            // 
            this.car_Rental_Database_VersionIIIDataSet.DataSetName = "Car_Rental_Database_VersionIIIDataSet";
            this.car_Rental_Database_VersionIIIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(51)))), ((int)(((byte)(83)))));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(327, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 50);
            this.button2.TabIndex = 9;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataMember = "Employee";
            this.employeeBindingSource1.DataSource = this.car_Rental_Database_VersionIIIDataSet;
            // 
            // Employeeview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::interrface.Properties.Resources.white;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Employeeview";
            this.Text = "Employeeview";
            this.Load += new System.EventHandler(this.Employeeview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_Rental_Database_VersionIIIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Car_Rental_Database_VersionIIIDataSet car_Rental_Database_VersionIIIDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Car_Rental_Database_VersionIIIDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDepartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeUserNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeePasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNationalIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeePhoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNationalityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeBankingInforamtionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeGraduationStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource employeeBindingSource1;
    }
}