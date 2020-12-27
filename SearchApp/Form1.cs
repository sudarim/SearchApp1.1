using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using System.Windows;
using System.Threading;
using System.Timers;

namespace SearchApp
{
    public partial class Form1 : Form
    {
        public BackgroundWorker bgWorker = null;
        
      

        private Searcher searcher;

        System.Windows.Forms.Timer timer1;
        DateTime time;
        DateTime timeStart;
        double timePassed;
        DateTime timePause;
        double timePending;












        public Form1()
                                                        {
                                                            InitializeComponent();

            
                                                            buttonPause.Enabled = false;
                                                            resetBut.Enabled = false;
            
                                                            searcher = new Searcher(null, null);
            

                                                            searcher.OnFound += Found;
                                                            searcher.OnPrintTree += TreePrinterMethod;
                                                                 
                                                                        

                                                            


                                                            searcher.OnFilesProcessed += FilesProcessed;
                                                            searcher.OnFoundFilesUpdate += FoundFilesUpdate;

                                                            searcher.OnGetCurrentPath += CurrentDirectory;

            
                                                            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
                                                                 


                                                        }

        private void PrintTime(System.Diagnostics.Stopwatch watch)
        {
            timeElapsed.Text = watch.ElapsedMilliseconds.ToString();
        }

        private void TreePrinterMethod(string s)
        {
            treeView1.BeginInvoke((Action)delegate ()
           {
               TreeBuilder.CreatePath(treeView1.Nodes, s);
           });

        }

        private void CurrentDirectory(string path)
                                        {
                                            currentD.BeginInvoke((Action)delegate ()
                                          {
                                              currentD.Text = path;
                                          });
                                        }



                                private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
                                {
                                    throw new NotImplementedException();
                                }

                            private void FilesProcessed(int i)
                            {
                                label3.BeginInvoke((Action)delegate ()
                              {
                                  label3.Text = "Files processed: " + i;
                              });
                            }



                                    void FoundFilesUpdate(int i)
                                    {
                                        filesFoundLabel.BeginInvoke((Action)delegate ()
                                        {
                                            filesFoundLabel.Text = "Files found:" + i;
                                        });
                                    }


                                                                void Found(string path)
                                                                {
                                                                    listBox1.BeginInvoke((Action)delegate () {
                                                                        listBox1.Items.Add(path);
                                                                    });


                                                                }

                                                    void WorkerDone(object sender, RunWorkerCompletedEventArgs e)
                                                    {

                                                           
                                                            MessageBox.Show("Done");
            
                                                        TreeBuilder.PrintList();
                                                           
                                                            buttonPause.Enabled = false;
                                                         resetBut.Enabled = true;
                                                         
                                                           

        }



                                                void WorkInBackGround(object sender, DoWorkEventArgs e)    
                                                {
                                                        


                                                    searcher.Search();

                   
                                                    searcher._busy.WaitOne();
                                                    if (bgWorker.CancellationPending)
                                                    {
                                                        e.Cancel = true;
                                                        return;
                                                    }

                                                }



                                                           

                                                void StartWorker()
                                                {


                                                   
                                                    if (!bgWorker.IsBusy)
                                                    {

                                                        bgWorker.RunWorkerAsync();
                                                                
                                                    }

                                                    stat.Text = "<<<IN PROGRESS>>>";

                                                    searcher._busy.Set();                            
           
                                                }


                                                            void PauseWorker()
                                                            {
                                                                                
                                                                searcher._busy.Reset();     

                                                                stat.Text= "<<<PAUSED>>>";
        }











        void Resetter()
                            {
                                if (bgWorker.IsBusy)
                                {
                                    if (!searcher._stop)
                                    {
                    
                                          searcher._stop = true;
                    
                                                 searcher.FIlesFound = 0;
                                        searcher.FilesProcessed = 0;
                                         
                }
                                        bgWorker.CancelAsync();
                                         

                                        searcher._busy.Set();

           
                                    

                                    stat.Text = "<<<PENDING>>>";
                                    buttonRun.Enabled = true;
                                    buttonPause.Enabled = false;

                                }

                            }







                        








                    private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
                    {
                        UserData.SearchDir = tbSearchDir.Text;
                        UserData.FileName = tbFN.Text;

                        UserData.Save();

                    }

                   

        private void buttonRun_Click_1(object sender, EventArgs e)
        {



            timePending = 0;
            timer1 = new System.Windows.Forms.Timer();
            
            timer1.Enabled = true;
            timer1.Tick += new System.EventHandler(OnTimerEvent);
            

            resetBut.Enabled = false;
            buttonPause.Enabled = true;
            buttonRun.Enabled = false;
            bgWorker = new BackgroundWorker();
           
            bgWorker.WorkerSupportsCancellation = true;
           
            bgWorker.WorkerReportsProgress = true;
            
            bgWorker.DoWork += WorkInBackGround;
           
            bgWorker.ProgressChanged += worker_ProgressChanged;
           
            bgWorker.RunWorkerCompleted += WorkerDone;
           
            searcher._stop = false; 
            searcher.FName = tbFN.Text;
            searcher.Direct = tbSearchDir.Text;
            time = DateTime.Now;              
            StartWorker();
           





        }

       


       

        private void resetBut_Click_1(object sender, EventArgs e)
        {
            timeElapsed.Text = "Time elapsed: ";
            treeView1.Nodes.Clear();
            buttonRun.Enabled = true;
            buttonPause.Enabled = false;
            buttonPause.Text = "Pause";
            label3.Text = "Files processed: ";
            searcher._pause = false;
            searcher.FIlesFound = 0;
            searcher.FilesProcessed = 0;
            Resetter();
            currentD.Text = (string)null;
            listBox1.Items.Clear();
            TreeBuilder.pathList.Clear();
            //label1.Text = "Time elapsed: ";
            filesFoundLabel.Text = "Files found: ";
        }

        private void buttonPause_Click_1(object sender, EventArgs e)
        {
            
            if (buttonPause.Text.ToLower() == "pause")
            {
                timePause = DateTime.Now;
                searcher._pause = true;
                buttonRun.Enabled = false;
                resetBut.Enabled = true;
                buttonPause.Text = "Resume";
                timer1.Tick += new System.EventHandler(OnTimerEvent);
                timePause = DateTime.Now;
                PauseWorker();

                

                
                
                
            }
           else if (buttonPause.Text.ToLower() == "resume")
            {
                timePending = (DateTime.Now - timePause).TotalSeconds;
                searcher._pause = false;
                buttonPause.Text = "Pause";
                resetBut.Enabled = false;
                timer1.Tick -= new System.EventHandler(OnTimerEvent);
                StartWorker();
                


            }

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            
                UserData.Load();
           
            tbSearchDir.Text = UserData.SearchDir;
                tbFN.Text = UserData.FileName;
                    
            
        }
        private void OnTimerEvent(object sender, EventArgs e)
        {
            if (bgWorker.IsBusy)
            {

                if (!searcher._pause)
                {
                    
                    timePassed = (DateTime.Now - time).TotalSeconds;
                    
                    timeElapsed.Text = "Time elapsed: " +  ( (int)timePassed - (int)timePending )  + " s";

                }
                if (searcher._pause)
                {
                   
                    timePassed = (timePause - time).TotalSeconds;
                    timeElapsed.Text = "Time elapsed: " + (int) timePassed + " s";

                }
                



            }
        }
    }
    
}
