using System;
using System.Collections.Generic;

// Посередник
public interface IMediator
{
    void SendMessage(Component sender, string message);
}

// Компонент
public abstract class Component
{
    protected IMediator mediator;

    public Component(IMediator mediator)
    {
        this.mediator = mediator;
    }

    public abstract void Send(string message);
    public abstract void Receive(string message);
}

// Конкретний компонент
public class ConcreteComponent : Component
{
    public ConcreteComponent(IMediator mediator) : base(mediator) { }

    public override void Send(string message)
    {
        Console.WriteLine($"Вiдправлено повiдомлення: {message}");
        mediator.SendMessage(this, message);
    }

    public override void Receive(string message)
    {
        Console.WriteLine($"Компонент отримав повiдомлення: {message}");
    }
}

// Конкретний посередник
public class ConcreteMediator : IMediator
{
    private List<Component> components = new List<Component>();

    public void AddComponent(Component component)
    {
        components.Add(component);
    }

    public void SendMessage(Component sender, string message)
    {
        foreach (var component in components)
        {
            if (component != sender)
                component.Receive(message);
        }
    }
}

