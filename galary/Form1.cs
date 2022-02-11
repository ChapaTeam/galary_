using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;


namespace galary
{
    public partial class Form1 : Form
    {
        List<string> lists = new List<string>();
     
        int imageNamber = 0;
        int total = File.ReadAllLines("info.txt").Length;
    


        public Form1()
        {
            InitializeComponent();
            foreach (string str in File.ReadAllLines("info.txt"))
            {
                lists.Add(str);
            }
        }
    
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {

                dialog.Filter = "*.jpg|*.jpg|*.png|*.png";
                if (dialog.ShowDialog() == DialogResult.OK)
                {

                    lists.Add(dialog.FileName);

                }
            }
            selectedImage.Image = Image.FromFile(lists.Last());
        }


        //private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    File.AppendAllLines("info.txt", lists);
        //}
        //this.FormClosing += Form2_FormClosing;

        private void buttonNext_Click(object sender, EventArgs e)
        {
           
            if (lists.Count != lists.Count) return;
            {
                imageNamber++;

            }
               if(imageNamber < total)
                selectedImage.Image = Image.FromFile(lists[imageNamber]);
         
        }
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
         
           // if (lists.Count == lists.Count)
            {
                imageNamber--;
            }

            if (imageNamber > 0) 
               selectedImage.Image = Image.FromFile(lists[imageNamber]);
          
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            File.AppendAllLines("info.txt", lists);
            //foreach (string str in File.ReadAllLines("info.txt"))
            //{
            //    lists.Add(str);
            //}

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
           
        }
        private void buttonRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
