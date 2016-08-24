using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PaCman
{
    class DeadSpiritsImg
    {
        Image[] img = new Image[] 
        { 
            Properties.Resources.dead, 
            Properties.Resources.dead1, 
            Properties.Resources.dead2, 
            Properties.Resources.dead3, 
            Properties.Resources.dead4
        };

        public Image[] Img
        {
            get { return img; }
        }
    }
}
