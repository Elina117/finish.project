using System;
namespace next
{
	public class DeveloperInfoAttribute : System.Attribute
    {
        public string Name { get; }
        public string datereliz { get; }

        public DeveloperInfoAttribute() { }
        public DeveloperInfoAttribute(string name, string datereliz)
        {
            Name = name;
            this.datereliz = datereliz;
        }
    }
}

