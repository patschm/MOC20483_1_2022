using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var sA = txtA.Text;
            var sB = txtB.Text;
            if (int.TryParse(sA, out int a) && int.TryParse(sB, out int b))
            {
                //var ctx = SynchronizationContext.Current;
                ////int res = LongAdd(a, b);
                //Task.Run(() => LongAdd(a, b))
                //    .ContinueWith(task => {
                //            ctx.Post(UpdateAnswer, task.Result);
                //        });


                int result = await DoCalc(a, b);
                UpdateAnswer(result);

            }

        }

        private async Task<int> DoCalc(int a, int b)
        {
            int res = await LongAddAsync(a, b);
            return res;
        }

        private void UpdateAnswer(object res)
        {
            lblAnswer.Text = res.ToString();
        }

        private int LongAdd(int a, int b)
        {
            Task.Delay(5000).Wait();
            return a + b;
        }
        private Task<int> LongAddAsync(int a, int b)
        {
            return Task.Run(() => LongAdd(a, b));
        }
    }
}