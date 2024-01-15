

public class RatingEngine
{
    public IRatingContext Context { get; set; } = new DefaultRatingContext();
    public decimal Rating { get; set; }
    public RatingEngine()
    {
        Context.Engine = this;
    }
    public void Rate()
    {
        Context.Log("Starting rate.");

        Context.Log("Loading policy.");

        string policyJson = Context.LoadPolicyFromFile();

        var policy = Context.GetPolicyFromJsonString(policyJson);

        var factory = new RaterFactory();

        var rater = factory.Create(policy, Context);
        
        rater.Rate(policy);
        
        Context.Log("Rating completed.");
    }
}