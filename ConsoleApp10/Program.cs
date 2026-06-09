

class MusicalInstrument
{
    protected string name;

    public MusicalInstrument(string name)
    {
        this.name = name;
        Console.WriteLine($"{this.name} created.");
    }

    public virtual void Sound()
    {
        Console.WriteLine($"{name} is making a sound...");
    }

    public virtual void Show()
    {
        Console.WriteLine($"Instrument name: {name}");
    }

    public virtual void Desc()
    {
        Console.WriteLine($"{name} is a musical instrument.");
    }

    public virtual void History()
    {
        Console.WriteLine($"The history of {name} is unknown.");
    }
}

class Violin : MusicalInstrument
{
    public Violin() : base("Violin") { }

    public override void Sound()
    {
        Console.WriteLine("Violin produces a high-pitched, bowed string sound.");
    }

    public override void Show()
    {
        Console.WriteLine("Instrument name: Violin");
    }

    public override void Desc()
    {
        Console.WriteLine("Violin is a bowed string instrument with four strings.");
    }

    public override void History()
    {
        Console.WriteLine("The Violin was developed in 16th century Italy.");
    }
}

class Ukulele : MusicalInstrument
{
    public Ukulele() : base("Ukulele") { }

    public override void Sound()
    {
        Console.WriteLine("Ukulele produces a light, cheerful plucked string sound.");
    }

    public override void Show()
    {
        Console.WriteLine("Instrument name: Ukulele");
    }

    public override void Desc()
    {
        Console.WriteLine("Ukulele is a small, four-stringed instrument from Hawaii.");
    }

    public override void History()
    {
        Console.WriteLine("The Ukulele originated in Hawaii in the 19th century.");
    }
}

class Trombone : MusicalInstrument
{
    public Trombone() : base("Trombone") { }

    public override void Sound()
    {
        Console.WriteLine("Trombone produces a deep, resonant brass sound.");
    }

    public override void Show()
    {
        Console.WriteLine("Instrument name: Trombone");
    }

    public override void Desc()
    {
        Console.WriteLine("Trombone is a brass wind instrument with a slide mechanism.");
    }

    public override void History()
    {
        Console.WriteLine("The Trombone originated in 15th century Europe.");
    }
}

class Cello : MusicalInstrument
{
    public Cello() : base("Cello") { }

    public override void Sound()
    {
        Console.WriteLine("Cello produces a deep, rich bowed string sound.");
    }

    public override void Show()
    {
        Console.WriteLine("Instrument name: Cello");
    }

    public override void Desc()
    {
        Console.WriteLine("Cello is a large bowed string instrument held between the knees.");
    }

    public override void History()
    {
        Console.WriteLine("The Cello was developed in the early 16th century in Italy.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        MusicalInstrument[] instruments = new MusicalInstrument[]
        {
            new Violin(),
            new Ukulele(),
            new Trombone(),
            new Cello()
        };

        foreach (var instrument in instruments)
        {
            Console.WriteLine("---");
            instrument.Show();
            instrument.Sound();
            instrument.Desc();
            instrument.History();
        }

        Console.WriteLine("---");
    }
}