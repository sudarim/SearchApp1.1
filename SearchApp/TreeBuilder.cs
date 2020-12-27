using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using Microsoft.VisualBasic.FileIO;


namespace SearchApp
{
    
   internal class TreeBuilder
    {

        static string Nodes = "Nodes.txt";
        private static String path = Path.Combine(Environment.CurrentDirectory, Nodes);

        internal static List<string> pathList = new List<string>();

        internal static void PrintList ()
        {
            try
            {
                StreamWriter sw = File.AppendText(path);
                foreach (string str in pathList)
                {
                    sw.WriteLine(str);
                }
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

      


      

        internal static void CreatePath(TreeNodeCollection nodeList, string path)
        {
            


            TreeNode node = null;
            string folder = string.Empty;

            int p = path.IndexOf('\\');

            if (p == -1)
            {
                folder = path;
                path = "";
            }
            else
            {
                folder = path.Substring(0, p);
                path = path.Substring(p + 1, path.Length - (p + 1));
            }

            node = null;

            foreach (TreeNode item in nodeList)
            {
                if (item.Text == folder)
                {
                    node = item;
                }
            }

            if (node == null)
            {
                node = new TreeNode(folder);
                nodeList.Add(node);
            }

            if (path != "")
            {
                CreatePath(node.Nodes, path);
            }
        }



    }
}
