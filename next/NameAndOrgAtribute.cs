using System;
namespace next
{
	public class NameAndOrgAtribute : System.Attribute
    {
        public string Name { get; }
        public string Organization { get; set; }
        public NameAndOrgAtribute(string name, string organization)
        {
            Name = name;
            Organization = organization;
        }
        public NameAndOrgAtribute() { }
    }
}

