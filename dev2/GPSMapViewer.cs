using System;
using System.Diagnostics;
using System.IO.Ports;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace dev2
{
    public partial class GPSMapViewer : Form
    {
        private SerialPort serialPort;
        private ChromiumWebBrowser browser;

        private double lastLat = 0;
        private double lastLon = 0;
        private Timer mapTimer;

        public GPSMapViewer()
        {
            InitializeComponent();
        }


        private void MapTimer_Tick(object sender, EventArgs e)
        {
            if (lastLat != 0 && lastLon != 0)
            {
                string url = $"https://www.google.com/maps/search/?api=1&query={lastLat},{lastLon}";
                browser.Load(url);
            }
        }

        private void GPSMapViewer_Load(object sender, EventArgs e)
        {
          
            ComChoice.Items.AddRange(SerialPort.GetPortNames());

          
            Cef.Initialize(new CefSettings());

            browser = new ChromiumWebBrowser("https://www.google.com/maps");
            browser.Dock = DockStyle.Fill;

        
            pnlBrowser.Controls.Add(browser);

            mapTimer = new Timer();
            mapTimer.Interval = 3000; 
            mapTimer.Tick += MapTimer_Tick;
            mapTimer.Start();
        }

        
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (ComChoice.SelectedItem == null)
            {
                MessageBox.Show("Sélectionnez un port COM.");
                return;
            }

            try
            {
                serialPort = new SerialPort(ComChoice.SelectedItem.ToString(), 9600);
                serialPort.DataReceived += SerialPort_DataReceived;
                serialPort.Open();

                MessageBox.Show("Port ouvert!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message);
            }
        }

      
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadLine();

           
            if (this.IsHandleCreated)
            {
                this.Invoke(new Action(() =>
                {
                    rtbData.AppendText(data + "\n");

                    string[] parts = data.Split(',');

                    if (parts.Length > 5 && parts[0] == "$GPGGA")
                    {
                        try
                        {
                            string rawLat = parts[2];
                            string latDir = parts[3];
                            string rawLon = parts[4];
                            string lonDir = parts[5];

                            double latitude = ConvertToDecimal(rawLat, latDir);
                            double longitude = ConvertToDecimal(rawLon, lonDir);

                           
                            rtbData.AppendText($"--> LAT: {latitude} | LON: {longitude}\n");

                            if (latitude != 0 && longitude != 0)
                            {
                                string url = $"https://www.google.com/maps/search/?api=1&query={lastLat},{lastLon}"; lastLat = latitude;
                                lastLon = longitude;
                            }
                        }
                        catch
                        {
                        }
                    }
                }));
            }
        }

        
        private double ConvertToDecimal(string value, string direction)
        {
            if (string.IsNullOrEmpty(value)) return 0;

            double val = double.Parse(value, System.Globalization.CultureInfo.InvariantCulture);

            double degrees = Math.Floor(val / 100);
            double minutes = val - (degrees * 100);
            double decimalDegrees = degrees + (minutes / 60);

            if (direction == "S" || direction == "W")
                decimalDegrees *= -1;
            Debug.WriteLine(decimalDegrees);
            return decimalDegrees;
        }

        
    }
}