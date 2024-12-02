using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudServices.Core
{
    internal interface ISubnet
    {
        void Create();              // Create a subnet
        void Delete();              // Delete the subnet
        void Configure();           // Configure subnet settings 
        string GetDetails();        // Get details about the subnet
    }
}
