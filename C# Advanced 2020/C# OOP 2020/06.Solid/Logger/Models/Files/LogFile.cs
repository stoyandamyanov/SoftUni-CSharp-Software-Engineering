﻿using Logger.Models.Contracts;
using Logger.Models.Enumerations;
using Logger.Models.IOManagement;
using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Logger.Models.Files
{
    public class LogFile : IFile
    {
        private IOManager IOManager;

        public LogFile(string folderName, string fileName)
        {
            this.IOManager = new IOManager(folderName, fileName);

            this.IOManager.EnsureDirectoryAndFileExist();
        }

        public string Path => this.IOManager.CurrentFilePath;

        public long Size => this.GetFileSize();

        public string Write(ILayout layout, IError error)
        {
            string format = layout.Format;

            DateTime dateTime = error.dateTime;
            string message = error.Message;
            Level level = error.Level;

            string formattedMessage = String.Format(format, dateTime.ToString("M/dd/yyyy h:mm:ss tt", CultureInfo.InvariantCulture), message, level.ToString());

            return formattedMessage;
        }

        private long GetFileSize()
        {
            string text = File.ReadAllText(this.Path);

            long size = text
                .Where(ch => Char.IsLetter(ch))
                .Sum(ch => ch);

            return size;
        }
    }
}
