using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;

using WebApplication4.Providers;
using WebApplication4.Tools;
using WebApplication4.Models;

namespace WebApplication4.BL
{
    public class BL_Loyalty
    {
        ProvidersContext context = new ProvidersContext();
        Log_CentralWebAPI logCentral = new Log_CentralWebAPI();
        EndpointProviderModel EndpointProvider = new EndpointProviderModel();

        #region Controller
        public Model_Base BL_TestConn()
        {
            try
            {
                string jsonReq = string.Empty;
                string EndpointName = EndpointProvider.TestConnection;
                string LoyaltyWebApi = System.Configuration.ConfigurationManager.AppSettings["LoyaltyWebApi"].ToString();
                LoyaltyWebApi = LoyaltyWebApi + EndpointName;

                jsonReq = ""; 

                FmkTools.RestResponse responseApi = FmkTools.RestClient.RequestRest_1(FmkTools.HttpVerb.POST, LoyaltyWebApi, null, jsonReq);
                string jsonResponse = responseApi.message;

                var Response = Newtonsoft.Json.JsonConvert.DeserializeObject<Model_Base>(jsonResponse);

                return Response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CardResponse_Model BL_LinkCard(LinkCard_Req Req)
        {
            try
            {
                string jsonReq = string.Empty;
                string EndpointName = EndpointProvider.LinkCard;
                string LoyaltyWebApi = System.Configuration.ConfigurationManager.AppSettings["LoyaltyWebApi"].ToString();
                LoyaltyWebApi = LoyaltyWebApi + EndpointName;

                jsonReq = JsonConvert.SerializeObject(Req);

                FmkTools.RestResponse responseApi = FmkTools.RestClient.RequestRest_1(FmkTools.HttpVerb.POST, LoyaltyWebApi, null, jsonReq);
                string jsonResponse = responseApi.message;

                var Response = Newtonsoft.Json.JsonConvert.DeserializeObject<CardResponse_Model>(jsonResponse);

                return Response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 

        public CardResponse_Model BL_LinkVirtualCard(LinkCard_Req Req)
        {
            try
            {
                string jsonReq = string.Empty;
                string EndpointName = EndpointProvider.LinkVirtualCard;
                string LoyaltyWebApi = System.Configuration.ConfigurationManager.AppSettings["LoyaltyWebApi"].ToString();
                LoyaltyWebApi = LoyaltyWebApi + EndpointName;

                jsonReq = JsonConvert.SerializeObject(Req);

                FmkTools.RestResponse responseApi = FmkTools.RestClient.RequestRest_1(FmkTools.HttpVerb.POST, LoyaltyWebApi, null, jsonReq);
                string jsonResponse = responseApi.message;

                var Response = Newtonsoft.Json.JsonConvert.DeserializeObject<CardResponse_Model>(jsonResponse);

                return Response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public CardResponse_Model BL_CardReplacement(ReplaceCard_Req Req)
        {
            try
            {
                string jsonReq = string.Empty;
                string EndpointName = EndpointProvider.CardReplacement;
                string LoyaltyWebApi = System.Configuration.ConfigurationManager.AppSettings["LoyaltyWebApi"].ToString();
                LoyaltyWebApi = LoyaltyWebApi + EndpointName;

                jsonReq = JsonConvert.SerializeObject(Req);

                FmkTools.RestResponse responseApi = FmkTools.RestClient.RequestRest_1(FmkTools.HttpVerb.POST, LoyaltyWebApi, null, jsonReq);
                string jsonResponse = responseApi.message;

                var Response = Newtonsoft.Json.JsonConvert.DeserializeObject<CardResponse_Model>(jsonResponse);

                return Response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CardResponse_Model BL_ReplacementByTicket(ReplaceCard_Req Req)
        {
            try
            {
                string jsonReq = string.Empty;
                string EndpointName = EndpointProvider.ReplacementByTicket;
                string LoyaltyWebApi = System.Configuration.ConfigurationManager.AppSettings["LoyaltyWebApi"].ToString();
                LoyaltyWebApi = LoyaltyWebApi + EndpointName;

                jsonReq = JsonConvert.SerializeObject(Req);

                FmkTools.RestResponse responseApi = FmkTools.RestClient.RequestRest_1(FmkTools.HttpVerb.POST, LoyaltyWebApi, null, jsonReq);
                string jsonResponse = responseApi.message;

                var Response = Newtonsoft.Json.JsonConvert.DeserializeObject<CardResponse_Model>(jsonResponse);

                return Response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Balance_Model BL_Balances(LoyaltyReq_Base Req)
        {
            try
            {
                string jsonReq = string.Empty;
                string EndpointName = EndpointProvider.Balances;
                string LoyaltyWebApi = System.Configuration.ConfigurationManager.AppSettings["LoyaltyWebApi"].ToString();
                LoyaltyWebApi = LoyaltyWebApi + EndpointName;

                jsonReq = JsonConvert.SerializeObject(Req);

                FmkTools.RestResponse responseApi = FmkTools.RestClient.RequestRest_1(FmkTools.HttpVerb.POST, LoyaltyWebApi, null, jsonReq);
                string jsonResponse = responseApi.message;

                var Response = Newtonsoft.Json.JsonConvert.DeserializeObject<Balance_Model>(jsonResponse);

                return Response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RedencionSaldoResponse_Model BL_RedemptionBalances(RedencionSaldoRequest_Model Req)
        {
            try
            {
                string jsonReq = string.Empty;
                string EndpointName = EndpointProvider.RedemptionBalances;
                string LoyaltyWebApi = System.Configuration.ConfigurationManager.AppSettings["LoyaltyWebApi"].ToString();
                LoyaltyWebApi = LoyaltyWebApi + EndpointName;

                jsonReq = JsonConvert.SerializeObject(Req);

                FmkTools.RestResponse responseApi = FmkTools.RestClient.RequestRest_1(FmkTools.HttpVerb.POST, LoyaltyWebApi, null, jsonReq);
                string jsonResponse = responseApi.message;

                var Response = Newtonsoft.Json.JsonConvert.DeserializeObject<RedencionSaldoResponse_Model>(jsonResponse);

                return Response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Procesador de Pagos
        public Saldo_Res BL_ProcesadorPagos(Saldo_Req Req)
        {
            try
            {
                string jsonReq = string.Empty;
                string EndpointName = EndpointProvider.ProcesadorPagosSaldo;
                string LoyaltyWebApi = System.Configuration.ConfigurationManager.AppSettings["LoyaltyWebApi"].ToString();
                LoyaltyWebApi = LoyaltyWebApi + EndpointName;

                jsonReq = JsonConvert.SerializeObject(Req);

                FmkTools.RestResponse responseApi = FmkTools.RestClient.RequestRest_1(FmkTools.HttpVerb.POST, LoyaltyWebApi, null, jsonReq);
                string jsonResponse = responseApi.message;

                var Response = Newtonsoft.Json.JsonConvert.DeserializeObject<Saldo_Res>(jsonResponse);

                return Response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Saldo_Res BL_SaldosOmonel(SaldosOmonel_Req Req)
        {
            try
            {
                string jsonReq = string.Empty;
                string EndpointName = EndpointProvider.SaldosOmonel;
                string LoyaltyWebApi = System.Configuration.ConfigurationManager.AppSettings["LoyaltyWebApi"].ToString();
                LoyaltyWebApi = LoyaltyWebApi + EndpointName;

                jsonReq = JsonConvert.SerializeObject(Req);

                FmkTools.RestResponse responseApi = FmkTools.RestClient.RequestRest_1(FmkTools.HttpVerb.POST, LoyaltyWebApi, null, jsonReq);
                string jsonResponse = responseApi.message;

                var Response = Newtonsoft.Json.JsonConvert.DeserializeObject<Saldo_Res>(jsonResponse);

                return Response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ConsultaOrdenResponseModel BL_ConsultaOrden(ConsultaOrdenRequestModel Req)
        {
            try
            {
                string jsonReq = string.Empty;
                string EndpointName = EndpointProvider.ConsultaOrden;
                string LoyaltyWebApi = System.Configuration.ConfigurationManager.AppSettings["LoyaltyWebApi"].ToString();
                LoyaltyWebApi = LoyaltyWebApi + EndpointName;

                jsonReq = JsonConvert.SerializeObject(Req);

                FmkTools.RestResponse responseApi = FmkTools.RestClient.RequestRest_1(FmkTools.HttpVerb.POST, LoyaltyWebApi, null, jsonReq);
                string jsonResponse = responseApi.message;

                var Response = Newtonsoft.Json.JsonConvert.DeserializeObject<ConsultaOrdenResponseModel>(jsonResponse);

                return Response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Conciliacion
        public ConciliacionModelResponse BL_Conciliacion(ConciliacionModelRequest Req)
        {
            try
            {

                string jsonReq = string.Empty;
                string EndpointName = EndpointProvider.Conciliacion;
                string LoyaltyWebApi = System.Configuration.ConfigurationManager.AppSettings["LoyaltyWebApi"].ToString();
                LoyaltyWebApi = LoyaltyWebApi + EndpointName;

                jsonReq = JsonConvert.SerializeObject(Req);

                FmkTools.RestResponse responseApi = FmkTools.RestClient.RequestRest_1(FmkTools.HttpVerb.POST, LoyaltyWebApi, null, jsonReq);
                string jsonResponse = responseApi.message;

                var Response = Newtonsoft.Json.JsonConvert.DeserializeObject<ConciliacionModelResponse>(jsonResponse);

                return Response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}