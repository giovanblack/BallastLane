using BallastLane.Core.Entities;
using LinqToDB;
using LinqToDB.Data;


namespace BallastLane.Infrastructure
{
	public class BallastLaneContext : DataConnection
	{

		public BallastLaneContext(DataOptions<BallastLaneContext> options):base(options.Options){ }


		public ITable<User> Users => this.GetTable<User>();
	}
}
