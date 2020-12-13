
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
            this.buttonConnect = new System.Windows.Forms.Button();
            this.tabControlCubes = new System.Windows.Forms.TabControl();
            this.tabPageHoursOfJob = new System.Windows.Forms.TabPage();
            this.buttonBuildReportHoursOfBug = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelMeasures = new System.Windows.Forms.Label();
            this.comboBoxMeasures = new System.Windows.Forms.ComboBox();
            this.tabPageBugs = new System.Windows.Forms.TabPage();
            this.tabPageBonuses = new System.Windows.Forms.TabPage();
            this.buttonBuildReports = new System.Windows.Forms.Button();
            this.tabControlCubes.SuspendLayout();
            this.tabPageHoursOfJob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonConnect.Location = new System.Drawing.Point(403, 494);
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
            this.tabControlCubes.Enabled = false;
            this.tabControlCubes.Location = new System.Drawing.Point(12, 12);
            this.tabControlCubes.Name = "tabControlCubes";
            this.tabControlCubes.SelectedIndex = 0;
            this.tabControlCubes.Size = new System.Drawing.Size(1276, 476);
            this.tabControlCubes.TabIndex = 1;
            // 
            // tabPageHoursOfJob
            // 
            this.tabPageHoursOfJob.Controls.Add(this.buttonBuildReportHoursOfBug);
            this.tabPageHoursOfJob.Controls.Add(this.dataGridView1);
            this.tabPageHoursOfJob.Controls.Add(this.labelMeasures);
            this.tabPageHoursOfJob.Controls.Add(this.comboBoxMeasures);
            this.tabPageHoursOfJob.Location = new System.Drawing.Point(4, 25);
            this.tabPageHoursOfJob.Name = "tabPageHoursOfJob";
            this.tabPageHoursOfJob.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHoursOfJob.Size = new System.Drawing.Size(1268, 447);
            this.tabPageHoursOfJob.TabIndex = 0;
            this.tabPageHoursOfJob.Text = "Количество часов";
            this.tabPageHoursOfJob.UseVisualStyleBackColor = true;
            // 
            // buttonBuildReportHoursOfBug
            // 
            this.buttonBuildReportHoursOfBug.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonBuildReportHoursOfBug.Location = new System.Drawing.Point(26, 400);
            this.buttonBuildReportHoursOfBug.Name = "buttonBuildReportHoursOfBug";
            this.buttonBuildReportHoursOfBug.Size = new System.Drawing.Size(178, 41);
            this.buttonBuildReportHoursOfBug.TabIndex = 3;
            this.buttonBuildReportHoursOfBug.Text = "Построить отчет";
            this.buttonBuildReportHoursOfBug.UseVisualStyleBackColor = true;
            this.buttonBuildReportHoursOfBug.Click += new System.EventHandler(this.buttonBuildReportHoursOfBug_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1218, 299);
            this.dataGridView1.TabIndex = 2;
            // 
            // labelMeasures
            // 
            this.labelMeasures.AutoSize = true;
            this.labelMeasures.Location = new System.Drawing.Point(23, 19);
            this.labelMeasures.Name = "labelMeasures";
            this.labelMeasures.Size = new System.Drawing.Size(49, 17);
            this.labelMeasures.TabIndex = 1;
            this.labelMeasures.Text = "Меры:";
            // 
            // comboBoxMeasures
            // 
            this.comboBoxMeasures.FormattingEnabled = true;
            this.comboBoxMeasures.Location = new System.Drawing.Point(26, 49);
            this.comboBoxMeasures.Name = "comboBoxMeasures";
            this.comboBoxMeasures.Size = new System.Drawing.Size(217, 24);
            this.comboBoxMeasures.TabIndex = 0;
            // 
            // tabPageBugs
            // 
            this.tabPageBugs.Location = new System.Drawing.Point(4, 25);
            this.tabPageBugs.Name = "tabPageBugs";
            this.tabPageBugs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBugs.Size = new System.Drawing.Size(1268, 447);
            this.tabPageBugs.TabIndex = 1;
            this.tabPageBugs.Text = "Баги";
            this.tabPageBugs.UseVisualStyleBackColor = true;
            // 
            // tabPageBonuses
            // 
            this.tabPageBonuses.Location = new System.Drawing.Point(4, 25);
            this.tabPageBonuses.Name = "tabPageBonuses";
            this.tabPageBonuses.Size = new System.Drawing.Size(1268, 447);
            this.tabPageBonuses.TabIndex = 2;
            this.tabPageBonuses.Text = "Премия";
            this.tabPageBonuses.UseVisualStyleBackColor = true;
            // 
            // buttonBuildReports
            // 
            this.buttonBuildReports.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonBuildReports.Location = new System.Drawing.Point(620, 494);
            this.buttonBuildReports.Name = "buttonBuildReports";
            this.buttonBuildReports.Size = new System.Drawing.Size(178, 41);
            this.buttonBuildReports.TabIndex = 2;
            this.buttonBuildReports.Text = "Построить отчеты";
            this.buttonBuildReports.UseVisualStyleBackColor = true;
            this.buttonBuildReports.Click += new System.EventHandler(this.buttonBuildReports_Click);
            // 
            // ProjectManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 547);
            this.Controls.Add(this.buttonBuildReports);
            this.Controls.Add(this.tabControlCubes);
            this.Controls.Add(this.buttonConnect);
            this.Name = "ProjectManagementForm";
            this.Text = "Управление проектами";
            this.Load += new System.EventHandler(this.ProjectManagementForm_Load);
            this.tabControlCubes.ResumeLayout(false);
            this.tabPageHoursOfJob.ResumeLayout(false);
            this.tabPageHoursOfJob.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TabControl tabControlCubes;
        private System.Windows.Forms.TabPage tabPageHoursOfJob;
        private System.Windows.Forms.TabPage tabPageBugs;
        private System.Windows.Forms.TabPage tabPageBonuses;
        private System.Windows.Forms.Label labelMeasures;
        private System.Windows.Forms.ComboBox comboBoxMeasures;
        private System.Windows.Forms.Button buttonBuildReports;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonBuildReportHoursOfBug;
    }
}