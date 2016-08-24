using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PaCman
{
    partial class View : UserControl
    {
        Model model;

        public View(Model model)
        {
            InitializeComponent();

            this.model = model;
        }

        void Draw(PaintEventArgs e)
        {
            DrawWall(e);
            DrawDeadSpirit(e);
            DrawApples(e);
            DrawTank(e);
            DrawPackman(e);
            DrawProjectile(e);

           

            if (model.gameStatus != GameStatus.playing)
                return;


            Thread.Sleep(model.speedGame);
            Invalidate();
        }

        private void DrawDeadSpirit(PaintEventArgs e)
        {
            foreach(DeadSpirit ds in model.DeadSpirit)
            e.Graphics.DrawImage(ds.CurentImg, new Point(ds.X,ds.Y));
        }

        private void DrawProjectile(PaintEventArgs e)
        {
            e.Graphics.DrawImage(model.Projectile.Img, new Point(model.Projectile.X, model.Projectile.Y));
        }

        private void DrawPackman(PaintEventArgs e)
        {
            e.Graphics.DrawImage(model.Packman.CurentImg, new Point(model.Packman.X, model.Packman.Y));
        }

        private void DrawApples(PaintEventArgs e)
        {
            for (int i = 0; i < model.Apples.Count; i++)
                e.Graphics.DrawImage(model.Apples[i].Img, new Point(model.Apples[i].X, model.Apples[i].Y));
        }

        private void DrawTank(PaintEventArgs e)
        {
            for (int i = 0; i < model.Tanks.Count;i++ )
                e.Graphics.DrawImage(model.Tanks[i].CurentImg, new Point(model.Tanks[i].X, model.Tanks[i].Y));
        }

        private void DrawWall(PaintEventArgs e)
        {
            for( int y =40; y<520 ; y+=80 )
               for (int x = 40; x< 520; x+= 80)
            e.Graphics.DrawImage(model.wall.Img, new Point(x, y));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Draw(e);
        }

    }
}
