using System.ComponentModel.DataAnnotations;

namespace LockWise.Data.Models;

public class PasswordEntry
{
    public int Id { get; set; }

    [Required, MaxLength(200)]
    public string Name { get; set; } = string.Empty;

    [Required, MaxLength(256)]
    public string UserName { get; set; } = string.Empty;

    [Required]
    public string EncryptedPassword { get; set; } = string.Empty;

    [Url, MaxLength(2048)]
    public string? Website { get; set; }

    public string UserId { get; set; } = string.Empty;

    public ApplicationUser? User { get; set; }

    [Required]
    public int FolderId { get; set; }
    public Folder? Folder { get; set; }
}