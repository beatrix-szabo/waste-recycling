using Codecool.WasteRecycling.Garbages;
using System;

namespace Codecool.WasteRecycling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dustbin dustbin = new Dustbin("Blue");

            Console.WriteLine(dustbin);
            Console.WriteLine();

            //Garbages 
            Garbage garbage = new Garbage("Bad Fruit");
            Garbage paper = new PaperGarbage("NewsPaper", false);
            Garbage plastic = new PlasticGarbage("Bottle", false);

            //Throw out all garbage
            dustbin.ThrowOutGarbage(garbage);
            dustbin.ThrowOutGarbage(paper);
            dustbin.ThrowOutGarbage(plastic);
            Console.WriteLine(dustbin);

            Console.WriteLine(dustbin.DisplayContents());
            Console.WriteLine();

            //Empty dustbin
            dustbin.EmptyContents();
            Console.WriteLine(dustbin);
        }
    }
}
