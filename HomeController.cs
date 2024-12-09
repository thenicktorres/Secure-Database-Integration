/*
 * Course: CS 3410
 * Section: 01
 * Name: Nick Torres
 * Professor: Ms. Emin Mary Abraham
 * Assignment #: Final Project (Assignment 8)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingCartV2.Models;

namespace ShoppingCartV2.Controllers
{
    public partial class HomeController : Controller
    {
        // Text for Site Heading
        string siteHeading = "The Cleat Vault";

        // Text for Order View Heading
        string orderHeading = "Cleats Orders";

        // Text for View Heading for each Tab
        string[] tabHeadings = { "Home", "Nike", "Adidas", "Puma",
                                         "Check-Out", "Admin", "About" };

        // View label displayed on each Tab
        string[] tabLabels = { "Home", "Nike", "Adidas", "Puma",
                                       "Check-Out", "Admin", "About" };

        // View method name for each Tab
        string[] tabViews = { "Index", "Nike", "Adidas", "Puma",
                                       "CheckOut", "Admin", "About" };

        // Text for View Heading of any Options columns
        string[] optionsColumnHeading = { "", "Cleats Options",
                                              "", "", "" };

        // The tax rate is 5%
        decimal taxRate = 0.05M;

        // Action Method for Home page View
        public ActionResult Index()
        {
            Session["PageHeading"] = siteHeading;

            ViewBag.Message = "Welcome To " + siteHeading;
            ViewBag.Message2 = "<img src=\"/Images/Store_Logo.JPG\">";
            ViewBag.Message2 += "<br />Welcome to the Cleats Vault!";
            return View();
        }

        // Action Method for About page View
        public ActionResult About()
        {
            Session["PageHeading"] = siteHeading;

            ViewBag.Message = "About " + siteHeading;
            ViewBag.Message2 = "Nick T is the Webmaster";
            return View();
        }

        // Action Method for First Product View
        public ActionResult Nike()
        {
            return GetTabView(1);
        }

        // Action Method to Process First Product View
        [HttpPost]
        public ActionResult Nike(string button, FormCollection collection)
        {
            return ProcessTabView(1, button, collection);
        }

        // Action Method for Second Product View
        public ActionResult Adidas()
        {
            return GetTabView(2);
        }

        // Action Method to Process Second Product View
        [HttpPost]
        public ActionResult Adidas(string button, FormCollection collection)
        {
            return ProcessTabView(2, button, collection);
        }

        // Action Method for Third Product View
        public ActionResult Puma()
        {
            return GetTabView(3);
        }

        // Action Method to Process Third Product View
        [HttpPost]
        public ActionResult Puma(string button, FormCollection collection)
        {
            return ProcessTabView(3, button, collection);
        }

    }
}