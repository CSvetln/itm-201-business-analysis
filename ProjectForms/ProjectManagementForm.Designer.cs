
namespace ProjectForms
{
    partial class ProjectManagementForm
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
            this.buttonConnect = new System.Windows.Forms.Button();
            this.tabControlCubes = new System.Windows.Forms.TabControl();
            this.tabPageHoursOfJob = new System.Windows.Forms.TabPage();
            this.comboBoxHoursOfJob = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.datesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectManagementDataSet = new ProjectForms.ProjectManagementDataSet();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonBuildReportHoursOfBug = new System.Windows.Forms.Button();
            this.dataGridViewHoursOfJob = new System.Windows.Forms.DataGridView();
            this.labelMeasuresSort = new System.Windows.Forms.Label();
            this.tabPageBugs = new System.Windows.Forms.TabPage();
            this.buttonBuildReportBugs = new System.Windows.Forms.Button();
            this.dataGridViewBugs = new System.Windows.Forms.DataGridView();
            this.tabPageBonuses = new System.Windows.Forms.TabPage();
            this.buttonBuildReportBonuses = new System.Windows.Forms.Button();
            this.dataGridViewBonuses = new System.Windows.Forms.DataGridView();
            this.labelSelectEmpl = new System.Windows.Forms.Label();
            this.comboBoxSelectEmpl = new System.Windows.Forms.ComboBox();
            this.buttonBuildReport = new System.Windows.Forms.Button();
            this.datesTableAdapter = new ProjectForms.ProjectManagementDataSetTableAdapters.DatesTableAdapter();
            this.tabControlCubes.SuspendLayout();
            this.tabPageHoursOfJob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoursOfJob)).BeginInit();
            this.tabPageBugs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBugs)).BeginInit();
            this.tabPageBonuses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBonuses)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonConnect.Location = new System.Drawing.Point(347, 494);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(178, 41);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Подключение";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // tabControlCubes
            // 
            this.tabControlCubes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlCubes.Controls.Add(this.tabPageHoursOfJob);
            this.tabControlCubes.Controls.Add(this.tabPageBugs);
            this.tabControlCubes.Controls.Add(this.tabPageBonuses);
            this.tabControlCubes.Location = new System.Drawing.Point(12, 12);
            this.tabControlCubes.Name = "tabControlCubes";
            this.tabControlCubes.SelectedIndex = 0;
            this.tabControlCubes.Size = new System.Drawing.Size(1276, 476);
            this.tabControlCubes.TabIndex = 1;
            // 
            // tabPageHoursOfJob
            // 
            this.tabPageHoursOfJob.Controls.Add(this.comboBoxHoursOfJob);
            this.tabPageHoursOfJob.Controls.Add(this.dateTimePicker2);
            this.tabPageHoursOfJob.Controls.Add(this.dateTimePicker1);
            this.tabPageHoursOfJob.Controls.Add(this.buttonBuildReportHoursOfBug);
            this.tabPageHoursOfJob.Controls.Add(this.dataGridViewHoursOfJob);
            this.tabPageHoursOfJob.Controls.Add(this.labelMeasuresSort);
            this.tabPageHoursOfJob.Location = new System.Drawing.Point(4, 25);
            this.tabPageHoursOfJob.Name = "tabPageHoursOfJob";
            this.tabPageHoursOfJob.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHoursOfJob.Size = new System.Drawing.Size(1268, 447);
            this.tabPageHoursOfJob.TabIndex = 0;
            this.tabPageHoursOfJob.Text = "Количество часов";
            this.tabPageHoursOfJob.UseVisualStyleBackColor = true;
            // 
            // comboBoxHoursOfJob
            // 
            this.comboBoxHoursOfJob.FormattingEnabled = true;
            this.comboBoxHoursOfJob.Items.AddRange(new object[] {
            "По сотрудникам",
            "По проектам"});
            this.comboBoxHoursOfJob.Location = new System.Drawing.Point(537, 4);
            this.comboBoxHoursOfJob.Name = "comboBoxHoursOfJob";
            this.comboBoxHoursOfJob.Size = new System.Drawing.Size(193, 24);
            this.comboBoxHoursOfJob.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.datesBindingSource, "Date", true));
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datesBindingSource, "Date", true));
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.datesBindingSource, "Date", true));
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.datesBindingSource, "Date", true));
            this.dateTimePicker2.Location = new System.Drawing.Point(331, 6);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // datesBindingSource
            // 
            this.datesBindingSource.DataMember = "Dates";
            this.datesBindingSource.DataSource = this.projectManagementDataSet;
            // 
            // projectManagementDataSet
            // 
            this.projectManagementDataSet.DataSetName = "ProjectManagementDataSet";
            this.projectManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.datesBindingSource, "Date", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.datesBindingSource, "Date", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datesBindingSource, "Date", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.datesBindingSource, "Date", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.dateTimePicker1.Location = new System.Drawing.Point(125, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.TabStop = false;
            // 
            // buttonBuildReportHoursOfBug
            // 
            this.buttonBuildReportHoursOfBug.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonBuildReportHoursOfBug.Location = new System.Drawing.Point(9, 384);
            this.buttonBuildReportHoursOfBug.Name = "buttonBuildReportHoursOfBug";
            this.buttonBuildReportHoursOfBug.Size = new System.Drawing.Size(178, 41);
            this.buttonBuildReportHoursOfBug.TabIndex = 3;
            this.buttonBuildReportHoursOfBug.Text = "Построить отчет";
            this.buttonBuildReportHoursOfBug.UseVisualStyleBackColor = true;
            this.buttonBuildReportHoursOfBug.Click += new System.EventHandler(this.buttonBuildReportHoursOfBug_Click);
            // 
            // dataGridViewHoursOfJob
            // 
            this.dataGridViewHoursOfJob.AllowUserToAddRows = false;
            this.dataGridViewHoursOfJob.AllowUserToDeleteRows = false;
            this.dataGridViewHoursOfJob.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewHoursOfJob.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHoursOfJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHoursOfJob.Location = new System.Drawing.Point(9, 34);
            this.dataGridViewHoursOfJob.Name = "dataGridViewHoursOfJob";
            this.dataGridViewHoursOfJob.ReadOnly = true;
            this.dataGridViewHoursOfJob.RowHeadersWidth = 51;
            this.dataGridViewHoursOfJob.RowTemplate.Height = 24;
            this.dataGridViewHoursOfJob.Size = new System.Drawing.Size(1253, 344);
            this.dataGridViewHoursOfJob.TabIndex = 2;
            // 
            // labelMeasuresSort
            // 
            this.labelMeasuresSort.AutoSize = true;
            this.labelMeasuresSort.Location = new System.Drawing.Point(6, 6);
            this.labelMeasuresSort.Name = "labelMeasuresSort";
            this.labelMeasuresSort.Size = new System.Drawing.Size(113, 17);
            this.labelMeasuresSort.TabIndex = 1;
            this.labelMeasuresSort.Text = "Отсортировать:";
            // 
            // tabPageBugs
            // 
            this.tabPageBugs.Controls.Add(this.buttonBuildReportBugs);
            this.tabPageBugs.Controls.Add(this.dataGridViewBugs);
            this.tabPageBugs.Location = new System.Drawing.Point(4, 25);
            this.tabPageBugs.Name = "tabPageBugs";
            this.tabPageBugs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBugs.Size = new System.Drawing.Size(1268, 447);
            this.tabPageBugs.TabIndex = 1;
            this.tabPageBugs.Text = "Баги";
            this.tabPageBugs.UseVisualStyleBackColor = true;
            // 
            // buttonBuildReportBugs
            // 
            this.buttonBuildReportBugs.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonBuildReportBugs.Location = new System.Drawing.Point(9, 390);
            this.buttonBuildReportBugs.Name = "buttonBuildReportBugs";
            this.buttonBuildReportBugs.Size = new System.Drawing.Size(178, 41);
            this.buttonBuildReportBugs.TabIndex = 5;
            this.buttonBuildReportBugs.Text = "Построить отчет";
            this.buttonBuildReportBugs.UseVisualStyleBackColor = true;
            this.buttonBuildReportBugs.Click += new System.EventHandler(this.buttonBuildReportBugs_Click);
            // 
            // dataGridViewBugs
            // 
            this.dataGridViewBugs.AllowUserToAddRows = false;
            this.dataGridViewBugs.AllowUserToDeleteRows = false;
            this.dataGridViewBugs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBugs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBugs.Location = new System.Drawing.Point(9, 6);
            this.dataGridViewBugs.Name = "dataGridViewBugs";
            this.dataGridViewBugs.ReadOnly = true;
            this.dataGridViewBugs.RowHeadersWidth = 51;
            this.dataGridViewBugs.RowTemplate.Height = 24;
            this.dataGridViewBugs.Size = new System.Drawing.Size(1253, 378);
            this.dataGridViewBugs.TabIndex = 4;
            // 
            // tabPageBonuses
            // 
            this.tabPageBonuses.Controls.Add(this.buttonBuildReportBonuses);
            this.tabPageBonuses.Controls.Add(this.dataGridViewBonuses);
            this.tabPageBonuses.Controls.Add(this.labelSelectEmpl);
            this.tabPageBonuses.Controls.Add(this.comboBoxSelectEmpl);
            this.tabPageBonuses.Location = new System.Drawing.Point(4, 25);
            this.tabPageBonuses.Name = "tabPageBonuses";
            this.tabPageBonuses.Size = new System.Drawing.Size(1268, 447);
            this.tabPageBonuses.TabIndex = 2;
            this.tabPageBonuses.Text = "Премия";
            this.tabPageBonuses.UseVisualStyleBackColor = true;
            // 
            // buttonBuildReportBonuses
            // 
            this.buttonBuildReportBonuses.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonBuildReportBonuses.Location = new System.Drawing.Point(12, 388);
            this.buttonBuildReportBonuses.Name = "buttonBuildReportBonuses";
            this.buttonBuildReportBonuses.Size = new System.Drawing.Size(178, 41);
            this.buttonBuildReportBonuses.TabIndex = 4;
            this.buttonBuildReportBonuses.Text = "Построить отчет";
            this.buttonBuildReportBonuses.UseVisualStyleBackColor = true;
            this.buttonBuildReportBonuses.Click += new System.EventHandler(this.buttonBuildReportBonuses_Click);
            // 
            // dataGridViewBonuses
            // 
            this.dataGridViewBonuses.AllowUserToAddRows = false;
            this.dataGridViewBonuses.AllowUserToDeleteRows = false;
            this.dataGridViewBonuses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBonuses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBonuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBonuses.Location = new System.Drawing.Point(12, 38);
            this.dataGridViewBonuses.Name = "dataGridViewBonuses";
            this.dataGridViewBonuses.ReadOnly = true;
            this.dataGridViewBonuses.RowHeadersWidth = 51;
            this.dataGridViewBonuses.RowTemplate.Height = 24;
            this.dataGridViewBonuses.Size = new System.Drawing.Size(1244, 344);
            this.dataGridViewBonuses.TabIndex = 3;
            // 
            // labelSelectEmpl
            // 
            this.labelSelectEmpl.AutoSize = true;
            this.labelSelectEmpl.Location = new System.Drawing.Point(12, 11);
            this.labelSelectEmpl.Name = "labelSelectEmpl";
            this.labelSelectEmpl.Size = new System.Drawing.Size(149, 17);
            this.labelSelectEmpl.TabIndex = 1;
            this.labelSelectEmpl.Text = "Выбрать сотрудника:";
            // 
            // comboBoxSelectEmpl
            // 
            this.comboBoxSelectEmpl.FormattingEnabled = true;
            this.comboBoxSelectEmpl.Location = new System.Drawing.Point(177, 8);
            this.comboBoxSelectEmpl.Name = "comboBoxSelectEmpl";
            this.comboBoxSelectEmpl.Size = new System.Drawing.Size(300, 24);
            this.comboBoxSelectEmpl.TabIndex = 0;
            // 
            // buttonBuildReport
            // 
            this.buttonBuildReport.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonBuildReport.Location = new System.Drawing.Point(531, 494);
            this.buttonBuildReport.Name = "buttonBuildReport";
            this.buttonBuildReport.Size = new System.Drawing.Size(178, 41);
            this.buttonBuildReport.TabIndex = 2;
            this.buttonBuildReport.Text = "Построить отчеты";
            this.buttonBuildReport.UseVisualStyleBackColor = true;
            this.buttonBuildReport.Click += new System.EventHandler(this.buttonBuildReport_Click);
            // 
            // datesTableAdapter
            // 
            this.datesTableAdapter.ClearBeforeFill = true;
            // 
            // ProjectManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 547);
            this.Controls.Add(this.buttonBuildReport);
            this.Controls.Add(this.tabControlCubes);
            this.Controls.Add(this.buttonConnect);
            this.Name = "ProjectManagementForm";
            this.Text = "Управление проектами";
            this.tabControlCubes.ResumeLayout(false);
            this.tabPageHoursOfJob.ResumeLayout(false);
            this.tabPageHoursOfJob.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoursOfJob)).EndInit();
            this.tabPageBugs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBugs)).EndInit();
            this.tabPageBonuses.ResumeLayout(false);
            this.tabPageBonuses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBonuses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TabControl tabControlCubes;
        private System.Windows.Forms.TabPage tabPageHoursOfJob;
        private System.Windows.Forms.TabPage tabPageBugs;
        private System.Windows.Forms.TabPage tabPageBonuses;
        private System.Windows.Forms.Label labelMeasuresSort;
        private System.Windows.Forms.DataGridView dataGridViewHoursOfJob;
        private System.Windows.Forms.Button buttonBuildReportHoursOfBug;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBoxHoursOfJob;
        private System.Windows.Forms.Button buttonBuildReportBonuses;
        private System.Windows.Forms.DataGridView dataGridViewBonuses;
        private System.Windows.Forms.Label labelSelectEmpl;
        private System.Windows.Forms.ComboBox comboBoxSelectEmpl;
        private System.Windows.Forms.Button buttonBuildReport;
        private System.Windows.Forms.Button buttonBuildReportBugs;
        private System.Windows.Forms.DataGridView dataGridViewBugs;
        private ProjectManagementDataSet projectManagementDataSet;
        private System.Windows.Forms.BindingSource datesBindingSource;
        private ProjectManagementDataSetTableAdapters.DatesTableAdapter datesTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}