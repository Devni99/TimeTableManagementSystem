
namespace Itpm
{
    partial class Form5
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
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.iTPMDataSet1 = new Itpm.ITPMDataSet1();
            this.time4TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.time4_TableTableAdapter = new Itpm.ITPMDataSet1TableAdapters.Time4_TableTableAdapter();
            this.iTPMDataSet2 = new Itpm.ITPMDataSet2();
            this.time5TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.time5_TableTableAdapter = new Itpm.ITPMDataSet2TableAdapters.Time5_TableTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecture1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecture2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTPMDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time4TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTPMDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time5TableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Location = new System.Drawing.Point(227, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(769, 41);
            this.label5.TabIndex = 20;
            this.label5.Text = "ABC Institute Time Table Management System";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.lecture1DataGridViewTextBoxColumn,
            this.lecture2DataGridViewTextBoxColumn,
            this.subjectCodeDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.gIDDataGridViewTextBoxColumn,
            this.roomDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.time5TableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(106, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1006, 603);
            this.dataGridView1.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(337, 740);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 41);
            this.button1.TabIndex = 22;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(915, 729);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(197, 52);
            this.button14.TabIndex = 32;
            this.button14.Text = "NEXT>>";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(646, 740);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 41);
            this.button2.TabIndex = 33;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // iTPMDataSet1
            // 
            this.iTPMDataSet1.DataSetName = "ITPMDataSet1";
            this.iTPMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // time4TableBindingSource
            // 
            this.time4TableBindingSource.DataMember = "Time4_Table";
            this.time4TableBindingSource.DataSource = this.iTPMDataSet1;
            // 
            // time4_TableTableAdapter
            // 
            this.time4_TableTableAdapter.ClearBeforeFill = true;
            // 
            // iTPMDataSet2
            // 
            this.iTPMDataSet2.DataSetName = "ITPMDataSet2";
            this.iTPMDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // time5TableBindingSource
            // 
            this.time5TableBindingSource.DataMember = "Time5_Table";
            this.time5TableBindingSource.DataSource = this.iTPMDataSet2;
            // 
            // time5_TableTableAdapter
            // 
            this.time5_TableTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // lecture1DataGridViewTextBoxColumn
            // 
            this.lecture1DataGridViewTextBoxColumn.DataPropertyName = "Lecture1";
            this.lecture1DataGridViewTextBoxColumn.HeaderText = "Lecture1";
            this.lecture1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lecture1DataGridViewTextBoxColumn.Name = "lecture1DataGridViewTextBoxColumn";
            this.lecture1DataGridViewTextBoxColumn.Width = 125;
            // 
            // lecture2DataGridViewTextBoxColumn
            // 
            this.lecture2DataGridViewTextBoxColumn.DataPropertyName = "Lecture2";
            this.lecture2DataGridViewTextBoxColumn.HeaderText = "Lecture2";
            this.lecture2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lecture2DataGridViewTextBoxColumn.Name = "lecture2DataGridViewTextBoxColumn";
            this.lecture2DataGridViewTextBoxColumn.Width = 125;
            // 
            // subjectCodeDataGridViewTextBoxColumn
            // 
            this.subjectCodeDataGridViewTextBoxColumn.DataPropertyName = "Subject_Code";
            this.subjectCodeDataGridViewTextBoxColumn.HeaderText = "Subject_Code";
            this.subjectCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectCodeDataGridViewTextBoxColumn.Name = "subjectCodeDataGridViewTextBoxColumn";
            this.subjectCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Subject";
            this.subjectDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.Width = 125;
            // 
            // gIDDataGridViewTextBoxColumn
            // 
            this.gIDDataGridViewTextBoxColumn.DataPropertyName = "GID";
            this.gIDDataGridViewTextBoxColumn.HeaderText = "GID";
            this.gIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gIDDataGridViewTextBoxColumn.Name = "gIDDataGridViewTextBoxColumn";
            this.gIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomDataGridViewTextBoxColumn
            // 
            this.roomDataGridViewTextBoxColumn.DataPropertyName = "Room";
            this.roomDataGridViewTextBoxColumn.HeaderText = "Room";
            this.roomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomDataGridViewTextBoxColumn.Name = "roomDataGridViewTextBoxColumn";
            this.roomDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1179, 805);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTPMDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time4TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTPMDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time5TableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button2;
        private ITPMDataSet1 iTPMDataSet1;
        private System.Windows.Forms.BindingSource time4TableBindingSource;
        private ITPMDataSet1TableAdapters.Time4_TableTableAdapter time4_TableTableAdapter;
        private ITPMDataSet2 iTPMDataSet2;
        private System.Windows.Forms.BindingSource time5TableBindingSource;
        private ITPMDataSet2TableAdapters.Time5_TableTableAdapter time5_TableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecture1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecture2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
    }
}