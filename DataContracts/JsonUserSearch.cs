using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace HiRePro.JSONServiceLayer.UserManagement.DataContracts
{
    [DataContract]
    public class JsonUserSearch
    {
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>The email.</value>
        [DataMember]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the name of the login.
        /// </summary>
        /// <value>The name of the login.</value>
        [DataMember]
        public string LoginName { get; set; }

        /// <summary>
        /// Gets or sets the role ids.
        /// </summary>
        /// <value>The role ids.</value>
        [DataMember]
        public int[] RoleIds { get; set; }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>The name of the user.</value>
        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public int[] SourceIds { get; set; }

        [DataMember]
        public bool IsRolesNotIn { get; set; }
    }
}
