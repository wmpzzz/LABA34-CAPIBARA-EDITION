using N7Pa;

namespace NgPa
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetStyle(this);
        }
        public void Navigate(Form formFrom, Form formTo)
        {
            formFrom.Hide();

            formTo.ShowDialog();

            formFrom.Show();

        }
        public void SetStyle(Control element)
        {
            foreach (Control control in element.Controls)
            {
                if (control is Button button)
                {
                    button.Cursor = Cursors.Hand;
                }
                SetStyle(control);
            }
        }
        private void ToTimerButton_click(object sender, EventArgs e)
        {
            TimerForm form = new TimerForm();
            Navigate(this, form);

        }

        private void ToGameButton_Click(object sender, EventArgs e)
        {
            AnimationForm form = new AnimationForm();
            Navigate(this, form);
        }

        private void ToFieldButton_Click(object sender, EventArgs e)
        {
            FieldForm form = new FieldForm();
            Navigate(this, form);
        }
    }
}
