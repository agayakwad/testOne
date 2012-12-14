using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using HiRePro.JSONServiceLayer.CommonManagement.DataContracts;

namespace HiRePro.JSONServiceLayer.UserManagement.DataContracts.Requests
{
    [DataContract]
    public class JsonArchiveUserRequest : JsonTenantAdamInfo
    {
        [DataMember]
        public bool IsArchived { get; set; }

        [DataMember]
        public int[] Ids { get; set; }  

    }
}
