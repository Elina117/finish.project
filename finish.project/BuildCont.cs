using System;
namespace finish.project
{
	public class BuildCont
	{
        Buiding[] buidings = new Buiding[10];
        public Buiding this[int index]
        {
            get => buidings[index];
            set => buidings[index] = value;
        }
        public BuildCont(Buiding[] buidings)
        {
            this.buidings = buidings;
        }
    }
}

