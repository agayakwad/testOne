using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Collections;
using HiRePro.JSONServiceLayer.CommonManagement.DataContracts;

namespace HiRePro.JSONServiceLayer.UserManagement.DataContracts.Requests
{
    [DataContract]
    public class JsonCreateRolesForUserRequest : JsonTenantAdamInfo
    {      
        [DataMember]
        public IList<JsonRole> UserRoles { get; set; }

    }
}
