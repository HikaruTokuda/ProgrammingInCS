#define LISTENING1_30
//#define LISTENING1_31


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows


/// <summary>
/// Entering a very large number of averages causes the entire user interface to lock up while the program runs the 
/// event handler behind the "Start" button.
/// Tasks provide a means to solve this problem.(tPart of Listening 1_30)
/// ★★Listening1_31 is not work well...
/// </summary>


namespace ProgrammingInCSharp.Chapter1
{
    public partial class Listening1_29 : Form
    {
        private double computeAverages(long noOfValues)
        {
            double total = 0;
            Random rand = new Random();

            for (long values = 0; values < noOfValues; values++)
            {
                total = total + rand.Next();
            }

            return total / noOfValues;
        }

        public Listening1_29()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long noOfValues = long.Parse(numberOfValuesTextBox.Text);
#if LISTENING1_29
            ResultText.Text = "Result :" + computeAverages(noOfValues);
#endif
#if LISTENING1_30
            Task.Run( () => {
                ResultText.Text = "Result :" + computeAverages(noOfValues);
            });
#endif
#if LISTENING1_31
            Task.Run( () => {
                double result = computeAverages(noOfValues);
                CoreDis
            });
#endif

        }
    }
}
