namespace lab1.Assessment.Question2; 

public class WhiteGloveClient : Decorator {

    public WhiteGloveClient(Ticket ticket) : base(ticket) {
    }
    
    public override string GetModifier() {
        Ticket.Description += ", WhiteGloveClient";
        return Ticket.Description;
    }

    public override double GetDeadline() {
        Ticket.Deadline *= 0.8;
        return Ticket.Deadline;
    }
}
