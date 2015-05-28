using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TGDB
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e){
            if (e.KeyCode == Keys.Return)
            {
                CheckLogin();
            }
        }

        private void button3_Click(object sender, EventArgs e){Dispose();}
        private void button2_Click(object sender, EventArgs e){Dispose();}
        private void button1_Click(object sender, EventArgs e){CheckLogin();}

        private void Dispose()
        {
            this.Close();
        }

        private void CheckLogin()
        {
            //CHECK USERNAME AND PASS, IF GOOD THEN SEND TO NEXT SCREEN;
            if (textBox1.Text.Equals("Demetry"))
            {
                if (textBox2.Text.Equals("Merlin"))
                {
                    ;
                    //Unhandled as of yet
                }
            }
            //this.Close();
        }
    }
}
