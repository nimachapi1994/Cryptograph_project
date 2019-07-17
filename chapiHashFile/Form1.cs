using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;

namespace chapiHashFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        internal static string GetStringSha256Hash(string text)
        {
            if (String.IsNullOrEmpty(text))
                return String.Empty;

            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] textData = System.Text.Encoding.UTF8.GetBytes(text);
                byte[] hash = sha.ComputeHash(textData);
                return BitConverter.ToString(hash).Replace("-", String.Empty);
            }
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
         
           
           
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string filepath = openFileDialog1.FileName;
                Encrypt d = new Encrypt();
                d.DecryptFile(filepath, textBox2.Text, filepath);
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox=false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //hash all files
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string filepath = openFileDialog1.FileName;
                Encrypt d = new Encrypt();
                d.EncryptFile(openFileDialog1.FileName, textBox1.Text, openFileDialog1.FileName);
                //string filetext = "hi hasan khrdal sose kachab amin  nima aragh " + Environment.NewLine + "nima" + Environment.NewLine + "hasan";
                //string x = GetStringSha256Hash(filetext);
                //File.Delete(filepath);
                //File.WriteAllText(filepath , x, Encoding.UTF8);


            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            MessageBox.Show(random.Next(1, 999999).ToString());
        }
    }
}
