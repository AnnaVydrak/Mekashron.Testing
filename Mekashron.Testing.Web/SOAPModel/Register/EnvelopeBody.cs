using System;

namespace Mekashron.Testing.Web.SOAPModel.Register
{
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2003/05/soap-envelope")]
    public partial class EnvelopeBody
    {

        private RegisterNewCustomer registerNewCustomerField;

        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:ICUTech.Intf-IICUTech")]
        public RegisterNewCustomer RegisterNewCustomer
        {
            get
            {
                return this.registerNewCustomerField;
            }
            set
            {
                this.registerNewCustomerField = value;
            }
        }
    }
}