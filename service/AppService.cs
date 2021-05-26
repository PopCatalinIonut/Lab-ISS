using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using domain;
using domain.validator;
using persistance;

namespace service
{
    public class AppService
    {
        private UsersRepository usersRepo;
        private BugsRepository bugsRepo;
        private Dictionary<string,User> loggedUsers;

        public AppService(UsersRepository usersRepo, BugsRepository bugsRepo)
        {
            this.usersRepo = usersRepo;
            this.bugsRepo = bugsRepo;
            loggedUsers = new Dictionary<string,User>();
        }

        public User login(string username, string password)
        {
            User user = usersRepo.findOne(username, password);
            if (user != null)
            {
                if (loggedUsers.ContainsKey(username))
                    throw new ServiceException("User already logged in!");
                loggedUsers.Add(user.username,user);
                return user;
            }

            return null;
        }

        public Bug insertBug(Bug bug)
        {
            BugValidator vali = new BugValidator();
            vali.Validate(bug);
            Bug inserted = bugsRepo.Save(bug);
            if (inserted == null)
                throw new ServiceException("Bug was not added!");
            return inserted;
        }

        public List<Bug> getBugsByOwner(string currentUser)
        {
            return bugsRepo.getBugsByOwner(currentUser).ToList();
        }

        public int deleteBug(int id)
        {
            return bugsRepo.Delete(id);
        }

        public void logout(string currentUser)
        {
            loggedUsers.Remove(currentUser);
        }

        public IEnumerable<Bug> findUnresolvedBugs()
        {
            return bugsRepo.findAvailableBugs();
        }

        public int updateBugStatus(int id, Status status)
        {
            return bugsRepo.updateStatus(id, status);
        }

        public List<User> findAllProgrammers()
        {
            return usersRepo.findAllByPosition("Programmer");
        }
    }
}