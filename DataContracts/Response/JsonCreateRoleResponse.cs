using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using HiRePro.JSONServiceLayer.BaseResponse;

namespace HiRePro.JSONServiceLayer.UserManagement.DataContracts.Response
{
    [DataContract]
    public class JsonCreateRoleResponse: ResponseBase
    {
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="JsonCreateRoleResponse"/> is created.
        /// </summary>
        /// <value><c>true</c> if created; otherwise, <c>false</c>.</value>
        [DataMember]
        public bool Created { get; set; }
    }

    [DataContract]
    public class JsonDeleteRoleResponse : ResponseBase
    {
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="JsonDeleteRoleResponse"/> is deleted.
        /// </summary>
        /// <value><c>true</c> if deleted; otherwise, <c>false</c>.</value>
        [DataMember]
        public bool Deleted { get; set; }
    }
}
