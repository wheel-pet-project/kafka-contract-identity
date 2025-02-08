namespace From.IdentityKafkaEvents;

public class PasswordRecoverTokenCreated
{
    public PasswordRecoverTokenCreated(Guid eventId, Guid accountId, string recoveryUrl)
    {
        EventId = eventId;
        AccountId = accountId;
        RecoveryUrl = recoveryUrl;
    }
    
    public Guid EventId { get; private set; }
    
    public Guid AccountId { get; private set; }
    
    public string RecoveryUrl { get; private set; }
}