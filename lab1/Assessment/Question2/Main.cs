namespace lab1.Assessment.Question2; 

public class Main {
    public void Make() {
        Ticket ticket = new BugReport();
        Console.WriteLine(ticket.GetModifier());
        Console.WriteLine(ticket.GetDeadline());
        
        ticket = new BacklogReissue(ticket);
        Console.WriteLine(ticket.GetModifier());
        Console.WriteLine(ticket.GetDeadline());

        Ticket ticket2 = new ServiceRequest();
        Console.WriteLine(ticket2.GetModifier());
        Console.WriteLine(ticket2.GetDeadline());
        
        ticket2 = new WhiteGloveClient(ticket2);
        Console.WriteLine(ticket2.GetModifier());
        Console.WriteLine(ticket2.GetDeadline());
    }
}
