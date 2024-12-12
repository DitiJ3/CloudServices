using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudServices.Core
{
    public interface IStorageService
    {
        void Provision();        // Provision the storage service
        void AttachToVM();       // Attach the storage to a virtual machine
        void DetachFromVM();     // Detach the storage from a virtual machine
        string GetStatus();      // Get the current status of the storage service
        string GetDetails();     // Get details about the storage
        string StorageType { get; set; } // Get and Set specific storage type
        int StorageCapacityGB { get; set; }  // Get and Set specific storage capacity in GB
        bool IsEncrypted { get; set; } // Get and Set encryption status
    }
}
