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

namespace Asg2_Analytics
{
   
    public partial class Form1 : Form
    {
       
        int reccount = 0;
        int timesum = 0;
        int intersum = 0;
        int maxtime = 0;
        int mintime = 9999;
        int mininter = 9999;
        int mxinter = 0;
        int bcount;
        
        DateTime prev;
        DateTime firstrecstart;
        public  string filename = "Default";


        string path;


        public void calculations(DateTime x,DateTime y)
        {   
            if(timesum==0)
            {
                firstrecstart = x;
            }
            int entry_time_min= (y - x).Minutes;
            int entry_time_sec = (y - x).Seconds;
           int entry_time =((entry_time_min * 60) + entry_time_sec);
            timesum = timesum + ((entry_time_min * 60) + entry_time_sec);
            
            if (entry_time > maxtime)
                maxtime = entry_time;
            if (entry_time < mintime)
                mintime = entry_time;
            if (reccount > 0)
            {
                int inter_rec_min = ((x - prev).Minutes);
                int inter_rec_sec = ((x - prev).Seconds);
                int inter_rec = (inter_rec_min * 60) + inter_rec_sec;
                intersum = intersum + inter_rec;
                if (inter_rec > mxinter)
                    mxinter = inter_rec;
                if (inter_rec < mininter)
                    mininter = inter_rec;
            }

            prev = y;
   
        }

        string conversion(int secs)
        {
            int min = secs / 60;
            int sec = secs % 60;
            string op = min.ToString() + ":" + sec.ToString();
            return op;
        }
        string conversions(int min, int sec)
        {

            string op = min.ToString() + ":" + sec.ToString();
            return op;
          
        }
        public void pull()
        {
            NoOfRecord.Text = reccount.ToString();

            MinEntry.Text = conversion(mintime);
            MaxEntry.Text = conversion(maxtime);
            int avgentry = timesum / reccount;
            AvgEntry.Text = conversion(avgentry);
            Min_Inter.Text = conversion(mininter);
            MaxInter.Text = conversion(mxinter);
            int avginter = intersum/reccount;
            AvgInter.Text = conversion(avginter);
            int totaltimem = (prev - firstrecstart).Minutes;
            int totaltimes = (prev - firstrecstart).Seconds;
            Total_Time.Text = conversions(totaltimem, totaltimes);
            BackSpaceCount.Text = bcount.ToString();
            write();
        }

        public void write()
        {
            filename = fname.Text;
            if (fname.Text == "")
            {
                fname.Text = "Default";
            }
            path = Application.StartupPath + "\\" + filename + ".txt";
            StreamWriter strm = File.CreateText(@path);
            strm.Flush();
            strm.Close();
            DateTime savetime = DateTime.Now;


            try
            {
                using (System.IO.StreamWriter write = System.IO.File.AppendText(path))
                {

                    
                    {
                      
                        write.WriteLine("Number of records: "+reccount.ToString());
                        write.WriteLine("Minimum entry time: "+ conversion(mintime));
                        write.WriteLine("Maximum entry time: " + conversion(maxtime));
                        write.WriteLine("Average entry time: " + conversion(intersum / reccount));
                        write.WriteLine("Minimum inter-record time: "+conversion(mininter));
                        write.WriteLine("Maximum inter-record time: " + conversion(mxinter));
                        write.WriteLine("Average inter-record time: " + conversion(intersum / reccount));
                        int totaltimem = (prev - firstrecstart).Minutes;
                        int totaltimes = (prev - firstrecstart).Seconds;
                        write.WriteLine("Total time: " + conversions(totaltimem, totaltimes));
                        write.WriteLine("Backspace count: "+bcount.ToString());
                       
                    }
                    //write.WriteLine("Save Pressed at " + savetime);
                    //write.WriteLine("First key Pressed at " + currtime);
                    //write.WriteLine("Backspaces Pressed: " + backcount);
                }
            }
            catch (Exception f)
            {
                Console.Write(f);
            }


        }

        public void read(String path)
        {
           
            string line;

            if (!File.Exists(path))
            {
                using (FileStream strm = File.Create(path))
                {

                }

            }


            System.IO.StreamReader file =
       new System.IO.StreamReader(@path);

            var lineCount = File.ReadLines(path).Count();
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split('|');
                {

                    
                    DateTime firstfield = Convert.ToDateTime(words[13]);
                    DateTime lastfield = Convert.ToDateTime(words[14]);
                    string backspcount = words[15];
                     bcount =bcount + Convert.ToInt32(backspcount);
                    calculations(firstfield, lastfield);
                    reccount++;
                    //add(words[0] + " " + words[2], words[9]);
                }
                lineCount = lineCount - 1;
            }
            file.Close();
            pull();

        }//read function to be reference in Progr
    
    
        public Form1()
        {
            InitializeComponent();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
          
            filename = fname.Text;
            if(fname.Text=="")
            {
                fname.Text = "Default";
            }
            path = Application.StartupPath + "\\" + filename + ".txt";
            

            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                
                string path = openFileDialog1.FileName;
                try
                {
                    //operations op = new operations();
                    read(path);
                    
                    
                }
                catch (IOException)
                {
                }


            }
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
    

}
