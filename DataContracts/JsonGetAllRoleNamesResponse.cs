using System.Runtime.Serialization;
using HiRePro.JSONServiceLayer.BaseResponse;

namespace HiRePro.JSONServiceLayer.CommonManagement.DataContracts {
    [DataContract]
    public class JsonGetAllRoleNamesResponse : ResponseBase {
        [DataMember]
        public GetAllRoleNames[] AllRoleNames;
    }

    [DataContract]
    public class GetAllRoleNames {
        [DataMember]
        public int ObjectId { get; set; }
        [DataMember]
        public bool IsSystemRole { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}
