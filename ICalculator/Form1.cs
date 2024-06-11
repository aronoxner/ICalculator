using System.Text;

namespace ICalculator
{
    public partial class BadCalculator : Form
    {
        StringBuilder textViewer = new StringBuilder();
        decimal number1;
        decimal number2;
        decimal number3;
        decimal number4;
        decimal result;
        public BadCalculator()
        {
            InitializeComponent();
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

        private void btnDeleteDigit_Click(object sender, EventArgs e)
        {
            txtViewer.Text = txtViewer.Text.Substring(0, txtViewer.Text.Length - 1);

        }

        private void btnClearRecent_Click(object sender, EventArgs e)
        {
            txtViewer.Text = txtViewer.Text.Remove(0);
        }

        private void btnclearAll_Click(object sender, EventArgs e)
        {
            txtViewer.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            string num1 = txtViewer.Text;
            txtViewer.Text = string.Empty;
            decimal.TryParse(num1, out number1);
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
  
            string num4 = txtViewer.Text;
            txtViewer.Text = string.Empty;
            decimal.TryParse(num4, out number4);
            if (number1 != null)
            {
                Math Add1 = new Math();
                result = Add1.Add(number1, number4);
            }
            string resultString = result.ToString();
            txtViewer.Text = resultString;


        }
    }
}
