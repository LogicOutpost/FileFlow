# FileFlow v1.0.0

## About

FileFlow is a Windows Forms application designed to help organize files quickly and easily.

Select a folder, and FileFlow will scan the files inside it and display statistics showing how many files of each supported extension are present.

When you're ready, press **Sort** and FileFlow will automatically create appropriately named folders and move the files into their corresponding categories.

## Features

* Select a folder to scan
* Display the number of files found by extension
* Automatically categorize files
* Automatically create category folders when needed
* Move files into their appropriate folders with one click
* Customizable application background colors
* Customizable button colors
* Customizable statistics box colors
* Simple Windows Forms interface

## Current Categories

FileFlow currently recognizes several categories of files, including:

* Images
* Documents
* Spreadsheets
* Audio
* Video
* Archives
* Code
* Disk/System-related files

Files are categorized based on their file extension.

## How It Works

1. Select the folder you want FileFlow to organize.
2. FileFlow scans the folder and displays the file statistics.
3. Review the number of files detected for each extension.
4. Press **Sort**.
5. FileFlow creates the necessary category folders.
6. Files are moved into their corresponding folders.

### Example

Before sorting:

```text
Downloads
├── photo.jpg
├── resume.pdf
├── song.mp3
├── report.docx
└── video.mp4
```

After sorting:

```text
Downloads
├── Images
│   └── photo.jpg
├── Documents
│   ├── resume.pdf
│   └── report.docx
├── Audio
│   └── song.mp3
└── Video
    └── video.mp4
```

## Customization

FileFlow includes customizable colors for:

* Application backgrounds
* Buttons
* Statistics display

This allows users to change the appearance of the application to their preference.

## Version

**Version:** 1.0.0

This is the initial release of FileFlow.

## What's Next

Planned improvements for future versions may include:

* Better duplicate-file handling
* Additional file categories
* Sorting options and configuration
* Improved file organization controls
* Additional customization options
* Organization history/logging

## Built With

* C#
* .NET
* Windows Forms
* System.IO

## Status

**Stable — Initial Release**

FileFlow is currently a work in progress and will continue to receive improvements and new features.
