using System.Drawing;

namespace WORDPAD_KILLER
{
    class TextParams
    {
        private bool left;
        private bool rigth;
        private bool center;

        public string str { get; set; }

        public string Front { get; set; }
        public string Color { get; set; }
        public float Size { get; set; } = 8.5f;



        public string FamilyName { get; set; } = "Microsoft Sans Serif";
        public GraphicsUnit Unit { get; set; } = GraphicsUnit.Point;
        public byte GdiCharSet { get; set; } = ((byte)0);



        public bool Bold { get; set; }
        public bool Underline { get; set; }
        public bool Italic { get; set; }



        public bool Left
        {
            get => left;
            set
            {
                left = value;
                if (value == true)
                {
                    center = default;
                    rigth = default;
                }
            }
        }
        public bool Rigth
        {
            get => rigth;
            set
            {
                rigth = value;
                if (value == true)
                {
                    left = default;
                    center = default;
                }
            }
        }
        public bool Center
        {
            get => center;
            set
            {
                center = value;
                if (center == true)
                {
                    left = default;
                    rigth = default;
                }
            }
        }
    }
}
