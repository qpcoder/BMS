/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace QPC.BMS.WebApi
{
    /// NOTE: 
    /// You can use the "Rename" command on the "Refactor" menu to change the interface name "IMainServices" in both code and config file together.
    [ServiceContract]
    public interface IMainServices
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "GetMessage",
        Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json)]
        string GetMessage();

        [OperationContract]
        [WebInvoke(UriTemplate = "PostMessage", Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        string PostMessage(string userName);
    }
}
