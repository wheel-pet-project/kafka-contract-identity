namespace From.IdentityKafkaEvents;

public class AccountCreated
{
    public AccountCreated(Guid eventId, Guid id, string email, string phone, string confirmationUrl)
    {
        EventId = eventId;
        Id = id;
        Email = email;
        Phone = phone;
        ConfirmationUrl = confirmationUrl;
    }
    
    public Guid EventId { get; private set; }
    
    public Guid Id { get; private set; }
    
    public string Email { get; private set; }
    
    public string Phone { get; private set; }
    
    public string ConfirmationUrl { get; private set; }
}