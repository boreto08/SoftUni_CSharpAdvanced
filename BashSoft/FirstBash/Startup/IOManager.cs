namespace Startup
{
    using System.Collections.Generic;
    using System.IO;

    public class IOManager
    {
        public static void TraverseDirectory(string path)
        {
            OutputWriter.WriteEmptyLine();
            int initialIdentation = path.Split('\\').Length;
            Queue<string> subFolders = new Queue<string>();
            subFolders.Enqueue(path);

            while (subFolders.Count != 0)
            {
                string currentPath = subFolders.Dequeue();
                int indentation = currentPath.Split('\\').Length - initialIdentation;
                foreach (var directoryPath in Directory.GetDirectories(currentPath))
                {
                    subFolders.Enqueue(directoryPath);
                }

                OutputWriter.WriteMessageOnNewLine(string.Format($"{new string('-', indentation)}{currentPath}"));
            }
        }
    }
}
