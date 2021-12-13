
using System;
using System.Collections.Generic;
using Wisej.Web;

namespace WisejWebDesktopApplication2
{
	public partial class Window1 : Form
	{
		public Window1()
        {
            InitializeComponent();

            

        }

        private void BindData()
        {
            var data = new List<EmplInfo>();
            data.Add(new EmplInfo() { EmplCode = "E001", EmplName = "Employee 001", EmplGroup = "DirectHired" });
            data.Add(new EmplInfo() { EmplCode = "E002", EmplName = "Employee 002", EmplGroup = "DirectHired" });
            data.Add(new EmplInfo() { EmplCode = "E003", EmplName = "Employee 003", EmplGroup = "DirectHired" });
            data.Add(new EmplInfo() { EmplCode = "E004", EmplName = "Employee 004", EmplGroup = "Secondaire" });
            data.Add(new EmplInfo() { EmplCode = "E005", EmplName = "Employee 005", EmplGroup = "Secondaire" });

            this.dataGridView1.DataSource = data;
        }

        private void Window1_Load(object sender, EventArgs e)
        {
			
			this.dataGridView1.AddSummaryRows(SummaryType.Count, SummaryRowPosition.Above, this.EmplGroup, this.EmplCode);
            BindData();

        }
    }
}
