using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TreeViewCore.node;

namespace TreeViewCore
{
    public static class NodeGenerator
    {
        private static EnumerationOptions nodeSearchOption = new EnumerationOptions {
            IgnoreInaccessible = true
        };

        public static Dir Generate(string dirPath)
        {
            return Generate(dirPath, new CancellationToken());
        }

        public static Dir Generate(string dirPath, CancellationToken cancelToken)
        {
            if (!System.IO.Directory.Exists(dirPath))
            {
                throw new ArgumentException(
                    "You have to set a directory path"
                );
            }

            Root = GenerateChildren(new Dir(dirPath), cancelToken);
            Root.Name = Root.Path;

            return Root;
        }

        public static Dir Root
        {
            get; private set;
        }

        private static Dir GenerateChildren(
            Dir currentDir,
            CancellationToken cancelToken
        ) {
            cancelToken.ThrowIfCancellationRequested();

            string[]? dirs = null;

            try
            {
                dirs =
                    System.IO.Directory.GetDirectories(
                        currentDir.Path,
                        "*",
                        nodeSearchOption
                    );
            }
            catch { }

            if (dirs is not null && dirs.Length > 0)
            {
                foreach (string dir in dirs)
                {
                    cancelToken.ThrowIfCancellationRequested();

                    Dir subDir = new node.Dir(Path.GetFileName(dir), currentDir);
                    currentDir.Children.Add(
                        GenerateChildren(subDir, cancelToken)
                    );
                }
            }

            string[]? files = null;

            try
            {
                files =
                    System.IO.Directory.GetFiles(
                        currentDir.Path,
                        "*",
                        nodeSearchOption
                    );
            }
            catch { }

            if (files is not null && files.Length > 0)
            {
                foreach (string file in files)
                {
                    cancelToken.ThrowIfCancellationRequested();

                    currentDir.Children.Add(
                        new node.File(Path.GetFileName(file), currentDir)
                    );
                }
            }

            return currentDir;
        }
    }
}