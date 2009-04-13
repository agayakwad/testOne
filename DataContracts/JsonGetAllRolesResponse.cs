using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using HiRePro.JSONServiceLayer.BaseResponse;

namespace HiRePro.JSONServiceLayer.UserManagement.DataContracts
{
    [DataContract]
   public class JsonGetAllRolesResponse : ResponseBase
   {
        [DataMember]
        public List<JsonRole> roleCollection { get; set; }

        [DataMember]
        public int RecordCount { get; set; }
   }
}
