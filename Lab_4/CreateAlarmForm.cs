using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab_4
{
    public partial class CreateAlarmForm : Form
    {
        public CreateAlarmForm()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AlarmControl newAlarm = new AlarmControl();
            newAlarm.AlarmName = nameField.Text;
            newAlarm.IsActive = true; // или значение из CheckBox
            newAlarm.SoundTime = timeField.Text;


            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();

            mainForm.AddAlarmControl(newAlarm);
            this.Close();
        }
    }
}
