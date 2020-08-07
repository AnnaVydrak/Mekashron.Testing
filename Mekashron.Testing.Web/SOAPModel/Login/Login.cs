namespace Mekashron.Testing.Web.SOAPModel.Login
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:ICUTech.Intf-IICUTech")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:ICUTech.Intf-IICUTech", IsNullable = false)]
    public partial class Login
    {

        private string userNameField;

        private string passwordField;

        private string iPsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public string UserName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public string Password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public string IPs
        {
            get
            {
                return this.iPsField;
            }
            set
            {
                this.iPsField = value;
            }
        }
    }
}