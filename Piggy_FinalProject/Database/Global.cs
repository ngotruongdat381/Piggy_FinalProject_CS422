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
    public class Global
    {
        [Column(IsDbGenerated = true, IsPrimaryKey = true)]
        public int ID
        {
            get;
            set;
        }
        [Column]
        public string ParaName
        {
            get;
            set;
        }
        [Column]
        public string Type
        {
            get;
            set;
        }
        [Column]
        public string Value
        {
            get;
            set;
        }
        [Column]
        public bool Status
        {
            get;
            set;
        }
    }
}
