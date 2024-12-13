using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N7Pa
{
    public partial class TimerForm : Form
    {
        public TimerForm()
        {
            InitializeComponent();
        }
        private readonly Stopwatch stopwatch = new Stopwatch();
        private void StartButton_Click_1(object sender, EventArgs e)
        {
            stopwatch.Start();
            timerT.Start();

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            TimerLabel.Text = stopwatch.Elapsed.ToString("mm\\:ss");
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
            timerT.Stop();
        }

        private void TimerForm_Load(object sender, EventArgs e)
        {
            TimerLabel.Text = "00:00";
        }
    }
}
