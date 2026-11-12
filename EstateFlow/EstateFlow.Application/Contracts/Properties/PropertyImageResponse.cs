namespace EstateFlow.Application.Contracts.Properties;

public class PropertyImageResponse
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string FilePath { get; set; }
    public DateTime UploadedAt { get; set; }
    public Guid PropertyId { get; set; }
}
