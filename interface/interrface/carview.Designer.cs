namespace interrface
{
    partial class carview
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
            this.car_Rental_Database_VersionIIIDataSet = new interrface.Car_Rental_Database_VersionIIIDataSet();
            this.carRentalDatabaseVersionIIIDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTableAdapter = new interrface.Car_Rental_Database_VersionIIIDataSetTableAdapters.CarTableAdapter();
            this.carIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturCompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineCapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horsePowerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maximumSpeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transmissionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tankSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tractionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelTankCapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfCylinderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_Rental_Database_VersionIIIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDatabaseVersionIIIDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carIDDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.departmentIDDataGridViewTextBoxColumn,
            this.makerIDDataGridViewTextBoxColumn,
            this.manufacturCompanyDataGridViewTextBoxColumn,
            this.carModelDataGridViewTextBoxColumn,
            this.engineCapacityDataGridViewTextBoxColumn,
            this.horsePowerDataGridViewTextBoxColumn,
            this.maximumSpeedDataGridViewTextBoxColumn,
            this.transmissionTypeDataGridViewTextBoxColumn,
            this.yearModelDataGridViewTextBoxColumn,
            this.fuelDataGridViewTextBoxColumn,
            this.tankSizeDataGridViewTextBoxColumn,
            this.seatsDataGridViewTextBoxColumn,
            this.tractionTypeDataGridViewTextBoxColumn,
            this.fuelTankCapacityDataGridViewTextBoxColumn,
            this.numberOfCylinderDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.carBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(502, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // car_Rental_Database_VersionIIIDataSet
            // 
            this.car_Rental_Database_VersionIIIDataSet.DataSetName = "Car_Rental_Database_VersionIIIDataSet";
            this.car_Rental_Database_VersionIIIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carRentalDatabaseVersionIIIDataSetBindingSource
            // 
            this.carRentalDatabaseVersionIIIDataSetBindingSource.DataSource = this.car_Rental_Database_VersionIIIDataSet;
            this.carRentalDatabaseVersionIIIDataSetBindingSource.Position = 0;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "Car";
            this.carBindingSource.DataSource = this.carRentalDatabaseVersionIIIDataSetBindingSource;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // carIDDataGridViewTextBoxColumn
            // 
            this.carIDDataGridViewTextBoxColumn.DataPropertyName = "CarID";
            this.carIDDataGridViewTextBoxColumn.HeaderText = "CarID";
            this.carIDDataGridViewTextBoxColumn.Name = "carIDDataGridViewTextBoxColumn";
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            // 
            // departmentIDDataGridViewTextBoxColumn
            // 
            this.departmentIDDataGridViewTextBoxColumn.DataPropertyName = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn.HeaderText = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn.Name = "departmentIDDataGridViewTextBoxColumn";
            // 
            // makerIDDataGridViewTextBoxColumn
            // 
            this.makerIDDataGridViewTextBoxColumn.DataPropertyName = "MakerID";
            this.makerIDDataGridViewTextBoxColumn.HeaderText = "MakerID";
            this.makerIDDataGridViewTextBoxColumn.Name = "makerIDDataGridViewTextBoxColumn";
            // 
            // manufacturCompanyDataGridViewTextBoxColumn
            // 
            this.manufacturCompanyDataGridViewTextBoxColumn.DataPropertyName = "ManufacturCompany";
            this.manufacturCompanyDataGridViewTextBoxColumn.HeaderText = "ManufacturCompany";
            this.manufacturCompanyDataGridViewTextBoxColumn.Name = "manufacturCompanyDataGridViewTextBoxColumn";
            // 
            // carModelDataGridViewTextBoxColumn
            // 
            this.carModelDataGridViewTextBoxColumn.DataPropertyName = "CarModel";
            this.carModelDataGridViewTextBoxColumn.HeaderText = "CarModel";
            this.carModelDataGridViewTextBoxColumn.Name = "carModelDataGridViewTextBoxColumn";
            // 
            // engineCapacityDataGridViewTextBoxColumn
            // 
            this.engineCapacityDataGridViewTextBoxColumn.DataPropertyName = "EngineCapacity";
            this.engineCapacityDataGridViewTextBoxColumn.HeaderText = "EngineCapacity";
            this.engineCapacityDataGridViewTextBoxColumn.Name = "engineCapacityDataGridViewTextBoxColumn";
            // 
            // horsePowerDataGridViewTextBoxColumn
            // 
            this.horsePowerDataGridViewTextBoxColumn.DataPropertyName = "HorsePower";
            this.horsePowerDataGridViewTextBoxColumn.HeaderText = "HorsePower";
            this.horsePowerDataGridViewTextBoxColumn.Name = "horsePowerDataGridViewTextBoxColumn";
            // 
            // maximumSpeedDataGridViewTextBoxColumn
            // 
            this.maximumSpeedDataGridViewTextBoxColumn.DataPropertyName = "MaximumSpeed";
            this.maximumSpeedDataGridViewTextBoxColumn.HeaderText = "MaximumSpeed";
            this.maximumSpeedDataGridViewTextBoxColumn.Name = "maximumSpeedDataGridViewTextBoxColumn";
            // 
            // transmissionTypeDataGridViewTextBoxColumn
            // 
            this.transmissionTypeDataGridViewTextBoxColumn.DataPropertyName = "TransmissionType";
            this.transmissionTypeDataGridViewTextBoxColumn.HeaderText = "TransmissionType";
            this.transmissionTypeDataGridViewTextBoxColumn.Name = "transmissionTypeDataGridViewTextBoxColumn";
            // 
            // yearModelDataGridViewTextBoxColumn
            // 
            this.yearModelDataGridViewTextBoxColumn.DataPropertyName = "YearModel";
            this.yearModelDataGridViewTextBoxColumn.HeaderText = "YearModel";
            this.yearModelDataGridViewTextBoxColumn.Name = "yearModelDataGridViewTextBoxColumn";
            // 
            // fuelDataGridViewTextBoxColumn
            // 
            this.fuelDataGridViewTextBoxColumn.DataPropertyName = "Fuel";
            this.fuelDataGridViewTextBoxColumn.HeaderText = "Fuel";
            this.fuelDataGridViewTextBoxColumn.Name = "fuelDataGridViewTextBoxColumn";
            // 
            // tankSizeDataGridViewTextBoxColumn
            // 
            this.tankSizeDataGridViewTextBoxColumn.DataPropertyName = "TankSize";
            this.tankSizeDataGridViewTextBoxColumn.HeaderText = "TankSize";
            this.tankSizeDataGridViewTextBoxColumn.Name = "tankSizeDataGridViewTextBoxColumn";
            // 
            // seatsDataGridViewTextBoxColumn
            // 
            this.seatsDataGridViewTextBoxColumn.DataPropertyName = "Seats";
            this.seatsDataGridViewTextBoxColumn.HeaderText = "Seats";
            this.seatsDataGridViewTextBoxColumn.Name = "seatsDataGridViewTextBoxColumn";
            // 
            // tractionTypeDataGridViewTextBoxColumn
            // 
            this.tractionTypeDataGridViewTextBoxColumn.DataPropertyName = "TractionType";
            this.tractionTypeDataGridViewTextBoxColumn.HeaderText = "TractionType";
            this.tractionTypeDataGridViewTextBoxColumn.Name = "tractionTypeDataGridViewTextBoxColumn";
            // 
            // fuelTankCapacityDataGridViewTextBoxColumn
            // 
            this.fuelTankCapacityDataGridViewTextBoxColumn.DataPropertyName = "FuelTankCapacity";
            this.fuelTankCapacityDataGridViewTextBoxColumn.HeaderText = "FuelTankCapacity";
            this.fuelTankCapacityDataGridViewTextBoxColumn.Name = "fuelTankCapacityDataGridViewTextBoxColumn";
            // 
            // numberOfCylinderDataGridViewTextBoxColumn
            // 
            this.numberOfCylinderDataGridViewTextBoxColumn.DataPropertyName = "NumberOfCylinder";
            this.numberOfCylinderDataGridViewTextBoxColumn.HeaderText = "NumberOfCylinder";
            this.numberOfCylinderDataGridViewTextBoxColumn.Name = "numberOfCylinderDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(51)))), ((int)(((byte)(83)))));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(295, 295);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 37);
            this.button3.TabIndex = 4;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // carview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::interrface.Properties.Resources.white;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "carview";
            this.Text = "CAR DELETE";
            this.Load += new System.EventHandler(this.carview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_Rental_Database_VersionIIIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDatabaseVersionIIIDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource carRentalDatabaseVersionIIIDataSetBindingSource;
        private Car_Rental_Database_VersionIIIDataSet car_Rental_Database_VersionIIIDataSet;
        private System.Windows.Forms.BindingSource carBindingSource;
        private Car_Rental_Database_VersionIIIDataSetTableAdapters.CarTableAdapter carTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn carIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturCompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineCapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horsePowerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maximumSpeedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transmissionTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tankSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tractionTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelTankCapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfCylinderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
    }
}