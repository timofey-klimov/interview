A a = new A();
a.Method();

A b = new B();
b.Method();

A c = new C();
c.Method();

C cc = new C();
cc.Method();



class A
{
    public virtual void Method()
    {
        Console.WriteLine("From A");
    }
}


class B : A
{
    public override void Method()
    {
        Console.WriteLine("From B");
    }
}

class C : B
{
    public new void Method()
    {
        Console.WriteLine("From C");
    }
}

