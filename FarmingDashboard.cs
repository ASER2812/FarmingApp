using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

enum CLR_OPT { Black, Red, Green, Blue };


namespace WindowsFormsApp1
{
    public sealed partial class FarmingDashboard : Form
    {
        private static FarmingDashboard instance = null;
        private static readonly object padlock = new object();

        FarmingDashboard()
        {
            InitializeComponent();
        }

        public static FarmingDashboard Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new FarmingDashboard();
                    }
                    return instance;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.MSG_BOX.Text.Length == 0)
            {
                this.MSG_BOX.AppendText("You have chosen Option: " + OPT_BOX.SelectedItem.ToString() + ".");

            }
            else
            {
                this.MSG_BOX.AppendText("\nYou have chosen Option: " + OPT_BOX.SelectedItem.ToString() + ".");

            }

        }



        private void button2_Click(object sender, EventArgs e)
        {

        }

    

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CLR_BOX_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SETCLR_BTN_Click(object sender, EventArgs e)
        {

            int option = CLR_BOX.SelectedIndex;
            if (this.MSG_BOX.Text.Length != 0) option = CLR_BOX.SelectedIndex;

            switch (option)
            {
                case (int)CLR_OPT.Black:
                    MSG_BOX.ForeColor = Color.Black;
                    break;
                case (int)CLR_OPT.Red:
                    MSG_BOX.ForeColor = Color.Red;
                    break;
                case (int)CLR_OPT.Green:
                    MSG_BOX.ForeColor = Color.Green;
                    break;
                case (int)CLR_OPT.Blue:
                    MSG_BOX.ForeColor = Color.Blue;
                    break;
            }
        }

        private void MSG_BOX_TextChanged(object sender, EventArgs e)
        {

        }
        private void DLT_BTN_Click(object sender, EventArgs e)
        {
            if (MSG_BOX.Text != "") {
                String[] msg_lines = this.MSG_BOX.Text.Split('\n');

                this.MSG_BOX.Text = "";

                for (int i = 0; i <= msg_lines.Length - 3; i++)
                {
                    this.MSG_BOX.Text += msg_lines[i] + "\n";
                }
                if (msg_lines.Length - 2 >= 0)
                this.MSG_BOX.Text += msg_lines[msg_lines.Length - 2];
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
