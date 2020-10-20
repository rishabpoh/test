using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Azure.Storage.Files.Shares;

namespace LargeFileMigrationScript
{
    class Program
    {
        static void Main(string[] args)
        {
            // Required to authenticate to storage account
            string storageAccountName = "rishabstoragetest";
            string storageConnectionString = "";

            // Names of Directory to access and File to create
            string dirName = "testdest";
            string shareName = "testfileshare1";

            // Get a reference to a share and create it
            ShareClient share = new ShareClient(storageConnectionString, shareName);
            await share.createAsnc();

            Console.WriteLine("Migrating files from to .");

        }

        private async Task<Response<TCompleteUpload>> UploadInParallelAsync(
            Stream content,
            long? contentLength,
            TServiceSpecificArgs args,
            IProgress<long> progressHandler,
            CancellationToken cancellationToken)
        {
            // A list of tasks that are currently executing which will
            // always be smaller than _maxWorkerCount
            List<Task> runningTasks = new List<Task>();

            // Partition fileshare into byte ranges
            await foreach ()

        }
    }
}
