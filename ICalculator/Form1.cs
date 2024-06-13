using System.Text;

namespace ICalculator
{
    public partial class BadCalculator : Form
    {
        string input = string.Empty;
        string operation1 = string.Empty;
        string operation2 = string.Empty;
        char operation;
        decimal result;

        public BadCalculator()
        {
            InitializeComponent();

        }

        private void BadCalculator_Load(object sender, EventArgs e)
        {

        }

        #region NumberButtonInputs
        private void btn0_Click(object sender, EventArgs e)
        {
            this.txtViewer.Text = "";
            input += "0";
            this.txtViewer.Text += input;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.txtViewer.Text = "";
            input += "1";
            this.txtViewer.Text += input;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.txtViewer.Text = "";
            input += "2";
            this.txtViewer.Text += input;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.txtViewer.Text = "";
            input += "3";
            this.txtViewer.Text += input;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.txtViewer.Text = "";
            input += "4";
            this.txtViewer.Text += input;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.txtViewer.Text = "";
            input += "5";
            this.txtViewer.Text += input;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.txtViewer.Text = "";
            input += "6";
            this.txtViewer.Text += input;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.txtViewer.Text = "";
            input += "7";
            this.txtViewer.Text += input;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.txtViewer.Text = "";
            input += "8";
            this.txtViewer.Text += input;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.txtViewer.Text = "";
            input += "9";
            this.txtViewer.Text += input;
        }
        #endregion

        #region Operations
        private void btnPeriod_Click(object sender, EventArgs e)
        {
            this.txtViewer.Text = "";
            input += ".";
            this.txtViewer.Text += input;
        }

        private void btnDeleteDigit_Click(object sender, EventArgs e)
        {
            string view = this.txtViewer.Text;
            string dView=view.Substring(0, view.Length - 1);
            txtViewer.Text = dView;

        }

        private void btnClearRecent_Click(object sender, EventArgs e)
        {
            this.txtViewer.Text = "";
            if (operation1 == string.Empty)
                this.input = string.Empty;
            else this.operation1 = string.Empty;
        }

        private void btnclearAll_Click(object sender, EventArgs e)
        {
            this.txtViewer.Text = "";
            this.input=string.Empty;
            this.operation1 = string.Empty;
            this.operation2 = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            operation1 = input;
            operation = '+';
            input = string.Empty;

        }
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            operation1 = input;
            operation = '-';
            input = string.Empty;
        }
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operation1 = input;
            operation = 'x';
            input = string.Empty;
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            operation1 = input;
            operation = '÷';
            input = string.Empty;
        }
        #endregion
        #region IMath
        private void btnEquals_Click(object sender, EventArgs e)
        {
            operation2 = input;
            decimal num1, num2;
            decimal.TryParse(operation1, out num1);
            decimal.TryParse(operation2, out num2);

            switch (operation)
            {
                case '+':
                    Math calc1 = new Math();
                    result = calc1.Add(num1, num2);
                    txtViewer.Text = result.ToString();
                    break;

                case '-':
                    Math calc2 = new Math();
                    result = calc2.Subtract(num1, num2);
                    txtViewer.Text = result.ToString();
                    break;

                case 'x':
                    Math calc3 = new Math();
                    result = calc3.Multiply(num1, num2);
                    txtViewer.Text = result.ToString();
                    break;

                case '÷':
                    Math calc4 = new Math();
                    if (num2 != 0)
                    {
                        result = calc4.Divide(num1, num2);
                        txtViewer.Text = result.ToString();
                    }
                    else txtViewer.Text = "DIVZero";
                    break;
            }

        }  
        #endregion



    }
}
