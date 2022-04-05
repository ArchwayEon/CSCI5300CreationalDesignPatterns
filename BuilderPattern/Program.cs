using BuilderPattern.GOF.Builder;

Director director = new();

IBuilder builder1 = new ConcreteBuilder1();
IBuilder builder2 = new ConcreteBuilder2();

director.Construct(builder1);
Console.WriteLine(builder1.GetResult().Name);

director.Construct(builder2);
Console.WriteLine(builder2.GetResult().Name);
