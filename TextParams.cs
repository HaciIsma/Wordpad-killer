using System.Drawing;

namespace WORDPAD_KILLER
{
    class TextParams
    {
        public string str { get; set; }

        public string Front { get; set; }
        public Color Color { get; set; } = Color.Black;
        public float Size { get; set; } = 8.5f;

        public string FamilyName { get; set; } = "Microsoft Sans Serif";
        public GraphicsUnit Unit { get; set; } = GraphicsUnit.Point;
        public byte GdiCharSet { get; set; } = ((byte)0);

        public bool Bold { get; set; }
        public bool Underline { get; set; }
        public bool Italic { get; set; }

    }
}
