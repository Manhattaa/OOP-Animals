using System;

// Bas-klass
class Animal
{
    // Egenskaper som alla djur delar på
    public string WhatName { get; set; }
    public int WhatAge { get; set; }
    public string WhatSpecies { get; set; }
    public string WhatHabitat { get; set; }
    public string WhatColor { get; set; }
    public string IsSpotty { get; set; }
    public bool IsPredator { get; set; }

    // Konstruktor för "Animal"
    public Animal(string name, int age, string species, string habitat, string color, string spots, bool isPredator)
    {
        WhatName = name;
        WhatAge = age;
        WhatSpecies = species;
        WhatHabitat = habitat;
        WhatColor = color;
        IsSpotty = spots;
        IsPredator = isPredator;
    }

    // Gemensam metod för att göra ljud
    public virtual void MakeSound()
    {
        Console.WriteLine("Djuret gör ett ljud");
    }
}

// Subklasser som ärver från "Animal"
class Lion : Animal
{
    public int ManeLength { get; set; }

    public Lion(string name, int age, string habitat, bool isPredator, int maneLength)
        : base(name, age, "Lion", habitat, "Orange", "Spotted", isPredator)
    {
        ManeLength = maneLength;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Lejonet ryter!");
    }
}

class Tuna : Animal
{
    public int SwimSpeed { get; set; }

    public Tuna(string name, int age, string habitat, bool isPredator, int swimSpeed)
        : base(name, age, "Tuna", habitat, "Silver", "Not Spotted", isPredator)
    {
        SwimSpeed = swimSpeed;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Tonfisken blubbar");
    }
}

class Trashpanda : Animal
{
    public string TrashpandaSpecificTrait { get; set; }

    public Trashpanda(string name, int age, string habitat, string trashpandaSpecificTrait)
        : base(name, age, "Raccoon", habitat, "Gray", "Spotted", false)
    {
        TrashpandaSpecificTrait = trashpandaSpecificTrait;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Tvättbjörnen morrar");
    }
}

class Seagull : Animal
{
    public string SeagullSpecificTrait { get; set; }

    public Seagull(string name, int age, string habitat, string seagullSpecificTrait)
        : base(name, age, "Seagull", habitat, "White", "Not Spotted", false)
    {
        SeagullSpecificTrait = seagullSpecificTrait;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Fiskmåsen skränar");
    }
}

// Subklass av Animal
class Dog : Animal
{
    public int TailLength { get; set; }

    public Dog(string name, int age, string habitat, bool isPredator, int tailLength)
        : base(name, age, "Dog", habitat, "Varies", "Varies", isPredator)
    {
        TailLength = tailLength;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Hunden skäller!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Skapa olika djur och anropa MakeSound-metoden
        Animal lion = new Lion("Simba", 5, "Savannah", true, 10);
        Animal tuna = new Tuna("Flipper", 8, "Ocean", false, 30);
        Animal trashpanda = new Trashpanda("Bandit", 3, "Dumpsters", "Curious");
        Animal seagull = new Seagull("Gulliver", 2, "Sky", "Loud");

        lion.MakeSound();
        tuna.MakeSound();
        trashpanda.MakeSound();
        seagull.MakeSound();
    }
}
