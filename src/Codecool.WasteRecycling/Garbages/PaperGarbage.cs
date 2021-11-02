namespace Codecool.WasteRecycling.Garbages
{
    public class PaperGarbage : Garbage
    {

        //Constructor
        public PaperGarbage(string name, bool flag): base (name)
        {
            this.Squizzed = flag;
        }

        //Properties
        public bool Squizzed { get; private set; }

        //Methods
        public void Squeeze()
        { 
            if(Squizzed == false)
            {
                this.Squizzed = true;
            }
        }

    }
}
