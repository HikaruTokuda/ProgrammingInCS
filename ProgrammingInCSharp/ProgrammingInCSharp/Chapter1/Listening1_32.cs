#define LISTENING1_34

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

/// <summary>
/// Listening1_32～33
/// The act of loading a web page may fail because the server is offline or the URL is incorrect.
/// The FetchWebPage method will throw an exception in this situation.
/// It is very important to note that exceptions can only be caught in this way because the 
/// FetchWebPage method returns a result.
/// It is possible to creatae an  async method of type void that does not return a value.
/// 
/// Listening1_34
/// An async method can contaion a anumber of await method.
/// These will be completed in sequence. In other words, if you want to create an "awaitable" task that returns
/// when a number of parallel tasks have completetd you can use the Task.WhenAll method to create a task
/// that completes when a given lists of tasks have been completed.
/// </summary>
namespace ProgrammingInCSharp.Chapter1
{
    public partial class Listening1_32 : Form
    {
        public Listening1_32()
        {
            InitializeComponent();
        }

        private async Task<string> FetchWebPage(string url)
        {
            HttpClient httpClient = new HttpClient();
            return await httpClient.GetStringAsync(url);
        }

        async Task<IEnumerable<string>> FetchWebPages(string[] urls)
        {
            var tasks = new List<Task<String>>();

            foreach (string url in urls)
            {
                tasks.Add(FetchWebPage(url));
            }

            return await Task.WhenAll(tasks);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ResultTextBlock.Text = await FetchWebPage(URLTextBox.Text);
                StatusTextBox.Text = "Page Loaded";
            }
            catch(Exception ex)
            {
                StatusTextBox.Text = ex.Message;
            }
        }
    }
}
