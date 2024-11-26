namespace løsningsforslag_winforms_opgaver
{
    public partial class Form1 : Baseform
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trykButton_Click(object sender, EventArgs e)
        {
            SkrivHejLabel.Text = "Hello world";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
