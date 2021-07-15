using Adapter;
using Adapter.Interfaces;
using Bridge;
using Builder;
using Composite;
using System;
using Command;
using Mediator;
using Observer;
using Strategy;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("COMMAND");
            Invoker invoker = new Invoker();
            invoker.SetOnStart(new SimpleCommand("Say Hi!"));
            Receiver receiver = new Receiver();
            invoker.SetOnFinish(new ComplexCommand(receiver, "Send Email", "Save Report"));
            invoker.DoSomethingImportant();
            Console.WriteLine("-------------------------------------------------------------------------------");


            Console.WriteLine("MEDIATOR");
            Component1 component1 = new Component1();
            Component2 component2 = new Component2();
            new ConcreteMediator(component1, component2);
            Console.WriteLine("Client triggers operation A.");
            component1.DoA();
            Console.WriteLine();
            Console.WriteLine("Client triggers operation D.");
            component2.DoD();
            Console.WriteLine("-------------------------------------------------------------------------------");


            Console.WriteLine("OBSERVER");
            var subject = new Subject();
            var observerA = new ConcreteObserverA();
            subject.Attach(observerA);
            var observerB = new ConcreteObserverB();
            subject.Attach(observerB);
            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();
            subject.Detach(observerB);
            subject.SomeBusinessLogic();
            Console.WriteLine("-------------------------------------------------------------------------------");


            Console.WriteLine("STRATEGY");
            var context = new Context();
            Console.WriteLine("Client: Strategy is set to normal sorting.");
            context.SetStrategy(new ConcreteStrategyA());
            context.DoSomeBusinessLogic();
            Console.WriteLine();
            Console.WriteLine("Client: Strategy is set to reverse sorting.");
            context.SetStrategy(new ConcreteStrategyB());
            context.DoSomeBusinessLogic();
            Console.WriteLine("-------------------------------------------------------------------------------");


            Console.WriteLine("ABSTRACT_FACTORY");
            new Abstract.Client().Main();
            Console.WriteLine("-------------------------------------------------------------------------------");


            Console.WriteLine("BUILDER");
            var director = new Director();
            var builder = new ConcreteBuilder();
            director.Builder = builder;
            Console.WriteLine("Standard basic product:");
            director.BuildMinimalViableProduct();
            Console.WriteLine(builder.GetProduct().ListParts());
            Console.WriteLine("Standard full featured product:");
            director.BuildFullFeaturedProduct();
            Console.WriteLine(builder.GetProduct().ListParts());
            Console.WriteLine("Custom product:");
            builder.BuildPartA();
            builder.BuildPartC();
            Console.Write(builder.GetProduct().ListParts());
            Console.WriteLine("-------------------------------------------------------------------------------");


            Console.WriteLine("FACTORY");
            new Factory.Client().Main();
            Console.WriteLine("-------------------------------------------------------------------------------");


            Console.WriteLine("ADAPTER");
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter.Adapter(adaptee);
            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");
            Console.WriteLine(target.GetRequest());
            Console.WriteLine("-------------------------------------------------------------------------------");


            Console.WriteLine("SINGLETON");
            Singleton.Singleton s1 = Singleton.Singleton.GetInstance();
            Singleton.Singleton s2 = Singleton.Singleton.GetInstance();

            if (s1 == s2)
                Console.WriteLine("Singleton works");
            else
                Console.WriteLine("Singleton failed");
            Console.WriteLine("-------------------------------------------------------------------------------");


            Console.WriteLine("BRIDGE");
            Bridge.Client bridgeClient = new Bridge.Client();
            Abstraction abstraction = new Abstraction(new ConcreteImplementationA());
            bridgeClient.ClientCode(abstraction);
            Console.WriteLine();
            abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
            bridgeClient.ClientCode(abstraction);
            Console.WriteLine("-------------------------------------------------------------------------------");


            Console.WriteLine("COMPOSITE");
            Composite.Client client = new Composite.Client();
            Leaf leaf = new Leaf();
            Console.WriteLine("Client: I get a simple component:");
            client.ClientCode(leaf);
            Composite.Composite tree = new Composite.Composite();
            Composite.Composite branch1 = new Composite.Composite();
            branch1.Add(new Leaf());
            branch1.Add(new Leaf());
            Composite.Composite branch2 = new Composite.Composite();
            branch2.Add(new Leaf());
            tree.Add(branch1);
            tree.Add(branch2);
            Console.WriteLine("Client: Now I've got a composite tree:");
            client.ClientCode(tree);
            Console.Write("Client: I don't need to check the components classes even when managing the tree:\n");
            client.ClientCode2(tree, leaf);
            Console.WriteLine("-------------------------------------------------------------------------------");
        }
    }
}
