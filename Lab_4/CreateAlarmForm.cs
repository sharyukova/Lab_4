using System;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class CreateAlarmForm : Form
    {
        private DataGridView dataGridView;
        public CreateAlarmForm(DataGridView dataGrid)
        {
            InitializeComponent();
            dataGridView = dataGrid;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if ((nameField.Text != null) && (timeField.Value > DateTime.Now))
            {
                string name = nameField.Text;
                bool status = true;
                string time = timeField.Text;

                dataGridView.Rows.Add(name, time, status);
                this.Close();
            }
            else
            {
                string name = "Без названия";
                bool status = true;
                string time = timeField.Text;

                dataGridView.Rows.Add(name, time, status);
                this.Close();
            }
        }
    }
}
