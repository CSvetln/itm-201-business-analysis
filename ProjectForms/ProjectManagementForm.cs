using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using Microsoft.AnalysisServices.AdomdClient;

namespace ProjectForms
{
    public partial class ProjectManagementForm : Form
    {
        ConnectForm connectForm;
        public Microsoft.AnalysisServices.MeasureEnumerator measures;
        AdomdConnection conn;
        List<String> listEmployees;

        public ProjectManagementForm()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            connectForm = new ConnectForm();
            connectForm.Show();
        }

        private void buttonBuildReport_Click(object sender, EventArgs e)
        {
            conn = new AdomdConnection(String.Format("provider=msolap;Data Source={0}", connectForm.nameServer));
            conn.Open();
            conn.ChangeDatabase("ProjectAnalysis");
            this.getFilterData();
            foreach (var empl in listEmployees)
                comboBoxSelectEmpl.Items.Add(empl.ToString());
            conn.Close();
        }

        private void getFilterData()
        {
            AdomdCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"
                        select {[Люди].[Имя сотрудника].Members} on rows,
                        {[Проекты].[Название проекта]} on columns
                        from [Часы работы];";

            CellSet cs = cmd.ExecuteCellSet();
            listEmployees = new List<string>();

            TupleCollection tuplesOnRows = cs.Axes[1].Set.Tuples;
            foreach (Microsoft.AnalysisServices.AdomdClient.Tuple row in tuplesOnRows)
            {
                listEmployees.Add(row.Members[0].Caption);       
            }
        }
       
        private void buttonBuildReportHoursOfBug_Click(object sender, EventArgs e)
        {
            string row;
            if (comboBoxHoursOfJob.SelectedIndex == 0)
                row = "[Люди].[Имя сотрудника].Members";
            else
                row = "[Проекты].[Название проекта].Members";
            string mdx = @"select {"+ row +"} on rows," +
                          "{[Даты].[Дата].&[" + dateTimePicker1.Value.ToString("yyyy-MM-dd") +
                          "T00:00:00]:[Даты].[Дата].&[" + dateTimePicker2.Value.ToString("yyyy-MM-dd") +
                          "T00:00:00]} on columns from [Часы работы]";
            buildReport(mdx, dataGridViewHoursOfJob);
        }

        private void buttonBuildReportBonuses_Click(object sender, EventArgs e)
        {
            string mdx = @"select {[Даты].[Дата].Members} on rows,
                {[Люди].[Имя сотрудника].&[" + comboBoxSelectEmpl.SelectedItem.ToString() + "]}  on columns from [Бонусы]";
            buildReport(mdx, dataGridViewBonuses);
        }

        private void buttonBuildReportBugs_Click(object sender, EventArgs e)
        {           
            string mdx = @"select {[Стадии].[Название стадии].Members} on rows,
                            {[Проекты].[Название проекта].Members}  on columns from [Баги]";
            buildReport(mdx, dataGridViewBugs);
        }

        private void buildReport(string mdx, DataGridView dataGrid)
        {
            conn.Open();
            conn.ChangeDatabase("ProjectAnalysis");
            AdomdDataAdapter adapter = new AdomdDataAdapter(mdx, conn);
            DataSet setin = new DataSet();
            adapter.Fill(setin);
            dataGrid.DataSource = setin.Tables[0];

            foreach(DataColumn column in setin.Tables[0].Columns)
            {
                if (column.ColumnName.Contains("Дата"))
                {
                    String columnName = column.ColumnName;
                 
                    System.Text.RegularExpressions.Match dateMatch = System.Text.RegularExpressions.Regex.Match(columnName, @"(?<year>\d{4})\-(?<month>\d{2})\-(?<day>\d{2})");
                    Int32 year = Convert.ToInt32(dateMatch.Groups["year"].Value);
                    Int32 month = Convert.ToInt32(dateMatch.Groups["month"].Value);
                    Int32 day = Convert.ToInt32(dateMatch.Groups["day"].Value);
                    DateTime period = new DateTime(year, month, day);

                    column.ColumnName = period.ToString(DATEFORMAT);
                }
            }

            conn.Close();
        }

        const string DATEFORMAT = "yyyy.MM.dd";
    }
}
