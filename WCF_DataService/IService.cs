using System.ServiceModel;
using System.ServiceModel.Web;
using WCF_DataService.Models;

namespace WCF_DataService
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        [WebGet(UriTemplate="Employees",ResponseFormat=WebMessageFormat.Json)]
        Employee[] GetEmployees();
    }
}
