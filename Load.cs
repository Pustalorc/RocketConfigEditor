using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Persiafighter.Programs.RocketConfigEditor
{
    static class Load
    {
        private static string FilePath = "";
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MessageBox.Show("The program will search on your computer for the first occurence of Permissions.config.xml. Please wait until the file is found. This can take long if you have many files.");
            SearchLocal();
            if (FilePath == "")
            {
                Search();
                if (FilePath == "")
                {
                    MessageBox.Show("No file called Permissions.config.xml exists on your computer. Shutting down.");
                    Environment.Exit(0);
                }
            }
            Application.Run(new Editor(FilePath));
        }
        private static void SearchLocal()
        {
            try
            {
                foreach (string s in Directory.GetFiles("Permissions.config.xml"))
                {
                    FilePath = s;
                    return;
                }
                if (FilePath == "")
                {
                    Scan(Directory.GetCurrentDirectory());
                }
            }
            catch (Exception) { }
        }
        private static void Search()
        {
            foreach (string s in Directory.GetLogicalDrives())
            {
                try
                {
                    foreach (string d in Directory.GetFiles(s, "Permissions.config.xml"))
                    {
                        FilePath = d;
                        return;
                    }
                    if (FilePath == "")
                    {
                        Scan(s);
                    }
                    else if (FilePath != "")
                    {
                        return;
                    }
                }
                catch (Exception) { }
            }
            return;
        }
        private static void Scan(string sDir)
        {
            foreach (string d in Directory.GetDirectories(sDir))
            {
                try
                {
                    foreach (string s in Directory.GetFiles(d, "Permissions.config.xml"))
                    {
                        FilePath = s;
                        return;
                    }
                    if (FilePath == "")
                    {
                        Scan(d);
                    }
                    else if (FilePath != "")
                    {
                        return;
                    }
                }
                catch (Exception) { }
            }
        }
    }
}
