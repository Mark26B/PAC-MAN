using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PAC_MAN
{
    class LevelGameArea : PictureBox
    {
        public LevelGameArea()
        {
            InitializeLevel();
        }

        private void InitializeLevel()
        {
            this.BackColor = Color.DarkBlue;
            this.Size = new Size(400, 400);
            this.Location = new Point(10, 10);
            this.Name = "level";
        }

    }
}
