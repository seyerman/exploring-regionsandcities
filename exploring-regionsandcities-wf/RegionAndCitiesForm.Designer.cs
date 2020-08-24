namespace exploring_regionsandcities_wf
{
    partial class RegionAndCitiesForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.butOpenFile = new System.Windows.Forms.Button();
            this.regionAndCityDataView = new System.Windows.Forms.DataGridView();
            this.region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labRegion = new System.Windows.Forms.Label();
            this.cbRegions = new System.Windows.Forms.ComboBox();
            this.butClearTable = new System.Windows.Forms.Button();
            this.graphicReport = new System.Windows.Forms.Button();
            this.barCharRegionsDepts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.regionAndCityDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barCharRegionsDepts)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.InitialDirectory = "./";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(12, 23);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(474, 20);
            this.txtFileName.TabIndex = 0;
            // 
            // butOpenFile
            // 
            this.butOpenFile.Location = new System.Drawing.Point(491, 21);
            this.butOpenFile.Name = "butOpenFile";
            this.butOpenFile.Size = new System.Drawing.Size(75, 23);
            this.butOpenFile.TabIndex = 1;
            this.butOpenFile.Text = "Open File";
            this.butOpenFile.UseVisualStyleBackColor = true;
            this.butOpenFile.Click += new System.EventHandler(this.openFileClick);
            // 
            // regionAndCityDataView
            // 
            this.regionAndCityDataView.AllowUserToAddRows = false;
            this.regionAndCityDataView.AllowUserToDeleteRows = false;
            this.regionAndCityDataView.AllowUserToOrderColumns = true;
            this.regionAndCityDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.regionAndCityDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.region,
            this.deptCode,
            this.department,
            this.cityCode,
            this.city});
            this.regionAndCityDataView.Location = new System.Drawing.Point(12, 90);
            this.regionAndCityDataView.Name = "regionAndCityDataView";
            this.regionAndCityDataView.ReadOnly = true;
            this.regionAndCityDataView.Size = new System.Drawing.Size(554, 321);
            this.regionAndCityDataView.TabIndex = 2;
            // 
            // region
            // 
            this.region.HeaderText = "REGION";
            this.region.Name = "region";
            this.region.ReadOnly = true;
            // 
            // deptCode
            // 
            this.deptCode.HeaderText = "DEPT CODE";
            this.deptCode.Name = "deptCode";
            this.deptCode.ReadOnly = true;
            // 
            // department
            // 
            this.department.HeaderText = "DEPARTMENT";
            this.department.Name = "department";
            this.department.ReadOnly = true;
            // 
            // cityCode
            // 
            this.cityCode.HeaderText = "CITY CODE";
            this.cityCode.Name = "cityCode";
            this.cityCode.ReadOnly = true;
            // 
            // city
            // 
            this.city.HeaderText = "CITY";
            this.city.Name = "city";
            this.city.ReadOnly = true;
            // 
            // labRegion
            // 
            this.labRegion.AutoSize = true;
            this.labRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRegion.Location = new System.Drawing.Point(14, 56);
            this.labRegion.Name = "labRegion";
            this.labRegion.Size = new System.Drawing.Size(71, 20);
            this.labRegion.TabIndex = 3;
            this.labRegion.Text = "Region:";
            // 
            // cbRegions
            // 
            this.cbRegions.FormattingEnabled = true;
            this.cbRegions.Location = new System.Drawing.Point(101, 55);
            this.cbRegions.Name = "cbRegions";
            this.cbRegions.Size = new System.Drawing.Size(178, 21);
            this.cbRegions.TabIndex = 4;
            this.cbRegions.SelectedIndexChanged += new System.EventHandler(this.cbRegionsSelectedIndexChanged);
            // 
            // butClearTable
            // 
            this.butClearTable.Location = new System.Drawing.Point(491, 53);
            this.butClearTable.Name = "butClearTable";
            this.butClearTable.Size = new System.Drawing.Size(75, 23);
            this.butClearTable.TabIndex = 5;
            this.butClearTable.Text = "Clear Table";
            this.butClearTable.UseVisualStyleBackColor = true;
            this.butClearTable.Click += new System.EventHandler(this.clearTableClick);
            // 
            // graphicReport
            // 
            this.graphicReport.Location = new System.Drawing.Point(371, 53);
            this.graphicReport.Name = "graphicReport";
            this.graphicReport.Size = new System.Drawing.Size(101, 23);
            this.graphicReport.TabIndex = 6;
            this.graphicReport.Text = "Graphic Report";
            this.graphicReport.UseVisualStyleBackColor = true;
            this.graphicReport.Click += new System.EventHandler(this.graphicReportClick);
            // 
            // barCharRegionsDepts
            // 
            chartArea3.Name = "ChartArea1";
            this.barCharRegionsDepts.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.barCharRegionsDepts.Legends.Add(legend3);
            this.barCharRegionsDepts.Location = new System.Drawing.Point(586, 23);
            this.barCharRegionsDepts.Name = "barCharRegionsDepts";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.barCharRegionsDepts.Series.Add(series3);
            this.barCharRegionsDepts.Size = new System.Drawing.Size(518, 388);
            this.barCharRegionsDepts.TabIndex = 7;
            this.barCharRegionsDepts.Text = "barCharRegionsDept";
            // 
            // RegionAndCitiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 424);
            this.Controls.Add(this.barCharRegionsDepts);
            this.Controls.Add(this.graphicReport);
            this.Controls.Add(this.butClearTable);
            this.Controls.Add(this.cbRegions);
            this.Controls.Add(this.labRegion);
            this.Controls.Add(this.regionAndCityDataView);
            this.Controls.Add(this.butOpenFile);
            this.Controls.Add(this.txtFileName);
            this.Name = "RegionAndCitiesForm";
            this.Text = "Regions & Cities";
            ((System.ComponentModel.ISupportInitialize)(this.regionAndCityDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barCharRegionsDepts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button butOpenFile;
        private System.Windows.Forms.DataGridView regionAndCityDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn region;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.Label labRegion;
        private System.Windows.Forms.ComboBox cbRegions;
        private System.Windows.Forms.Button butClearTable;
        private System.Windows.Forms.Button graphicReport;
        private System.Windows.Forms.DataVisualization.Charting.Chart barCharRegionsDepts;
    }
}

