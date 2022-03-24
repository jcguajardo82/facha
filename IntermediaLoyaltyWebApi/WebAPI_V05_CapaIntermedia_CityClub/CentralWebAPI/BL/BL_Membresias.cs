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
    public class BL_Membresias
    {
        EndpointProviderModel EndpointProvider = new EndpointProviderModel();

        #region Controller
        public Model_Base BL_TestConn()
        {
            try
            {
                string jsonReq = string.Empty;
                string EndpointName = EndpointProvider.TestConnectionMem;
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

        public ValidateMemberModelResponse BL_Vinculacion(ValidateMemberModelRequest validateMemberModelRequest)
        {
            DataSet ds = new DataSet();

            try
            {
                string jsonReq = string.Empty;
                string EndpointName = EndpointProvider.Vinculacion;
                string LoyaltyWebApi = System.Configuration.ConfigurationManager.AppSettings["LoyaltyWebApi"].ToString();
                LoyaltyWebApi = LoyaltyWebApi + EndpointName;

                jsonReq = JsonConvert.SerializeObject(validateMemberModelRequest);

                FmkTools.RestResponse responseApi = FmkTools.RestClient.RequestRest_1(FmkTools.HttpVerb.POST, LoyaltyWebApi, null, jsonReq);
                string jsonResponse = responseApi.message;

                var Response = Newtonsoft.Json.JsonConvert.DeserializeObject<ValidateMemberModelResponse>(jsonResponse);

                return Response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SFValidaMembResponse BL_ValidateSFMemb(SFValidaMembRequest sFValidaMembRequest)
        {
            DataSet ds = new DataSet();

            try
            {
                string jsonReq = string.Empty;
                string EndpointName = EndpointProvider.ValidateSFMemb;
                string LoyaltyWebApi = System.Configuration.ConfigurationManager.AppSettings["LoyaltyWebApi"].ToString();
                LoyaltyWebApi = LoyaltyWebApi + EndpointName;

                jsonReq = JsonConvert.SerializeObject(sFValidaMembRequest);

                FmkTools.RestResponse responseApi = FmkTools.RestClient.RequestRest_1(FmkTools.HttpVerb.POST, LoyaltyWebApi, null, jsonReq);
                string jsonResponse = responseApi.message;

                var Response = Newtonsoft.Json.JsonConvert.DeserializeObject<SFValidaMembResponse>(jsonResponse);

                return Response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public GetMembershipModelResponse BL_GetMembership(ValidateMemberModelRequest validateMemberModelRequest)
        {
            DataSet ds = new DataSet();
            try
            {
                string jsonReq = string.Empty;
                string EndpointName = EndpointProvider.GetMembership;
                string LoyaltyWebApi = System.Configuration.ConfigurationManager.AppSettings["LoyaltyWebApi"].ToString();
                LoyaltyWebApi = LoyaltyWebApi + EndpointName;

                jsonReq = JsonConvert.SerializeObject(validateMemberModelRequest);

                FmkTools.RestResponse responseApi = FmkTools.RestClient.RequestRest_1(FmkTools.HttpVerb.POST, LoyaltyWebApi, null, jsonReq);
                string jsonResponse = responseApi.message;

                var Response = Newtonsoft.Json.JsonConvert.DeserializeObject<GetMembershipModelResponse>(jsonResponse);

                return Response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public ValidateMembEstatusResponse BL_ValidaAltaRenovacion(ValidaAltaRenovacion validaAltaRenovacionRequest)
        {
            DataSet ds = new DataSet();
            try
            {
                string jsonReq = string.Empty;
                string EndpointName = EndpointProvider.ValidateAtaRenovacion;
                string LoyaltyWebApi = System.Configuration.ConfigurationManager.AppSettings["LoyaltyWebApi"].ToString();
                LoyaltyWebApi = LoyaltyWebApi + EndpointName;

                jsonReq = JsonConvert.SerializeObject(validaAltaRenovacionRequest);

                FmkTools.RestResponse responseApi = FmkTools.RestClient.RequestRest_1(FmkTools.HttpVerb.POST, LoyaltyWebApi, null, jsonReq);
                string jsonResponse = responseApi.message;

                var Response = Newtonsoft.Json.JsonConvert.DeserializeObject<ValidateMembEstatusResponse>(jsonResponse);

                return Response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public GenerateMembershipModelResponseBase BL_GenerateMembership(GenerateMembershipModelRequest generateMembershipModelRequest)
        {
            DataSet ds = new DataSet();
            try
            {
                string jsonReq = string.Empty;
                string EndpointName = EndpointProvider.GenerateMembership;
                string LoyaltyWebApi = System.Configuration.ConfigurationManager.AppSettings["LoyaltyWebApi"].ToString();
                LoyaltyWebApi = LoyaltyWebApi + EndpointName;

                jsonReq = JsonConvert.SerializeObject(generateMembershipModelRequest);

                FmkTools.RestResponse responseApi = FmkTools.RestClient.RequestRest_1(FmkTools.HttpVerb.POST, LoyaltyWebApi, null, jsonReq);
                string jsonResponse = responseApi.message;

                var Response = Newtonsoft.Json.JsonConvert.DeserializeObject<GenerateMembershipModelResponseBase>(jsonResponse);

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