using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace English_Practice_V1._0
{
    public partial class wordForm : Form
    {
        public wordForm()
        {
            InitializeComponent();
        }

        public static bool isWordAdded = false;

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.ForeColor == Color.Gray)
            {
                textBox1.Text = string.Empty;
                textBox1.ForeColor = Color.Black;
            }

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text)) { textBox1.Text = "English"; textBox1.ForeColor=Color.Gray; }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.ForeColor == Color.Gray)
            {
                textBox2.Text = string.Empty;
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text)) { textBox2.Text = "Turkish"; textBox2.ForeColor=Color.Gray; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string item in Form1.wordList)
            {
                if (item.Split(" -*- ")[0] == textBox1.Text.Trim())
                {
                    MessageBox.Show("This word already exists!", "English Practice V1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (textBox1.Text.Contains("-*-") || textBox1.Text.Contains("\"") || textBox1.Text.Contains("\'") || textBox2.Text.Contains("-*-") || textBox2.Text.Contains("\"") || textBox2.Text.Contains("\'"))
            {
                MessageBox.Show("Invalid character detected.\nPlease avoid using single quotes (\'), double quotes (\"), or double dashes with blanks ( - ) in your input.", "English Practice V1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox1.Text.Length > 32 || textBox2.Text.Length > 32)
            {
                MessageBox.Show("The maximum allowed length is 32 characters for each.", "English Practice V1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text)
                && textBox1.ForeColor != Color.Gray && textBox2.ForeColor != Color.Gray)
            {
                StreamWriter f = new StreamWriter("wordlist.wl", true, Encoding.GetEncoding("utf-8"));
                f.WriteLine(textBox1.Text.Trim()+" -*- "+textBox2.Text.Trim());
                f.Close();
                f.Dispose();

                ChangeBackColor();

                isWordAdded = true;
                textBox1.Text = "English"; textBox1.ForeColor=Color.Gray;
                textBox2.Text = "Turkish"; textBox2.ForeColor=Color.Gray;
            }

            else
            {
                MessageBox.Show("Please fill in the blanks!", "English Practice V1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        void ChangeBackColor()
        {
            Color originalColor = this.BackColor; // Formun orijinal arka plan rengini saklayın
            this.BackColor = Color.Green; // Formun arka plan rengini yeşil yapın
            Refresh(); // Formu yenileyin

            timer1.Interval = 500; // 3 saniye bekleyin
            timer1.Tick += (s, e) =>
            {
                this.BackColor = originalColor; // Formun orijinal arka plan rengini geri yükleyin
                Refresh(); // Formu yenileyin
                timer1.Stop(); // Timer'ı durdurun
            };
            timer1.Start(); // Timer'ı başlatın
        }

        private void wordForm_Load(object sender, EventArgs e)
        {
        }

        private void wordForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // Eğer ENTER tuşuna basılmışsa
            {
                button1_Click(sender, e); // button1_Click olayını çağırın
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // Eğer ENTER tuşuna basılmışsa
            {
                button1_Click(sender, e); // button1_Click olayını çağırın
                textBox1.Focus();
            }
        }
    }
}
