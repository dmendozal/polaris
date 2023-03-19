namespace Polaris.Domain.Common;

/// <summary>
/// Abstract class because the class shouldn't be instantiated.
/// </summary>
public abstract class BaseEntity
{
    public int Id { get; set; }
    public DateTime? CreatedDate { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? LastModifiedDate { get; set; }
    public string? LastModifiedBy { get; set;}
}
