namespace Prototype.Core.Concretes;

public class Person
{
    public PersonId PersonId { get; set; } = new PersonId(0);
    public int Age { get; set; }
    public DateTime BirthDate { get; set; }
    public string? Name { get; set; }

    public Person ShallowClone()
    {
        return (Person)this.MemberwiseClone();
    }

    public Person DeepClone()
    {
        Person clone = (Person)this.MemberwiseClone();
        clone.PersonId = new PersonId(PersonId.Id + 1);
        clone.BirthDate = DateTime.Now.AddYears(-Age);
        return clone;
    }
}