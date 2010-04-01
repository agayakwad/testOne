using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using HiRePro.JSONServiceLayer.CommonManagement.DataContracts;

namespace HiRePro.JSONServiceLayer.UserManagement.DataContracts.Requests
{
    [DataContract]
    public class JsonGetAllUserRequest : JsonTenantAdamInfo
    {
        [DataMember]
        public JsonPagingCriteria PagingCriteria { get; set; }

        [DataMember]
        public TypeOfUser TypeOfUser { get; set; }
    }
}
