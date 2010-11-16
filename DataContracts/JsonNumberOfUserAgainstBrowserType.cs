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
using System.Runtime.Serialization;
using HirePro.Framework.UI.Windows.Business;
using HirePro.Framework.UI.Windows.Business.Base.Utility;
using HiRePro.JSONServiceLayer.CommonManagement.DataContracts;
using System.Collections.Generic;
using HiRePro.JSONServiceLayer.BaseResponse;

namespace HiRePro.JSONServiceLayer.UserManagement.DataContracts
{

    [DataContract]
    public class JsonNumberOfUserAgainstBrowserType 
    {      

        [DataMember]
        public string BrowserDetails { get; set; }
    
        [DataMember]
        public int TotalNumberOfUsers { get; set; }
    }

}
