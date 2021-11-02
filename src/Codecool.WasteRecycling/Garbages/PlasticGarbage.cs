namespace Codecool.WasteRecycling.Garbages
{
    public class PlasticGarbage : Garbage
    {
        //Constructor
        public PlasticGarbage(string name, bool flag) : base(name) 
        {
            this.Cleaned = flag;
        }

        //Properties
        public bool Cleaned { get; private set; }

        //Methods
        public void Clean() 
        {
            if (Cleaned = !false) 
            {
                Cleaned = true;
            }
        }

        
    }
}
