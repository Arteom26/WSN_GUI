using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using myLibrary;

namespace SMIP_Network
{
    public partial class Form1 : Form
    {

        Universal Universal = new Universal();
        DateTime time = new DateTime();


        #region Custum class Declaration
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private object iconCurrentChildForm;
        #endregion





        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelmainPage.Controls.Add(leftBorderBtn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;


            MainPageForm objForm3 = new MainPageForm(this);
            OpenChildForm(objForm3);
            // OpenChildForm(new MainPageForm());

        }

        #region Custom EventHandler
        public delegate void UpdateDelegate(object sender, UpdateDataEventArgs args);

        public event UpdateDelegate UpdateDataEventHandler;
        public class UpdateDataEventArgs : EventArgs
        {

        }
        protected void RefreshDataGridViewForm2()
        {
            UpdateDataEventArgs args = new UpdateDataEventArgs();
            UpdateDataEventHandler.Invoke(this, args);
        }
        #endregion





        #region  Custume UI 


        private struct RGBColors 
        {
            public static Color color1 = Color.FromArgb(255, 108, 17);
            public static Color color2 = Color.FromArgb(255, 179, 0);
            public static Color color3 = Color.FromArgb(14, 213, 81);
            public static Color color4 = Color.FromArgb(143, 241, 16);
            public static Color color5 = Color.FromArgb(17, 172, 194);
            public static Color color6 = Color.FromArgb(24, 161, 251);



        }



        //Methods

        private void ActiveButton(object senderBtn, Color color)
        { 
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //left border Button 

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

                currentBtn.BackColor = Color.FromArgb(194, 4, 48);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        
        
        }


        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {

                currentChildForm.Close();
            
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        
        
        }





        private void Home_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
           // OpenChildForm(new MainPageForm());

            MainPageForm objForm3 = new MainPageForm(this);
            OpenChildForm(objForm3);
            // objForm3.Activate();
           // objForm3.Show();
            // this.Hide();
        }

        private void Mote_BTN_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color2);
            OpenChildForm(new MotesForm());

         //   MainPageForm settings = new MainPageForm(serialPort1);
        }

        private void Statistics_Btn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color3);
            OpenChildForm(new StatisForm());
        }

        private void Configar_Btn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color4);
            OpenChildForm(new ConfigForm());
        }

        private void Setting_buttun_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color5);
            OpenChildForm(new SettingsForm());
        }

        private void Help_btn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color6);
            OpenChildForm(new HelpForm());
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd,int wMsg,int wParam, int lParam);




        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MaximBtn_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;          
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }



        #endregion









    }

}
