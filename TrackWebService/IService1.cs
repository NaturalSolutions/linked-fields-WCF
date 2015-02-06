using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TrackWebService
{
    /// <summary>
    /// Web service interface
    /// </summary>
    [ServiceContract]
    public interface IService1
    {

        /// <summary>
        /// Return all linked fields in the database
        /// </summary>
        /// <returns>all linked fields</returns>
        [OperationContract]
        [WebGet(UriTemplate = "linkedFields", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        linkedFieldsInformation GetAllLinkedFields();

    }
}
