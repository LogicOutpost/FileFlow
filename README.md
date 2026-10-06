# FileFlow

FileFlow is a Windows desktop application built with C# and Windows Forms that automatically organizes files into categorized folders.

The project started as a learning project focused on `System.IO` and has grown into a functional desktop utility with file scanning, automatic organization, file handling, and activity logging.

---

## Features

### File Scanning
- Select a folder to scan
- Detect supported file types
- Display file counts by category
- Display the number of files found in the selected folder

### File Organization
FileFlow automatically creates category folders and moves files into the appropriate location.

Supported categories include:

- Images
- Documents
- Spreadsheets
- Audio
- Video
- Archives
- Code
- Disk/System Files

### File Handling
- Handles files during the organization process
- Checks file paths before moving files
- Creates required directories automatically
- Handles file-related errors without crashing the application

### Logging
FileFlow now maintains an activity log for file organization operations.

Logging can include:

- Selected folder
- Scan activity
- Files moved
- Files skipped
- Errors
- Organization activity

Logs are stored in the user's **FileFlow Logs** folder.

### Custom UI
- Custom background colors
- Custom button colors
- Custom statistics display
- Windows Forms desktop interface

---

## How It Works

1. Select a folder using the folder browser.
2. FileFlow scans the selected folder.
3. Files are identified based on their extensions.
4. File statistics are displayed.
5. Click **Sort** to organize the files.
6. FileFlow creates the necessary category folders.
7. Files are moved into their corresponding folders.
8. FileFlow records relevant activity in the log.

### Example

Before:

```text
Downloads
├── photo.jpg
├── resume.pdf
├── song.mp3
├── report.docx
├── video.mp4
└── data.csv
```

After:

```text
Downloads
├── Images
│   └── photo.jpg
├── Documents
│   └── resume.pdf
├── Audio
│   └── song.mp3
├── Video
│   └── video.mp4
└── Spreadsheets
    └── data.csv
```

---

## FileFlow Logs

FileFlow creates a dedicated log folder in the user's profile:

```text
C:\Users\<Username>\FileFlow Logs
```

The log provides a record of FileFlow activity and can be used to review what happened during file organization.

---

## Technologies

- C#
- .NET
- Windows Forms
- System.IO
- System.Diagnostics
- Visual Studio

---

## Project Structure

```text
FileFlow/
├── FileFlow.sln
├── FileFlow/
│   ├── Program.cs
│   ├── Form1.cs
│   ├── Form1.Designer.cs
│   ├── Form1.resx
│   ├── Properties/
│   └── FileFlow.csproj
├── .gitignore
└── README.md
```

---

## Version History

### v1.1.0

Added:

- File handling functionality
- File activity logging
- Improved file organization handling
- Logging for file operations
- Additional error handling
- Updated application functionality

### v1.0.0

Initial release of FileFlow.

Included:

- Folder selection
- File scanning
- File statistics
- File extension detection
- Automatic category folder creation
- Automatic file organization
- Custom Windows Forms interface

---

## Planned Features

- [ ] Duplicate file handling
- [ ] File preview before organization
- [ ] Undo organization
- [ ] Configurable file categories
- [ ] Custom file extensions
- [ ] Improved logging and organization history
- [ ] Additional UI customization
- [ ] File organization statistics

---

## Development Goals

FileFlow is an ongoing C# project designed to explore practical Windows application development.

The project focuses on:

- C# programming
- Windows Forms development
- File and directory management
- Event-driven programming
- Exception handling
- Application logging
- Building practical desktop utilities

---

## Safety

FileFlow moves files from their original location into category folders.

Always verify the selected folder before using the **Sort** function and maintain backups of important files.

---

## Status

**Current Version: v1.1.0**

FileFlow is an actively developed project.

---

## Download

The latest compiled version of FileFlow can be found in the project's **GitHub Releases** section.

Download the latest installer and follow the installation instructions provided with the release.

---

## Author

**LogicOutpost**

C# / .NET developer in training, building practical desktop applications and expanding skills through progressively larger projects.
