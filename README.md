# ImplementationsInInterfaces
A project showing the issues around implementing methods in an interface in C#. The downside is that the only way to call the method is to cast the concrete object to the interface.

### Interface
Here is an interface with an implemented member
``` C#
interface IBase
{
    string A { get; set; }
    string Dupe(int count);
    string Add(string b) => A + b;
}
```

### Implementing the Interface
Concrete class implementation of interface
``` C#
public class AdderFromInterface : IBase
{
    public  AdderFromInterface(string a)
    {
        A = a;
    }

    public string A { get; set; }

    public string Dupe(int count)
    {
        return string.Concat(Enumerable.Repeat(A, count));
    }
}
```

### Abstract Base Class
Here is the same interface implemented as an abstract base class. Note that there is no implementation of the Dupe method.
``` C#
public abstract class Base
{
    public abstract string A { get; set; }
    public abstract string Dupe(int count);
    public string Add(string b) => A + b;
}
```

### Implementing the Abstract Base Class
And the concrete class that implements the abstract base class. Note that there is no implementation of the Dupe method.
``` C#
public class AdderFromBase: Base
{
    public AdderFromBase(string a)
    {
        A = a;
    }
    public override string A { get; set; }
    public override string Dupe(int count)
    {
        return string.Concat(Enumerable.Repeat(A, count));
    }
}
```


### Demonstrate the difference
This shows how implementations in an interface differ from an implementation in an abstract base class.
``` C#
AdderFromInterface adderI = new("Test");
Console.WriteLine(adderI.Dupe(3));
// The next statement generates a compiler errror. 
Console.WriteLine(adderI.Add("B"));
// In order to call a member implemented in an interace, you must cast the object to the interfacee
Console.WriteLine(((IBase)adderI).Add("B"));

AdderFromBase adderB = new("Test");
Console.WriteLine(adderB.Dupe(3));
// Note that this can be called either as the object or as the base class.
Console.WriteLine(adderB.Add("B"));
Console.WriteLine(((Base)adderB).Add("B"));
```

#### This is the compiler error
Error	CS1061:
'AdderFromInterface' does not contain a definition for 'Add' and no accessible extension method 'Add' accepting a first argument of type 'AdderFromInterface' could be found (are you missing a using directive or an assembly reference?)

