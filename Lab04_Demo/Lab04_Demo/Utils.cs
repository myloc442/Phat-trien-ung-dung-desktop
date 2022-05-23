﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_Demo
{
    public static class Utils
    {
        public static string GetCurrentProjectDirectory()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;

            return projectDirectory;
        }

        public static string GetPathTo(params string[] args)
        {
            string relativePath = String.Join("\\", args);
            return GetCurrentProjectDirectory() + "\\" + relativePath;
        }
    }
}
