public class RaterFactory
{
    public Rater Create(Policy policy, IRatingContext context)
    {
        switch (policy.Type)
        {
            case PolicyType.Auto:
                return new AutoPolicyRater(new RatingUpdater(context.Engine));

            case PolicyType.Flood:
                return new FloodPolicyRater(new RatingUpdater(context.Engine));

            case PolicyType.Land:
                return new LandPolicyRater(new RatingUpdater(context.Engine));

            case PolicyType.Life:
                return new LifePolicyRater(new RatingUpdater(context.Engine));

            default:
                // currently this can't be reached 
                return new UnknownPolicyRater(new RatingUpdater(context.Engine));
        }
    }
}
