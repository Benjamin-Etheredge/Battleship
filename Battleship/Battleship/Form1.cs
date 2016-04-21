using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Battleship
{
    public partial class Form1 : Form
    {
        private Button[][] buttons;
        private Battleship game;
        private bool boardsAreSet = false;


        public Form1()
        {
            game = new Battleship();
            dynamic_InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //game.Play();
        }

        private void dynamic_InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttons = new System.Windows.Forms.Button[10][];

            for (int i = 0; i < 10; i++)
            {
                buttons[i] = new System.Windows.Forms.Button[10];
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    buttons[i][j] = new System.Windows.Forms.Button();
                }
            }

            //this.button91 = new System.Windows.Forms.Button()
            this.button101 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    this.splitContainer1.Panel1.Controls.Add(buttons[i][j]);
                }
            }
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button101);
            this.splitContainer1.Panel2.Controls.Add(this.radioButton2);
            this.splitContainer1.Panel2.Controls.Add(this.radioButton1);
            this.splitContainer1.Size = new System.Drawing.Size(770, 385);
            this.splitContainer1.SplitterDistance = 304;
            this.splitContainer1.TabIndex = 103;
            // 
            // button91
            // 
            int n = 1;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    buttons[i][j].Location = new System.Drawing.Point(75*i, 23*j);
                    buttons[i][j].Name = "button" + n.ToString();
                    buttons[i][j].Size = new System.Drawing.Size(75, 23);
                    buttons[i][j].TabIndex = 199;
                    buttons[i][j].UseVisualStyleBackColor = true;
                    buttons[i][j].Click += new System.EventHandler(this.button1_Click);
                    n++;
                }
            }

            // 
            // button101
            // 
            this.button101.Location = new System.Drawing.Point(559, 24);
            this.button101.Name = "button101";
            this.button101.Size = new System.Drawing.Size(75, 23);
            this.button101.TabIndex = 105;
            this.button101.Text = "Clear";
            this.button101.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(166, 30);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(60, 17);
            this.radioButton2.TabIndex = 104;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Vertical";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(74, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(72, 17);
            this.radioButton1.TabIndex = 103;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Horizontal";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(770, 385);
            this.Controls.Add(this.splitContainer1);
            this.MaximumSize = new System.Drawing.Size(9999, 9999);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!boardsAreSet)
            {
                //set boat
            }
            else
            {
                //fire here
            }
        }
    }
}
