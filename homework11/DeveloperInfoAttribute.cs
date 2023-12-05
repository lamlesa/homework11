using System;

namespace homework11
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public sealed class DeveloperInfoAttribute : Attribute
    {
        public string developer_name;
        public DateTime time;
        public DeveloperInfoAttribute(string developer)
        {
            developer_name = developer;
            time = DateTime.Now;
        }
    }
}