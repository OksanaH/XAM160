using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

using Foundation;
using UIKit;

namespace People.iOS
{
    public class FileAccessHelper
    {
        public static string GetLocalFilePath(string filename)
        {
            string path = System.Environment.GetFolderPath
                (Environment.SpecialFolder.Personal);
            //going one level up
            string libraryFolder = Path.Combine(path, "..", "Library");
            if (!Directory.Exists(libraryFolder))
            {
                Directory.CreateDirectory(libraryFolder);
            }
            return Path.Combine(libraryFolder, filename);
        }
    }
}
