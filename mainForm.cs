using System;

namespace TeleserviceTools
{
    public partial class mainForm : System.Windows.Forms.Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        //Eventhandlers for Encode
        private void btnEncode_Click(object sender, EventArgs e)
        {
            txtDevicename.Text =  Program.CIPCencode(txtExtension.Text);
            txtTFTP.Text = "TFTP Address to use is:\r\n10.255.133.42\r\n10.255.133.43\r\nDeviceName to use is: " + txtDevicename.Text;
        }
        private void txtExtension_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnEncode_Click(this, e);
            }
        }

        //Eventhandlers for Decode
        private void btnDecode_Click(object sender, EventArgs e)
        {
            txtExtension.Text = Program.CIPCdecode(txtDevicename.Text);
            txtTFTP.Text = "";
        }
        private void txtDevicename_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnDecode_Click(this, e);
            }
        }

        //Eventhandles for IPEI Checksum
        private void btnIPEI_Click(object sender, EventArgs e)
        {
            txtIPEIwithChkSum.Text = Program.IPEIChkSumCalc(txtIPEI.Text);
        }

        private void txtIPEI_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnIPEI_Click(this, e);
            }
        }
     
        private void mainForm_Load(object sender, EventArgs e)
        {
            aboutText.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + "\r\nVersion: " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString() + "\r\nLicense: Free, Open, Do with as you will. But keep the credit.\r\nCredit: Johan Åhman";

            
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            gameForm game = new gameForm();
            game.Show();
        }
    }

}
