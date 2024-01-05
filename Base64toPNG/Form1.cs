using System.Drawing.Imaging;

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
                bSave.Enabled = true;
            }
            catch
            { MessageBox.Show("An error occured. Enter valid Base64 input.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if(sfdImage.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(pbResult.Image);
                using (MemoryStream ms = new MemoryStream())
                {
                    try
                    {
                        bmp.Save(ms, ImageFormat.Png);
                        byte[] bytes = ms.ToArray();
                        File.WriteAllBytes(sfdImage.FileName, bytes);
                    } catch { MessageBox.Show("An error occured. Cannot save into already existing file.", "File already exists", MessageBoxButtons.OK,MessageBoxIcon.Error); }
                }
            }
        }
    }
}
