namespace North.Identity.Core.Exceptions;

public class InvalidAggregateIdException : DomainException
{
    public override string Code { get; } = "invalid_id";

    public InvalidAggregateIdException() : base("Invalid aggregate id")
    {
    }
}
