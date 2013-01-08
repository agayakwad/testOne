using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HiRePro.JSONServiceLayer.CommonManagement.DataContracts;
using System.Runtime.Serialization;
using HiRePro.JSONServiceLayer.CommonManagement.DataContracts.EventDataContracts;

namespace HiRePro.JSONServiceLayer.UserManagement.DataContracts.Requests
{
    [DataContract]
   public class JsonCloneRoleRequest:JsonTenantAdamInfo
    {
        [DataMember]
        public int RoleId
        {
            get;
            set;
        }
        [DataMember]
        public string RoleName
        {
        get;set;
        }
    }
}
