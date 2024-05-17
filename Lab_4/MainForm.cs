using System;
using System.Media;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class MainForm : Form
    {
        Timer timer = new Timer();
        SoundPlayer sp = new SoundPlayer("..\\..\\files\\soundforalarm.wav");

        public MainForm()
        {
            InitializeComponent();

            timer.Interval = 1000; 
            timer.Tick += Timer_Tick;
            timer.Start();
           
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
           
            foreach (DataGridViewRow row in alarmsGridView.Rows)
            {
                if (row.Cells["ActiveStatus"].Value != null && (bool)row.Cells["ActiveStatus"].Value)
                {
                    string time = row.Cells["Time"].Value.ToString();
                    if (DateTime.Now.ToString("HH:mm:ss") == time)
                    {
                        PlayAlarmSound();
                    }
                }
            }
        }
        private void PlayAlarmSound()
        {
            sp.Play();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            CreateAlarmForm createAlarmForm = new CreateAlarmForm(alarmsGridView);
            createAlarmForm.ShowDialog();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотить удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (alarmsGridView.SelectedCells.Count > 0)
                {
                    DataGridViewCell selectedCell = alarmsGridView.SelectedCells[0];


                    int rowIndex = selectedCell.RowIndex;

                    if (rowIndex != -1)
                    {
                        alarmsGridView.Rows.RemoveAt(rowIndex);
                    }
                }
            }
        }
    }
}
