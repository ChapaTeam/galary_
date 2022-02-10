using System.Drawing;
using System.Windows.Forms;﻿

namespace galary
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
            
            button = new Button();
            this.button.Text = "+";
            this.button.Location = new Point(650, 50);
            this.button.Size = new Size(50, 50);
            button.Font = new Font("Times New Roman", 14);
            this.Controls.Add(button);

            button1 = new Button();
            this.button1.Text = ">";
            this.button1.Location = new Point(650, 250);
            this.button1.Size = new Size(50, 50);
            button1.Font = new Font("Times New Roman", 14);
            this.Controls.Add(button1);

            button2 = new Button();
            this.button2.Text = "<";
            this.button2.Location = new Point(150, 250);
            this.button2.Size = new Size(50, 50);
            button2.Font = new Font("Times New Roman", 14);
            this.Controls.Add(button2);

            box.Image = Image.FromFile("img.png");
            box.SizeMode = PictureBoxSizeMode.CenterImage;
            box.Size = new Size(300, 100);
            box.Location = new Point(275, 225);
            this.Controls.Add(box);

            label = new Label();
            this.label.Location = new System.Drawing.Point(400, 200);
            this.label.Size = new Size(50, 20);
            this.label.Text = "1/24";
            this.Controls.Add(label);
        }

        Button button;
        Button button1;
        Button button2;

        PictureBox box = new PictureBox();

        Label label;

        #endregion
    }
}

