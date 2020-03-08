﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EngProject.Classes;
using NUnit.Framework;

namespace EngProject.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var text = new TextClass();
            text.GetText();
            richTextBox1.Text = text.Text;
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            label1.Text = richTextBox1.SelectedText;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
