using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

// Devon Cardiff
// Sept 2016
namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Graphics fg = this.CreateGraphics();
            //Font drawFont = new Font("Ariel", 50, FontStyle.Bold);
            //SolidBrush 
            //    firstBrush= new SolidBrush(Color.Black);
            InitializeComponent();
            //fg.DrawString("Greetings!", drawFont, firstBrush, 100, 100);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //Gets rid of the title page completely
            titleLabel.Visible = false;
            subText.Visible = false;
            Graphics formGraphics = this.CreateGraphics();
            Pen whitePen = new Pen(Color.White, 10);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            //Creates stars and black background and sounds
            formGraphics.Clear(Color.Black);
            SoundPlayer player1 = new SoundPlayer(Properties.Resources.starSound);
            player1.Play();
            formGraphics.FillEllipse(whiteBrush, 297, 200, 10, 10);
            Thread.Sleep(50);
            SoundPlayer player2 = new SoundPlayer(Properties.Resources.starSound);
            player2.Play();
            formGraphics.FillEllipse(whiteBrush, 271, 238, 10, 10);
            Thread.Sleep(50);
            SoundPlayer player3 = new SoundPlayer(Properties.Resources.starSound);
            player3.Play();
            formGraphics.FillEllipse(whiteBrush, 212, 202, 10, 10);
            Thread.Sleep(50);
            SoundPlayer player4 = new SoundPlayer(Properties.Resources.starSound);
            player4.Play();
            formGraphics.FillEllipse(whiteBrush, 221, 162, 10, 10);
            Thread.Sleep(50);
            SoundPlayer player5 = new SoundPlayer(Properties.Resources.starSound);
            player5.Play();
            formGraphics.FillEllipse(whiteBrush, 193, 126, 10, 10);
            Thread.Sleep(50);
            SoundPlayer player6 = new SoundPlayer(Properties.Resources.starSound);
            player6.Play();
            formGraphics.FillEllipse(whiteBrush, 105, 68, 10, 10);
            Thread.Sleep(200);
            formGraphics.DrawLine(whitePen, 105, 68, 208, 140);
            Thread.Sleep(200);
            formGraphics.DrawLine(whitePen, 221 , 162 , 208, 140);
            Thread.Sleep(200);
            formGraphics.DrawLine(whitePen, 221, 162, 212, 202);
            Thread.Sleep(200);
            formGraphics.DrawLine(whitePen, 271 , 238, 212, 202);
            Thread.Sleep(200);
            formGraphics.DrawLine(whitePen, 271, 238, 297, 200);

            Thread.Sleep(500);

            Pen bluePen = new Pen(Color.Blue, 10);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);

            formGraphics.FillEllipse(blueBrush, 297, 200, 10, 10);
            Thread.Sleep(50);
            formGraphics.FillEllipse(blueBrush, 271, 238, 10, 10);
            Thread.Sleep(50);
            formGraphics.FillEllipse(blueBrush, 212, 202, 10, 10);
            Thread.Sleep(50);
            formGraphics.FillEllipse(blueBrush, 221, 162, 10, 10);
            Thread.Sleep(50);
            formGraphics.FillEllipse(whiteBrush, 193, 126, 10, 10);
            Thread.Sleep(50);
            formGraphics.FillEllipse(blueBrush, 105, 68, 10, 10);
            Thread.Sleep(200);
            formGraphics.DrawLine(bluePen, 105, 68, 208, 140);
            Thread.Sleep(200);
            formGraphics.DrawLine(bluePen, 221, 162, 208, 140);
            Thread.Sleep(200);
            formGraphics.DrawLine(bluePen, 221, 162, 212, 202);
            Thread.Sleep(200);
            formGraphics.DrawLine(bluePen, 271, 238, 212, 202);
            Thread.Sleep(200);
            formGraphics.DrawLine(bluePen, 271, 238, 297, 200);

            Thread.Sleep(500);

            Pen yellowPen = new Pen(Color.Yellow, 10);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);

            formGraphics.FillEllipse(yellowBrush, 297, 200, 10, 10);
            Thread.Sleep(50);
            formGraphics.FillEllipse(yellowBrush, 271, 238, 10, 10);
            Thread.Sleep(50);
            formGraphics.FillEllipse(yellowBrush, 212, 202, 10, 10);
            Thread.Sleep(50);
            formGraphics.FillEllipse(yellowBrush, 221, 162, 10, 10);
            Thread.Sleep(50);
            formGraphics.FillEllipse(yellowBrush, 193, 126, 10, 10);
            Thread.Sleep(50);
            formGraphics.FillEllipse(yellowBrush, 105, 68, 10, 10);
            Thread.Sleep(200);
            formGraphics.DrawLine(yellowPen, 105, 68, 208, 140);
            Thread.Sleep(200);
            formGraphics.DrawLine(yellowPen, 221, 162, 208, 140);
            Thread.Sleep(200);
            formGraphics.DrawLine(yellowPen, 221, 162, 212, 202);
            Thread.Sleep(200);
            formGraphics.DrawLine(yellowPen, 271, 238, 212, 202);
            Thread.Sleep(200);
            formGraphics.DrawLine(yellowPen, 271, 238, 297, 200);
            Thread.Sleep(500);

            Pen redPen = new Pen(Color.Red, 10);
            SolidBrush redBrush = new SolidBrush(Color.Red);

            formGraphics.FillEllipse(redBrush, 297, 200, 10, 10);
            Thread.Sleep(50);
            formGraphics.FillEllipse(redBrush, 271, 238, 10, 10);
            Thread.Sleep(50);
            formGraphics.FillEllipse(redBrush, 212, 202, 10, 10);
            Thread.Sleep(50);
            formGraphics.FillEllipse(redBrush, 221, 162, 10, 10);
            Thread.Sleep(50);
            formGraphics.FillEllipse(redBrush, 193, 126, 10, 10);
            Thread.Sleep(50);
            formGraphics.FillEllipse(redBrush, 105, 68, 10, 10);
            Thread.Sleep(200);
            formGraphics.DrawLine(redPen, 105, 68, 208, 140);
            Thread.Sleep(200);
            formGraphics.DrawLine(redPen, 221, 162, 208, 140);
            Thread.Sleep(200);
            formGraphics.DrawLine(redPen, 221, 162, 212, 202);
            Thread.Sleep(200);
            formGraphics.DrawLine(redPen, 271, 238, 212, 202);
            Thread.Sleep(200);
            formGraphics.DrawLine(redPen, 271, 238, 297, 200);



            Thread.Sleep(2000);
            formGraphics.Clear(Color.Black);
            Thread.Sleep(500);
            //Creates Music / Band test and lightning bolt
            Graphics fg = this.CreateGraphics();
            Font bandFont = new Font("Ariel", 50, FontStyle.Bold);
            SolidBrush bandBrush = new SolidBrush(Color.White);
            fg.DrawString("Music", bandFont, bandBrush, 0, 40);
            Thread.Sleep(500);
            fg.DrawString("Band", bandFont, bandBrush, 250, 40);
            Thread.Sleep(200);
            formGraphics.DrawLine(whitePen, 220, 50, 210, 75 );
            formGraphics.DrawLine(whitePen, 240, 75, 207, 75);
            formGraphics.DrawLine(whitePen, 240, 75, 210, 110);
            Thread.Sleep(100);
            SoundPlayer strumPlayer = new SoundPlayer(Properties.Resources.strumSound);
            strumPlayer.Play();
            Thread.Sleep(2500);
            Font sponsorFont = new Font("Ariel", 15, FontStyle.Bold);
            SolidBrush sponsorBrush = new SolidBrush(Color.White);
            fg.DrawString("Our Sponsor!", sponsorFont, sponsorBrush, 100, 250);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
