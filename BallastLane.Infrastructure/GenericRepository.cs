using LinqToDB;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq.Expressions;
using BallastLane.Core.Interfaces;
using System.Collections.Generic;

namespace BallastLane.Infrastructure
{
	public class GenericRepository<T> : IRepository<T> where T : class 
	{
		internal BallastLaneContext _ctx;



		public GenericRepository(BallastLaneContext context)
		{
			this._ctx = context;

		}

		public virtual IEnumerable<T> GetList(Expression<Func<T, bool>> filter = null,
		Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null)
		{
			IQueryable<T> query = _ctx.GetTable<T>();

			if (filter != null)
			{
				query = query.Where(filter);
			}


			if (orderBy != null)
			{
				return orderBy(query).ToList();
			}
			else
			{
				return query.ToList();
			}
		}

		public void Insert(T entity)
		{
			_ctx.Insert(entity);
		}


		public void Update(T entity)
		{
			_ctx.Update(entity);
		}


		public void Delete(T entity)
		{
			_ctx.Delete(entity);
		}

		private bool disposed = false;


		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					_ctx.Dispose();
				}
			}
			this.disposed = true;
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}


}
