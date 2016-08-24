
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PaCman
{
   
    class Packman: IRun, ITurn, ITransparent, ICurentPicture
    {
        PackmanImg packmankImg = new PackmanImg();
        Image[] img;
        Image curentImg;

        int k;
        int sizeField;
        int x, y, direct_x, direct_y, nextDirect_x, nextDirect_y;

        public Image CurentImg
        {
            get { return curentImg; }
        }

        public int NextDirect_y
        {
            get { return nextDirect_y; }
            set
            {
                if (value == 0 || value == -1 || value == 1)
                    nextDirect_y = value;
                else nextDirect_y = 0;
            }
        }

        public int NextDirect_x
        {
            get { return nextDirect_x; }
            set
            {
                if (value == 0 || value == -1 || value == 1)
                    nextDirect_x = value;
                else nextDirect_x = 0;
            }
        }

        public int Direct_x
        {
            get { return direct_x; }
            set
            {
                if (value == 0 || value == -1 || value == 1)
                    direct_x = value;
                else direct_x = 0;
            }
        }

        public int Direct_y
        {
            get { return direct_y; }
            set
            {
                if (value == 0 || value == -1 || value == 1)
                    direct_y = value;
                else direct_y = 0;
            }
        }

        public Packman(int sizeField)
        {
            this.sizeField = sizeField;

            this.x = 240;
            this.y = 480;
            this.NextDirect_x = 0;
            this.NextDirect_y = -1;
            this.Direct_x = 0;
            this.Direct_y = -1;
            PutImg();
            PutCurentImage();


        }

        public int Y
        {
            get { return y; }
        }

        public int X
        {
            get { return x; }
        }

        public void Run()
        {

            x += direct_x;
            y += direct_y;
            if (Math.IEEERemainder(x, 80) == 0 && Math.IEEERemainder(y, 80) == 0)
                Turn();
            PutCurentImage();

            Transparent();
        }

        private void PutCurentImage()
        {
            curentImg = img[k];
            k++;
            if (k == 12)
                k = 0;
        }

        public void Turn()
        {
            Direct_x = NextDirect_x;
            Direct_y = NextDirect_y;
            PutImg();
        }

        public void Transparent()
        {
            if (x == -1)
                x = sizeField - 41;
            if (x >= sizeField - 39)
                x = 1;

            if (y == -1)
                y = sizeField - 41;
            if (y >= sizeField - 39)
                y = 1;
        }

        void PutImg()
        {
            if (direct_x == 1)
                img = packmankImg.Right;
            if (direct_x == -1)
                img = packmankImg.Left;
            if (direct_y == 1)
                img = packmankImg.Down;
            if (direct_y == -1)
                img = packmankImg.Up;

        }


    }
}
