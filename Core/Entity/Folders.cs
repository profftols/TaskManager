using Core.Interfaces;
using System;
using System.IO;

namespace Core
{
    public class Folders : IFolderService
    {
        public string GetFolderName(string path)
        {
            Directory.CreateDirectory(path);
            return null;
        }
    }
}
