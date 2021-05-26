using service;
using System.Windows.Forms;
using domain;
using ISS_Bugs;

namespace controllers
{
    public class LoginController
    {
        public AppService appService { get; set; }
        public LoginController(AppService appService)
        {
            this.appService = appService;
        }

        public User login(string username, string password)
        {
            return appService.login(username, password);
        }
        
    }
}