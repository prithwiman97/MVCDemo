using MVCDemo.Models;
using MVCDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Profile(Users user)
        {
            MVCDemoContext context = new MVCDemoContext();
            Users found = context.Users.Find(user.Id);
            if (found == null)
                return Content("Id Password does not match");
            return View(found);
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Posts()
        {
            Users user = new Users
            {
                Name="Biswarup",
                Password="absd"
            };
            List<Posts> posts = new List<Posts> 
            {
                new Posts{Title="Post 1",Content="My first post"},
                new Posts{Title="Post 2",Content="My second post"},
                new Posts{Title="Post 3",Content="My third post"}
            };
            PostsByUsers postsByUsers = new PostsByUsers
            {
                User=user,
                Posts=posts
            };
            return View(postsByUsers);
        }
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Create(Users user)
        {
            MVCDemoContext context = new MVCDemoContext();
            context.Users.Add(user);
            context.SaveChanges();
            return Content("Registration Successful");
        }
    }
}