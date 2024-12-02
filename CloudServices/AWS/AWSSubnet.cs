using CloudServices.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudServices.AWS
{
    internal class AWSSubnet : ISubnet
    {
        public void Create()
        {
            // Simulate creating an AWS subnet
            Console.WriteLine("Creating AWS Subnet...");
        }

        public void Delete()
        {
            // Simulate deleting an AWS subnet
            Console.WriteLine("Deleting AWS Subnet...");
        }

        public void Configure()
        {
            // Simulate configuring the AWS subnet (e.g., IP range)
            Console.WriteLine("Configuring AWS Subnet...");
        }

        public string GetDetails()
        {
            // Simulate retrieving details of the AWS subnet
            return "AWS Subnet Details: 10.0.1.0/24 IP range";
        }
    }
}
