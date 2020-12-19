using System;
using System.Windows.Forms;
using Microsoft.AnalysisServices;


namespace ProjectForms
{
    public partial class ConnectForm : Form
    {
        public Server server = new Server();
        public Microsoft.AnalysisServices.DimensionCollection dims;
        public Database database;
        public Microsoft.AnalysisServices.CubeCollection cubes;
        public string nameServer;

        public ConnectForm()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                nameServer = textBoxAddressServer.Text;
                server.Connect(String.Format("provider=msolap;Data Source={0}", nameServer));
                database = server.Databases[1];
                this.getDimensions();
                this.getCubes();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getDimensions()
        {
            dims = database.Dimensions;
            foreach (var dim in dims)
                comboBoxDimensions.Items.Add(dim.ToString());
        }

        private void getCubes()
        {
            cubes = database.Cubes;
            foreach (var cub in cubes)
                comboBoxCubes.Items.Add(cub.ToString());
        }

        private string getDimsDateLastProcess(int id)
        {
            return dims[id].LastProcessed.ToString();
        }

        private string getCubesDateLastProcess(int id)
        {
            return cubes[id].LastProcessed.ToString();
        }

        private void comboBoxDimensions_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            {
                if (comboBoxDimensions.SelectedIndex > 0)
                    labelDate.Text = getDimsDateLastProcess(comboBoxDimensions.SelectedIndex);
                else
                    MessageBox.Show("Выберите измерение!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxCubes_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelDate.Text = getCubesDateLastProcess(comboBoxCubes.SelectedIndex);
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            try
            {
                dims[comboBoxDimensions.SelectedIndex].Process(ProcessType.ProcessFull);
                MessageBox.Show(String.Format("Измерение {0} успешно обработано!", dims[comboBoxDimensions.SelectedIndex].ToString()));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonProcessCube_Click(object sender, EventArgs e)
        {
            try
            {
                cubes[comboBoxCubes.SelectedIndex].Process(ProcessType.ProcessFull);
                MessageBox.Show(String.Format("Куб {0} успешно обработан!", cubes[comboBoxCubes.SelectedIndex].ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
