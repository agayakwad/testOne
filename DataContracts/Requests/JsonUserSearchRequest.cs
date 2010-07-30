using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using HiRePro.JSONServiceLayer.CommonManagement.DataContracts;

namespace HiRePro.JSONServiceLayer.UserManagement.DataContracts.Requests
{
    [DataContract]
    public class JsonUserSearchRequest : JsonTenantAdamInfo
    {
        [DataMember]
        public JsonPagingCriteria PagingCriteria { get; set; }

        [DataMember]
        public TypeOfUser TypeOfUser { get; set; }

        [DataMember]
        public int UserNameId { get; set; }

        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public string Email { get; set; }



    }
}
