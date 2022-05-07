namespace FirstDesktopApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.inputListBox.Items.Add(2);
            this.inputListBox.Items.Add(3);
            this.inputListBox.Items.Add(4);
            this.inputListBox.Items.Add(1);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void calculateButton_Click(object sender, EventArgs e)
        {

        }

        private void Sort_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            foreach (int item in this.inputListBox.Items)
            {
                list.Add(item);
            }

            list.Sort();

            foreach (int item in list)
            {
                this.outputListBox.Items.Add(item);
            }
        }

        private void inputListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void outputListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}