namespace lab1.Assessment.Question2; 

public class BugReport : Ticket {
    
    public BugReport() {
        Description = "BugReport";
    }

    public override double GetDeadline() {
        Deadline = 2;
        return Deadline;
    }
}
