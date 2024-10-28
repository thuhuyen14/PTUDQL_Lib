using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using HellloWorld;

namespace QLTV_KTQD
{
    public partial class frmmain2 : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentSecondForm;

        private Size formOriginalSize;
        
        //Constructor
        public frmmain2()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            pnMenu.Controls.Add(leftBorderBtn);

            //căn giữa màn
            this.Resize += frmmain2_Resiz;
            formOriginalSize = this.Size;
           

            //Form -- xoá cái mút phóng to thu nhỏ, tắt
            //  this.Text = string.Empty;
            //  this.ControlBox = false;
            //  this.DoubleBuffered = true;
            //  this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void frmmain2_Resiz(object sender, EventArgs e)
        {
           
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
        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(65, 105, 225);
        }
        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(237, 239, 242);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
       
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(43, 32, 145);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        //tạo form con bên trong
        private void Opensecondform(Form secondForm)
        {
            //chỉ mở 1 form duy nhất
            if (currentSecondForm != null)
            {
                currentSecondForm.Close();
            }
            currentSecondForm = secondForm;
            //End
            secondForm.TopLevel = false; //để cho hiển thị lên trên
            secondForm.FormBorderStyle = FormBorderStyle.None; //xoá các viền cạnh form
            secondForm.Dock = DockStyle.Fill; //điềm vào vùng chứa của panel
            panelDesktop.Controls.Add(secondForm);   //lệnh thêm form thứ 2
            panelDesktop.Tag = secondForm;  //liên kết dữ liệu với bảng
            secondForm.BringToFront(); //đưa biểu mẫu lên trước và hiển thị chúng
            secondForm.Show();   //hiển thị biểu mẫu
    
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;


        }
        private void iconhome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            Opensecondform(new frmtaikhoan());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            Opensecondform(new frmSach());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            Opensecondform(new frmDocgia());
        }

        private void iconphieumuon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            Opensecondform(new frmPM());
        }

        private void iconBaocao_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            Opensecondform(new frmthongke());
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            Opensecondform(new frmtaikhoan());
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
