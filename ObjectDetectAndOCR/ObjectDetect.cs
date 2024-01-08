using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectDetectAndOCR
{
    public class ObjectDetect
    {

        private readonly CascadeClassifier cascadeClassifier;
        private readonly List<VideoCapture> videoCapture = new List<VideoCapture>();
        private VideoCapture VideoFileNameCapture;
        private double TotalFrames;
        private double FPS;
        private int CurrentFrame = 0;
        private bool IsReadingFrames = true;

        public ObjectDetect(string haarCascadeFile)
        {
            cascadeClassifier = new CascadeClassifier(haarCascadeFile);
        }

        public Bitmap FindObject(Bitmap btm)
        {
            Bitmap bitmap = (Bitmap)btm.Clone();
            Image<Bgr, byte> grayImage = new Image<Bgr, byte>(bitmap);
            Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.1, 1);
            foreach (Rectangle rect in rectangles)
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    using (Pen pen = new Pen(Color.Red, 3))
                    {
                        graphics.DrawRectangle(pen, rect);
                    }
                }
            }
            return bitmap;
        }

        public void StartCamera(int Camera, PictureBox picImage)
        {
            if (videoCapture.Count < (Camera + 1)) { videoCapture.Add(new VideoCapture(Camera)); }
            else { return; }
            videoCapture[videoCapture.Count - 1].ImageGrabbed += new EventHandler((object sender, EventArgs eventArgs) => VideoCapture_ImageGrabbed(sender, eventArgs, Camera, picImage));
            videoCapture[videoCapture.Count - 1].Start();
        }

        public void StopCamera(int Camera)
        {
            if (videoCapture[Camera] == null) { return; }
            videoCapture[Camera].Stop();
            videoCapture[Camera].Dispose();
            videoCapture[Camera] = null;
            videoCapture.Remove(videoCapture[Camera]);
        }

        public async void StartVideoFileCapture(string videoFileName, PictureBox picImage)
        {
            if (VideoFileNameCapture == null)
            {
                VideoFileNameCapture = new VideoCapture(videoFileName);
            }
            IsReadingFrames = true;
            using (Mat mat = new Mat())
            {
                try
                {
                    VideoFileNameCapture.Read(mat);
                    picImage.Image = FindObject(mat.Bitmap);
                    TotalFrames = VideoFileNameCapture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameCount);
                    FPS = VideoFileNameCapture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps);
                    while (IsReadingFrames && CurrentFrame < TotalFrames)
                    {
                        CurrentFrame++;
                        VideoFileNameCapture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.PosFrames, CurrentFrame);
                        VideoFileNameCapture.Read(mat);
                        picImage.Image = FindObject(mat.Bitmap);
                        await Task.Delay(1000 / Convert.ToInt16(FPS));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void StopVideoFileCapture()
        {
            IsReadingFrames = false;
            VideoFileNameCapture = null;
        }

        private void VideoCapture_ImageGrabbed(object sender, EventArgs e, int Camera, PictureBox picImage)
        {
            using (Mat mat = new Mat())
            {
                try
                {
                    videoCapture[Camera].Retrieve(mat);
                    picImage.Image = FindObject(mat.Bitmap);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
