using System.Collections.Generic;
using System.Runtime.CompilerServices;
using domain;
using ISS_Bugs;
using service;

namespace controllers
{
    public class TesterController: UserController
    {  
        private AppService appService;
       
        public string currentUser { get; }

        public TesterController(AppService appService, string currentUser) { 
            this.appService = appService;
            this.currentUser = currentUser;
        }

        public void insertBug(Bug bug)
        {
            appService.insertBug(bug);
        }

        public List<Bug> getInsertedBugs()
        {
            return appService.getBugsByOwner(currentUser);
        }

        public int deleteBug(int id)
        {
            return appService.deleteBug(id);
        }

        public void logout()
        {
            appService.logout(currentUser);
        }
    }
}