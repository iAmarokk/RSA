using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA
{
    public partial class FormRSA : Form
    {
        RSA rsa = new RSA();

        public FormRSA()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonGenP_Click(object sender, EventArgs e)
        {
            if (textBoxP.Text == "" && textBoxq.Text == "")
            {
                rsa.GenerateP();
            }
            else
            {
                ManualInput();
            }
            ShowNumbers();
        }

        private void buttonGenQ_Click(object sender, EventArgs e)
        {

            rsa.GenerateQ();
            ShowNumbers();
        }

        private void ShowNumbers()
        {
            textBoxP.Text = Show(rsa.p);
            textBoxq.Text = Show(rsa.q);
            textBoxn.Text = Show(rsa.n);
            textBoxfn.Text = Show(rsa.m);
            textBoxe.Text = Show(rsa.e);
            textBoxd.Text = Show(rsa.d);

            textPublicE.Text = textBoxe.Text;
            textPublicN.Text = textBoxn.Text;

            textPrivateD.Text = textBoxd.Text;
            textPrivateN.Text = textBoxn.Text;
        }

        private string Show(int n)
        {
            if (n > 0)
                return n.ToString();
            else
                return "";
        }

        public void ManualInput()
        {
            rsa.p = Convert.ToInt32(textBoxP.Text);
            rsa.q = Convert.ToInt32(textBoxq.Text);
            rsa.CalcNumbers();
        }

        private void buttonFindE_Click(object sender, EventArgs e)
        {
            rsa.GenerateE();
            ShowNumbers();
        }

        private void buttonFindD_Click(object sender, EventArgs e)
        {
            rsa.GenerateD();
            ShowNumbers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitGrid();
            Encrypt();
        }

        void InitGrid()
        {
            grid.Rows.Clear();
            string message = textPublicMessage.Text;
            for (int j = 0; j < message.Length; j++)
            {
                grid.Rows.Add();
                grid["coLetter", j].Value = message[j];
                grid["coAscii", j].Value = (int)message[j];
            }
        }

        void Encrypt()
        {
            int e = int.Parse(textPublicE.Text);
            int n = int.Parse(textPublicN.Text);
            for (int row = 0; row < grid.Rows.Count; row++)
            {
                int t = int.Parse(grid["coAscii", row].Value.ToString());
                int c = rsa.Encrypt(t, e, n);
                grid["coEncrypt", row].Value = c;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Decrypt();
        }

        void Decrypt()
        {
            int d = int.Parse(textPrivateD.Text);
            int n = int.Parse(textPrivateN.Text);
            string message = "";
            char s;
            for (int row = 0; row < grid.Rows.Count; row++)
            {
                int c = int.Parse(grid["coEncrypt", row].Value.ToString());
                int r = rsa.Decrypt(c, d, n);
                grid["coDecrypt", row].Value = r;
                if (r < 2000)
                    s = (char)r;
                else
                    s = '?';
                grid["coDeLetter", row].Value = s;
                message += s;
            }
            textPrivateMessage.Text = message;
        }
    }
}
