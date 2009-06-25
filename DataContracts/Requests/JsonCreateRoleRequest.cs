using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HiRePro.JSONServiceLayer.CommonManagement.DataContracts;
using System.Runtime.Serialization;

namespace HiRePro.JSONServiceLayer.UserManagement.DataContracts.Requests
{
    [DataContract]
    public class JsonCreateRoleRequest : JsonTenantAdamInfo
    {
        #region Fields

        private JsonRole _jsonRole;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the json role.
        /// </summary>
        /// <value>The json role.</value>
        [DataMember]
        public JsonRole JsonRole
        {
            get { return _jsonRole; }
            set { _jsonRole = value; }
        }

        #endregion

    }

    [DataContract]
    public class JsonDeleteRoleRequest : JsonTenantAdamInfo
    {
        #region Fields

        private JsonRole _jsonRole;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the json role.
        /// </summary>
        /// <value>The json role.</value>
        [DataMember]
        public JsonRole JsonRole
        {
            get { return _jsonRole; }
            set { _jsonRole = value; }
        }

        #endregion

    }
}
