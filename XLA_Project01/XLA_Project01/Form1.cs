using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.Util;

namespace XLA_Project01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Image<Bgr, Byte> hinh = new Image<Bgr, Byte>(@"C:\Users\Qduy\Desktop\Machine_Vision\Lena_goc.PNG");

            imgBox_HienThiHinh.Image = hinh;
        }
    }
}
