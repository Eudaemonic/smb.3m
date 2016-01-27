using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace smb._3m
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ClearText();

            richTextBox1.Text = @"Get the Trace1 or Trace2 file from C:\ProgramData\3M Library Systems\Logs directory";
        }

        private string MyDocuments()
        {

            string result = (string)Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToString();
     
           return result;

        }

        public string ReadFileSelfReturn(string FileLocation)
        {
            List<stat> hs = new List<stat>();
        

            var result = "";

           using( StreamReader sr = new StreamReader(FileLocation))
           {
               while ((result = sr.ReadLine()) != null)
	                {
                            if(result.Contains("|AB"))
                            {
                                var x = new stat();

                                var line = (result.IndexOf("|AB") + 3);

                                var raw = result.Remove(0, line);

                                var end = raw.IndexOf("|");

                                raw = raw.Remove(end);

                                x.item = raw;

                                x.type = "return";

                                x.date = ReturnDate(result);

                                x.user = "No user on return";

                              
                                hs.Add(x);
                             

                            }
		                    
	                }

           }

           var processedFile = MyDocuments() + "\\self-return-processed" + DateTime.Now.ToFileTime().ToString() + ".txt"; ;

          StreamWriter sw = new StreamWriter(processedFile);

           foreach (var item in hs)
           {
               sw.WriteLine(item.date + "," + item.type + "," + item.user + "," + item.item);
           }

           sw.Close();


            return processedFile;
        }

        private string ReturnDate(string line)
        {

            var end = (line.IndexOf("-") - 1);

            return line.Remove(end);

        }


        //Self Issue
        public string ReadFileSelfIssue(string FileLocation)
        {

            List<stat> hs = new List<stat>();

            var result = "";

            using (StreamReader sr = new StreamReader(FileLocation))
            {
                while ((result = sr.ReadLine()) != null)
                {
                    
                   //User

                 
                        //Issue Book
                        if (result.Contains("|AA") && result.Contains("|AB"))
                        {


                            var x = new stat();

                            var line = (result.IndexOf("|AA") + 3);

                            var raw = result.Remove(0, line);

                            var end = raw.IndexOf("|");

                            raw = raw.Remove(end);

                            x.user = raw;

                            //Item

                            var line2 = (result.IndexOf("|AB") + 3);

                            var raw2 = result.Remove(0, line2);

                            var end2 = raw2.IndexOf("|");

                            raw2 = raw2.Remove(end);

                            x.item = raw2;

                            x.type = "issue";

                            x.date = ReturnDate(result);

                            if (hs.Any(m => m.item == x.item) == false)
                            {
                                hs.Add(x);
                            }


                        }

                        if (result.Contains("|AB") && !result.Contains("|AA"))
                        {

                            var x = new stat();

                            var line = (result.IndexOf("|AB") + 3);

                            var raw = result.Remove(0, line);

                            var end = raw.IndexOf("|");

                            raw = raw.Remove(end);

                            x.item = raw;

                            //Item

                            x.user = "null";

                            x.type = "renewal";

                            x.date = ReturnDate(result);

                            if (hs.Any(m => m.item == x.item) == false)
                            {
                                hs.Add(x);
                            }

                        }
 

                }

            }

            var processedFile = MyDocuments() + "\\self-issue-processed" + DateTime.Now.ToFileTime().ToString() + ".txt";

            StreamWriter sw = new StreamWriter(processedFile);

            foreach (var item in hs)
            {
                sw.WriteLine(item.date + "," + item.type + "," + item.user + "," + item.item);
            }

            sw.Close();


            return processedFile;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ClearText();

            if (rbSelfIssue.Checked && !string.IsNullOrEmpty(txtFile.Text))
            {
                AddLink(ReadFileSelfIssue(txtFile.Text));
            }


            if (rbSelfReturns.Checked && !string.IsNullOrEmpty(txtFile.Text))
            {
                AddLink(ReadFileSelfReturn(txtFile.Text));
            }
            if (rbSelfIssue.Checked == false && rbSelfReturns.Checked == false)
            {
                label1.Text = "Select a process";
            }
            if (string.IsNullOrEmpty(txtFile.Text))
            {
                label1.Text = "Select a File";
            }
            
        }

        public class stat
        {
            public string date { get; set; }
            public string type {get; set;}
            public string user { get; set; }
            public string item { get; set; }

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void btnOpenFIle_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
           
            od.InitialDirectory = MyDocuments();
                od.Filter = "txt files (*.txt)|* .txt|All files (*.*)|*.*";
                od.FilterIndex = 2;
                od.RestoreDirectory = true;

                od.ShowDialog();

                txtFile.Text = od.FileName;
                
        }

        public void AddLink(string linkToAdd)
        {
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = linkToAdd;
            linkLabel1.Links.Add(link);
            linkLabel1.Text = linkToAdd;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Send the URL to the operating system.
            Process.Start(e.Link.LinkData as string);
        }
        private void ClearText()
        {
            label1.Text = label1.Text = "";
            linkLabel1.Text = "";
            linkLabel1.Links.Clear();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
