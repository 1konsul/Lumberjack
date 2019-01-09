using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lumberjack
{
    public partial class Form1 : Form
    {
        private Queue<Lumberjack> breakfastLine=new Queue<Lumberjack>();
        Lumberjack currentLumberjack;

        private string lineDescription(Queue<Lumberjack> brekfastLine)
        {
            string line = "";
            int n = 1;
            foreach (Lumberjack lumberjack in breakfastLine)
            {
                line += n.ToString() + ". " + lumberjack.Name+Environment.NewLine;
                n++;
            }
            return line;
        }

        private void RedrawForm(string textLine)
        {
            textBox2Line.Text = textLine;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1AddLumberjack_Click(object sender, EventArgs e)
        {
            currentLumberjack = new Lumberjack(textBox1LumberjackName.Text);
            breakfastLine.Enqueue(currentLumberjack);
            RedrawForm(lineDescription(breakfastLine));
        }

        private void button2AddFlapjacks_Click(object sender, EventArgs e)
        {

        }

        private void button3NextLumberjack_Click(object sender, EventArgs e)
        {

        }
    }
}
