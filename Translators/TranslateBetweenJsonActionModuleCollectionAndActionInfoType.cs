using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HiRePro.JSONServiceLayer.UserManagement.DataContracts;
using Common.ServiceProxies.UserManagement;
using Common.ServiceProxies.SystemService;

namespace HiRePro.JSONServiceLayer.UserManagement.Translators
{
    public static class TranslateBetweenJsonActionModuleCollectionAndActionInfoType
    {
        public static List<JsonActionModule> ServiceToBusiness(Common.ServiceProxies.UserManagement.ActionType[] from)
        {
            List<JsonActionModule> to = new List<JsonActionModule>();
            List<int> moduleIds = new List<int>();
            if (from != null)
            {
                if (from.Length > 0)
                {
                    for (int i = 0; i < from.Length; i++)
                    {
                        if (to.Count > 0)
                        {
                            for (int j = 0; j < to.Count; j++)
                            {
                                if (moduleIds.Contains(from[i].ModuleId))
                                {
                                    JsonAction action = new JsonAction();
                                    action.ActionName = from[i].Name;
                                    action.ActionId = from[i].Id;
                                    to[j].ActionCollection.Add(action);
                                    break;
                                }
                                else
                                {
                                    JsonActionModule actionModule = new JsonActionModule();
                                    actionModule.ModuleId = from[i].ModuleId;
                                    moduleIds.Add(from[i].ModuleId);
                                    JsonAction action = new JsonAction();
                                    action.ActionName = from[i].Name;
                                    action.ActionId = from[i].Id;
                                    actionModule.ActionCollection = new List<JsonAction>();
                                    actionModule.ActionCollection.Add(action);
                                    to.Add(actionModule);
                                    break;
                                }
                            }
                        }
                        else
                        {

                            JsonActionModule actionModule = new JsonActionModule();
                            actionModule.ModuleId = from[i].ModuleId;
                            moduleIds.Add(from[i].ModuleId);
                            JsonAction action = new JsonAction();
                            action.ActionName = from[i].Name;
                            action.ActionId = from[i].Id;
                            actionModule.ActionCollection = new List<JsonAction>();
                            actionModule.ActionCollection.Add(action);
                            to.Add(actionModule);
                        }

                    }
                }
            }
            return to;
        }
    }
}
