namespace Creational.FluentBuilder.GenericRecursion;

// absztrakt építőosztály
public abstract class PersonBuilder<T> where T : PersonBuilder<T>
{
    protected Person person;

    public PersonBuilder()
    {
        person = new Person();
    }

    public virtual T SetName(string name)
    {
        person.Name = name;
        return (T)this;
    }

    public virtual T SetAge(int age)
    {
        person.Age = age;
        return (T)this;
    }

    public Person Build()
    {
        return person;
    }
}

// konkrét építő osztály 
public class NormalPersonBuilder : PersonBuilder<NormalPersonBuilder> { }

// A specifikus építőosztály
public class UpperCasePersonBuilder : PersonBuilder<UpperCasePersonBuilder>
{
    public override UpperCasePersonBuilder SetName(string name)
    {
        person.Name = name.ToUpper();
        return this;
    }
}

// A specifikus építőosztály
public class DoubledAgePersonBuilder : PersonBuilder<DoubledAgePersonBuilder>
{
    public override DoubledAgePersonBuilder SetAge(int age)
    {
        person.Age = age * 2;
        return this;
    }
}

class ClientCode
{
    public static void Test()
    {
        Person person1 = new NormalPersonBuilder()
            .SetName("John Doe")
            .SetAge(30)
            .Build();

        Person person2 = new UpperCasePersonBuilder()
            .SetName("John Doe") // JOHN DOE
            .SetAge(30)
            .Build();

        Person person3 = new DoubledAgePersonBuilder()
            .SetName("John Doe")
            .SetAge(30) // 60
            .Build();
    }
}

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
