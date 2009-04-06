using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HiRePro.JSONServiceLayer.CommonManagement.DataContracts;
using HirePro.Framework.Core.Utility.Enums;


namespace HiRePro.JSONServiceLayer.UserManagement.Translators
{
    public static class TranslateBetweenJsonPagingCriteriaAndPagingCriteriaType
    {

        public static JsonPagingCriteria ServiceToBusiness(Common.ServiceProxies.UserManagement.PagingCriteriaType from)
        {
            JsonPagingCriteria to = new JsonPagingCriteria();
            if (from != null)
            {
                to.MaxResults = from.MaxResults;
                to.PageNo = from.PageNumber;
                to.IsSpecificToUser = from.IsSpecificToUser;
                to.ObjectState = EnumAdapter.GetEnumValue<ObjectState>(from.ObjectState);
            }
            return to;
        }

        public static Common.ServiceProxies.UserManagement.PagingCriteriaType BusinessToService(JsonPagingCriteria from)
        {
            Common.ServiceProxies.UserManagement.PagingCriteriaType to = new Common.ServiceProxies.UserManagement.PagingCriteriaType();
            if (from != null)
            {
                to.MaxResults = from.MaxResults;
                to.PageNumber = from.PageNo;
                to.IsSpecificToUser = from.IsSpecificToUser;
                to.ObjectState = EnumAdapter.GetEnumValue<Common.ServiceProxies.UserManagement.ObjectStateType>(from.ObjectState);
            }
            return to;
        }

    }
}
