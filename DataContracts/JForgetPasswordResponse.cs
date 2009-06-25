using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Runtime.Serialization;
using HiRePro.JSONServiceLayer.JSONInfrastructureServices.InfraDataContracts;
using HiRePro.JSONServiceLayer.BaseResponse;

namespace HiRePro.JSONServiceLayer.UserManagement
{
    [DataContract]
    public class JsonForgetPasswordResponse : ResponseBase
    {
        #region Properties
        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>The name of the user.</value>
        [DataMember]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the U id.
        /// </summary>
        /// <value>The U id.</value>
        [DataMember]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the hint answer.
        /// </summary>
        /// <value>The hint answer.</value>
        [DataMember]
        public string HintAnswer { get; set; }

        /// <summary>
        /// Gets or sets the hint question.
        /// </summary>
        /// <value>The hint question.</value>
        [DataMember]
        public string HintQuestion { get; set; } 
        #endregion
    }
}
