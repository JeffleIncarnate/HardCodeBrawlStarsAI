// Namespaces that we are using
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;
using HardCodeBrawlStarsAI;

namespace HardCodeBrawlStarsAI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Before Form is loaded
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // This is a method that runs the exe of scrcpy which is a Screen mirroring platform
        private void scrcpy_Click(object sender, EventArgs e)
        {
            try
            {
                string Scrcpy = @"C:\Users\hp\Downloads\scrcpy-win64-v1.23\scrcpy.exe";
                Process.Start(Scrcpy);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Finished");
            }
        }

        // This is a funciton that starts a new Thread and make a loop that will run
        // forever so we can screenshot the game
        private void capture_Click(object sender, EventArgs e)
        {
            ThreadStart ChildRef = new ThreadStart(CaptureMyScreen);
            Thread ChildThread = new Thread(ChildRef);
            ChildThread.Start();
        }

        // Void to Capture 
        public void CaptureMyScreen()
        {
            try
            {
                // Here I am starting a new thread to Run Recognition aswell as a Loop to
                // continueslly capture the game
                ThreadStart ThreadChild = new ThreadStart(Data);
                Thread thread = new Thread(ThreadChild);
                thread.Start();

                while (true)
                {
                    //Creating a new Bitmap object
                    Bitmap captureBitmap = new Bitmap(1024, 768, PixelFormat.Format32bppArgb);
                    //Bitmap captureBitmap = new Bitmap(int width, int height, PixelFormat);
                    //Creating a Rectangle object which will
                    //capture our Current Screen
                    Rectangle captureRectangle = Screen.AllScreens[0].Bounds;
                    //Creating a New Graphics Object
                    Graphics captureGraphics = Graphics.FromImage(captureBitmap);
                    //Copying Image from The Screen
                    captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);

                    pictureBox1.Image = captureBitmap;
                    Thread.Sleep(200);
                }
            }
            catch (Exception ex) // Catch Exception and Show to Console, so the app don't crash
            {
                MessageBox.Show(ex.Message);
            }
        }

        // This is a function that has 1 object which Runs Data Recogniton on all the 
        public void Data(/* I will add a Bitmap Param Later (Overload Issues) */)
        {
            PlayerRecognation.ApiCallJSTensor api = new PlayerRecognation.ApiCallJSTensor();

            MessageBox.Show(Convert.ToString(api.GetData()));
        }
    }
}
