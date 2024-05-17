using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class AlarmControl : UserControl
    {
        public AlarmControl()
        {
            InitializeComponent();
        }

        public string AlarmName
        {
            get { return nameLabel.Text; }
            set { nameLabel.Text = value; }
        }

        public bool IsActive
        {
            get { return activStatusChkBox.Checked; }
            set { activStatusChkBox.Checked = value; }
        }

        public string SoundTime
        {
            get { return timeLabel.Text; }
            set { timeLabel.Text = value; }
        }

        public string RepeatInfo
        {
            get { return periodicityLabel.Text; }
            set { periodicityLabel.Text = value; }
        }
    }
}
