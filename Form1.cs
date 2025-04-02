using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace URL_Dumper
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private int scannedCount1 = 0;
        private int scannedCount2 = 0;
        private volatile int stopScanner = 0;
        private string LoadTXTFile = null;
        private ConcurrentBag<string> accessibleUrls = new ConcurrentBag<string>();
        private Stopwatch stopwatch1 = new Stopwatch();
        private Stopwatch stopwatch2 = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            DisplaySubdomains.Visible = false;
            DisplaySubdirectories.Visible = false;
            StopBtn.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string url = urlInput.Text.Trim();
            if (!url.EndsWith("/"))
            {
                url += "/";
            }
            string rootDomain = GetRootDomain(url);

            if (string.IsNullOrEmpty(rootDomain))
            {
                MessageBox.Show("Invalid URL. Please enter a valid domain.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] subdomains;
            int totalSubdomains;

            if (string.IsNullOrEmpty(LoadTXTFile))
            {
                subdomains = Properties.Resources.Subdomain.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            }
            else
            {
                subdomains = File.ReadAllLines(LoadTXTFile); 
            }

            totalSubdomains = subdomains.Length; 

            scannedCount1 = 0;
            scannedCount2 = 0;
            stopScanner = 0;

            Invoke(new Action(() =>
            {
                label3.Visible = true;
                DisplaySubdomains.Visible = true;
                DisplaySubdirectories.Visible = true;
                StopBtn.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
            }));

            stopwatch1.Restart();
            stopwatch2.Restart();

            await Task.WhenAll(
                Task.Run(() => CheckSubdomains(rootDomain, subdomains, totalSubdomains)),
                Task.Run(() => CheckSubdirectories(url, subdomains, totalSubdomains))
            );
        }

        private async void CheckSubdirectories(string url, string[] subdomains, int totalSubdomains)
        {
            foreach (var subdomain in subdomains)
            {
                if (stopScanner == 1)
                {
                    Invoke(new Action(() =>
                    {
                        label6.Text = "(0 out of 0)";
                        DisplaySubdirectories.Text = "";
                    }));

                    break;
                }


                string fullUrl = $"{url}{subdomain.ToLower()}";

                if (await IsUrlAccessible(fullUrl))
                {
                    accessibleUrls.Add(fullUrl);

                    Invoke(new Action(() =>
                    {
                        if (!DisplaySubdirectories.Text.Contains(fullUrl))
                        {
                            DisplaySubdirectories.AppendText(fullUrl + Environment.NewLine);
                        }
                    }));
                }


                Interlocked.Increment(ref scannedCount2);
                UpdateETC(stopwatch2, scannedCount2, totalSubdomains, label8);
                Invoke(new Action(() =>
                {
                    label6.Text = $"({scannedCount2} out of {totalSubdomains}) URL: {fullUrl}";
                }));
            }
        }

        private async void CheckSubdomains(string rootDomain, string[] subdomains, int totalSubdomains)
        {
            foreach (var subdomain in subdomains)
            {
                if (stopScanner == 1)
                {
                    Invoke(new Action(() =>
                    {
                        label3.Text = "(0 out of 0)";
                        DisplaySubdomains.Text = "";
                    }));

                    break;
                }


                string fullUrl = $"https://{subdomain.ToLower()}.{rootDomain}";

                if (await IsUrlAccessible(fullUrl))
                {
                    accessibleUrls.Add(fullUrl);

                    Invoke(new Action(() =>
                    {

                        if (!DisplaySubdomains.Text.Contains(fullUrl))
                        {
                            DisplaySubdomains.AppendText(fullUrl + Environment.NewLine);
                        }
                    }));
                }

                Interlocked.Increment(ref scannedCount1);
                UpdateETC(stopwatch1, scannedCount1, totalSubdomains, label7);
                Invoke(new Action(() =>
                {
                    label3.Text = $"({scannedCount1} out of {totalSubdomains}) URL: {fullUrl}";
                }));
            }
        }

        private async Task<bool> IsUrlAccessible(string url)
        {
            using (HttpClientHandler handler = new HttpClientHandler { AllowAutoRedirect = false })
            using (HttpClient client = new HttpClient(handler))
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    HashSet<int> redirectStatusCodes = new HashSet<int> { 300, 301, 302, 303, 307, 308 };

                    if (redirectStatusCodes.Contains((int)response.StatusCode))
                    {
                        return false;
                    }

                    HashSet<int> successStatusCodes = new HashSet<int> { 200, 201, 202, 204, 403 };
                    return successStatusCodes.Contains((int)response.StatusCode);
                }
                catch (Exception ex)
                {
                    return false; 
                }
            }
        }

        private string GetRootDomain(string url)
        {
            try
            {
                Uri uri = new Uri(url);
                string host = uri.Host;
                Match match = Regex.Match(host, @"([a-zA-Z0-9-]+\.(?:co\.)?[a-zA-Z]+)$");
                return match.Success ? match.Groups[1].Value : null;
            }
            catch
            {
                return null;
            }
        }

        private void UpdateETC(Stopwatch stopwatch, int scanned, int total, Label label)
        {
            if (scanned == 0) return;

            double elapsedSeconds = stopwatch.Elapsed.TotalSeconds;
            double estimatedTotalTime = (elapsedSeconds / scanned) * total;
            double remainingTime = estimatedTotalTime - elapsedSeconds;

            if (remainingTime < 0) remainingTime = 0;

            TimeSpan etcTime = TimeSpan.FromSeconds(remainingTime);

            string formattedETC;
            if (etcTime.TotalHours >= 1)
                formattedETC = $"ETC: {etcTime.Hours}h {etcTime.Minutes}m {etcTime.Seconds}s";
            else if (etcTime.TotalMinutes >= 1)
                formattedETC = $"ETC: {etcTime.Minutes}m {etcTime.Seconds}s";
            else
                formattedETC = $"ETC: {etcTime.Seconds}s";

            Invoke(new Action(() =>
            {
                label.Text = formattedETC;
            }));
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            Interlocked.Exchange(ref stopScanner, 1);

            Invoke(new Action(() =>
            {
                DisplaySubdirectories.Clear();
                DisplaySubdomains.Clear();
                urlInput.Clear();
                label6.Text = "(0 out of 0)";
                label8.Text = "ETC: 0h 0m 0s";
                label3.Text = "(0 out of 0)";
                label7.Text = "ETC: 0h 0m 0s";
                LoadFile.Text = "Load Wordlist (Optional)";
                LoadTXTFile = null;
            }));
        }

        private void LoadFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt"; 
                openFileDialog.Title = "Select a Text File";

                if (openFileDialog.ShowDialog() == DialogResult.OK) 
                {
                    LoadTXTFile = openFileDialog.FileName;
                    LoadFile.Text = System.IO.Path.GetFileName(openFileDialog.FileName); 
                }
            }
        }

    }
}