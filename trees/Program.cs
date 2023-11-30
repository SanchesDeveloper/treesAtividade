using System;
using System.Collections.Generic;

class Node
{
    public string Name { get; set; }
    public List<Node> Children { get; set; }

    public Node(string name)
    {
        Name = name;
        Children = new List<Node>();
    }

    public void AddChild(Node child)
    {
        Children.Add(child);
    }

    public void Display(int depth = 0)
    {
        Console.WriteLine(new string('-', depth) + Name);

        foreach (var child in Children)
        {
            child.Display(depth + 2);
        }
    }
}

class Program
{
    static void Main()
    {
        // Criar um organograma simples
        Node root = new Node("CEO");

        Node cto = new Node("CTO");
        Node cfo = new Node("CFO");

        Node devManager = new Node("Development Manager");
        Node qaManager = new Node("QA Manager");
        Node financeManager = new Node("Finance Manager");

        Node devTeamLead = new Node("Development Team Lead");
        Node devEngineer1 = new Node("Dev Engineer 1");
        Node devEngineer2 = new Node("Dev Engineer 2");

        Node qaEngineer1 = new Node("QA Engineer 1");
        Node qaEngineer2 = new Node("QA Engineer 2");

        Node accountant = new Node("Accountant");

        root.AddChild(cto);
        root.AddChild(cfo);

        cto.AddChild(devManager);
        cto.AddChild(qaManager);

        devManager.AddChild(devTeamLead);
        devTeamLead.AddChild(devEngineer1);
        devTeamLead.AddChild(devEngineer2);

        qaManager.AddChild(qaEngineer1);
        qaManager.AddChild(qaEngineer2);

        cfo.AddChild(financeManager);
        financeManager.AddChild(accountant);

        // Exibir o organograma
        root.Display();
    }
}