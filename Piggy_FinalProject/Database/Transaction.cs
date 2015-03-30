using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Piggy_FinalProject.Database
{
    [Table]
    public class Transaction
    {
        [Column(IsDbGenerated = true, IsPrimaryKey = true)]
        public int ID
        {
            get;
            set;
        }
        [Column]
        public int TransactionType
        {
            get;
            set;
        }
        [Column]
        public int CategoryID
        {
            get;
            set;
        }
        [Column]
        public double Amount
        {
            get;
            set;
        }
        [Column]
        public DateTime dateTime
        {
            get;
            set;
        }
        [Column]
        public string Description
        {
            get;
            set;
        }
        [Column]
        public int MethodID
        {
            get;
            set;
        }
    }
}
