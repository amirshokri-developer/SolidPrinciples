public class RaterFactory
{
    private readonly ILogger _logger;

    public RaterFactory(ILogger logger)
    {
        _logger = logger;
    }

    public Rater Create(Policy policy)
    {
        switch (policy.Type)
        {
            case PolicyType.Auto:
                return new AutoPolicyRater(_logger);

            case PolicyType.Flood:
                return new FloodPolicyRater(_logger);

            case PolicyType.Land:
                return new LandPolicyRater(_logger);

            case PolicyType.Life:
                return new LifePolicyRater(_logger);

            default:
                // currently this can't be reached 
                return new UnknownPolicyRater(_logger);
        }
    }
}
