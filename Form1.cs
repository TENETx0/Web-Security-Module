using System;
using System.Diagnostics;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Windows.Forms;
using System.Linq;
using System.Management;

namespace SecurityModule
{
    public partial class Form1 : Form
    {
        private GroupBox SysInfo;

        public Form1()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            // Disable button1 until checkbox is clicked
            button1.Enabled = false;

            // Set up Terms and Conditions Text
            richTextBox1.Text = GetTermsAndConditions();
            richTextBox1.ReadOnly = true;
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;

            // Hook Checkbox event
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



        private async void label2_Click(object sender, EventArgs e)


        {
            // Show pre-loader first
            label2.Text = "Fetching System Information...";
            await Task.Delay(100); // 1 second delay to simulate loading

            // Initialize variables
            string machineName = Environment.MachineName;
            string userName = Environment.UserName;
            string osVersion = Environment.OSVersion.VersionString;
            string is64Bit = Environment.Is64BitOperatingSystem ? "64-bit" : "32-bit";
            string osName = "Unknown OS";
            string architecture = "Unknown Architecture";

            try
            {
                // Retrieve OS details using WMI
                using (var searcher = new System.Management.ManagementObjectSearcher("SELECT Caption, OSArchitecture FROM Win32_OperatingSystem"))
                {
                    foreach (System.Management.ManagementObject os in searcher.Get())
                    {
                        osName = os["Caption"]?.ToString() ?? "Unknown OS";
                        architecture = os["OSArchitecture"]?.ToString() ?? "Unknown Architecture";
                    }
                }
            }
            catch (Exception ex)
            {
                osName = "Error fetching OS Name: " + ex.Message;
            }

            // Format the information
            string osInfo = $"Machine Name     : {machineName}\n" +
                            $"User Name        : {userName}\n" +
                            $"Operating System : {osName}\n" +
                            $"OS Version       : {osVersion}\n" +
                            $"Architecture     : {architecture}\n" +
                            $"System Type      : {is64Bit}";

            // Display the final OS Information
            label2.Text = osInfo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                MessageBox.Show("You must agree to the Terms and Conditions before proceeding.", "Agreement Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Terms Accepted. Proceeding to testing modules.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Open PenTest form
            PenTest pentestForm = new PenTest();
            pentestForm.Show();

            // Optional: hide the current form if you want
            this.Hide();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = checkBox1.Checked;
        }

        private string GetTermsAndConditions()
        {
            return @"Terms and Conditions:

- You must have authorization to perform penetration testing.

- Unauthorized access is illegal and punishable under law.

- The developer is not responsible for misuse of this tool.

- You agree not to target public networks without explicit permission.

- Scans may cause service disruption or detection by firewalls.

- Proceed only if you accept full responsibility for your actions.";
        }

        private async void label3_Click_1(object sender, EventArgs e)
        {
            label3.Text = "Scanning Frameworks Running...";
            await Task.Delay(1000); // 1 second delay to simulate loading

            try
            {
                // Fetch running processes
                var processes = Process.GetProcesses();

                // Filter frameworks related processes
                var frameworkProcesses = processes
                    .Where(p => p.ProcessName.Contains("dotnet", StringComparison.OrdinalIgnoreCase) ||
                                p.ProcessName.Contains("java", StringComparison.OrdinalIgnoreCase) ||
                                p.ProcessName.Contains("python", StringComparison.OrdinalIgnoreCase) ||
                                p.ProcessName.Contains("node", StringComparison.OrdinalIgnoreCase) ||
                                p.ProcessName.Contains("php", StringComparison.OrdinalIgnoreCase) ||
                                p.ProcessName.Contains("perl", StringComparison.OrdinalIgnoreCase))
                    .OrderBy(p => p.ProcessName)
                    .Select(p => $"{p.ProcessName.PadRight(25)} PID: {p.Id}")
                    .ToList();

                // Check if any framework found
                if (frameworkProcesses.Count == 0)
                {
                    label3.Text = "No major frameworks are currently running.";
                }
                else
                {
                    // Build display text
                    string result = "Framework Processes Running:\n\n" + string.Join("\n", frameworkProcesses);

                    label3.Text = result;
                }
            }
            catch (Exception ex)
            {
                label3.Text = "Error fetching framework processes: " + ex.Message;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
