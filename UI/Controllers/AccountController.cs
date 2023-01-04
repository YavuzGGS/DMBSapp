using Business.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Configuration;
using System.Data;
using UI.Models;

namespace UI.Controllers
{
    public class AccountController : Controller
    {
        private UserManager _userManager;
        public AccountController()
        {
            _userManager = new UserManager();

        }
        public IActionResult Index()
        {
            var model = new UserViewModel()
            {

                Users = _userManager.GetAll()


            };
            return View(model);
        }
        
        public IActionResult Edit(int id)
        {
            var model = new UserViewModel()
            {

                Users = _userManager.GetAll(),
                User = _userManager.GetById(id),
                


            };
            return View(model);

        }
        [HttpPost]
        public IActionResult Edit(User user)
        {
            User updateUser = new User
            {
                UserID= user.UserID,
                Username = user.Username,
                Password = user.Password,
                Role = user.Role

            };
            _userManager.Update(updateUser);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            
            _userManager.Delete(_userManager.GetById(id));
            return RedirectToAction("Index");
        }

        public IActionResult Login()
        {

            UserViewModel model = new UserViewModel()
            {
                User = new User()
            };

            return View();
        }
        [HttpPost]
        public IActionResult Login(User user)
        {

            User dbUser = _userManager.GetByUsername(user.Username);
            if(dbUser != null)
            {
                if (dbUser.Username == user.Username && dbUser.Password == user.Password)
                    UserInfo.user = dbUser;
                    return RedirectToAction("Index", "Book", new { area = "" });
            }

            return View();
        }

        public IActionResult Register()
        {
            UserViewModel model = new UserViewModel()
            {
                User = new User()
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Register(User user)
        {
            user.Role = "User";
            _userManager.Add(user);
            return RedirectToAction("Login", "Account");
        }

    }
}
