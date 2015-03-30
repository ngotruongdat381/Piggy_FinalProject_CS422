using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piggy_FinalProject.Database
{
    [Table]
    public class TransactionType
    {
        [Column(IsDbGenerated = true, IsPrimaryKey = true)]
        public int ID
        {
            get;
            set;
        }
        [Column]
        public int Description
        {
            get;
            set;
        }
    }
}
