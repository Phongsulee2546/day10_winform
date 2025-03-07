namespace day10_winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gettext = question_text.Text;
            string[] string_values = gettext.Split('/');
            double a, b, c;
            a = Convert.ToDouble(string_values[0]);
            b = Convert.ToDouble(string_values[1]);
            c = a / b;
            solution_textbox.Text = c.ToString();
            solution_label.Text = c.ToString();
        }

        private void question_text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
