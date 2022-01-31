using System;
using System.Collections.Generic;

namespace ONF
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree t1 = new Tree(200, 30, TypeOfTree.Resinous_tree);
            Tree t2 = new Tree(2000, 100, TypeOfTree.Hardwood_tree);
            Tree t3 = new Tree(15000, 1000, TypeOfTree.Resinous_tree);
            Tree t4 = new Tree(25, 3, TypeOfTree.Hardwood_tree);

            Parcel p1 = new Parcel(
                1,
                new List<GeoCoordinate.NetStandard2.GeoCoordinate> {
                    new GeoCoordinate.NetStandard2.GeoCoordinate(47.76046807377427, 7.350892771234676),
                    new GeoCoordinate.NetStandard2.GeoCoordinate(47.73632250242514, 7.3028557263941325),
                    new GeoCoordinate.NetStandard2.GeoCoordinate(47.741655552891146, 7.291956754172469),
                    new GeoCoordinate.NetStandard2.GeoCoordinate(1.1, 1.1)
                });

            p1.PlantATree(t1);
            p1.PlantATree(t2);
            p1.PlantATree(t3);

            Console.WriteLine($"There are {p1.GetNumberTrees()} trees");
            
            Console.WriteLine(p1.GetSurface());
        }
    }
}
