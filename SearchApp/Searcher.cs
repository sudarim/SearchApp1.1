using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Globalization;
using System.Windows;
using System.Threading;

namespace SearchApp
{
    delegate void Found(string path);
    delegate void FoundFilesUpdate(int i);
    delegate void FilesProcessed(int i);
    delegate void StopTheThread();
    delegate void PauseTheThread();
     delegate void GetCurrentPath(string path);
    delegate void PrintTree(string s);
    

    




    class Searcher
    {
        public ManualResetEvent _busy = new ManualResetEvent(false);
        private static string Filename;
        internal static string Dir;
        public event Found OnFound;
        public event FoundFilesUpdate OnFoundFilesUpdate;
        public event FilesProcessed OnFilesProcessed;
        public event PrintTree OnPrintTree;
       public event GetCurrentPath OnGetCurrentPath;
      

        public Boolean _stop = false;
        public Boolean _pause = false;
        
    
        internal int FilesProcessed = 0;
        internal int FIlesFound = 0;
        internal long TimeElapsed = 0;
        
        



        public Searcher(string fname, string dir)
        {
            Filename = fname;
            Dir = dir;
            
        }
        public void Scan(string dir)
        {

            


            if (!_stop)
                {


               


                    try
                    {

                        _busy.WaitOne();




                        string[] files = Directory.GetFiles(dir);
                        string[] dirs = Directory.GetDirectories(dir);
                        List<string> listAllFiles = new List<string>();
                        listAllFiles.AddRange(files);
                        FilesProcessed += listAllFiles.Count();
                        OnFilesProcessed(FilesProcessed);
                        listAllFiles.AddRange(dirs);
                        foreach (string s in listAllFiles)
                        {



                       
                        string _s = s.ToLower();   //то, что нашлось
                            string _fn = this.FName.ToLower();   //то, что задаем
                           
                            if (Directory.Exists(s) && s != "." && s != "..")
                            {
                            
                            OnGetCurrentPath(s);
                                    
                                    Scan(s);
                            
                                continue;
                            }
                            // if (_s.Contains(_fn) )
                            //  {
                            //  OnFound(s);


                            //   }
                            if (Matcher(_s, _fn))
                            {

                           // UserData.DirToFileWriter(s);
                            OnFound(s);
                                FIlesFound++;
                                OnFoundFilesUpdate(FIlesFound);
                            OnPrintTree(s);
                           
                             
                        }





                        }
                    }


                    catch (Exception e) { }
                
                }
            
            
        }

        


       public void Search()
        {

            //UserData.DirToFileWriter(Dir);

            Scan(Dir);
           
        }

        public string FName {
            set { Filename = value; }
            get { return Filename;}
          }

        public string Direct
        {
            set { Dir = value; }
            get { return Dir; }
        }


       private bool Matcher(string foundName, string pattern)
        {
            Regex rg = new Regex(pattern);
            MatchCollection matched = rg.Matches(foundName);
            return matched.Count != 0;
            
        }
        


        

    }
}
