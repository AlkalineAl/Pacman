using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PaCman
{
    class DeadSpirit
    {
        DeadSpiritsImg dsImg = new DeadSpiritsImg();
        Image curentImg;
        int k;
        int x, y;

        public Image CurentImg
        {
            get { return curentImg; }
        }

        Image[] img;       

        public int Y
        {
            get { return y; }
        }

        public int X
        {
            get { return x; }
        }

        public DeadSpirit(int x, int y)
        {
            this.x = x;
            this.y = y;
            img = dsImg.Img;
            PutCurentImage();
        }

        public void Dead()
        {
            PutCurentImage();
        }
        
        protected void PutCurentImage()
        {
            curentImg = img[k];
            k++;
            if (k == 5)
                k = 0;
        }
    }
}
