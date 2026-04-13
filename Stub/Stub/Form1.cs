using System;
using System.Drawing;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Stub
{
    public partial class Form1 : Form
    {
        private const string MARKER = "<DATA>";

        public Form1()
        {
            InitializeComponent();

            toolTip1.SetToolTip(title1_Label, "String value provided by builder and displayed in UI.");
            toolTip1.SetToolTip(title2_Label, "Integer value provided by builder and used in UI logic.");
            toolTip1.SetToolTip(title3_Label, "Boolean flag controlling UI state (enabled/disabled).");

            LoadConfiguration();
        }

        class Config
        {
            public string Message { get; set; }
            public int Number { get; set; }
            public bool Flag { get; set; }
            public string Color { get; set; }
        }

        private void LoadConfiguration()
        {
            try
            {
                string exePath = Application.ExecutablePath;
                byte[] fileBytes = File.ReadAllBytes(exePath);

                byte[] markerBytes = Encoding.UTF8.GetBytes(MARKER);

                int markerIndex = FindMarker(fileBytes, markerBytes);
                if (markerIndex < 0)
                {
                    SetStatus("Config not found in executable.");
                    return;
                }

                int lengthStart = markerIndex + markerBytes.Length;

                if (lengthStart + 4 > fileBytes.Length)
                {
                    SetStatus("Invalid config length header.");
                    return;
                }

                int dataLength = BitConverter.ToInt32(fileBytes, lengthStart);

                if (dataLength <= 0 || lengthStart + 4 + dataLength > fileBytes.Length)
                {
                    SetStatus("Corrupted or invalid config data.");
                    return;
                }

                int dataStart = lengthStart + 4;

                byte[] jsonBytes = new byte[dataLength];
                Array.Copy(fileBytes, dataStart, jsonBytes, 0, dataLength);

                string json = Encoding.UTF8.GetString(jsonBytes);

                Config config = JsonConvert.DeserializeObject<Config>(json);

                if (config == null)
                {
                    SetStatus("Failed to parse configuration.");
                    return;
                }

                ApplyConfiguration(config);
            }
            catch (JsonException)
            {
                SetStatus("Configuration format error (invalid JSON).");
            }
            catch (IOException ex)
            {
                SetStatus("File access error: " + ex.Message);
            }
            catch (Exception ex)
            {
                SetStatus("Unexpected error: " + ex.Message);
            }
        }

        private void ApplyConfiguration(Config config)
        {
            try
            {
                string_Label.Text = config.Message;
                integer_Label.Text = config.Number.ToString();
                button.Enabled = config.Flag;

                if (!string.IsNullOrWhiteSpace(config.Color))
                    panel1.BackColor = Color.FromName(config.Color);
            }
            catch (Exception ex)
            {
                SetStatus("UI update error: " + ex.Message);
            }
        }

        private void SetStatus(string message)
        {
            this.Text = message;
        }

        private int FindMarker(byte[] data, byte[] marker)
        {
            for (int i = 0; i <= data.Length - marker.Length; i++)
            {
                bool match = true;

                for (int j = 0; j < marker.Length; j++)
                {
                    if (data[i + j] != marker[j])
                    {
                        match = false;
                        break;
                    }
                }

                if (match)
                    return i;
            }

            return -1;
        }

        private void exit_Label_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Label_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}