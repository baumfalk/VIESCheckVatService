//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1022
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VIESCheckVatService.ec.europa.eu
{
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("SharpDevelop", "4.4.1.9729-7196a277")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="checkVatBinding", Namespace="urn:ec.europa.eu:taxud:vies:services:checkVat")]
    public partial class checkVatService : System.Web.Services.Protocols.SoapHttpClientProtocol
    {
        
        /// <remarks/>
        public checkVatService()
        {
            this.Url = "http://ec.europa.eu/taxation_customs/vies/services/checkVatService";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="urn:ec.europa.eu:taxud:vies:services:checkVat:types", ResponseNamespace="urn:ec.europa.eu:taxud:vies:services:checkVat:types", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("requestDate", DataType="date")]
        public System.DateTime checkVat(ref string countryCode, ref string vatNumber, out bool valid, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] out string name, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] out string address)
        {
            object[] results = this.Invoke("checkVat", new object[] {
                        countryCode,
                        vatNumber});
            countryCode = ((string)(results[1]));
            vatNumber = ((string)(results[2]));
            valid = ((bool)(results[3]));
            name = ((string)(results[4]));
            address = ((string)(results[5]));
            return ((System.DateTime)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegincheckVat(string countryCode, string vatNumber, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("checkVat", new object[] {
                        countryCode,
                        vatNumber}, callback, asyncState);
        }
        
        /// <remarks/>
        public System.DateTime EndcheckVat(System.IAsyncResult asyncResult, out string countryCode, out string vatNumber, out bool valid, out string name, out string address)
        {
            object[] results = this.EndInvoke(asyncResult);
            countryCode = ((string)(results[1]));
            vatNumber = ((string)(results[2]));
            valid = ((bool)(results[3]));
            name = ((string)(results[4]));
            address = ((string)(results[5]));
            return ((System.DateTime)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="urn:ec.europa.eu:taxud:vies:services:checkVat:types", ResponseNamespace="urn:ec.europa.eu:taxud:vies:services:checkVat:types", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("requestDate", DataType="date")]
        public System.DateTime checkVatApprox(
                    ref string countryCode, 
                    ref string vatNumber, 
                    ref string traderName, 
                    ref string traderCompanyType, 
                    ref string traderStreet, 
                    ref string traderPostcode, 
                    ref string traderCity, 
                    string requesterCountryCode, 
                    string requesterVatNumber, 
                    out bool valid, 
                    out string traderAddress, 
                    out matchCode traderNameMatch, 
                    [System.Xml.Serialization.XmlIgnoreAttribute()] out bool traderNameMatchSpecified, 
                    out matchCode traderCompanyTypeMatch, 
                    [System.Xml.Serialization.XmlIgnoreAttribute()] out bool traderCompanyTypeMatchSpecified, 
                    out matchCode traderStreetMatch, 
                    [System.Xml.Serialization.XmlIgnoreAttribute()] out bool traderStreetMatchSpecified, 
                    out matchCode traderPostcodeMatch, 
                    [System.Xml.Serialization.XmlIgnoreAttribute()] out bool traderPostcodeMatchSpecified, 
                    out matchCode traderCityMatch, 
                    [System.Xml.Serialization.XmlIgnoreAttribute()] out bool traderCityMatchSpecified, 
                    out string requestIdentifier)
        {
            object[] results = this.Invoke("checkVatApprox", new object[] {
                        countryCode,
                        vatNumber,
                        traderName,
                        traderCompanyType,
                        traderStreet,
                        traderPostcode,
                        traderCity,
                        requesterCountryCode,
                        requesterVatNumber});
            countryCode = ((string)(results[1]));
            vatNumber = ((string)(results[2]));
            traderName = ((string)(results[3]));
            traderCompanyType = ((string)(results[4]));
            traderStreet = ((string)(results[5]));
            traderPostcode = ((string)(results[6]));
            traderCity = ((string)(results[7]));
            valid = ((bool)(results[8]));
            traderAddress = ((string)(results[9]));
            traderNameMatch = ((matchCode)(results[10]));
            traderNameMatchSpecified = ((bool)(results[11]));
            traderCompanyTypeMatch = ((matchCode)(results[12]));
            traderCompanyTypeMatchSpecified = ((bool)(results[13]));
            traderStreetMatch = ((matchCode)(results[14]));
            traderStreetMatchSpecified = ((bool)(results[15]));
            traderPostcodeMatch = ((matchCode)(results[16]));
            traderPostcodeMatchSpecified = ((bool)(results[17]));
            traderCityMatch = ((matchCode)(results[18]));
            traderCityMatchSpecified = ((bool)(results[19]));
            requestIdentifier = ((string)(results[20]));
            return ((System.DateTime)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegincheckVatApprox(string countryCode, string vatNumber, string traderName, string traderCompanyType, string traderStreet, string traderPostcode, string traderCity, string requesterCountryCode, string requesterVatNumber, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("checkVatApprox", new object[] {
                        countryCode,
                        vatNumber,
                        traderName,
                        traderCompanyType,
                        traderStreet,
                        traderPostcode,
                        traderCity,
                        requesterCountryCode,
                        requesterVatNumber}, callback, asyncState);
        }
        
        /// <remarks/>
        public System.DateTime EndcheckVatApprox(
                    System.IAsyncResult asyncResult, 
                    out string countryCode, 
                    out string vatNumber, 
                    out string traderName, 
                    out string traderCompanyType, 
                    out string traderStreet, 
                    out string traderPostcode, 
                    out string traderCity, 
                    out bool valid, 
                    out string traderAddress, 
                    out matchCode traderNameMatch, 
                    out bool traderNameMatchSpecified, 
                    out matchCode traderCompanyTypeMatch, 
                    out bool traderCompanyTypeMatchSpecified, 
                    out matchCode traderStreetMatch, 
                    out bool traderStreetMatchSpecified, 
                    out matchCode traderPostcodeMatch, 
                    out bool traderPostcodeMatchSpecified, 
                    out matchCode traderCityMatch, 
                    out bool traderCityMatchSpecified, 
                    out string requestIdentifier)
        {
            object[] results = this.EndInvoke(asyncResult);
            countryCode = ((string)(results[1]));
            vatNumber = ((string)(results[2]));
            traderName = ((string)(results[3]));
            traderCompanyType = ((string)(results[4]));
            traderStreet = ((string)(results[5]));
            traderPostcode = ((string)(results[6]));
            traderCity = ((string)(results[7]));
            valid = ((bool)(results[8]));
            traderAddress = ((string)(results[9]));
            traderNameMatch = ((matchCode)(results[10]));
            traderNameMatchSpecified = ((bool)(results[11]));
            traderCompanyTypeMatch = ((matchCode)(results[12]));
            traderCompanyTypeMatchSpecified = ((bool)(results[13]));
            traderStreetMatch = ((matchCode)(results[14]));
            traderStreetMatchSpecified = ((bool)(results[15]));
            traderPostcodeMatch = ((matchCode)(results[16]));
            traderPostcodeMatchSpecified = ((bool)(results[17]));
            traderCityMatch = ((matchCode)(results[18]));
            traderCityMatchSpecified = ((bool)(results[19]));
            requestIdentifier = ((string)(results[20]));
            return ((System.DateTime)(results[0]));
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("SharpDevelop", "4.4.1.9729-7196a277")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ec.europa.eu:taxud:vies:services:checkVat:types")]
    public enum matchCode
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }
}
