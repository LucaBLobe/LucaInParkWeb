namespace LucaInParkWeb.Models.Domain.Entities
{
    public class BaseEntity
    {
        public static string GeneratorId()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
