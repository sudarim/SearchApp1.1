using System;
using System.Text;
using System.IO;




namespace SearchApp
{
    public static class UserData
    {
        // ----- Variables -----

       
        private static  String searchDir = "C:\\";
        private static String searchfileName = "";
        static string fileName = "UserConfig.txt";
        static string directories = "Directories.txt";
        private static String path = Path.Combine(Environment.CurrentDirectory, fileName);
        private static String Dpath = Path.Combine(Environment.CurrentDirectory, directories);




        public static String SearchDir
        {
            get { return searchDir; }
            set { searchDir = value; }
        }

        public static String FileName
        {
            get { return searchfileName; }
            set { searchfileName = value; }
        }
         public static void Save()
        {

            try
            {
                StreamWriter sw = new StreamWriter(path);
                
                sw.WriteLine(searchDir);
                sw.WriteLine(FileName);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }


        }
       public static void Load()
        {
           
            try
            {

                string[] readText = File.ReadAllLines(path);
                searchDir = readText[0];
                searchfileName = readText[1];
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }




        } 
        public static void DirToFileWriter (string str)
        {
            try
            {
                StreamWriter sw = File.AppendText(Dpath);

                sw.WriteLine(str);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
        
    }
}
