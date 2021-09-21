using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace PRV_Sorts
{
    public partial class Form1 : Form
    {
        Bubble bubble = Bubble.GetInstance();
        QuickSort quick = QuickSort.GetInstance();
        Gnome gnome = Gnome.GetInstance();
        
        private void ShellProgressBar(int x)
        {
            if (InvokeRequired)
            {
                Gnome.Progress progress1 = this.ShellProgressBar;
                this.Invoke(progress1, x);
            }

            shellProgress.Value = x;
        }

        private void QuickProgressBar(int x)
        {
            if (InvokeRequired)
            {
                QuickSort.Progress progress1 = this.QuickProgressBar;
                this.Invoke(progress1, x);
            }

            quickProgressBar.Value = x;
        }

        private void BubbleProgressBar(int x)
        {
            if (InvokeRequired)
            {
                Bubble.Progress progress1 = this.BubbleProgressBar;
                this.Invoke(progress1, x);
            }

            bubbleProgressBar.Value = x;
        }

        public Form1()
        {
            InitializeComponent();

            for (int i = 1000; i < 20000; i+= 1000)
            {
                ElemsComboBox.Items.Add(i);
            }
            gnome.progress = ShellProgressBar;
            bubble.progress = BubbleProgressBar;
            quick.progress = QuickProgressBar;
        }

        private void CompareButton_Click(object sender, EventArgs e)
        {

            int size = Convert.ToInt32(ElemsComboBox.SelectedItem.ToString());
            RandomArray randomize = new RandomArray(size);

            int[] bubbleArray = randomize.GenerateNewArray(size);
            int[] quickArray = randomize.GenerateNewArray(size);
            int[] gnomeArray = randomize.GenerateNewArray(size);



            bubble.SetArray(bubbleArray);
            quick.SetArray(quickArray);
            gnome.SetArray(gnomeArray);

            Thread bubbleThread = new Thread(bubble.Sort);
            Thread quickThread = new Thread(quick.Sort);
            Thread gnomeThread = new Thread(gnome.Sort);
            
            //init timers
            Stopwatch bubbleTimer = new Stopwatch();
            Stopwatch quickTimer = new Stopwatch();
            Stopwatch gnomeTimer = new Stopwatch();

            bubbleTimer.Start();

            timer1.Start();
            bubbleThread.Start();
            quickTimer.Start();
            quickThread.Start();
            gnomeTimer.Start();
            gnomeThread.Start();

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bubble.isFinished) BubbleTimeLabel.Text = "finished ";
            if (quick.isFinished) QuickTimeLabel.Text = "finished ";
            if (gnome.isFinished) GnomeTimeLabel.Text = "finished ";
        }
    }
}
