namespace PetHome_MVC_Front.Models;

public class RegisterAsOwnerViewModel
{
	public string? FirstName { get; set; }
	public string? LastName { get; set; }
	public string? Email { get; set; }
	public string? PhoneNumber { get; set; }
	public string? Password { get; set; }
	public bool IsNewsletterSubscribed { get; set; }
	public IdentificationType IdentificationType { get; set; }
	public string? IdentificationNumber { get; set; }
}

public enum IdentificationType
{
	DNI,
	NIE
}