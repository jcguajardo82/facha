using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Providers
{
    public class ProvidersContext
    {
        public string MainConnectionString { get; set; } = "";                       //"server=CorpECom01;DATABASE=EcomSorianaDesaDB;UID=internet;PASSWORD=internet;";
        public string AccountConnectionString { get; set; } = "";                //"server=CorpECom01;DATABASE=EcomSorianaDesaDB;UID=internet;PASSWORD=internet;";
        public string AccountLealtadConnectionString { get; set; } = "";    //"server=CORPSRVTEST\SQL2008;DATABASE=CRMOCorpProdDB;UID=soriana;PASSWORD=sorpuntos;";
        /*public string SucursalesConnectionString { get; set; } = FmkTools.Seguridad.Desencriptar(System.Configuration.ConfigurationManager.AppSettings["SucursalesConnectionString"].ToString());           //"server=CORPSRVTEST\\SQL2008;DATABASE=CRMOCorpProdDB;UID=soriana;PASSWORD=sorpuntos;";
        public string PromocionesConnectionString { get; set; } = FmkTools.Seguridad.Desencriptar(System.Configuration.ConfigurationManager.AppSettings["PromoConnectionString"].ToString());               //Data Source=192.168.128.138\sql2008; Initial Catalog=CRMOCorpProdDB; User Id=soriana; Password=sorpuntos;
        public string CityClubConnectionString { get; set; } = FmkTools.Seguridad.Desencriptar(System.Configuration.ConfigurationManager.AppSettings["CityClubConnectionString"].ToString());               //"server=CorpECom01;DATABASE=EcomCityClubDesaDB;UID=internet;PASSWORD=internet";
        public string TiendaUrl { get; set; } = "\\http:TdaSrv{0}\\TiendaWebApi";
        public string aprecioConnectionString { get; set; } = "\\http:TdaSrv{0}\\TiendaWebApi"; */
        //"server=198.38.93.71\\SQLEXPRESS,5171;DATABASE=TestAppDB;UID=sa;PASSWORD=monaco70;";
        //"server=AGTZW7\\SQLEXPRESS;DATABASE=TestAppDB;UID=sa;PASSWORD=monaco70;"; 
    }
}