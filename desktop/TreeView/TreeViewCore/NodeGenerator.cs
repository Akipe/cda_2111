using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TreeViewCore.node;

namespace TreeViewCore
{
    public static class NodeGenerator
    {
        public static void SetRoot(string dirPath)
        {
            if (!System.IO.Directory.Exists(dirPath))
            {
                throw new ArgumentException(
                    "You have to set a directory path"
                );
            }

            Root = GenerateChildren(new Dir(dirPath));
        }

        public static Dir Root
        {
            get; private set;
        }

        private static Dir GenerateChildren(Dir currentDir)
        {
            string[]? dirs = null;

            try
            {
                dirs =
                    System.IO.Directory.GetDirectories(currentDir.Path);
            }
            catch { }
            finally
            {
                if (dirs is not null && dirs.Length > 0)
                {
                    foreach (string dir in dirs)
                    {
                        Dir subDir = new node.Dir(Path.GetFileName(dir), currentDir);
                        currentDir.Children.Add(
                            GenerateChildren(subDir)
                        );
                    }
                }
            }
            string[]? files = null;

            try
            {
                files =
                    System.IO.Directory.GetFiles(currentDir.Path);
            }
            catch { }
            finally
            {
                if (files is not null && files.Length > 0)
                {
                    foreach (string file in files)
                    {
                        currentDir.Children.Add(
                            new node.File(Path.GetFileName(file), currentDir)
                        );
                    }
                }
            }

            return currentDir;
        }
    }
}