
using System;
using System.IO;

class Program
{
    static string watchPath =
        @"C:\FolderWatcher\Watch";

    static string logPath =
        @"C:\FolderWatcher\Logs";

    static string logFile =
        @"C:\FolderWatcher\Logs\ActivityLog.txt";

    static void Main()
    {
        Directory.CreateDirectory(watchPath);
        Directory.CreateDirectory(logPath);

        FileSystemWatcher watcher =
            new FileSystemWatcher();

        watcher.Path = watchPath;

        watcher.Filter = "*.*";

        watcher.NotifyFilter =
            NotifyFilters.FileName |
            NotifyFilters.DirectoryName |
            NotifyFilters.LastWrite;

        watcher.Created += OnCreated;
        watcher.Deleted += OnDeleted;
        watcher.Renamed += OnRenamed;

        watcher.EnableRaisingEvents = true;

        Console.WriteLine("FOLDER WATCHER SERVICE");
        Console.WriteLine("----------------------");
        Console.WriteLine("Watching Folder: " + watchPath);
        Console.WriteLine("Log File: " + logFile);
        Console.WriteLine();
        Console.WriteLine("Monitoring Started...");
        Console.WriteLine("Press Enter to Stop.");

        Console.ReadLine();

        watcher.EnableRaisingEvents = false;
        watcher.Dispose();
    }

    static void WriteLog(string message)
    {
        string log =
            DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")
            + " : " + message;

        File.AppendAllText(
            logFile,
            log + Environment.NewLine
        );

        Console.WriteLine(log);
    }

    static void OnCreated(object sender,
        FileSystemEventArgs e)
    {
        WriteLog("FILE CREATED: " + e.Name);
    }

    static void OnDeleted(object sender,
        FileSystemEventArgs e)
    {
        WriteLog("FILE DELETED: " + e.Name);
    }

    static void OnRenamed(object sender,
        RenamedEventArgs e)
    {
        WriteLog(
            "FILE RENAMED: " +
            e.OldName + " -> " + e.Name
        );
    }
}
