using Common.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace PublicGateway.Controllers
{
    class AccountController : ApiController
    {
        private static readonly ILogger Logger = LoggerFactory.GetLogger(nameof(AccountController));


        /// <summary>
        /// 新用户注册
        /// </summary>
        [HttpGet]
        public string Register()
        {
            return nameof(AccountController.Register);
        }
        [HttpGet]
        public string Login()
        {
            return nameof(AccountController.Login);
        }

        [HttpGet]
        public string Password()
        {
            return nameof(AccountController.Password);
        }
        [HttpGet]
        public string Passport()
        {
            return nameof(AccountController.Passport);
        }

    }
}
