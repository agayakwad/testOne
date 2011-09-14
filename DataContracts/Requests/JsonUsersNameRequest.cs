using System.Runtime.Serialization;
using HiRePro.JSONServiceLayer.CommonManagement.DataContracts;

namespace HiRePro.JSONServiceLayer.UserManagement.DataContracts.Requests {
    [DataContract]
    public class JsonUsersNameRequest {
        #region Properties
        [DataMember]
        public bool IsAllUserRequired { get; set; }

        [DataMember]
        public bool IsInterviewerOnly { get; set; }

        [DataMember]
        public bool IsDeletedEntityBeIncluded { get; set; }

        [DataMember]
        public TypeOfUser TypeofUser { get; set; }

        [DataMember]
        public bool IsRPOUserRequired { get; set; }

        [DataMember]
        public bool IsRefresh { get; set; }

        [DataMember]
        public ObjectState ObjectState { get; set; }
        #endregion
    }
}
