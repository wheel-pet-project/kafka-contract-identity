namespace From.IdentityKafkaEvents;

public class PasswordRecoverTokenCreated
{
    public PasswordRecoverTokenCreated(Guid eventId, string recoveryUrl)
    {
        EventId = eventId;
        RecoveryUrl = recoveryUrl;
    }
    
    public Guid EventId { get; private set; }
    
    public string RecoveryUrl { get; private set; }
}