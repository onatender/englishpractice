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
    public partial class removeForm : Form
    {
        public removeForm()
        {
            InitializeComponent();
        }

        void reloadWordCount()
        {
            int num = 0;
            foreach (var item in listBox1.Items)
                num++;

            wordCount.Text = "Word Count : "+num.ToString();
        }

        List<string> wordList = new List<string>();
        public static bool isDeleted = false;

        private void removeForm_Load(object sender, EventArgs e)
        {
            wordList.Clear();
            listBox1.Items.Clear(); 

            if (File.Exists("wordlist.wl"))
            {
                using (StreamReader sr = new StreamReader("wordlist.wl"))
                {
                    string alltext = sr.ReadToEnd();
                    foreach (string word in alltext.Split("\n"))
                    {
                        if (!string.IsNullOrWhiteSpace(word))
                        wordList.Add(word);
                    }
                }

            }

            foreach (string word in wordList) { listBox1.Items.Add(word); }
            reloadWordCount();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string silinecek = listBox1.Items[listBox1.SelectedIndex].ToString();
            listBox1.SelectedIndex = -1;
            textBox1.ForeColor = Color.Gray;
            textBox1.Text = "Search";
            listBox1.Items.Clear();
            string exText = string.Empty;

            using (StreamReader sr = new StreamReader("wordlist.wl"))
            {
                exText = sr.ReadToEnd();
            }

            using (StreamWriter sw = File.CreateText("wordlist.wl"))
            {
                if(exText.Contains("\n"+silinecek))
                sw.Write(exText.Replace("\n"+silinecek, string.Empty));
                else sw.Write(exText.Replace(silinecek+"\n", string.Empty));
            }

            foreach (string item in wordList)
            {
                if (item != silinecek)
                {
                    listBox1.Items.Add(item);
                }
            }
            reloadWordCount();

            removeForm_Load(sender, e);
            isDeleted = true;
            MessageBox.Show("Word removed successfully!", "English Practice V1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
            reloadWordCount();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.ForeColor == Color.Gray) return;

            listBox1.Items.Clear();
            if (textBox1.Text == "")
            {
                foreach (string item in wordList)
                {
                    listBox1.Items.Add(item);
                }
                reloadWordCount();
                return;
            }
            foreach (string item in wordList)
            {
                if (item.Contains(textBox1.Text))
                {
                    listBox1.Items.Add(item);
                }
            }
            reloadWordCount();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.ForeColor == Color.Gray)
            {
                textBox1.Text = string.Empty;
                textBox1.ForeColor=Color.Black;
            }


        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.ForeColor=Color.Gray;
                textBox1.Text = "Search";
            }
        }
    }
}
