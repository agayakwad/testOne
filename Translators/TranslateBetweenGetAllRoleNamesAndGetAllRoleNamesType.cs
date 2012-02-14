using Common.ServiceProxies.UserManagement;
using HiRePro.JSONServiceLayer.CommonManagement.DataContracts;

namespace HiRePro.JSONServiceLayer.UserManagement.Translators {
    public class TranslateBetweenGetAllRoleNamesAndGetAllRoleNamesType {
        public static GetAllRoleNames ServiceToBusiness(GetAllRoleNamesType allRoleNames) {
            GetAllRoleNames jsonAllRoleNames = new GetAllRoleNames();
            if (allRoleNames != null) {
                jsonAllRoleNames.ObjectId = allRoleNames.Id;
                jsonAllRoleNames.IsSystemRole = allRoleNames.IsSystemRole;
                if (allRoleNames.Name != null)
                    jsonAllRoleNames.Name = allRoleNames.Name;
            }
            return jsonAllRoleNames;
        }
    }
}