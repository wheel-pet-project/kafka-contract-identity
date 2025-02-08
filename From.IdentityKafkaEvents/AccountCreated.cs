namespace From.IdentityKafkaEvents;

public class AccountCreated
{
    public AccountCreated(Guid eventId, Guid accountId, string email, string phone, string confirmationUrl)
    {
        EventId = eventId;
        AccountId = accountId;
        Email = email;
        Phone = phone;
        ConfirmationUrl = confirmationUrl;
    }
    
    public Guid EventId { get; private set; }
    
    public Guid AccountId { get; private set; }
    
    public string Email { get; private set; }
    
    public string Phone { get; private set; }
    
    public string ConfirmationUrl { get; private set; }
}