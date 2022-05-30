namespace lab1.Assessment.Question2;

public class BacklogReissue : Decorator {

    public BacklogReissue(Ticket ticket) : base(ticket) {
    }
    
    public override string GetModifier() {
        Ticket.Description += ", BacklogReissue";
        return Ticket.Description;
    }

    public override double GetDeadline() {
        Ticket.Deadline += 100;
        return Ticket.Deadline;
    }
}
