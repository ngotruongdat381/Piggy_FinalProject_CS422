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
    public class Reminder
    {
        [Column(IsDbGenerated = true, IsPrimaryKey = true)]
        public int ID
        {
            get;
            set;
        }
        [Column]
        public DateTime Datetime
        {
            get;
            set;
        }
        [Column]
        public bool isRepeat
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
        public int ReminderTypeID
        {
            get;
            set;
        }
        [Column]
        public string ExtraParameter
        {
            get;
            set;
        }
    }
}
