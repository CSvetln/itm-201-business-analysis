using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AnalysisServices.AdomdClient;

namespace ProjectForms
{
    public partial class ProjectManagementForm : Form
    {
        ConnectForm connectForm;
        public Microsoft.AnalysisServices.MeasureEnumerator measures;
        public ProjectManagementForm()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            connectForm = new ConnectForm();
            connectForm.Show();         
        }

        private void buttonBuildReports_Click(object sender, EventArgs e)
        {
            tabControlCubes.Enabled = true;
            measures = connectForm.cubes[1].AllMeasures;
            foreach (var t in measures)
                comboBoxMeasures.Items.Add(t.ToString());

        }

        private void buttonBuildReportHoursOfBug_Click(object sender, EventArgs e)
        {
            AdomdConnection conn;
            conn = new AdomdConnection(String.Format("provider=msolap;Data Source={0}", connectForm.nameServer));
            try
            {
                conn.Open();
                conn.ChangeDatabase("ProjectAnalysis");
                // string Resstring = "SELECT {" + a + "} ON COLUMNS, NON EMPTY {" + col + "} ON ROWS FROM " + rw;
                AdomdDataAdapter adapter = new AdomdDataAdapter(@"select {[Dates].[Дата].Members} on rows,
{[Persons].[Имя сотрудника].Members}  on columns
from [Часы работы];", conn);
                DataSet setin = new DataSet();
                adapter.Fill(setin);
                dataGridView1.DataSource = setin.Tables[0];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProjectManagementForm_Load(object sender, EventArgs e)
        {

        }
    }
}
