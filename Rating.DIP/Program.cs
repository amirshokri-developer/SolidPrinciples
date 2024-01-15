

var logger = new ConsoleLogger();

var engine = new RatingEngine(logger,
    new FilePolicySource(),
    new JsonPolicySerializer(),
    new RaterFactory(logger));

engine.Rate();

if (engine.Rating > 0)
{
    Console.WriteLine($"Rating: {engine.Rating}");
}
else
{
    Console.WriteLine("No rating produced.");
}