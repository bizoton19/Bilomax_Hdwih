using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilomax.Generic.Infrastructure.Querying
{
    public class Query
    {
        private IList<Query> _subQueries = new List<Query>();
        private IList<Criterion> _criteria = new List<Criterion>();
        public IEnumerable<Criterion> Criteria
        {
            get { return _criteria; }
        }
        public IEnumerable<Query> Subqueries
        {
            get { return _subQueries; }
        }

        public void AddSubQuery(Query subQuery)
        {
            _subQueries.Add(subQuery);
        }
        public void Add(Criterion criterion)
        {
            _criteria.Add(criterion);
        }
        public QueryOperator QueryOperator { get; set; }
        public OrderByClause OrderByProperTy { get; set; }
    }
}
