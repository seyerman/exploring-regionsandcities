using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Security.Policy;
using System.Windows.Forms.DataVisualization.Charting;

namespace exploring_regionsandcities_wf
{
    public partial class RegionAndCitiesForm : Form
    {
        private const string REGION = "REGION";
        private List<string[]> values;

        public RegionAndCitiesForm()
        {
            InitializeComponent();
        }

        private void openFileClick(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            clearTable();
            Console.WriteLine(openFileDialog.FileName);
            values = new List<string[]>();

            txtFileName.Text = openFileDialog.FileName;
            string[] lines = System.IO.File.ReadAllLines(openFileDialog.FileName);

            Dictionary<string, bool> regions = new Dictionary<string,bool>();
            foreach (string line in lines){
                string[] rowLine = line.Split(',');

                if (!rowLine[0].Equals(REGION)) {
                    values.Add(rowLine);
                    regionAndCityDataView.Rows.Add(rowLine);
                }

                if (!regions.ContainsKey(rowLine[0])) {
                    regions.Add(rowLine[0],true);
                    cbRegions.Items.Add(rowLine[0]);
                }
            }
        }

        private void cbRegionsSelectedIndexChanged(object sender, EventArgs e)
        {
            clearTable();
            foreach (string[] row in values){
                if (cbRegions.SelectedItem.Equals(row[0]) || cbRegions.SelectedItem.Equals(REGION)) {
                    regionAndCityDataView.Rows.Add(row);
                }
            }
        }

        private void clearTableClick(object sender, EventArgs e)
        {
            clearTable();
        }

        private void clearTable()
        {
            regionAndCityDataView.Rows.Clear();
        }

        private void graphicReportClick(object sender, EventArgs e)
        {
            string serieName = "Departments by Region";
            barCharRegionsDepts.Series.Clear();
            barCharRegionsDepts.Series.Add(serieName);

            Dictionary<string,Dictionary<string,int>> regions = new Dictionary<string,Dictionary<string,int>>();
            foreach (string[] row in values) {
                string reg = row[0];
                string dept = row[2];
                if (!regions.ContainsKey(reg)) {
                    regions.Add(reg,new Dictionary<string, int>());
                    regions[reg].Add(dept,1);
                }
                else {
                    if (!regions[reg].ContainsKey(dept)) {
                        regions[reg].Add(dept,1);
                    }
                    else {
                        regions[reg][dept] += 1;
                    }
                }
            }

            foreach(KeyValuePair<string, Dictionary<string,int>> kvp in regions) {
                barCharRegionsDepts.Series[serieName].Points.AddXY(kvp.Key,kvp.Value.Count);
            }

            barCharRegionsDepts.Series[serieName].ChartType = SeriesChartType.Bar;
        }
    }
}
