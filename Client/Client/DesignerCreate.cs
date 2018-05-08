using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class DesignerCreate : Form
    {
        private DesignerCreate()
        {
            InitializeComponent();
        }
        private static DesignerCreate L = null;

      
        public string MainColor;
        public string SideColor;
        public string Laces = "No Laces";
        public static DesignerCreate GetInstance()
        {
            if (L == null)
            {
                return new DesignerCreate();
            }
            return L;
        }
        private void DesignerCreate_Load(object sender, EventArgs e)
        {

        }

        private void btnSendOrderToAdmin_Click(object sender, EventArgs e)
        {
        }

        private void btnApply_Click(object sender, EventArgs e)
        {

            if (btnSelectedColor.BackColor == System.Drawing.Color.Black)
            {
                if (rbtnSide.Checked)
                {
                    pbSide.Image = Client.Properties.Resources.ShoeBlack;
                    SideColor = "Black";

                }
                else
                {
                    pbMain.Image = Client.Properties.Resources.ShoeBlackFront;
                    MainColor = "Black";
                }
            }


            if (btnSelectedColor.BackColor == System.Drawing.Color.Aqua)
            {
                if (rbtnSide.Checked)
                {
                    pbSide.Image = Client.Properties.Resources.ShoeSky;
                    SideColor = "Aqua";
                }
                else
                {
                    pbMain.Image = Client.Properties.Resources.ShoeAquaFront;
                    MainColor = "Aqua";
                }
            }

            if (btnSelectedColor.BackColor == System.Drawing.Color.Green)
            {
                if (rbtnSide.Checked)
                {
                    pbSide.Image = Client.Properties.Resources.ShoeGreen;
                    SideColor = " Green";
                }
                else
                {
                    pbMain.Image = Client.Properties.Resources.ShoeGreenFront;
                    MainColor = "Green";
                }
            }

            if (btnSelectedColor.BackColor == System.Drawing.Color.Blue)
            {
                if (rbtnSide.Checked)
                {
                    pbSide.Image = Client.Properties.Resources.ShoeBlue;
                    SideColor = "Blue";
                }
                else
                {
                    pbMain.Image = Client.Properties.Resources.ShoeBlueFront;
                    MainColor = "Blue";
                }
            }

            if (btnSelectedColor.BackColor == System.Drawing.Color.Red)
            {
                if (rbtnSide.Checked)
                {
                    pbSide.Image = Client.Properties.Resources.ShoeRed;
                    SideColor = "Red";
                }
                else
                {
                    pbMain.Image = Client.Properties.Resources.ShoeRedFront;
                    MainColor = "Red";
                }
            }

            if (btnSelectedColor.BackColor == System.Drawing.Color.Brown)
            {
                if (rbtnSide.Checked)
                {
                    pbSide.Image = Client.Properties.Resources.ShoeBrown;
                    SideColor = "Brown";
                }
                else
                {
                    pbMain.Image = Client.Properties.Resources.ShoeBrownFront;
                    MainColor = "Brown";
                }
            }

            if (btnSelectedColor.BackColor == System.Drawing.Color.Gray)
            {
                if (rbtnSide.Checked)
                {
                    pbSide.Image = Client.Properties.Resources.ShoeGrey;
                    SideColor = "Gray";
                }
                else
                {
                    pbMain.Image = Client.Properties.Resources.ShoeGrayFront;
                    MainColor = "Gray";
                }
            }

            if (btnSelectedColor.BackColor == System.Drawing.Color.Orange)
            {
                if (rbtnSide.Checked)
                {
                    pbSide.Image = Client.Properties.Resources.ShoeOrange;
                    SideColor = "Orange";
                }
                else
                {

                    pbMain.Image = Client.Properties.Resources.ShoeOrangeFront;
                    MainColor = "Orange";
                }
            }

            if (btnSelectedColor.BackColor == System.Drawing.Color.Pink)
            {
                if (rbtnSide.Checked)
                {
                    pbSide.Image = Client.Properties.Resources.ShoePink;
                    SideColor = "Pink";
                }
                else
                {
                    pbMain.Image = Client.Properties.Resources.ShoePinkFront;
                    MainColor = "Pink";
                }
            }

            if (btnSelectedColor.BackColor == System.Drawing.Color.Yellow)
            {
                if (rbtnSide.Checked)
                {
                    pbSide.Image = Client.Properties.Resources.ShoeYellow;
                    SideColor = "Yellow";
                }
                else
                {
                    pbMain.Image = Client.Properties.Resources.ShoeYellowFront;
                    MainColor = "Yellow";
                }
            }


        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            btnSelectedColor.BackColor = System.Drawing.Color.Black;
        }

        private void btnSky_Click(object sender, EventArgs e)
        {
            btnSelectedColor.BackColor = System.Drawing.Color.SkyBlue;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            btnSelectedColor.BackColor = System.Drawing.Color.Green;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            btnSelectedColor.BackColor = System.Drawing.Color.Blue;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            btnSelectedColor.BackColor = System.Drawing.Color.Red;
        }

        private void btnBrown_Click(object sender, EventArgs e)
        {
            btnSelectedColor.BackColor = System.Drawing.Color.Brown;
        }

        private void btnGrey_Click(object sender, EventArgs e)
        {
            btnSelectedColor.BackColor = System.Drawing.Color.Gray;
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            btnSelectedColor.BackColor = System.Drawing.Color.Orange;
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            btnSelectedColor.BackColor = System.Drawing.Color.Yellow;
        }

        private void btnPink_Click(object sender, EventArgs e)
        {
            btnSelectedColor.BackColor = System.Drawing.Color.Pink;
        }

        private void btnAddLaces_Click(object sender, EventArgs e)
        {
            Laces = "Added";
            lblLaces.Text = "Laces are added";
        }

        private void btnRemoveLaces_Click(object sender, EventArgs e)
        {
            Laces = "No Laces";
            lblLaces.Text = "No Laces";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            pbMain.Image = Client.Properties.Resources.ShoeTemplateFront;
            pbSide.Image = Client.Properties.Resources.ShoeTemplate;
            MessageBox.Show("Your edits has been reset");
        }
    }
}
