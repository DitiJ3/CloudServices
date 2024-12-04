using CloudServices.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudServices.AWS
{
    public class AWSDatabaseService : IDatabaseService
    {
        // Properties for Database configuration
        public string DBEngine { get; set; } = "MySQL";  // Default database engine
        public int StorageCapacityGB { get; set; } = 10;  // Default storage capacity in GB
        public bool IsEncrypted { get; set; } = true;  // Default encryption status
        public bool IsRunning { get; set; } = false;  // Tracks whether the database is running

        // Method to Create an AWS Database
        public void CreateDatabase()
        {
            // create an AWS database
            Console.WriteLine($"Creating AWS Database with engine {DBEngine} and {StorageCapacityGB} GB of storage...");
            IsRunning = true;
        }

        // Method to Connect to the AWS Database
        public void Connect()
        {
            // connecte to an AWS database
            Console.WriteLine("Connecting to AWS Database...");
        }

        // Method to Backup the AWS Database
        public void Backup()
        {
            // backe up an AWS database
            Console.WriteLine("Backing up AWS Database...");
        }

        // Method to Restore the AWS Database from Backup
        public void Restore()
        {
            // restore an AWS database from backup
            Console.WriteLine("Restoring AWS Database from backup...");
        }

        // Method to Get the Status of the AWS Database
        public string GetStatus()
        {
            return IsRunning ? "AWS Database is running" : "AWS Database is stopped";
        }

        // Method to Get the Details of the AWS Database
        public string GetDetails()
        {
            // retrieve details of the AWS database
            return $"AWS Database Details: Engine {DBEngine}, {StorageCapacityGB} GB, Encrypted: {IsEncrypted}, Running: {IsRunning}";
        }
    }
}