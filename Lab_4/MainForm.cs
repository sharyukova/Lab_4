using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class MainForm : Form
    {
        Timer timer = new Timer();
        SoundPlayer sp = new SoundPlayer("..\\..\\files\\soundforalarm.wav");

        private List<AlarmControl> alarms = new List<AlarmControl>();

        internal void AddAlarmControl(AlarmControl alarm)
        {
            // Добавление AlarmControl на главную форму
            alarms.Add(alarm);
            splitContainer1.Panel1.Controls.Add(alarm);
        }


        public MainForm()
        {
            InitializeComponent();

            timer.Interval = 1000; 
            timer.Tick += Timer_Tick;
           
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            PlayAlarmSound();

            foreach (AlarmControl alarm in alarms)
            {
                DateTime time = DateTime.Parse(alarm.SoundTime);

                if (alarm.IsActive && time.TimeOfDay == DateTime.Now.TimeOfDay)
                {
                    // Воспроизведение звука для будильника
                    PlayAlarmSound();
                }
            }
        }
        private void PlayAlarmSound()
        {
            sp.Play();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            CreateAlarmForm createAlarmForm = new CreateAlarmForm();
            createAlarmForm.ShowDialog();
        }
    }
}
