using FindMyFriendsCommunication;
using FindMyFriendsData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace FindMyFriendsService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract(Namespace = "HTTP://loic.martin/", Name = "FindMyFriendsREST")]
    public interface IFindMyFriendsWebService
    {

        [OperationContract]
        [WebGet(UriTemplate = "GetGroups?id={userId}", ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<GroupDTO> GetGroups(Guid userId);

        [OperationContract]
        [WebGet(UriTemplate = "GetUsers?id={groupId}", ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<UserDTO> GetUsers(Guid groupId);

        [OperationContract]
        //[WebGet(UriTemplate = "CreateAccount?name={name}&email={email}&password={password}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        [WebInvoke(Method="POST", UriTemplate="CreateAccount", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        void CreateAccount(AccountDTO account);

        [OperationContract]
        //[WebGet(UriTemplate = "CreateAccount?name={name}&email={email}&password={password}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        [WebInvoke(Method = "POST", UriTemplate = "Login", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        UserDTO Login(AccountDTO account);
    }
}
