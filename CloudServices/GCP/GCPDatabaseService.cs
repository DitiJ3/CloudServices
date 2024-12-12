using CloudServices.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudServices.GCP
{
    public class GCPDatabaseService : IDatabaseService
    {
        // Properties for Database configuration
        public string DBEngine { get; set; } = "MySQL";  // Default database engine
        public int StorageCapacityGB { get; set; } = 10;  // Default storage capacity in GB
        public bool IsEncrypted { get; set; } = true;  // Default encryption status
        public bool IsRunning { get; set; } = false;  // Tracks whether the database is running

        // Method to Create an GCP Database
        public void CreateDatabase()
        {
            // create an GCP database
            Console.WriteLine($"Creating GCP Database with engine {DBEngine} and {StorageCapacityGB} GB of storage...");
            IsRunning = true;
        }

        // Method to Connect to the GCP Database
        public void Connect()
        {
            // connecte to an GCP database
            Console.WriteLine("Connecting to GCP Database...");
        }

        // Method to Backup the GCP Database
        public void Backup()
        {
            // backe up an GCP database
            Console.WriteLine("Backing up GCP Database...");
        }

        // Method to Restore the GCP Database from Backup
        public void Restore()
        {
            // restore an GCP database from backup
            Console.WriteLine("Restoring GCP Database from backup...");
        }

        // Method to Get the Status of the GCP Database
        public string GetStatus()
        {
            return IsRunning ? "GCP Database is running" : "GCP Database is stopped";
        }

        // Method to Get the Details of the GCP Database
        public string GetDetails()
        {
            // retrieve details of the GCP database
            return $"GCP Database Details: Engine {DBEngine}, {StorageCapacityGB} GB, Encrypted: {IsEncrypted}, Running: {IsRunning}";
        }
    }
}