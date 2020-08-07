namespace Mekashron.Testing.Web.SOAPModel
{

    // Примечание. Для запуска созданного кода может потребоваться NET Framework версии 4.5 или более поздней версии и .NET Core или Standard версии 2.0 или более поздней.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.xmlsoap.org/soap/envelope/", IsNullable = false)]
    public partial class Envelope
    {

        private EnvelopeBody bodyField;

        /// <remarks/>
        public EnvelopeBody Body
        {
            get
            {
                return this.bodyField;
            }
            set
            {
                this.bodyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public partial class EnvelopeBody
    {

        private RegisterNewCustomerResponse registerNewCustomerResponseField;
        private LoginResponse login;

        private string encodingStyleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:ICUTech.Intf-IICUTech")]
        public RegisterNewCustomerResponse RegisterNewCustomerResponse
        {
            get
            {
                return this.registerNewCustomerResponseField;
            }
            set
            {
                this.registerNewCustomerResponseField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:ICUTech.Intf-IICUTech")]
        public LoginResponse LoginResponse
        {
            get
            {
                return this.login;
            }
            set
            {
                this.login = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string encodingStyle
        {
            get
            {
                return this.encodingStyleField;
            }
            set
            {
                this.encodingStyleField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:ICUTech.Intf-IICUTech")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:ICUTech.Intf-IICUTech", IsNullable = false)]
    public partial class RegisterNewCustomerResponse
    {

        private string returnField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public string @return
        {
            get
            {
                return this.returnField;
            }
            set
            {
                this.returnField = value;
            }
        }
    }
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:ICUTech.Intf-IICUTech")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:ICUTech.Intf-IICUTech", IsNullable = false)]
    public partial class LoginResponse
    {

        private string returnField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public string @return
        {
            get
            {
                return this.returnField;
            }
            set
            {
                this.returnField = value;
            }
        }
    }


}