using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HiRePro.JSONServiceLayer.BaseResponse;
using System.Runtime.Serialization;

namespace HiRePro.JSONServiceLayer.UserManagement.DataContracts.Response
{
    [DataContract]
    public class JsonUserSearchResponse :ResponseBase
    {

        [DataMember]
        public IList<JsonUser> JsonUserCollection
        {
            get;
            set;
        }
        [DataMember]
        public int RecordCount
        {
            get;
            set;
        }
    }
}
