using System;
class Building
{
    public int Floors;
    public int Area;
    public int Occupants;

public void AreaPerPerson(){
    Console.WriteLine(Area/Occupants);
}
}
class BuildingDemo
{
    static void Main()
    {
        Building house=new Building();
        Building office=new Building();
        house.Occupants=10;
        house.Area=1000;
        house.Floors=31;
        office.Occupants=10;
        office.Area=21;
        office.Floors=2;
        house.AreaPerPerson();
        office.AreaPerPerson();
    }
}
