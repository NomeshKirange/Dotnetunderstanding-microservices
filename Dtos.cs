using System; // <--- 1. NEED THIS for Guid and DateTimeOffset

namespace Play.Catalog.Service.Dtos
{
    // 2. Fixed "guid" to "Guid" (Capital G)
    public record ItemDto(Guid ID, string Name, string Description, decimal Price, DateTimeOffset CreatedDate);

    public record CreateItemDto(string Name, string Description, decimal Price);

    public record UpdateItemDto(string Name, string Description, decimal Price);
    
}