using Emgu.CV.Structure;
using Emgu.CV;
using IronOcr;

namespace DetectaObjetos
{
    public partial class FrmDeteccaoObjeto : Form
    {
        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");
        VideoCapture? videoCapture;

        public FrmDeteccaoObjeto()
        {
            InitializeComponent();
        }

        private void ExtrairTextoDeImagem(Bitmap bmp)
        {
            var ocr = new IronTesseract();

            using (var ocrInput = new OcrInput())
            {
                ocrInput.AddImage("image.png");
                ocrInput.AddPdf("document.pdf");

                // Optionally Apply Filters if needed:
                // ocrInput.Deskew();  // use only if image not straight
                // ocrInput.DeNoise(); // use only if image contains digital noise

                var ocrResult = ocr.Read(ocrInput);
                Console.WriteLine(ocrResult.Text);
            }
        }


        private void AbrirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, Filter = "JPG|*.jpg" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ShowImage(new Bitmap(System.Drawing.Image.FromFile(ofd.FileName)));
            }
        }

        private void IniciarWebCamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (videoCapture != null) { return; }
            videoCapture = new VideoCapture(0);
            videoCapture.ImageGrabbed += VideoCapture_ImageGrabbed;
            videoCapture.Start();
        }

        private void PararWebCamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (videoCapture == null) { return; }
            videoCapture.Stop();
            videoCapture.Dispose();
            videoCapture = null;
            picImagem.Image = null;
        }

        private void VideoCapture_ImageGrabbed(object? sender, EventArgs e)
        {
            using Mat mat = new();
            try
            {
                videoCapture.Retrieve(mat);
                ShowImage(videoCapture.re);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowImage(Bitmap btm)
        {
            Bitmap bitmap = (Bitmap)btm.Clone();
            Image<Bgr, byte> grayImage = new(bitmap);
            System.Drawing.Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.1, 1);
            foreach (System.Drawing.Rectangle rect in rectangles)
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    using (Pen pen = new Pen(System.Drawing.Color.Red, 3))
                    {
                        graphics.DrawRectangle(pen, rect);
                    }
                }
            }
            picImagem.Image = bitmap;
        }
    }
}
