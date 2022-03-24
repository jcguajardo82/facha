using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class EndpointProviderModel
    {
        public string TestConnection { get; set; } = "/api/Loyalty/TestConnection";
        public string LinkCard { get; set; } = "/api/Loyalty/LinkCard";
        public string LinkVirtualCard { get; set; } = "/api/Loyalty/LinkVirtualCard";
        public string CardReplacement { get; set; } = "/api/Loyalty/CardReplacement";
        public string Balances { get; set; } = "/api/Loyalty/Balances";
        public string RedemptionBalances { get; set; } = "/api/Loyalty/RedemptionBalances";
        public string TicketList { get; set; } = "/api/Loyalty/TicketList";
        public string DetailTickets { get; set; } = "/api/Loyalty/DetailTickets";
        public string ReplacementByTicket { get; set; } = "/api/Loyalty/ReplacementByTicket";
        public string ProcesadorPagosSaldo { get; set; } = "/api/Loyalty/ProcesadorPagosSaldo";
        public string SaldosOmonel { get; set; } = "/api/Loyalty/SaldosOmonel";
        public string ConsultaOrden { get; set; } = "/api/Loyalty/ConsultaOrden";

        #region CityClub Membresias
        public string TestConnectionMem { get; set; } = "/api/Membresia/TestConnection";
        public string Vinculacion { get; set; } = "/api/Membresia/Vinculacion";
        public string ValidateSFMemb { get; set; } = "/api/Membresia/ValidateSFMemebresia";
        public string GetMembership { get; set; } = "/api/Membresia/GetMembership";
        public string ValidateAtaRenovacion { get; set; } = "/api/Membresia/ValidateAtaRenovacion";
        public string GenerateMembership { get; set; } = "/api/Membresia/GenerateMembership";
        #endregion

        #region Conciliacion
        public string Conciliacion { get; set; } = "/api/Loyalty/Conciliacion";
        #endregion
    }
}