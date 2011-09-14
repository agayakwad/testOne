using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace HiRePro.JSONServiceLayer.UserManagement.DataContracts.Response {
    [DataContract]
    public class JsonUserNamesOutput {
        #region Public Properties

        /// <summary>
        /// Gets or sets the name of the User.
        /// </summary>
        /// <value>The name of the User.</value>
        [DataMember]
        public string CommonName { get; set; }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        /// <value>The user id.</value>
        [DataMember]
        public int CommonId { get; set; }

        /// <summary>
        /// Gets or sets the email of the user.
        /// </summary>
        /// <value>The email of the user.</value>
        [DataMember]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the source type of the user.
        /// </summary>
        /// <value>The source type of the user.</value>
        [DataMember]
        public string SourceTypeText { get; set; }

        #endregion
    }
}
