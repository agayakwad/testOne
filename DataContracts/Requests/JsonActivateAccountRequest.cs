using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HiRePro.JSONServiceLayer.CommonManagement.DataContracts;
using System.Runtime.Serialization;

namespace HiRePro.JSONServiceLayer.UserManagement.DataContracts.Requests
{
    [DataContract]
    public class JsonActivateAccountRequest : JsonTenantAdamInfo
    {
        [DataMember]
        public string EmailId { get; set; }

        [DataMember]
        public bool SendActivationMail { get; set; } 
    }
}
