﻿using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.WindowsAzure.Storage;

namespace Microsoft.Azure.Jobs.Host.Bindings
{
    internal class BindingProviderContext
    {
        public ParameterInfo Parameter { get; set; }

        public IReadOnlyDictionary<string, Type> BindingDataContract { get; set; }

        public CloudStorageAccount StorageAccount { get; set; }

        public string ServiceBusConnectionString { get; set; }
    }
}