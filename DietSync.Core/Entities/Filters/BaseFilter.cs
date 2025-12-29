namespace DietSync.Core.Entities.Filters
{
    public class BaseFilter
    {
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public string Sort { get; set; } = string.Empty;
    }
}
