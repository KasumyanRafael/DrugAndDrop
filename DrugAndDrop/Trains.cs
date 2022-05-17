using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrugAndDrop
{
    class Trains
    {

    }
    class Train: PictureBox
    {
        int id;
        public Train(int id, Control control,int x,int y)
        {
            this.id = id;
            this.Load("Train/p"+id.ToString()+"Ossetian.png");
            this.SizeMode = PictureBoxSizeMode.AutoSize;
            control.Controls.Add(this);
            this.Location = new System.Drawing.Point(x, y);
            this.MouseMove += Train_MouseMove;
        }

        private void Train_MouseMove(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("abba");
        }
    }

}
