using System;

namespace Mekashron.Testing.Web.SOAPModel.Register
{
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:ICUTech.Intf-IICUTech")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:ICUTech.Intf-IICUTech", IsNullable = false)]
    public partial class RegisterNewCustomer
    {

        private string emailField;

        private string passwordField;

        private string firstNameField;

        private string lastNameField;

        private string mobileField;

        private string countryIDField;

        private string aIDField;

        private string signupIPField;

        private string encodingStyleField;

        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public string Email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }

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

        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public string FirstName
        {
            get
            {
                return this.firstNameField;
            }
            set
            {
                this.firstNameField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public string LastName
        {
            get
            {
                return this.lastNameField;
            }
            set
            {
                this.lastNameField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public string Mobile
        {
            get
            {
                return this.mobileField;
            }
            set
            {
                this.mobileField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public string CountryID
        {
            get
            {
                return this.countryIDField;
            }
            set
            {
                this.countryIDField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public string aID
        {
            get
            {
                return this.aIDField;
            }
            set
            {
                this.aIDField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public string SignupIP
        {
            get
            {
                return this.signupIPField;
            }
            set
            {
                this.signupIPField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/2003/05/soap-envelope")]
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
}