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

        public Form1()
        {
            InitializeComponent();

            for (int i = 1000; i < 20000; i+= 1000)
            {
                ElemsComboBox.Items.Add(i);
            }
            
        }

        private void CompareButton_Click(object sender, EventArgs e)
        {
            int size = Convert.ToInt32(ElemsComboBox.SelectedItem.ToString());
            RandomArray randomize = new RandomArray(size);

            int[] bubbleArray = randomize.GenerateNewArray(size);
            int[] quickArray = randomize.GenerateNewArray(size);
            int[] gnomeArray = randomize.GenerateNewArray(size);

            Bubble bubble = Bubble.GetInstance();
            QuickSort quick = QuickSort.GetInstance();
            Gnome gnome = Gnome.GetInstance();

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
            bubbleThread.Start();
            quickTimer.Start();
            quickThread.Start();
            gnomeTimer.Start();
            gnomeThread.Start();

            while(!(bubble.isFinished && quick.isFinished && gnome.isFinished))
            {
                if (bubble.isFinished) bubbleTimer.Stop();
                if (quick.isFinished) quickTimer.Stop();
                if (gnome.isFinished) gnomeTimer.Stop();
            }

            /*
            bubbleTimer.Start();
            bubble.Sort();
            bubbleTimer.Stop();

            quickTimer.Start();
            quick.Sort();
            quickTimer.Stop();

            gnomeTimer.Start();
            gnome.Sort();
            gnomeTimer.Stop();

            */

            BubbleTimeLabel.Text = "time: " + bubbleTimer.ElapsedMilliseconds.ToString() + " ms";
            QuickTimeLabel.Text = "time: " + quickTimer.ElapsedMilliseconds.ToString() + " ms";
            GnomeTimeLabel.Text = "time: " + gnomeTimer.ElapsedMilliseconds.ToString() + " ms";

        }
    }
}
