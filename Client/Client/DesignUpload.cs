using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Client.localhost;
using System.Net.Sockets;

namespace Client
{
    public partial class DesignUpload : Form
    {
        private DesignUpload()
        {
            InitializeComponent();
        }
        private static DesignUpload L = null;

        public static DesignUpload GetInstance()
        {
            if (L == null)
            {
                return new DesignUpload();
            }
            return L;
        }

        private void DesignUpload_Load(object sender, EventArgs e)
        {
            pbSelectedImage.Image = Client.Properties.Resources.ShoeTemplate;
        }

        private void lnkHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home h = Home.GetInstance();
            h.Show();
            this.Hide();
        }

        private void lnkSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home h = Home.GetInstance();
            h.Show();
            this.Hide();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                pbSelectedImage.Image = System.Drawing.Image.FromFile(openFileDialog2.FileName);
            }
        }

        private void pbSelectedImage_Click(object sender, EventArgs e)
        {
            //dbSelectImage.ShowDialog();
        }



        private void btnUpload_Click(object sender, EventArgs e)
        {
            Service1 s = new Service1();
            // s.AddDesignInDL(pbSelectedImage.Image);
            /*
            TcpClient mTcpClient = new TcpClient();

            Bitmap tImage = new Bitmap(@"C:\Users\Milan\Downloads\guitarstill.gif");

            byte[] bStream;
            //if (string.IsNullOrEmpty(tbPayload.Text)) return;
            try
            {
                bStream = imageToByteArray(tImage);
                if (mTcpClient != null)
                {
                    if (mTcpClient.Client.Connected)
                    {
                        mTcpClient.GetStream().BeginWrite(imageToByteArray(tImage), 0, imageToByteArray(tImage).Length, onCompleteWriteToServer, mTcpClient);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }


        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            //richTextBox1.Text = ms.ToArray().ToString();
            return ms.ToArray();
        }//Within another method:
        */
        }

        

        private void btnCreateDesign_Click(object sender, EventArgs e)
        {

        }
    }
}
