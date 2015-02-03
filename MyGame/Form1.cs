using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame
{
    public partial class Form1 : Form
    {
        bool inprogress = false; //if false there is no game in progress
        int whoturn = 1; //if 1 then player 1 turn, if 2 then player 2 turn
        //Image image = Image.FromFile("X.png");
        //Image image2 = Image.FromFile("O.png");
        public Form1()
        {
            InitializeComponent();
        }

        private void GameButton_Click(object sender, EventArgs e)
        {
            if(inprogress == false)
            {
                inprogress = true;
                GameButton.Text = "Reset";
                ClearBoard();
            }
            else if(inprogress == true)
            {
                inprogress = false;
                GameButton.Text = "New Game";
                ClearBoard();
            }
            
        }



        private void TopLeftBox_Click(object sender, EventArgs e)
        {
            if(TopLeftBox.Image == null)
            {
                if(whoturn == 1)
                {
                    TopLeftBox.Image = new Bitmap("C:\\Users\\Jovonte\\Documents\\MyGame\\MyGame\\X.png");
                }
                else if(whoturn == 2)
                {
                    TopLeftBox.Image = new Bitmap("C:\\Users\\Jovonte\\Documents\\MyGame\\MyGame\\O.png");
                }
            
                Update();
            }
        }

        private void TopCenterBox_Click(object sender, EventArgs e)
        {
            if (TopCenterBox.Image == null)
            {
                if (whoturn == 1)
                {
                    TopCenterBox.Image = new Bitmap("C:\\Users\\Jovonte\\Documents\\MyGame\\MyGame\\X.png");
                }
                if (whoturn == 2)
                {
                    TopCenterBox.Image = new Bitmap("C:\\Users\\Jovonte\\Documents\\MyGame\\MyGame\\O.png");
                }
                Update();
            }
        }

        private void TopRightBox_Click(object sender, EventArgs e)
        {
            if (TopRightBox.Image == null)
            {
                if (whoturn == 1)
                {
                    TopRightBox.Image = new Bitmap("C:\\Users\\Jovonte\\Documents\\MyGame\\MyGame\\X.png");
                }
                if (whoturn == 2)
                {
                    TopRightBox.Image = new Bitmap("C:\\Users\\Jovonte\\Documents\\MyGame\\MyGame\\O.png");
                }
                Update();
            }
        }

        private void ClearBoard()
        {
            TopLeftBox.Image = null;
            TopCenterBox.Image = null;
            TopRightBox.Image = null;

            LeftBox.Image = null;
            CenterBox.Image = null;
            RightBox.Image = null;

            BottomLeftBox.Image = null;
            BottomCenterBox.Image = null;
            BottomRightBox.Image = null;
        }

        private void Update()
        {
            if (whoturn == 1)
            {
                whoturn++;
            }
            else
            {
                whoturn--;
            }
        }

        private void LeftBox_Click(object sender, EventArgs e)
        {
            if (LeftBox.Image == null)
            {
                if (whoturn == 1)
                {
                    LeftBox.Image = new Bitmap("C:\\Users\\Jovonte\\Documents\\MyGame\\MyGame\\X.png");
                }
                if (whoturn == 2)
                {
                    LeftBox.Image = new Bitmap("C:\\Users\\Jovonte\\Documents\\MyGame\\MyGame\\O.png");
                }
                Update();
            }

        }

        private void CenterBox_Click(object sender, EventArgs e)
        {
            if (CenterBox.Image == null)
            {
                if (whoturn == 1)
                {
                    CenterBox.Image = new Bitmap("C:\\Users\\Jovonte\\Documents\\MyGame\\MyGame\\X.png");
                }
                if (whoturn == 2)
                {
                    CenterBox.Image = new Bitmap("C:\\Users\\Jovonte\\Documents\\MyGame\\MyGame\\O.png");
                }
                Update();
            }

        }

        private void RightBox_Click(object sender, EventArgs e)
        {
            if (RightBox.Image == null)
            {
                if (whoturn == 1)
                {
                    RightBox.Image = new Bitmap("C:\\Users\\Jovonte\\Documents\\MyGame\\MyGame\\X.png");
                }
                if (whoturn == 2)
                {
                    RightBox.Image = new Bitmap("C:\\Users\\Jovonte\\Documents\\MyGame\\MyGame\\O.png");
                }
                Update();
            }
        }

        private void BottomLeft_Click(object sender, EventArgs e)
        {
            if (BottomLeftBox.Image == null)
            {
                if (whoturn == 1)
                {
                    BottomLeftBox.Image = new Bitmap("C:\\Users\\Jovonte\\Documents\\MyGame\\MyGame\\X.png");
                }
                if (whoturn == 2)
                {
                    BottomLeftBox.Image = new Bitmap("C:\\Users\\Jovonte\\Documents\\MyGame\\MyGame\\O.png");
                }
                Update();
            }
        }

        private void BottomCenter_Click(object sender, EventArgs e)
        {
            if (BottomCenterBox.Image == null)
            {
                if (whoturn == 1)
                {
                    BottomCenterBox.Image = new Bitmap("C:\\Users\\Jovonte\\Documents\\MyGame\\MyGame\\X.png");
                }
                if (whoturn == 2)
                {
                    BottomCenterBox.Image = new Bitmap("C:\\Users\\Jovonte\\Documents\\MyGame\\MyGame\\O.png");
                }
                Update();
            }
        }

        private void BottomRight_Click(object sender, EventArgs e)
        {
            if (BottomRightBox.Image == null)
            {
                if (whoturn == 1)
                {
                    BottomRightBox.Image = new Bitmap("C:\\Users\\Jovonte\\Documents\\MyGame\\MyGame\\X.png");
                }
                if (whoturn == 2)
                {
                    BottomRightBox.Image = new Bitmap("C:\\Users\\Jovonte\\Documents\\MyGame\\MyGame\\O.png");
                }
                Update();
            }
        }

    
    }
}
