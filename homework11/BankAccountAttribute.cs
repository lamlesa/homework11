using System;

namespace homework11
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public sealed class BankAccountAttribute : Attribute
    {
        public string developer_name;
        public string organization;
        public BankAccountAttribute(string developer, string organization)
        {
            developer_name = developer;
            this.organization = organization;
        }
    }
}