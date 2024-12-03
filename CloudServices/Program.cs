using CloudServices.Core;
using CloudServices.AWS;
using CloudServices.GCP;
using CloudServices.Azure;
using System;
using System.Collections.Generic;

namespace CloudServices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a Cloud Provider: 1. AWS  2. GCP  3. Azure");
            string choice = Console.ReadLine();
            ICloudServiceFactory factory = choice switch
            {
                "1" => new AWSFactory(),
                "2" => new GCPFactory(),
                "3" => new AzureFactory(),
                _ => null
            };

            if (factory == null)
            {
                Console.WriteLine("Invalid selection. Exiting.");
                return;
            }

            List<string> provisionedResources = new List<string>();
            while (true)
            {
                Console.WriteLine("\nSelect a Resource to Provision: ");
                Console.WriteLine("1. Virtual Machine");
                Console.WriteLine("2. Database Service");
                Console.WriteLine("3. Storage Service");
                Console.WriteLine("4. Virtual Network (VPC/VNet)");
                Console.WriteLine("5. Subnet");
                Console.WriteLine("Type 'apply' to finish and print provisioned resources.");
                
                string resourceChoice = Console.ReadLine()?.ToLower();

                if (resourceChoice == "apply")
                {
                    Console.WriteLine("\nProvisioned Resources:");
                    provisionedResources.ForEach(Console.WriteLine);
                    break;
                }

                switch (resourceChoice)
                {
                    case "1":
                        var vm = factory.CreateVirtualMachine();
                        ConfigureVirtualMachine(vm);
                        vm.Provision();
                        provisionedResources.Add(vm.GetDetails());
                        break;
                    case "2":
                        var db = factory.CreateDatabaseService();
                        ConfigureDatabaseService(db);
                        db.CreateDatabase();
                        provisionedResources.Add(db.GetDetails());
                        break;
                    case "3":
                        var storage = factory.CreateStorageService();
                        ConfigureStorageService(storage);
                        storage.Provision();
                        provisionedResources.Add(storage.GetDetails());
                        break;
                    case "4":
                        var vnet = factory.CreateVNet();
                        ConfigureVNet(vnet);
                        vnet.Create();
                        provisionedResources.Add(vnet.GetDetails());
                        break;
                    case "5":
                        var subnet = factory.CreateSubnet();
                        ConfigureSubnet(subnet);
                        subnet.Create();
                        provisionedResources.Add(subnet.GetDetails());
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        static void ConfigureVirtualMachine(IVirtualMachine vm)
        {
            Console.WriteLine("\nConfiguring Virtual Machine...");
            Console.Write("Enter VM Size (default is t2.micro): ");
            string size = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(size)) vm.VMSize = size;

            Console.Write("Enter Region (default is us-east-1): ");
            string region = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(region)) vm.Region = region;
        }

        static void ConfigureDatabaseService(IDatabaseService db)
        {
            Console.WriteLine("\nConfiguring Database Service...");
            Console.Write("Enter Database Engine (e.g., MySQL, PostgreSQL, MSSQL): ");
            string engine = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(engine)) db.DBEngine = engine;

            Console.Write("Enter Storage Capacity (GB): ");
            if (int.TryParse(Console.ReadLine(), out int storageCapacity)) db.StorageCapacityGB = storageCapacity;

            Console.Write("Is the database encrypted? (true/false): ");
            if (bool.TryParse(Console.ReadLine(), out bool isEncrypted)) db.IsEncrypted = isEncrypted;
        }

        static void ConfigureStorageService(IStorageService storage)
        {
            Console.WriteLine("\nConfiguring Storage Service...");
            Console.Write("Enter Storage Type (e.g., SSD, HDD): ");
            string storageType = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(storageType)) storage.StorageType = storageType;

            Console.Write("Enter Storage Capacity (GB): ");
            if (int.TryParse(Console.ReadLine(), out int storageCapacity)) storage.StorageCapacityGB = storageCapacity;

            Console.Write("Is the storage encrypted? (true/false): ");
            if (bool.TryParse(Console.ReadLine(), out bool isEncrypted)) storage.IsEncrypted = isEncrypted;
        }

        static void ConfigureVNet(IVNet vnet)
        {
            Console.WriteLine("\nConfiguring Virtual Network...");
            Console.Write("Enter VNet Name: ");
            string vnetName = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(vnetName)) vnet.VnetName = vnetName;

            Console.Write("Enter CIDR Block: ");
            string cidrBlock = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(cidrBlock)) vnet.CIDRBlock = cidrBlock;
        }

        static void ConfigureSubnet(ISubnet subnet)
        {
            Console.WriteLine("\nConfiguring Subnet...");
            Console.Write("Enter Subnet Name: ");
            string subnetName = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(subnetName)) subnet.SubnetName = subnetName;

            Console.Write("Enter CIDR Block: ");
            string cidrBlock = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(cidrBlock)) subnet.CIDRBlock = cidrBlock;
        }
    }
}
