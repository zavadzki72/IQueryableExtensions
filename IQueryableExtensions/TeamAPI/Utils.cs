using System;
using System.Collections.Generic;
using TeamAPI.Models;

namespace TeamAPI
{
    public static class Utils
    {

        private static readonly List<Team> TeamList = new()
        {
            new Team
            {
                Id = 1,
                CreateDate = DateTime.Now.Date,
                Name = "São Paulo Futebol Clube",
                Initials = "SPFC",
                NickName = "Soberano",
                City = "São Paulo",
                State = "SP",
                CreationYear = 1930
            },
            new Team
            {
                Id = 2,
                CreateDate = DateTime.Now.Date,
                Name = "Sport Club Corinthians Paulista",
                Initials = "COR",
                NickName = "Timão",
                City = "Tatuapé",
                State = "SP",
                CreationYear = 1910
            },
            new Team
            {
                Id = 3,
                CreateDate = DateTime.Now.Date,
                Name = "Santos Futebol Clube",
                Initials = "SAN",
                NickName = "Peixe",
                City = "Santos",
                State = "SP",
                CreationYear = 1912
            },
            new Team
            {
                Id = 4,
                CreateDate = DateTime.Now.Date,
                Name = "Sociedade Esportiva Palmeiras",
                Initials = "SEP",
                NickName = "Porco",
                City = "Perdizes",
                State = "SP",
                CreationYear = 1914
            },
            new Team
            {
                Id = 5,
                CreateDate = DateTime.Now.Date,
                Name = "Red Bull Bragantino",
                Initials = "RBB",
                NickName = "Massa Bruta",
                City = "Bragança Paulista",
                State = "SP",
                CreationYear = 1928
            },
            new Team
            {
                Id = 6,
                CreateDate = DateTime.Now.Date,
                Name = "Club Athletico Paranaense",
                Initials = "CAP",
                NickName = "Furacão",
                City = "Curitiba",
                State = "PR",
                CreationYear = 1850
            },
            new Team
            {
                Id = 7,
                CreateDate = DateTime.Now.Date,
                Name = "Coritiba Foot Ball Club",
                Initials = "CFC",
                NickName = "Coxa",
                City = "Curitiba",
                State = "PR",
                CreationYear = 1924
            },
            new Team
            {
                Id = 8,
                CreateDate = DateTime.Now.Date,
                Name = "Paraná Clube",
                Initials = "PAR",
                NickName = "Tricolor Paranaense",
                City = "Curitiba",
                State = "PR",
                CreationYear = 1989
            }
        };

        public static void PopulateMemoryDatabase(TeamDbContext context)
        {
            context.Teams.AddRange(TeamList);
            context.SaveChanges();
        }

    }
}
