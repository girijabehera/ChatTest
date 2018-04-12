using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBGChatNLPDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// https://stackoverflow.com/questions/275836/multiple-colors-in-a-c-sharp-net-label
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <returns></returns>
        private string format_text(string input, string output)
        {
            string parsedData = string.Empty;
            parsedData = "INPUT: " + input + System.Environment.NewLine + System.Environment.NewLine;
            parsedData = parsedData + "ZIPLINE DATA: " + output;
            parsedData = parsedData + System.Environment.NewLine + System.Environment.NewLine + "-----------------------------------------------------------------";
            return parsedData;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //string result = run_cmd("@C:/Python26/python.exe", "C://Python26//test.py 100");
            string parsed = format_text(txtChat.Text, "parsed data");
            lblProcessedData.Text = lblProcessedData.Text + System.Environment.NewLine + parsed;

        }

        private string run_cmd(string cmd, string args)
        {
            string result = "parsed Text";
            //ProcessStartInfo start = new ProcessStartInfo();
            //start.FileName = cmd;//cmd is full path to python.exe | @C:/Python26/python.exe
            //start.Arguments = args;//args is path to .py file and any cmd line args | C://Python26//test.py 100
            //start.UseShellExecute = false;
            //start.RedirectStandardOutput = true;
            //using (Process process = Process.Start(start))
            //{
            //    using (StreamReader reader = process.StandardOutput)
            //    {
            //        result = reader.ReadToEnd();
            //    }
            //}

            return result;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblProcessedData.ResetText();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
