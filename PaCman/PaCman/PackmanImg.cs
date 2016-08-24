using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PaCman
{
    class PackmanImg
    {
        Image[] up = new Image[] 
        { 
            Properties.Resources.PacImg0_1, 
            Properties.Resources.PacImg0_1,
            Properties.Resources.PacImg0_1,
            Properties.Resources.PacImg0_1, 
            Properties.Resources.PacImg0_1,
            Properties.Resources.PacImg0_1,
            Properties.Resources.PacImg0_1I,
            Properties.Resources.PacImg0_1I,
            Properties.Resources.PacImg0_1I,
            Properties.Resources.PacImg0_1I,
            Properties.Resources.PacImg0_1I,
            Properties.Resources.PacImg0_1I,
        };

        Image[] down = new Image[] 
        { 
            Properties.Resources.PacImg01,
            Properties.Resources.PacImg01,
            Properties.Resources.PacImg01,
            Properties.Resources.PacImg01,
            Properties.Resources.PacImg01,
            Properties.Resources.PacImg01,
            Properties.Resources.PacImg01I,
            Properties.Resources.PacImg01I,
            Properties.Resources.PacImg01I,
            Properties.Resources.PacImg01I,
            Properties.Resources.PacImg01I,
            Properties.Resources.PacImg01I,
        };

        Image[] left = new Image[] 
        { 
            Properties.Resources.PacImg_10,
            Properties.Resources.PacImg_10,
            Properties.Resources.PacImg_10,
            Properties.Resources.PacImg_10,
            Properties.Resources.PacImg_10,
            Properties.Resources.PacImg_10,
            Properties.Resources.PacImg_10I,
            Properties.Resources.PacImg_10I,
            Properties.Resources.PacImg_10I,
            Properties.Resources.PacImg_10I,
            Properties.Resources.PacImg_10I,
            Properties.Resources.PacImg_10I,
 
        };

        Image[] right = new Image[] 
        { 
            Properties.Resources.PacImg10, 
            Properties.Resources.PacImg10,
            Properties.Resources.PacImg10,
            Properties.Resources.PacImg10,
            Properties.Resources.PacImg10,
            Properties.Resources.PacImg10,
            Properties.Resources.PacImg10I,
            Properties.Resources.PacImg10I,
            Properties.Resources.PacImg10I,
            Properties.Resources.PacImg10I,
            Properties.Resources.PacImg10I,
            Properties.Resources.PacImg10I,
        };

        public Image[] Right
        {
            get { return right; }
        }

        public Image[] Up
        {
            get { return up; }
        }

        public Image[] Down
        {
            get { return down; }
        }

        public Image[] Left
        {
            get { return left; }
        }
    }
}
