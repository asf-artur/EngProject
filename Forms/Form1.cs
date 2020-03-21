using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
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
            InitAll();
        }

        private void InitAll()
        {
            WorkWithForms.Init(out workWithForms, this, textClass, treeView1, label1);
        }
        TextClass textClass = new TextClass();
        private WorkWithForms workWithForms;

        public void SmthFunc()
        {
            treeView1.Nodes.AddRange(workWithForms.GetTreeNodes().ToArray());
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            textClass.LoadText();
            richTextBox1.Text = textClass.Text;
            SmthFunc();
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
           //label1.Text =  textClass.GetTranslation(richTextBox1.SelectedText.Trim());
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
