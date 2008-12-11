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

namespace HiRePro.JSONServiceLayer.UserManagement
{
    [DataContract]
    public class JForgetPasswordResponse : AjaxCommonCriteria
    {
        private string _hintQue;
        private string _hintAns;
        private int _userId;
        private string _userName;

        [DataMember]
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        [DataMember]
        public int UId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        [DataMember]
        public string HintAns
        {
            get { return _hintAns; }
            set { _hintAns = value; }
        }
        [DataMember]
        public string HintQue
        {
            get { return _hintQue; }
            set { _hintQue = value; }
        }
    }
}
