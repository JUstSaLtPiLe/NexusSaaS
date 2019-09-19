﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NexusSaaS.Models;
using NexusSaaS.Repository.Interface;

namespace NexusSaaS.Controllers
{
    public class RegisterController : Controller
    {
        private IRoleRepository roleRepository;
        private IUserRepository userRepository;
        public RegisterController(IRoleRepository roleRepository, IUserRepository userRepository)
        {
            this.roleRepository = roleRepository;
            this.userRepository = userRepository;
        }
        public IActionResult LoadRegisterPartialView()
        {
            var listRoles = roleRepository.List();
            ViewData["listRoles"] = listRoles;
            return PartialView("RegisterPartialView");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(UserModel user)
        {
            if (user != null)
            {
                if (ModelState.IsValid)
                {
                    userRepository.Save(user);
                    TempData["registerStatus"] = "Sign up successfull";
                    return RedirectToAction("Index", "Home");
                }
            }
            return NotFound();
        }
    }
}