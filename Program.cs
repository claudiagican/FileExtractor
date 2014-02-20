using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileExtractor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainPanel());
        }

        public static void ProcessFiles(string source, string dest)
        {
            DirectoryInfo dirSrc = new DirectoryInfo(source);
            DirectoryInfo dirRes = new DirectoryInfo(dest);

            if (!dirRes.Exists)
                dirRes.Create();

            extract(dirSrc, dirRes);
        }

        private static void extract(DirectoryInfo source, DirectoryInfo dest)
        {

            foreach (FileInfo fi in source.GetFiles())
            {
                if (fi.Extension.ToLower() == ".zip")
                {
                    DirectoryInfo dirToExtract = new DirectoryInfo(fi.DirectoryName + "\\" + Path.GetFileNameWithoutExtension(fi.FullName));
                    try
                    {
                        using (ZipFile zip = ZipFile.Read(fi.FullName))
                        {
                            foreach (ZipEntry e in zip)
                            {
                                e.Extract(dirToExtract.FullName, ExtractExistingFileAction.OverwriteSilently);
                            }
                        }
                    }
                    catch { };
                }
            }
            
            foreach (DirectoryInfo subDir in source.GetDirectories())
            {
                extract(subDir, dest);
            }
        }


    }
}
