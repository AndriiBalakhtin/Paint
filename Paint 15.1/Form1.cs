using System.Drawing.Design;
using System.Security.Cryptography.X509Certificates;

namespace Paint_15._1
{
    public partial class Form1 : Form
    {
        class pennello
        {
            public int x, y;
            public int dim;
        }

        pennello p1;
       

        Bitmap CLEAN;
        Bitmap immagine;
        Color colore = Color.Black;
        public Form1()
        {
            InitializeComponent();
            p1 = new pennello
            {
                x = paintBox.Width / 2,
                y = paintBox.Height / 2,
                dim = 5
            };
            CLEAN = new Bitmap(paintBox.Width, paintBox.Height);
            immagine = new Bitmap(paintBox.Width, paintBox.Height);
            paintBox.Image = immagine;
            timer1.Enabled = true;

            this.KeyPreview = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {      
            disegnaPennello(p1);
        }

        private void disegnaPennello(pennello p)
        {
            int i, j;

            for(i = 0; i < p.dim; i++)
            {
                for(j = 0; j < p.dim; j++)
                {
                    immagine.SetPixel(p.x + i, p.y + j, colore);
                }
            }
            paintBox.Image = immagine;
        }

        private void clearImage(Bitmap bmp)
        {
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    bmp.SetPixel(x, y, Color.White);
                }
            }
            paintBox.Image = bmp;
            immagine = bmp;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar)
            {
                case 'a':
                    p1.x = p1.x - 1;
                    break;
                case 's':
                    p1.y = p1.y + 1;
                    break;
                case 'd':
                    p1.x = p1.x + 1;
                    break;
                case 'w':
                    p1.y = p1.y - 1;
                    break;
                case 'o':
                    colore = Color.White;
                    break;
                case 'p':
                    colore = Color.Black;
                    break;
            }  
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            clearImage(immagine);
        }
    }
}