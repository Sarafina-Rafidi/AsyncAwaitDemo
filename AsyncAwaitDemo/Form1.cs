using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int CountCharacters()
        {
            int count = 0;
            using(StreamReader reader = new StreamReader("C:\\Data.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);
            }

            return count;
        }


        //private void btnProcessFile_Click(object sender, EventArgs e)
        //{
        //    lblCount.Text = "Processing File. Please wait.....";
        //    int count = CountCharacters();    //this is going to process the file
        //    lblCount.Text = count.ToString() + " characters in the file";
        //}


        private async void btnProcessFile_Click(object sender, EventArgs e)
        {
            //use Task to call the CountCharacters method which takes a bit of time to execute
            //and that is why we are offloading that responsibility to this Task
            //while the task is executing the function the UI is free
            //and user will be able to interact with the form
            Task<int> task = new Task<int>(CountCharacters);
            task.Start();

            lblCount.Text = "Processing File. Please wait.....";

            //when the application has reach this point,
            //we have to wait for the Task to complete
            //so to signal that we are going to use the await keyword
            int count = await task;    //this is going to process the file
            lblCount.Text = task.ToString() + " characters in the file";
        }


    }
}