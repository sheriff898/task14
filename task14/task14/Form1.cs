namespace task14
{
    public partial class Form1 : Form
    {
        double zoomFactor = 1.0;
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async(null);
            webView21.Source = new Uri("https://www.google.az");
        }

        private void instagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.instagram.com");
        }

        private void youtubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.youtube.com");
        }

        private void facebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.facebook.com");
        }

        private void telegramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://web.telegram.org");
        }

        private void arxaFonRəngiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                menuStrip1.BackColor = colorDialog1.Color;
            }
        }

        private void yazıRəngiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                menuStrip1.ForeColor = colorDialog1.Color;
                foreach (ToolStripMenuItem item in menuStrip1.Items)
                {
                    item.ForeColor = colorDialog1.Color;
                    foreach (ToolStripItem subItem in item.DropDownItems)
                    {
                        subItem.ForeColor = colorDialog1.Color;
                    }
                }
            }

        }

        private void çapEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (webView21.CoreWebView2 != null)
            {
                webView21.CoreWebView2.ShowPrintUI();
            }
        }

        private void böyütToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (zoomFactor < 2.0)
            {
                zoomFactor += 0.1;
                webView21.ZoomFactor = zoomFactor;
            }
        }

        private void kiçiltToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (zoomFactor > 0.5)
            {
                zoomFactor -= 0.1;
                webView21.ZoomFactor = zoomFactor;
            }
        }

        private void çıxışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult cavab = MessageBox.Show("Çıxış edilsinmi?", "Təsdiq", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cavab == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
