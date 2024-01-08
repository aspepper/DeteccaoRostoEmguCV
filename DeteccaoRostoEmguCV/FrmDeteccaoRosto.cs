using Emgu.CV;
using Emgu.CV.OCR;
using Emgu.CV.Structure;
using System;
using System.Drawing;
using System.Windows.Forms;
using ObjectDetectAndOCR;

namespace DeteccaoRostoEmguCV
{
    public partial class FrmDeteccaoRosto : Form
    {

        private ObjectDetect objectDetect;

        public FrmDeteccaoRosto()
        {
            InitializeComponent();
            objectDetect = new ObjectDetect("haarcascade_frontalface_alt_tree.xml");
            //objectDetect = new ObjectDetect("haarcascade_russian_plate_number.xml");
            //objectDetect = new ObjectDetect("haarcascade_car.xml");
        }

        private void AbrirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, Filter = "JPG|*.jpg" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picImagem.Image = objectDetect.FindObject(new Bitmap(Image.FromFile(ofd.FileName)));
                }
            }
        }

        private void IniciarWebCamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objectDetect.StartCamera(0, this.picImagem);
        }

        private void PararWebCamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objectDetect.StopCamera(0);
            picImagem.Image = null;
        }

        private void AbrirVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, Filter = "Vídeo|*.mp4;*.mov" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    objectDetect.StartVideoFileCapture(ofd.FileName, picImagem);
                }
            }
        }

        private void PararVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objectDetect.StopVideoFileCapture();
        }

        /*        private void ObterTextoDaImagem(Bitmap bmp)
                {
                    Bitmap bitmap = (Bitmap)bmp.Clone();
                    OcrEngine ocrEngine = null;
                }
        */
    }
}
