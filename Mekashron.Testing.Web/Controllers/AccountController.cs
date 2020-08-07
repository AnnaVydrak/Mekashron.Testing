using System.Threading.Tasks;
using System.Web.Mvc;
using Mekashron.Testing.Web.Helpers;
using Mekashron.Testing.Web.Logic;
using Mekashron.Testing.Web.Models.Login;
using Mekashron.Testing.Web.Models.Register;
using Mekashron.Testing.Web.SOAPModel.Login;
using Mekashron.Testing.Web.SOAPModel.Register;
using Envelope = Mekashron.Testing.Web.SOAPModel.Login.Envelope;
using EnvelopeBody = Mekashron.Testing.Web.SOAPModel.Login.EnvelopeBody;

namespace Mekashron.Testing.Web.Controllers
{
    public class AccountController : Controller
    {
        private SOAPClient _soapClient;
        public AccountController()
        {
            _soapClient = new SOAPClient();
        }

        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {

            return View(new LoginView());
        }

        public ActionResult Register()
        {
            return View(new RegisterNewCustomerView());
        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginView login)
        {
            if (ModelState.IsValid)
            {
                Envelope envelope = new Envelope()
                {
                    Body = new EnvelopeBody()
                    {
                        Login = new Login()
                        {
                            UserName = login.UserName,
                            Password = login.Password,
                            IPs = Request.UserHostAddress
                        }
                    }
                };

                var result = await _soapClient.Login(envelope);
                ViewBag.Result = result;
               
            }

            return View(login);
        }

        [HttpPost]
        public async Task<ActionResult> Register(RegisterNewCustomerView register)
        {
            if (ModelState.IsValid)
            {
                SOAPModel.Register.Envelope envelope = new SOAPModel.Register.Envelope()
                {
                    Body = new SOAPModel.Register.EnvelopeBody()
                    {
                        RegisterNewCustomer = new RegisterNewCustomer()
                        {
                            FirstName = register.FirstName,
                            LastName = register.LastName,
                            Email = register.Email,
                            Mobile = register.Mobile,
                            Password = register.Password
                        }
                    }
                };

                Result result = await _soapClient.Register(envelope);
                ViewBag.Result = result;
            }

            return View(register);
        }
    }
}

