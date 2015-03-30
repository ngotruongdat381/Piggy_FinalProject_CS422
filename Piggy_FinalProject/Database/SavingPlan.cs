using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piggy_FinalProject.Database
{
    [Table]
    public class SavingPlan
    {
        [Column(IsDbGenerated = true, IsPrimaryKey = true)]
        public int ID
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
        public DateTime StartDate
        {
            get;
            set;
        }
        [Column]
        public DateTime EndDate
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
    }
}
