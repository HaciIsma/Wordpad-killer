﻿using MetroFramework.Forms;
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
        int boldCount = 0;
        TextParams @params = new TextParams();
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
        private void FrontStyleMake(string familyName, float emSize, GraphicsUnit unit, byte gdiCharSet)
        {

            if (@params.Bold)
            {
                this.Text.Font = new System.Drawing.Font(familyName, emSize, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold)
               ))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            else if (@params.Underline)
            {
                this.Text.Font = new System.Drawing.Font(familyName, emSize, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Underline)
                ))), unit, gdiCharSet);
            }
            else if (@params.Italic)
            {
                this.Text.Font = new System.Drawing.Font(familyName, emSize, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Italic)
                ))), unit, gdiCharSet);
            }
            else if (@params.Bold && @params.Underline)
            {
                this.Text.Font = new System.Drawing.Font(familyName, emSize, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline)
               ))), unit, gdiCharSet);
            }
            else if (@params.Bold && @params.Italic)
            {
                this.Text.Font = new System.Drawing.Font(familyName, emSize, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                ))), unit, gdiCharSet);
            }
            else if (@params.Underline && @params.Italic)
            {
                this.Text.Font = new System.Drawing.Font(familyName, emSize, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Underline | System.Drawing.FontStyle.Italic)
                ))), unit, gdiCharSet);
            }
            else if (@params.Italic && @params.Bold)
            {
                this.Text.Font = new System.Drawing.Font(familyName, emSize, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Bold)
                ))), unit, gdiCharSet);
            }
            else if (@params.Italic && @params.Bold && @params.Underline)
            {
                this.Text.Font = new System.Drawing.Font(familyName, emSize, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline)
                ))), unit, gdiCharSet);
            }
            else
            {
                this.Text.Font = new System.Drawing.Font(familyName, emSize, System.Drawing.FontStyle.Regular, unit, gdiCharSet);
            }
        }


        private void Fontcmbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            @params.Front = Fontcmbox.SelectedItem.ToString();
        }
        private void sizecmbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            @params.Size = int.Parse(sizecmbox.SelectedItem.ToString());
        }
        private void Colorcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            @params.Color = Colorcmb.SelectedItem.ToString();
        }
        private void Bold_Click(object sender, EventArgs e)
        {
            //boldCount++;
            //if (boldCount % 2 == 0)
            //{
            //    @params.Bold = true;
            //}
            //else
            //{
            //    @params.Bold = default;
            //
            //}
            FrontStyleMake(@params.FamilyName,@params.Size,@params.Unit,@params.GdiCharSet);

        }
        private void Underline_Click(object sender, EventArgs e)
        {
            @params.Underline = Text.Font.Underline;
            FrontStyleMake(@params.FamilyName, @params.Size, @params.Unit, @params.GdiCharSet);

        }
        private void Italic_Click(object sender, EventArgs e)
        {
            @params.Italic = Text.Font.Italic;
            FrontStyleMake(@params.FamilyName, @params.Size, @params.Unit, @params.GdiCharSet);

        }
        private void Left_Click(object sender, EventArgs e)
        {
            @params.Left = true;
        }
        private void Center_Click(object sender, EventArgs e)
        {
            @params.Center = true;
        }
        private void Right_Click(object sender, EventArgs e)
        {
            @params.Rigth = true;
        }
    }
}
