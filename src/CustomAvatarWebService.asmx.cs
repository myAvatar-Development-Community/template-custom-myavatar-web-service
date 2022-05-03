using System.Web.Services;
using NTST.ScriptLinkService.Objects;

namespace CustomAvatarWebService
{
    /// <summary>
    /// Summary description for CustomAvatarWebService
    /// </summary>
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
                case "doSomething":
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