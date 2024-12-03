using CloudServices.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudServices.Azure
{
    internal class AzureDatabaseService : IDatabaseService
    {
        // Properties for Database configuration
        public string DBEngine { get; set; } = "Postgress";  // Default database engine
        public int StorageCapacityGB { get; set; } = 10;  // Default storage capacity in GB
        public bool IsEncrypted { get; set; } = true;  // Default encryption status
        public bool IsRunning { get; set; } = false;  // Tracks whether the database is running

        // Method to Create an Azure Database
        public void CreateDatabase()
        {
            // create an Azure database
            Console.WriteLine($"Creating Azure Database with engine {DBEngine} and {StorageCapacityGB} GB of storage...");
            IsRunning = true;
        }

        // Method to Connect to the Azure Database
        public void Connect()
        {
            // connecte to an Azure database
            Console.WriteLine("Connecting to Azure Database...");
        }

        // Method to Backup the Azure Database
        public void Backup()
        {
            // backe up an Azure database
            Console.WriteLine("Backing up Azure Database...");
        }

        // Method to Restore the Azure Database from Backup
        public void Restore()
        {
            // restore an Azure database from backup
            Console.WriteLine("Restoring Azure Database from backup...");
        }

        // Method to Get the Status of the Azure Database
        public string GetStatus()
        {
            return IsRunning ? "Azure Database is running" : "Azure Database is stopped";
        }

        // Method to Get the Details of the Azure Database
        public string GetDetails()
        {
            // retrieve details of the Azure database
            return $"Azure Database Details: Engine {DBEngine}, {StorageCapacityGB} GB, Encrypted: {IsEncrypted}, Running: {IsRunning}";
        }
    }
}