using Codecool.WasteRecycling.Garbages;
using System.Collections.Generic;
using System.Text;

namespace Codecool.WasteRecycling
{
    public class Dustbin
    {

        // Constructor(s)
        public Dustbin(string color)
        {
            this.Color = color;
            Garbages = new List<Garbage>();
        }
        
        //Properies
        public string Color { get;}
        public List<Garbage> Garbages { get; private set; }
        public int HouseWasteCount { get; private set; }
        public int PaperCount { get; private set; }
        public int PlasticCount { get; private set; }

        //methods
        public void ThrowOutGarbage(Garbage garbage) 
        {
            if (garbage is PaperGarbage)
            {
                if (((PaperGarbage)garbage).Squizzed == false) 
                {
                    ((PaperGarbage)garbage).Squeeze();
                }
                PaperCount++;
                Garbages.Add(garbage);
            }
            else if (garbage is PlasticGarbage) 
            {
                if(((PlasticGarbage)garbage).Cleaned== false)
                {
                    ((PlasticGarbage)garbage).Clean();
                }
                PlasticCount++;
                Garbages.Add(garbage);
            }
            else 
            {
                HouseWasteCount++;
                Garbages.Add(garbage);
            }
            
        }

        public void EmptyContents()
        {
            Garbages.Clear();
            HouseWasteCount = 0;
            PaperCount = 0;
            PlasticCount = 0;
        }


        public override string ToString()
        {
            return Color + "Dustbin!" +
                "\n House waste content:" + HouseWasteCount + " item(s)" +
                "\n Paper content:" + PaperCount + " item(s)" +
                "\n Plastic content: "+ PlasticCount +" item(s)" ;
        }

       
        public StringBuilder DisplayContents()
        {
            StringBuilder garbagesName = new StringBuilder();

            for (int i = 0; i < Garbages.Count; i++)
            {
                garbagesName.Append("\n" + Garbages[i].Name + "; "); 
            }
            return garbagesName;
        }
    }
}
