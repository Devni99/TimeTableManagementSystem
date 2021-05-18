
namespace Itpm
{
    partial class Form3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.registerdLecturesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerdStudentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerdSubjectsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerdRoomsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time3TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTPMDataSet = new Itpm.ITPMDataSet();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.time3_TableTableAdapter = new Itpm.ITPMDataSetTableAdapters.Time3_TableTableAdapter();
            this.button14 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time3TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTPMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registerdLecturesDataGridViewTextBoxColumn,
            this.registerdStudentsDataGridViewTextBoxColumn,
            this.registerdSubjectsDataGridViewTextBoxColumn,
            this.registerdRoomsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.time3TableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(659, 507);
            this.dataGridView1.TabIndex = 0;
            // 
            // registerdLecturesDataGridViewTextBoxColumn
            // 
            this.registerdLecturesDataGridViewTextBoxColumn.DataPropertyName = "Registerd_Lectures";
            this.registerdLecturesDataGridViewTextBoxColumn.HeaderText = "Registerd_Lectures";
            this.registerdLecturesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.registerdLecturesDataGridViewTextBoxColumn.Name = "registerdLecturesDataGridViewTextBoxColumn";
            this.registerdLecturesDataGridViewTextBoxColumn.Width = 125;
            // 
            // registerdStudentsDataGridViewTextBoxColumn
            // 
            this.registerdStudentsDataGridViewTextBoxColumn.DataPropertyName = "Registerd_Students";
            this.registerdStudentsDataGridViewTextBoxColumn.HeaderText = "Registerd_Students";
            this.registerdStudentsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.registerdStudentsDataGridViewTextBoxColumn.Name = "registerdStudentsDataGridViewTextBoxColumn";
            this.registerdStudentsDataGridViewTextBoxColumn.Width = 125;
            // 
            // registerdSubjectsDataGridViewTextBoxColumn
            // 
            this.registerdSubjectsDataGridViewTextBoxColumn.DataPropertyName = "Registerd_Subjects";
            this.registerdSubjectsDataGridViewTextBoxColumn.HeaderText = "Registerd_Subjects";
            this.registerdSubjectsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.registerdSubjectsDataGridViewTextBoxColumn.Name = "registerdSubjectsDataGridViewTextBoxColumn";
            this.registerdSubjectsDataGridViewTextBoxColumn.Width = 125;
            // 
            // registerdRoomsDataGridViewTextBoxColumn
            // 
            this.registerdRoomsDataGridViewTextBoxColumn.DataPropertyName = "Registerd_Rooms";
            this.registerdRoomsDataGridViewTextBoxColumn.HeaderText = "Registerd_Rooms";
            this.registerdRoomsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.registerdRoomsDataGridViewTextBoxColumn.Name = "registerdRoomsDataGridViewTextBoxColumn";
            this.registerdRoomsDataGridViewTextBoxColumn.Width = 125;
            // 
            // time3TableBindingSource
            // 
            this.time3TableBindingSource.DataMember = "Time3_Table";
            this.time3TableBindingSource.DataSource = this.iTPMDataSet;
            // 
            // iTPMDataSet
            // 
            this.iTPMDataSet.DataSetName = "ITPMDataSet";
            this.iTPMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(720, 155);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Registerd_Lectures";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Registerd_Students";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Registerd_Subjects";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Registerd_Rooms";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(413, 507);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(536, 716);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Location = new System.Drawing.Point(213, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(769, 41);
            this.label5.TabIndex = 19;
            this.label5.Text = "ABC Institute Time Table Management System";
            // 
            // time3_TableTableAdapter
            // 
            this.time3_TableTableAdapter.ClearBeforeFill = true;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(910, 707);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(197, 52);
            this.button14.TabIndex = 31;
            this.button14.Text = "NEXT>>";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 785);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time3TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTPMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private ITPMDataSet iTPMDataSet;
        private System.Windows.Forms.BindingSource time3TableBindingSource;
        private ITPMDataSetTableAdapters.Time3_TableTableAdapter time3_TableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn registerdLecturesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registerdStudentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registerdSubjectsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registerdRoomsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button14;
    }
}