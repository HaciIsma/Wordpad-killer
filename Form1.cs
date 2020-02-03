using MetroFramework.Forms;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;


namespace WORDPAD_KILLER
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            FrontcmbAdd();
            ColorcmbAdd();
        }

        private void FrontcmbAdd()
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                Fontcmbox.Items.Add(font.Name.ToString());
            }
        }
        private void ColorcmbAdd()
        {
            foreach (var color in Enum.GetNames(typeof(System.Drawing.KnownColor)))
            {
                Colorcmb.Items.Add(color.ToString());
            }
        }
      
    }
}
