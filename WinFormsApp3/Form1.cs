using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Newtonsoft.Json;


namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        public static void SendWebhook(string url, string message, string username, string avatarUrl)
        {
            try
            {


                var content = new
                {
                    content = message,
                    username = username,
                    avatar_url = avatarUrl,


                };

                string response = string.Empty;
                string json = JsonConvert.SerializeObject(content);

                using (var client = new WebClient())
                {

                    client.Headers[HttpRequestHeader.ContentType] = "application/json";
                    client.UploadString(url, "POST", json);
                }
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("error pls enter the info for webhook");
            }


        }
        public static async Task DeleteWebhook(string url)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.DeleteAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Webhook deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show($"Failed to delete webhook. Status code: {response.StatusCode}");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("pls Enter The webhook");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string webhookUrl = textBox6.Text;
                string textMessage = textBox4.Text;
                string username = textBox5.Text;
                string avatarUrl = textBox3.Text;





                SendWebhook(webhookUrl, textMessage, username, avatarUrl);

            }
            catch (Exception)
            {

                MessageBox.Show("error pls enter the info for webhook");
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string webhookUrl = textBox6.Text;
                DeleteWebhook(webhookUrl);
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Please enter the webhook URL to delete.");
            }
        }
    }

    //my discord 9y_d
    //my instagram malhajr411
    //Enjoy
}







