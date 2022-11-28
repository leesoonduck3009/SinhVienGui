using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormMain : Form
    {
        Button currentBtn;
        public FormMain()
        {
            InitializeComponent();
        }


        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                currentBtn = (Button)senderBtn;
                currentBtn.BackColor = Color.FromArgb(74, 34, 170);
            }
        }
        private void DisableButton()
        {
            if(currentBtn!= null)
            {
                currentBtn.BackColor = Color.FromArgb(112, 51, 255);
            }    
        }    
        private void button1_Click(object sender, EventArgs e)
        {
            DisableButton();
            ActivateButton(sender);
            OpenChildFrom(new FormList());
            
        }
        private Form ActiveForm = null;
        private void OpenChildFrom(Form FormChild)
        {
            if(ActiveForm != null)
            {
                ActiveForm.Close(); 
            }
            FormChild.TopLevel = false;
            FormChild.FormBorderStyle = FormBorderStyle.None;
            FormChild.Dock = DockStyle.Fill;
            ActiveForm = FormChild;
            pnlDisplay.Controls.Add(FormChild);
            pnlDisplay.Tag = FormChild;
            FormChild.BringToFront();
            FormChild.Show();
        }

        private void bttFind_Click(object sender, EventArgs e)
        {
            DisableButton();
            ActivateButton(sender);
            OpenChildFrom(new FormSearch());
        }

        private void bttDel_Click(object sender, EventArgs e)
        {
            DisableButton();
            ActivateButton(sender);
            OpenChildFrom(new FormDel());
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            DisableButton();
            ActivateButton(sender);
            OpenChildFrom(new FormAdd());
        }

        private void bttChange_Click(object sender, EventArgs e)
        {
            DisableButton();
            ActivateButton(sender);
            OpenChildFrom(new FormChange());
        }
    }
   
}
