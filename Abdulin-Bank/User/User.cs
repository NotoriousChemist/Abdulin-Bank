using System.ComponentModel.DataAnnotations;

public class User
{
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    [AllowedNameSymbols]
    public string FirstName { get; set; }

    [Required]
    [AllowedNameSymbols]
    public string LastName { get; set; }

    [AllowedNameSymbols]
    public string? Patronymic { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    public List<BankAccount> BankAccounts { get; set; } = new List<BankAccount>();
    
    public int jjjjjj { get; set; }

    public string FullName => $"{LastName} {FirstName} {Patronymic}".Trim();
}