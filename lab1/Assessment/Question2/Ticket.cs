namespace lab1.Assessment.Question2;

public abstract class Ticket {
    public string Description = "";
    public double Deadline = 1;

    public virtual string GetModifier() {
        return Description;
    }

    public abstract double GetDeadline();
}
