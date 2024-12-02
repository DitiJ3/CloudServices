using CloudServices.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudServices.AWS
{
    internal class AWSFactory : ICloudServiceFactory
    {
        public IVirtualMachine CreateVirtualMachine()
        {
            return new AWSVirtualMachine();
        }
        public IStorageService CreateStorageService()
        {
            return new AWSStorageService();
        }

        public IDatabaseService CreateDatabaseService()
        {
            return new AWSDatabaseService();
        }

        public IVNet CreateVNet()
        {
            return new AWSVPC();
        }

        public ISubnet CreateSubnet()
        {
            return new AWSSubnet();
        }
    }
}
