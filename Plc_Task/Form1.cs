using com.calitha.goldparser;

namespace Plc_Task
{
    public partial class Form1 : Form
    {
        MyParser parser;
        public Form1()
        {
            InitializeComponent();
            parser = new MyParser("final_programming.cgt", listBox1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (parser.Parse != null)
            {
                parser.Parse(textBox1.Text);

            }
            else
            {
                Console.WriteLine("No Error Found");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}