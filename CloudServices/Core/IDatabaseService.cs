﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudServices.Core
{
    internal interface IDatabaseService
    {
        void CreateDatabase();       // Create a database
        void Connect();              // Connect to the database
        void Backup();               // Backup the database
        void Restore();              // Restore the database from a backup
        string GetStatus();          // Get the current status of the database
        string GetDetails();         // Get details about the database
    }
}