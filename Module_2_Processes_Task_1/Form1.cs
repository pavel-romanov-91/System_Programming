namespace Module_2_Processes_Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult form = new Form2().ShowDialog();
        }
    }
}