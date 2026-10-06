using System.Net;
using System.Text;

namespace EntryToNetwork_5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnFetch_Click_1(object sender, EventArgs e)
        {
            string uri = txtUri.Text;

            if (string.IsNullOrWhiteSpace(uri))
            {
                MessageBox.Show("Будь ласка, введіть URI.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string result = await client.GetStringAsync(uri);
                    txtResult.Text = result;
                }

                //HttpListener listener = new HttpListener();
                //listener.Prefixes.Add(uri);
                //listener.Start();
                //
                //while (true)
                //{
                //    HttpListenerContext context = await listener.GetContextAsync();
                //    HttpListenerRequest request = context.Request;
                //
                //    //Console.WriteLine($"Отримано запит: {request.Url}");
                //    //string result = await client.GetStringAsync(uri);
                //    //txtResult.Text = result;
                //
                //    string responseString = "<h1>Hello, HTTP!</h1>";
                //    byte[] buffer = Encoding.UTF8.GetBytes(responseString);
                //
                //    HttpListenerResponse response = context.Response;
                //    response.ContentLength64 = buffer.Length;
                //    response.ContentType = "text/html; charset=utf-8";
                //
                //    await response.OutputStream.WriteAsync(buffer, 0, buffer.Length);
                //    response.Close();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка при запиті:\n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
