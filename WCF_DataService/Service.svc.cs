using System.Linq;
using WCF_DataService.Models;

namespace WCF_DataService
{
    public class Service : IService
    {
        ApplicationEntities ctx;
        public Service()
        {
            ctx = new ApplicationEntities(); 
        }
        /// <summary>
        /// Method retrieves Employees using
        /// ADO.NET EF
        /// </summary>
        /// <returns></returns>
        public  Employee[] GetEmployees()
        {
            return ctx.Employees.ToArray();
        }
    }
}
