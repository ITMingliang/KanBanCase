using Juqent.CPS.WebApi.Dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Web.Script.Serialization;

namespace Juqent.CPS.WebApi
{
    public class RemoteServer
    {
        private static string Org;
        private static string Src;

        public static RemoteServer Instance
        {
            get { return new RemoteServer(); }
        }

        public ApiReqRetDto Post(string url, string json)
        {
            string ret = WebApiHelper.HttpPost(url, json);
            return JsonConvert.DeserializeObject<ApiReqRetDto>(ret);
        }
        public ApiReqRetDto PostByCode(string ApiCode, object input)
        {
            WebApiConfig cfg = WebApiUrl.GetWebApiConfig(ApiCode);
            string json = string.Empty;
            string ApiUrl = cfg.ApiUrl;
            if (input.GetType().ToString() == "System.String" && !String.IsNullOrEmpty(cfg.ParamName))
            {
                json = string.Empty;
                ApiUrl += "?" + cfg.ParamName + "=" + (input == null ? string.Empty : input.ToString());
            }
            else
                json = input == null ? string.Empty : JsonConvert.SerializeObject(input);
            return Post(ApiUrl, json);
        }

        public ApiReqRetDto Get(string url)
        {
            string ret = WebApiHelper.HttpGet(url);
            return JsonConvert.DeserializeObject<ApiReqRetDto>(ret);
        }

        #region System
        public AbpUserDto Login(string UserCode, string Password)
        {
            AbpUserDto User = new AbpUserDto { UserName = UserCode, Password = Password };
            WebApiConfig cfg = WebApiUrl.GetWebApiConfig("Sys.Login");
            ApiReqRetDto ret = Post(cfg.ApiUrl, JsonConvert.SerializeObject(User));
            if (ret.result != null)
                return JsonConvert.DeserializeObject<AbpUserDto>(ret.result.ToString());
            return null;
        }
        public LoginResultModel Login(LoginUserInfoDto UserInfo)
        {
            ApiReqRetDto ret = PostByCode("Sys.Login", UserInfo);
            if (ret.result != null)
                return JsonConvert.DeserializeObject<LoginResultModel>(ret.result.ToString());
            return null;
        }
        public DateTime? GetServerTime()
        {
            ApiReqRetDto ret = PostByCode("Sys.ServerTime", string.Empty);
            if (ret.result != null)
                return Convert.ToDateTime(ret.result.ToString());
            //JsonConvert.DeserializeObject<DateTime>();
            return null;
        }
        public DateTime? GetDatabaseTime()
        {
            ApiReqRetDto ret = PostByCode("Sys.DatabaseTime", string.Empty);
            if (ret.result != null)
                return JsonConvert.DeserializeObject<DateTime>(ret.result.ToString());
            return null;
        }
        public AbpUserDto GetUserById(long Id)
        {
            ApiReqRetDto ret = PostByCode("Sys.GetUser", Id.ToString());
            if (ret.result != null)
                return JsonConvert.DeserializeObject<AbpUserDto>(ret.result.ToString());
            return null;
        }
        //public void CreateOrUpdateUser(CreateOrUpdateUserInput UserInfo)
        //{
        //    ApiReqRetDto ret = PostByCode("Sys.CreateOrUpdateUser", UserInfo);
        //}
        //public GetUserForEditOutput GetUserForEdit(GetUsersInput input)
        //{
        //    ApiReqRetDto ret = PostByCode("Sys.GetUserForEdit", input);
        //    if (ret.result != null)
        //        return JsonConvert.DeserializeObject<GetUserForEditOutput>(ret.result.ToString());
        //    return null;
        //}
        //public AbpUserDto GetUserByUserName(AbpUserInput input)
        //{
        //    ApiReqRetDto ret = PostByCode("Sys.GetUserByUserName", input);
        //    if (ret.result != null)
        //        return JsonConvert.DeserializeObject<AbpUserDto>(ret.result.ToString());
        //    return null;
        //}
        public AbpUserDto UpdateUserActive(AbpUserDto input)
        {
            ApiReqRetDto ret = PostByCode("Sys.UpdateUserActive", input);
            if (ret.result != null)
                return JsonConvert.DeserializeObject<AbpUserDto>(ret.result.ToString());
            return null;
        }
        public List<PageInfoDto> GetPageInfo()
        {
            ApiReqRetDto ret = PostByCode("Imcc.GetPageInfo", string.Empty);
            if (ret.result != null)
                return JsonConvert.DeserializeObject<List<PageInfoDto>>(ret.result.ToString());
            return null;
        }
        #endregion

        #region OperationGuide
        /// <summary>
        /// 查找指定工作中心、设备编号下的文件信息
        /// </summary>
        /// <param name="input"></param>
        public List<EWIDocOutput> GetFileName(EWIDocInput input)
        {
            string parString = new JavaScriptSerializer().Serialize(input);
            string url = WebApiUrl.GetWebApiConfig("EWI.GetFile").ApiUrl;
            HttpWebResponse reponse = HttpPost(url, parString);
            object result = GetPostResult(reponse);
            return GetFileMessage<List<EWIDocOutput>>(result);
        }

        /// <summary>
        /// 获取指定文件流，并在本地保存
        /// </summary>
        /// <param name="filename"></param>
        public bool GetFile(string savepath, EWIFileInput input)
        {
            string parString = JsonConvert.SerializeObject(input);
            string url = WebApiUrl.GetWebApiConfig("EWI.DownLoadFile").ApiUrl;
            HttpWebResponse reponse = HttpPost(url, parString);
            object result = GetPostResult(reponse);
            EWIFileoutput fileMessage = GetFileMessage<EWIFileoutput>(result);
            if (!fileMessage.Success) return false;
            SaveFile(savepath, fileMessage);
            return true;
        }

        /// <summary>
        /// 请求服务
        /// </summary>
        /// <param name="url"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        private HttpWebResponse HttpPost(string url, string body)
        {
            Encoding encoding = Encoding.UTF8;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.Accept = "text/html, application/xhtml+xml, */*";
            request.ContentType = "application/json";

            byte[] buffer = encoding.GetBytes(body);
            request.ContentLength = buffer.Length;
            request.GetRequestStream().Write(buffer, 0, buffer.Length);
            return (HttpWebResponse)request.GetResponse();
        }

        /// <summary>
        /// 获取服务返回结果
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        private object GetPostResult(HttpWebResponse response)
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
            {
                string tempString = reader.ReadToEnd();
                EWIResultDto _ResultDto = (EWIResultDto)JsonConvert.DeserializeObject(tempString, typeof(EWIResultDto));
                return _ResultDto.result;
            }
        }

        /// <summary>
        /// reposeResult反系列化
        /// </summary>
        /// <param name="reposeResult"></param>
        /// <returns></returns>
        private T GetFileMessage<T>(object reposeResult)
        {
            return (T)JsonConvert.DeserializeObject(reposeResult.ToString(), typeof(T));
        }

        /// <summary>
        /// 保存文件
        /// </summary>
        /// <param name="filemessage"></param>
        private void SaveFile(string savepath, EWIFileoutput filemessage)
        {
            string fileAllPath = Path.Combine(savepath, filemessage.FileName);
            FileInfo fileInfo = new FileInfo(fileAllPath);
            if (fileInfo.Exists)
            {
                fileInfo.Delete();
            }
            FileStream stream = new FileStream(fileAllPath, FileMode.CreateNew);
            stream.Write(filemessage.FileByte, 0, filemessage.FileByte.Length);
            stream.Close();
        }
        #endregion
    }
}