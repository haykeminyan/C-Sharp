using System;
class Building
{
    public int Area;
    public int Person;
    
    public int AreaPerPerson()
    {
        return Area/Person;
    }
}
class BuildingDemo
{
    static void Main()
    {
        Building house=new Building();
        Building office=new Building();
        int areaPP;
        house.Area=123;
        house.Person=12;
        office.Person=1234;
        office.Area=323124;
        areaPP=house.AreaPerPerson();
        Console.WriteLine(areaPP);
        areaPP=office.AreaPerPerson();
        Console.WriteLine(areaPP);
    }
}
