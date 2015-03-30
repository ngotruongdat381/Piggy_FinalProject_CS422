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
    public class Wallet
    {
        [Column(IsDbGenerated = true, IsPrimaryKey = true)]
        public int ID
        {
            get;
            set;
        }
        [Column]
        public string Name
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
        public double Balance
        {
            get;
            set;
        }
        [Column]
        public double Expense
        {
            get;
            set;
        }
    }
}
