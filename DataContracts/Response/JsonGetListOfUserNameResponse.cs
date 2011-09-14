using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using HiRePro.JSONServiceLayer.BaseResponse;

namespace HiRePro.JSONServiceLayer.UserManagement.DataContracts.Response {
    [DataContract]
    public class JsonGetListOfUserNameResponse : ResponseBase {
        /// <summary>
        /// Gets or sets the get names output list.
        /// </summary>
        /// <value>The get names output list.</value>
        [DataMember]
        public List<JsonUserNamesOutput> GetNamesOutputList { get; set; }
    }
}
