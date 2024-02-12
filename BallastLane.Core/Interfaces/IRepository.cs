using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BallastLane.Core.Interfaces
{
	public interface IRepository<T> where T : class
	{
		void Insert(T entity);
		void Delete(T entity);
		void Update(T entity);
		IEnumerable<T> GetList(Expression<Func<T, bool>> filter = null,
		Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null);
	}
}
