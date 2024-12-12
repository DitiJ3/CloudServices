using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudServices.Core
{
    public interface ICloudServiceFactory
    {
        IVirtualMachine CreateVirtualMachine();
        IStorageService CreateStorageService();
        IDatabaseService CreateDatabaseService();
        IVNet CreateVNet();
        ISubnet CreateSubnet();
    }
}
