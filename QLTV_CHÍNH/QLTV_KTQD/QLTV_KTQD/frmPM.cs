using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HellloWorld
{
    public partial class frmPM : Form
    {
        private Size formOriginalSize;
        private Rectangle rcpnlEditPhieumuon;
        public frmPM()
        {
            InitializeComponent();
            this.Resize += frmPM_Resiz;
            formOriginalSize = this.Size;
            rcpnlEditPhieumuon = new Rectangle(pnlEditPhieumuon.Location, pnlEditPhieumuon.Size);
        }
        private void frmPM_Resiz(object sender, EventArgs e)
        {
            resize_Control(pnlEditPhieumuon, rcpnlEditPhieumuon);
        }
            private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblmathuthu_Click(object sender, EventArgs e)
        {

        }

        private void rtxtMapm_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lbltieude_Click(object sender, EventArgs e)
        {

        }

        private void rtbxmaPP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTimkiemPhieumuon_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimkiemPhieumuon_Click(object sender, EventArgs e)
        {

        }

        private void frmPM_Load(object sender, EventArgs e)
        {
            formOriginalSize = this.Size;
        }

        private void pnlEditPhieuphat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoaPhieumuon_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaPhieumuon_Click(object sender, EventArgs e)
        {

        }

        private void btnThemPhieumuon_Click(object sender, EventArgs e)
        {

        }
    }
}
