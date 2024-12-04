using CloudServices.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudServices.GCP
{
    public class GCPFactory : ICloudServiceFactory
    {
        public IVirtualMachine CreateVirtualMachine()
        {
            return new GCPVirtualMachine();
        }
        public IStorageService CreateStorageService()
        {
            return new GCPStorageService();
        }

        public IDatabaseService CreateDatabaseService()
        {
            return new GCPDatabaseService();
        }

        public IVNet CreateVNet()
        {
            return new GCPVnet();
        }

        public ISubnet CreateSubnet()
        {
            return new GCPSubnet();
        }
    }
}
