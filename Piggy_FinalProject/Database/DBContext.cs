using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piggy_FinalProject.Database
{
    public class DBContext:DataContext
    {
        public static string DBConnectionString = @"isostore:/Databases.sdf";
        public DBContext(string connectionString)
            : base(connectionString)
        { }
        public Table<Wallet> WalletTable;
        public Table<Category> CategoryTable;
        public Table<Global> GlobalTable;
        public Table<Method> MethodTable;
        public Table<Reminder> ReminderTable;
        public Table<ReminderType> ReminderTypeTable;
        public Table<SavingPlan> SavingPlanTable;
        public Table<Transaction> TransactionTable;
        public Table<TransactionType> TransactionTypeTable;
    }
}
