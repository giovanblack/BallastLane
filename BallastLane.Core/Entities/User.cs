using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallastLane.Core.Entities
{
	[Table("User", Schema = "dbo")]
	public partial class User
	{

		[PrimaryKey, Identity]
		[Column("Id")]
		public long Id { get; set; }

		[Column("AgentId")]
		public long? AgentId { get; set; }

		[Column("UserName")]
		public string UserName { get; set; }

		[Column("PasswordHash")]
		public string PasswordHash { get; set; }

		[Column("FirstName")]
		public string FirstName { get; set; }

		[Column("LastName")]
		public string LastName { get; set; }

		[Column("Email")]
		public string Email { get; set; }

		[Column("Active")]
		public bool? Active { get; set; }

		[Column("CreateByUserId")]
		public long CreateByUserId { get; set; }

		[Column("CreateDate")]
		public DateTime CreateDate { get; set; }

		[Column("ModifyByUserId")]
		public long? ModifyByUserId { get; set; }

		[Column("ModifyDate")]
		public DateTime? ModifyDate { get; set; }

		[Column("DeleteByUserId")]
		public long? DeleteByUserId { get; set; }

		[Column("DeleteDate")]
		public DateTime? DeleteDate { get; set; }

		[Column("Deleted")]
		public bool Deleted { get; set; }

		[Column("MiddleName")]
		public string MiddleName { get; set; }


	}
}
