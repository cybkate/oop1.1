namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                MessageBox.Show($"�� �����  ����� {a}");
            }
            catch
            {
                MessageBox.Show("�� �� �����  �����");
            }
        }
    }
}