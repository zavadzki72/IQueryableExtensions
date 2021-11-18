using AspNetCore.IQueryable.Extensions;
using AspNetCore.IQueryable.Extensions.Pagination;
using AspNetCore.IQueryable.Extensions.Sort;

namespace TeamAPI.Models.Dtos
{
    public class GetTeamFilterDto : ICustomQueryable, IQueryPaging, IQuerySort
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Initials { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string NickName { get; set; }
        public int? CreationYear { get; set; }
        public int? Limit { get; set; } = 5;
        public int? Offset { get; set; }
        public string Sort { get; set; }
    }
}
