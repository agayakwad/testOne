using System.Runtime.Serialization;

namespace HiRePro.JSONServiceLayer.CommonManagement.DataContracts {
    [DataContract]
    public class JsonUpdateSystemRolesByIdRequest : JsonTenantAdamInfo {
        [DataMember]
        public int[] AddedRoleIds;
        [DataMember]
        public int[] RemovedRoleIds;
    }
}
