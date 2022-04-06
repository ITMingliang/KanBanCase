using JuQent.Service.DataUtility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace Juqent.CPS.MvcWebApi.Controllers
{
    public class ProductionInfoController : ApiController
    {
        private const string DaDbName = "Default";

        [HttpPost]
        public HttpResponseMessage GetMoOutputs()
        {
            try
            {
                List<MoOutput> moOutputs = new List<MoOutput>();
                List<MoOutput> moOutputs2 = new List<MoOutput>();
                List<MoOutput> moOutputs3 = new List<MoOutput>();
                List<MoOutput> moOutputs4 = new List<MoOutput>();
                using (DapperDbContext Context = new DapperDbContext(DaDbName))
                {
                    moOutputs = Context.GetAll<MoOutput>(new { SectionType = "极片工段" }).ToList<MoOutput>();
                    moOutputs2 = Context.GetAll<MoOutput>(new { SectionType = "组装工段" }).ToList<MoOutput>();
                    moOutputs3 = Context.GetAll<MoOutput>(new { SectionType = "化成工段" }).ToList<MoOutput>();
                    moOutputs4 = Context.GetAll<MoOutput>(new { SectionType = "包装工段" }).ToList<MoOutput>();
                   
                    var jsonstr = new { part1 = moOutputs, part2 = moOutputs2, part3 = moOutputs3, part4 = moOutputs4};
                    string json = JsonConvert.SerializeObject(jsonstr);
                    //返回纯文本text/plain  ,返回json application/json  ,返回xml text/xml
                    HttpResponseMessage result = new HttpResponseMessage { Content = new StringContent(json, Encoding.GetEncoding("UTF-8"), "application/json") };
                    return result;

                }
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage { Content = new StringContent(JsonConvert.SerializeObject(ex.Message), Encoding.GetEncoding("UTF-8"), "application/json") };
            }
        }

        [HttpPost]
        public HttpResponseMessage GetStationOutputs()
        {
            try
            {
                string mocode = "M020189004859001";
                MoInfo moInfo = new MoInfo();
                List<StationDayOutput> dayoutput1 = new List<StationDayOutput>();
                List<StationDayOutput> dayoutput2 = new List<StationDayOutput>();
                List<StationDayOutput> dayoutput3 = new List<StationDayOutput>();
                List<StationDayOutput> dayoutput4 = new List<StationDayOutput>();
                List<StationPeriedTime> periedTime1 = new List<StationPeriedTime>();
                List<StationPeriedTime> periedTime2 = new List<StationPeriedTime>();
                List<StationPeriedTime> periedTime3 = new List<StationPeriedTime>();
                List<StationPeriedTime> periedTime4 = new List<StationPeriedTime>();


                using (DapperDbContext Context = new DapperDbContext(DaDbName))
                {
                    string sql = string.Format(@"select a.MoCode,a.ProductCode,a.ProductName,a.MoQty,a.CompleteRate,b.StationType,b.OutDate,b.OutputQty
                                    FROM StationDayOutput b
                                    LEFT JOIN  MoInfo a on a.ID=b.MoInfoId
                                    where a.MoCode='{0}'", mocode);
                    var listdata = Context.Query<StationDayOutput>(sql).ToList();
                    dayoutput1 = listdata.Where(t => t.StationType == "外壳打码").ToList();
                    dayoutput2 = listdata.Where(t => t.StationType == "卷芯入壳").ToList();
                    dayoutput3 = listdata.Where(t => t.StationType == "高温烘烤").ToList();
                    dayoutput4 = listdata.Where(t => t.StationType == "注液").ToList();

                    string sql2 = string.Format(@"select a.MoCode,a.ProductCode,a.ProductName,a.MoQty,a.CompleteRate,b.StationType,b.PeriedTime,b.PeriedQty,b.PeriedTargetQty
                                    FROM StationPeriedOutput as b
                                    LEFT JOIN  MoINFO as a on a.ID=b.MoInfoId 
                                    where a.MoCode='{0}'", mocode);
                    var listdata2 = Context.Query<StationPeriedTime>(sql2).ToList();
                    periedTime1 = listdata2.Where(t => t.StationType == "外壳打码").ToList();
                    periedTime2 = listdata2.Where(t => t.StationType == "卷芯入壳").ToList();
                    periedTime3 = listdata2.Where(t => t.StationType == "高温烘烤").ToList();
                    periedTime4 = listdata2.Where(t => t.StationType == "注液").ToList();

                    var jsonstr = new { part1 = dayoutput1, part2 = dayoutput2, part3 = dayoutput3, part4 = dayoutput4,part5 = periedTime1,part6=periedTime2,part7=periedTime3,part8=periedTime4 };
                    string json = JsonConvert.SerializeObject(jsonstr);
                    //返回纯文本text/plain  ,返回json application/json  ,返回xml text/xml
                    HttpResponseMessage result = new HttpResponseMessage { Content = new StringContent(json, Encoding.GetEncoding("UTF-8"), "application/json") };
                    return result;

                }
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage { Content = new StringContent(JsonConvert.SerializeObject(ex.Message), Encoding.GetEncoding("UTF-8"), "application/json") };
            }
        }

        [HttpPost]
        public HttpResponseMessage GetStationPPMs()
        {
            try
            {
                string mocode = "M020189004859001";
                MoInfo moInfo = new MoInfo();
                List<StationPPM> ppmlist = new List<StationPPM>();                

                using (DapperDbContext Context = new DapperDbContext(DaDbName))
                {
                    string sql = string.Format(@"select a.MoCode,a.ProductCode,a.ProductName,a.MoQty,a.CompleteRate,b.StationType,b.OutDate,b.PPM
                                    FROM StationPPM b
                                    LEFT JOIN  MoInfo a on a.ID=b.MoInfoId
                                    where a.MoCode='{0}'", mocode);
                    var listdata = Context.Query<StationPPM>(sql).ToList();

                    var errordata = Context.GetAll<ErrorTop>().ToList();

                    var jsonstr = new { part1 = listdata,part2 = errordata };
                    string json = JsonConvert.SerializeObject(jsonstr);
                    //返回纯文本text/plain  ,返回json application/json  ,返回xml text/xml
                    HttpResponseMessage result = new HttpResponseMessage { Content = new StringContent(json, Encoding.GetEncoding("UTF-8"), "application/json") };
                    return result;

                }
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage { Content = new StringContent(JsonConvert.SerializeObject(ex.Message), Encoding.GetEncoding("UTF-8"), "application/json") };
            }
        }
    }
}