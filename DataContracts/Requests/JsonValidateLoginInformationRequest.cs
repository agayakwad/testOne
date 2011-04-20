using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using HiRePro.JSONServiceLayer.CommonManagement.DataContracts;

namespace HiRePro.JSONServiceLayer.UserManagement.DataContracts.Requests
{
    [DataContract]
    public class JsonValidateLoginInformationRequest : JsonTenantAdamInfo
    {
        [DataMember]
        public int Id
        {
            get;
            set;
        }
        [DataMember]
        public string LoginName
        {
            get;
            set;
        }
        [DataMember]
        public string FirstName
        {
            get;
            set;
        }
        [DataMember]
        public string Email1
        {
            get;
            set;
        }
        [DataMember]
        public TypeOfUser TypeOfUser
        {
            get;
            set;
        }
    }
}