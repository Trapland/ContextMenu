using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ContextMenu
{
    public partial class Form1 : Form
    {
        int choice = 0;
        int count_but = 3;
        int count_text = 3;
        int count_check = 3;
        string but_text;
        string text_text;
        string check_text;
        public Form1()
        {
            InitializeComponent();
            but_text = createButtonToolStripMenuItem.Text;
            text_text = createToolStripMenuItem.Text;
            check_text = createCheckBoxToolStripMenuItem.Text;
            createButtonToolStripMenuItem.Text = but_text + count_but.ToString();
            createToolStripMenuItem.Text = text_text + count_text.ToString();
            createCheckBoxToolStripMenuItem.Text = check_text + count_check.ToString();
            menuStrip1.Items.Add(createButtonToolStripMenuItem);
            menuStrip1.Items.Add(createToolStripMenuItem);
            menuStrip1.Items.Add(createCheckBoxToolStripMenuItem);
        }

        private void createButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choice = 1;
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choice = 2;
        }

        private void createCheckBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choice = 3;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (choice == 1)
            {
                if (count_but > 0)
                {
                    Button button = new Button();
                    button.Location = new Point(e.X, e.Y);
                    button.Size = new Size(100, 100);
                    this.Controls.Add(button);
                    count_but--;
                    createButtonToolStripMenuItem.Text = but_text + count_but.ToString();
                }
                if (count_but == 0)
                {
                    createButtonToolStripMenuItem.Enabled = false;
                }
            }
            else if (choice == 2)
            {
                if (count_text > 0)
                {
                    TextBox text = new TextBox();
                    text.Location = new Point(e.X, e.Y);
                    text.Size = new Size(100, 100);
                    this.Controls.Add(text);
                    count_text--;
                    createToolStripMenuItem.Text = text_text + count_text.ToString();
                }
                if (count_text == 0)
                {
                    createToolStripMenuItem.Enabled = false;
                }
            }
            else if (choice == 3)
            {
                if (count_check > 0)
                {
                    CheckBox check = new CheckBox();
                    check.Location = new Point(e.X, e.Y);
                    check.Size = new Size(100, 100);
                    this.Controls.Add(check);
                    count_check--;
                    createCheckBoxToolStripMenuItem.Text = check_text + count_check.ToString();
                }
                if (count_check == 0)
                {
                    createCheckBoxToolStripMenuItem.Enabled = false;
                }
            }
        }
    }
}
