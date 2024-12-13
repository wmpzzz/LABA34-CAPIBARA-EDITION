using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N7Pa
{
    public partial class AnimationForm : Form
    {
        public AnimationForm()
        {
            InitializeComponent();
            
            Timer.Start();

        }
        int _counter = 0;
        private void Timer_Tick(object sender, EventArgs e)
        {
            PlayerPictureBox.Image = ImageList.Images[_counter];
            if (_counter == 7)
                _counter = 0;
            else
            {
                _counter++;
            }
               
        }
    }
}
