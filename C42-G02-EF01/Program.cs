using Microsoft.EntityFrameworkCore;

namespace C42_G02_EF01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region v1
            //Generation Schema
            //1.TPC --> default Behaviour
            //    Table Per Class

            //2.TPH

            //3.TPCC
            //    Table Per Concrete Class
            #endregion

            #region V2
            CompanyG030DBContext context = new CompanyG030DBContext();
            //var Result =context.Employees.Where(E=>E.EmpId ==1).FirstOrDefault();
            context.Database.Migrate();
            #endregion
        }
    }
}
