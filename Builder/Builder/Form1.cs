using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Builder
{
    public partial class Form1 : Form
    {
        private const string STUB_PATH = "Stub.exe";
        private const string MARKER = "<DATA>";

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        class Config
        {
            public string Message { get; set; }
            public int Number { get; set; }
            public bool Flag { get; set; }
            public string Color { get; set; }
        }

        private void build_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string stubFullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, STUB_PATH);

                if (!File.Exists(stubFullPath))
                {
                    MessageBox.Show("Stub.exe not found in application directory.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string message = string_TextBox.Text;
                if (string.IsNullOrWhiteSpace(message))
                    message = null;

                int.TryParse(integer_TextBox.Text, out int number);

                bool flag = boolean_Checkbox.Checked;

                string color = color_TextBox.Text;
                if (string.IsNullOrWhiteSpace(color))
                    color = null;

                var config = new Config
                {
                    Message = message,
                    Number = number,
                    Flag = flag,
                    Color = color
                };

                string json = JsonConvert.SerializeObject(config,
                    Formatting.None,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });

                byte[] jsonBytes = Encoding.UTF8.GetBytes(json);
                byte[] markerBytes = Encoding.UTF8.GetBytes(MARKER);
                byte[] lengthBytes = BitConverter.GetBytes(jsonBytes.Length);

                string outputPath = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    $"Output_{DateTime.Now.Ticks}.exe"
                );

                File.Copy(stubFullPath, outputPath, true);

                using (FileStream fs = new FileStream(outputPath, FileMode.Append, FileAccess.Write))
                {
                    fs.Write(markerBytes, 0, markerBytes.Length);
                    fs.Write(lengthBytes, 0, lengthBytes.Length);
                    fs.Write(jsonBytes, 0, jsonBytes.Length);
                }

                MessageBox.Show("Build completed successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Build failed:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
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