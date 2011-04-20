using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using HiRePro.JSONServiceLayer.BaseResponse;

namespace HiRePro.JSONServiceLayer.UserManagement.Response
{
    [DataContract]
    public class JsonValidateLoginInformationResponse : ResponseBase
    {
        [DataMember]
        public bool IsUserEmailExists { get; set; }
        [DataMember]
        public bool IsUserNameExists { get; set; }
    }
}