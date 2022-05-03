// PROJECT: custom-avatar-web-service-template (https://github.com/myAvatar-Development-Community/custom-avatar-web-service-template)
//    FILE: CustomAvatarWebService.asmx.cs
// UPDATED: 5-3-2022-11:59 AM
// LICENSE: Apache v2 (https://apache.org/licenses/LICENSE-2.0)

// A custom web service template for Netsmart's myAvatar™ EHR
// v1.0.0.0-b220503.115810
//
// Developed by:
//   - A Pretty Cool Program (https://github.com/APrettyCoolProgram)
//     Christopher Banwarth
//     Application Integration Architect
//     Spectrum Health Systems, Inc.
// 
// For more information, please visit:
//
//  https://github.com/myAvatar-Development-Community/custom-avatar-web-service-template

using System.Web.Services;
using NTST.ScriptLinkService.Objects;

namespace CustomAvatarWebService
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CustomAvatarWebService : System.Web.Services.WebService
    {
        [WebMethod]
        public string GetVersion()
        {
            return "VERSION 1.0";
        }

        [WebMethod]
        public OptionObject2015 RunScript(OptionObject2015 sentOptionObject, string action)
        {
            switch(action)
            {
                case "DoSomething":
                    return MethodName(sentOptionObject);

                default:
                    break;
            }

            return sentOptionObject;
        }

        private static OptionObject2015 MethodName(OptionObject2015 sentOptionObject)
        {
            return new OptionObject2015();
        }
    }
}