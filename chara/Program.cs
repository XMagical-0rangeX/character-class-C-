// TASK 2
Character chara1 = new Character("Spongebob", "This isn't your average everyday darkness. This is... advanced darkness!",
 "LEEDLE, LEEDLE, LEEDLE, LEE.");
Character chara2 = new Character("Mario", "Yahoo", "Yipee");


// TASK 3

chara1.speak(1);
chara1.setLevel(2);
chara2.speak(2);



// TASK 1
class Character
{
    // Declare Properties (State)
    public string Name { get; set; }
    public string Phrase1 { get; set; }
    public string Phrase2 { get; set; }
    public int Level { get; set; }


    // Constructor
    public Character(string name, string phrase1, string phrase2)
    {
        this.Name = name;
        this.Phrase1 = phrase1;
        this.Phrase2 = phrase2;
        this.Level = 0;
        Console.WriteLine($"Character created: {name} {phrase1} {phrase2}");
    }


    // Methods (Behaviour)
    public void speak(int phraseNum)
    {
        if (phraseNum == 1)
        {
            Console.WriteLine($"{this.Name}: {this.Phrase1}");
        }
        else
        {
            Console.WriteLine($"{this.Name}: {this.Phrase2}");
        }

    }

    public void setLevel(int newLevel)
    {
        this.Level = newLevel;
        Console.WriteLine($"{this.Name}'s Level is now: {this.Level}");
    }


}