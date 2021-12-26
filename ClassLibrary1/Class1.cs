using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public class ImageCombo : ComboBox
    {
        private ImageList lstImages = new ImageList();

        public ImageCombo()
        {

            this.DrawMode = DrawMode.OwnerDrawFixed;

        }

        public ImageList ImageList
        {

            get
            {

                return lstImages;

            }

            set
            {

                lstImages = value;

            }
        }
    }
}
