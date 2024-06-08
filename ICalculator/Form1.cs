using System.Text;

namespace ICalculator
{
    public partial class BadCalculator : Form
    {
        public BadCalculator()
        {
            InitializeComponent();
            StringBuilder textViewer = new StringBuilder();
            txtViewer.Text = string.Empty;
        }

        private void BadCalculator_Load(object sender, EventArgs e)
        {

        }

        #region NumberButtonInputs
        private void btn0_Click(object sender, EventArgs e)
        {
            txtViewer.AppendText(btn0.Text);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtViewer.AppendText(btn1.Text);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtViewer.AppendText(btn2.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtViewer.AppendText(btn3.Text);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtViewer.AppendText(btn4.Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtViewer.AppendText(btn5.Text);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtViewer.AppendText(btn6.Text);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtViewer.AppendText(btn7.Text);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtViewer.AppendText(btn8.Text);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtViewer.AppendText(btn9.Text);
        }
        #endregion

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            txtViewer.AppendText(btnPeriod.Text);
        }
    }
}
