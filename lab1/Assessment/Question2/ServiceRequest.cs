namespace lab1.Assessment.Question2; 

public class ServiceRequest : Ticket {
    
    public ServiceRequest() {
        Description = "ServiceRequest";
    }

    public override double GetDeadline() {
        Deadline = 4;
        return Deadline;
    }
}
