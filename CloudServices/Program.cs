using CloudServices.Core;
using CloudServices.AWS;

namespace CloudServices
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create AWS Factory
            ICloudServiceFactory awsFactory = new AWSFactory();

            // Create AWS resources
            var vm = awsFactory.CreateVirtualMachine();
            var storage = awsFactory.CreateStorageService();
            var db = awsFactory.CreateDatabaseService();
            var vnet = awsFactory.CreateVNet();
            var subnet = awsFactory.CreateSubnet();

            // Provision resources
            vm.Provision();
            storage.Provision();
            db.CreateDatabase();
            vnet.Create();
            subnet.Create();

            // Get details of resources
            Console.WriteLine(vm.GetDetails());
            Console.WriteLine(storage.GetDetails());
            Console.WriteLine(db.GetDetails());
            Console.WriteLine(vnet.GetDetails());
            Console.WriteLine(subnet.GetDetails());

            // Perform actions on resources
            vm.Start();
            storage.AttachToVM();
            db.Connect();
            vnet.Configure();
            subnet.Configure();
        }
    }
}
