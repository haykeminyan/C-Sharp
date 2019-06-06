using System;
class Building
{
    public int Occupants;
    public int Area;
    public int Floors;

    public Building(int o, int a, int f)
    {
        Occupants=o;
        Area=a;
        Floors=f;
    }
    public int AreaPerPerson()
    {
        return Area/Occupants;
    }
    public int MaxOccupant(int minArea)
    {
        return Area/minArea;
    }
}
class BuildingDemo
{
    static void Main()
    {
        Building house =new Building(2,2500,4);
        Building office =new Building(21,123,13);
        Console.WriteLine(house.MaxOccupant(300));
        Console.WriteLine(office.MaxOccupant(300));
        Console.WriteLine(house.AreaPerPerson());
    }
}
