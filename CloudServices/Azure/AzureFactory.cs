using CloudServices.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudServices.Azure
{
    public class AzureFactory : ICloudServiceFactory
    {
        public IVirtualMachine CreateVirtualMachine()
        {
            return new AzureVirtualMachine();
        }
        public IStorageService CreateStorageService()
        {
            return new AzureStorageService();
        }

        public IDatabaseService CreateDatabaseService()
        {
            return new AzureDatabaseService();
        }

        public IVNet CreateVNet()
        {
            return new AzureVnet();
        }

        public ISubnet CreateSubnet()
        {
            return new AzureSubnet();
        }
    }
}
