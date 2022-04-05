using PrototypePattern.GOF.Prototype;

Client c1 = new Client
{
    Original = new ConcretePrototype1
    {
        Name = "Name 1"
    }
};
Client c2 = new Client
{
    Original = new ConcretePrototype2
    {
        Id = "Id 1"
    }
};

c1.Operation();
c2.Operation();

ConcretePrototype1? p1 = (ConcretePrototype1?)c1.Copy;
ConcretePrototype2? p2 = (ConcretePrototype2?)c2.Copy;

if(p1 != c1.Original)
{
    Console.WriteLine($"{p1?.Name} is a copy");
}
if (p2 != c2.Original)
{
    Console.WriteLine($"{p2?.Id} is a copy");
}
