namespace Calculator
{
    public partial class MainForm : Form
    {
        double firstNumber;
        double secondNumber;
        string operationSymbol;
        public MainForm()
        {
            InitializeComponent();
        }

        private void one_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "9";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "0";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Display.Text = "";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(Display.Text);
            operationSymbol = "+";
            Display.Text = "";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(Display.Text);
            operationSymbol = "-";
            Display.Text = "";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(Display.Text);
            operationSymbol = "*";
            Display.Text = "";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(Display.Text);
            operationSymbol = "/";
            Display.Text = "";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            secondNumber = double.Parse(Display.Text);
            switch (operationSymbol)
            {
                case "+":
                    Display.Text = (firstNumber + secondNumber).ToString();
                    break;
                case "-":
                    Display.Text = (firstNumber - secondNumber).ToString();
                    break;
                case "*":
                    Display.Text = (firstNumber * secondNumber).ToString();
                    break;
                case "/":
                    Display.Text = (firstNumber / secondNumber).ToString();
                    break;
            }
        }
    }
} 