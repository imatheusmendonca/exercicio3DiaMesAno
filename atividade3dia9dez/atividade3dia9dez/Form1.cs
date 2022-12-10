namespace atividade3dia9dez
{
    public partial class Form1 : Form
    {
        private const bool V = false;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "O mês atual é dezembro";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            label1.Text = "Hoje é dia 09";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            label1.Text = "Estamos no ano de 2022";
        }
    }
}