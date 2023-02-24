namespace FirstApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Cyan;
        }

        private void button_click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
