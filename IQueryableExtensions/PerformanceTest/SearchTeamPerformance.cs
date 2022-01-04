using AspNetCore.IQueryable.Extensions;
using BenchmarkDotNet.Attributes;
using System.Collections.Generic;
using System.Linq;
using TeamAPI;
using TeamAPI.Models;
using TeamAPI.Models.Dtos;

namespace PerformanceTest
{
    public class SearchTeamPerformance
    {

        private readonly GetTeamFilterDto _filter = new GetTeamFilterDto
        {
            State = "SP"
        };

        [Benchmark]
        public List<Team> GetTeamsWithQueryableExtensions()
        {
            return Utils.TeamList.AsQueryable().Apply(new GetTeamFilterDto()).ToList();
        }

        [Benchmark]
        public List<Team> GetTeamsWithoutQueryableExtensions()
        {
            var filter = new GetTeamFilterDto();
            var query = from t in Utils.TeamList select t;

            if (filter.Id.HasValue)
                return query.Where(x => x.Id == filter.Id.Value).ToList();

            if (!string.IsNullOrWhiteSpace(filter.Name))
                query = query.Where(x => x.Name.Equals(filter.Name));

            if (!string.IsNullOrWhiteSpace(filter.Initials))
                query = query.Where(x => x.Initials.Equals(filter.Initials));

            if (!string.IsNullOrWhiteSpace(filter.City))
                query = query.Where(x => x.City.Equals(filter.City));

            if (!string.IsNullOrWhiteSpace(filter.State))
                query = query.Where(x => x.State.Equals(filter.State));

            if (!string.IsNullOrWhiteSpace(filter.NickName))
                query = query.Where(x => x.NickName.Equals(filter.NickName));

            if (filter.CreationYear.HasValue)
                query = query.Where(x => x.CreationYear == filter.CreationYear);

            var resultQuery = query.ToList();

            var pageNumber = filter.Offset ?? 1;
            var pageSize = filter.Limit ?? 5;

            resultQuery = resultQuery.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

            return resultQuery;
        }

        [Benchmark]
        public List<Team> GetTeamsWithQueryableExtensionsWithFilter()
        {
            return Utils.TeamList.AsQueryable().Apply(_filter).ToList();
        }

        [Benchmark]
        public List<Team> GetTeamsWithoutQueryableExtensionsWithFilter()
        {
            var filter = _filter;
            var query = from t in Utils.TeamList select t;

            if (filter.Id.HasValue)
                return query.Where(x => x.Id == filter.Id.Value).ToList();

            if (!string.IsNullOrWhiteSpace(filter.Name))
                query = query.Where(x => x.Name.Equals(filter.Name));

            if (!string.IsNullOrWhiteSpace(filter.Initials))
                query = query.Where(x => x.Initials.Equals(filter.Initials));

            if (!string.IsNullOrWhiteSpace(filter.City))
                query = query.Where(x => x.City.Equals(filter.City));

            if (!string.IsNullOrWhiteSpace(filter.State))
                query = query.Where(x => x.State.Equals(filter.State));

            if (!string.IsNullOrWhiteSpace(filter.NickName))
                query = query.Where(x => x.NickName.Equals(filter.NickName));

            if (filter.CreationYear.HasValue)
                query = query.Where(x => x.CreationYear == filter.CreationYear);

            var resultQuery = query.ToList();

            var pageNumber = filter.Offset ?? 1;
            var pageSize = filter.Limit ?? 5;

            resultQuery = resultQuery.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

            return resultQuery;
        }

    }
}
