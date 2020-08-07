namespace Mekashron.Testing.Web.SOAPModel.Login
{
  
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