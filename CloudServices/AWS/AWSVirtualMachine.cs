﻿using CloudServices.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudServices.AWS
{
    public class AWSVirtualMachine : IVirtualMachine
    {
        // Properties with default values
        public string VMSize { get; set; } = "t2.micro";  // Default size
        public string Region { get; set; } = "us-east-1";  // Default region
        public bool IsRunning { get; set; } = false;  // Tracks whether the VM is running

        // Provision, start, stop, reboot, and get details methods
        public void Provision()
        {
            Console.WriteLine($"Provisioning AWS Virtual Machine of size {VMSize} in region {Region}...");
            IsRunning = false;
        }

        public void Start()
        {
            Console.WriteLine($"Starting AWS Virtual Machine of size {VMSize} in region {Region}...");
            IsRunning = true;
        }

        public void Stop()
        {
            Console.WriteLine($"Stopping AWS Virtual Machine of size {VMSize} in region {Region}...");
            IsRunning = false;
        }

        public void Reboot()
        {
            Console.WriteLine($"Rebooting AWS Virtual Machine of size {VMSize} in region {Region}...");
        }

        public string GetDetails()
        {
            return $"AWS Virtual Machine Details: {VMSize}, {Region}, Is Running: {IsRunning}";
        }
    }
}