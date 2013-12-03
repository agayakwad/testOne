using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HiRePro.JSONServiceLayer.BaseResponse;
using HiRePro.JSONServiceLayer.UserManagement.DataContracts;
using System.Runtime.Serialization;

namespace HiRePro.JSONServiceLayer.UserManagement.Response
{  
    [DataContract]
    public class JsonGetAllUserResponse : ResponseBase
    {
        [DataMember]
        public IList<JsonUser> JsonUserCollection
        {
            get;
            set;
        }

        [DataMember]
        public int RecordCount{
            get;
            set;}

    }
}
