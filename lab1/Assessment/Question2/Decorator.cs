namespace lab1.Assessment.Question2;

public abstract class Decorator : Ticket {
    protected readonly Ticket Ticket;
    protected Decorator(Ticket ticket) {
        Ticket = ticket;
    }
    
    public abstract override string GetModifier();
    public abstract override double GetDeadline();
}
