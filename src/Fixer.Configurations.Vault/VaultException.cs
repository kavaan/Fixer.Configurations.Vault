using System;
using System.Collections.Generic;
using System.Text;

namespace Fixer.Configurations.Vault
{
    public class VaultException : Exception
    {
        public string Key { get; set; }

        public VaultException(string key) : this(null, key)
        {
        }

        public VaultException(Exception innerException, string key) : this(string.Empty, innerException, key)
        {
        }

        public VaultException(string message, Exception innerException, string key) : base(message)
        {
            Key = key;
        }
    }
}
