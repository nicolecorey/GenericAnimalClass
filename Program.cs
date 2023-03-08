using System;

public class Animal<T>
{
    
    public T info;

   public Animal(T info)
    {
        this.info = info;
    }
    public T getAnimal()
    {
        return info;
    }
    
}

class Program
{
    static void Main()
    {

        Animal<string> animalName = new Animal<string>("Cow");

        Animal<string> animalHabitat = new Animal<string>("Farm");

        Animal<bool> endangered = new Animal<bool>(false);

        Animal<bool> extinct = new Animal<bool>(false);

        Animal<int> averageLifeSpan = new Animal<int>(15);

        Console.WriteLine($"Animal: {animalName.getAnimal()}");
        Console.WriteLine($"Habitat: {animalHabitat.getAnimal()}");
        Console.WriteLine($"Endangered? {endangered.getAnimal()}");
        Console.WriteLine($"Extinct? {extinct.getAnimal()}");
        Console.WriteLine($"Average life span: {averageLifeSpan.getAnimal()}");
    }
}