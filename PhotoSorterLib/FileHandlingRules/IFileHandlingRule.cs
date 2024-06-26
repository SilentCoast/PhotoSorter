﻿namespace PhotoSorterLib.FileHandlingRules
{
    public interface IFileHandlingRule
    {
        /// <summary>
        /// Condition to Handle file
        /// </summary>
        /// <returns>true if file should be handled with alternative Handle</returns>
        bool ShouldHandle(FileInfo fileInfo);
        /// <summary>
        /// Action to perform if condition is met
        /// </summary>
        void Handle(FileInfo fileInfo);
    }
}