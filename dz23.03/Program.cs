class Program
{
    static void Main(string[] args)
    {
        // Створюємо посередника
        ConcreteMediator mediator = new ConcreteMediator();

        // Створюємо компоненти
        Component component1 = new ConcreteComponent(mediator);
        Component component2 = new ConcreteComponent(mediator);
        Component component3 = new ConcreteComponent(mediator);

        // Додаємо компоненти до посередника
        mediator.AddComponent(component1);
        mediator.AddComponent(component2);
        mediator.AddComponent(component3);

        // Відправляємо повідомлення
        component1.Send("Привiт, я перший компонент!");
    }
}
