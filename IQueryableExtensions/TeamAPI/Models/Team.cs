using System;

namespace TeamAPI.Models
{
    public class Team
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string Name { get; set; }
        public string Initials { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string NickName { get; set; }
        public int CreationYear { get; set; }
    }
}
