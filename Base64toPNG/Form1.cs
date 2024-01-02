namespace Base64toPNG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bConvert_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] bytes = Convert.FromBase64String(tbBase.Text);
                Image image;
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    image = Image.FromStream(ms);
                }
                pbResult.Image = image;
            }
            catch
            { MessageBox.Show("An error occured. Enter valid Base64 input."); }
        }
    }
}
