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
using HiRePro.JSONServiceLayer.JSONInfrastructureServices.InfraDataContracts;
using System.Runtime.Serialization;

namespace HiRePro.JSONServiceLayer.UserManagement
{
    [DataContract]
    public class JResetPasswordResponse : AjaxCommonCriteria
    {
        private bool _isResetSuccessfully;

        [DataMember]
        public bool IsResetSuccessfully
        {
            get { return _isResetSuccessfully; }
            set { _isResetSuccessfully = value; }
        }
    }
}
