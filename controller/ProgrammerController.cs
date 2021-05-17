using System.Collections;
using System.Collections.Generic;
using domain;
using service;

namespace controllers
{
    public class ProgrammerController: UserController
    {
        private AppService appService;
        public string currentUser { get; }
        public ProgrammerController(AppService appService) { this.appService = appService; }

        public void logout()
        {
            appService.logout(currentUser);
        }

        public IEnumerable<Bug> getBugs()
        {
            return appService.findUnresolvedBugs();
        }

        public void updateBugStatus(int id, Status status)
        {
            appService.updateBugStatus(id, status);
        }

        public List<User> getAllProgrammers()
        {
            return appService.findAllProgrammers();
        }
    }
}