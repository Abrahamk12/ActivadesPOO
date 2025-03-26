namespace Formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lEjemplo_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Añadir elementos al ComboBox
            comboBox1.Items.Add("Opción 1");
            comboBox1.Items.Add("Opción 2");
            comboBox1.Items.Add("Opción 3");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedItem.ToString();
            
        }
    }
}
