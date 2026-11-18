# Folder Watcher Service

## Project Description

Folder Watcher Service is a file monitoring application developed using C# and .NET. It monitors a selected folder and automatically detects changes in its contents.

Whenever a file is created, deleted, or renamed, the application records the event along with its date and time in a log file. This helps users keep track of file activities and monitor changes made inside a folder.

The application uses the `FileSystemWatcher` class from the .NET framework to detect file system events.

## Features

- Monitor a selected folder.
- Detect newly created files.
- Detect deleted files.
- Detect renamed files.
- Automatically record file activities.
- Store event details in a log file.
- Record date and time for every event.
- Continuously monitor folder changes.

## Technologies Used

- C#
- .NET
- Visual Studio
- FileSystemWatcher
- System.IO Namespace

## Main Functionalities

### 1. Folder Monitoring
- Select a folder to monitor.
- Monitor changes inside the selected folder.
- Detect file system activities automatically.

### 2. File Event Detection
The application detects the following events:

| Event | Description |
|---|---|
| Created | Detects when a new file is created |
| Deleted | Detects when a file is deleted |
| Renamed | Detects when a file is renamed |

### 3. Log File Management
- Record every detected event.
- Store file names and event types.
- Include date and time in each log entry.
- Save event information to a text log file.

## Example Log Output

```text
[2026-11-18 10:30:15] CREATED: notes.txt
[2026-11-18 10:35:20] DELETED: oldfile.txt
[2026-11-18 10:40:45] RENAMED: document.txt -> report.txt
```

## Important .NET Class

### FileSystemWatcher

`FileSystemWatcher` is a .NET class used to monitor changes in a specified directory.

Important properties and events:

| Property / Event | Purpose |
|---|---|
| Path | Specifies the folder to monitor |
| Filter | Specifies which files to monitor |
| EnableRaisingEvents | Starts or stops monitoring |
| Created | Detects file creation |
| Deleted | Detects file deletion |
| Renamed | Detects file renaming |



## Author

**Vishnu Kumar**

**output screen**
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/e206b51f-7a16-4d14-bec2-f8b7f9031634" />
