using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using HiRePro.JSONServiceLayer.CommonManagement.DataContracts;

namespace HiRePro.JSONServiceLayer.UserManagement.DataContracts.Requests
{
    [DataContract]
    public class JsonAddOrRemoveUserToRoleRequest : JsonTenantAdamInfo
    {
        [DataMember]
        public string RoleName { get; set; }

        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public string[] UpdateAddedRoleName { get; set; }

        [DataMember]
        public string[] UpdateRemovedRoleName { get; set; }

    }
}
