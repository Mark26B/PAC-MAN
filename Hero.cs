using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAC_MAN
{
    class Hero : PictureBox
    {
        public int Step { get; set; } = 5;
        public int HorizontalVelocity { get; set; } = 0;
        public int VerticalVelocity { get; set; } = 0;

        public Hero()
        {
            InitializeHero();
        }

        private void InitializeHero()
        {
            this.BackColor = Color.Green;
            this.Size = new Size(100, 100);
            this.Location = new Point(200, 200);
            this.Name = "hero";
        }


    }
}
