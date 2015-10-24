﻿using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using Veil.DataAccess;
using Veil.DataAccess.Interfaces;
using Veil.DataModels.Models;

namespace Veil.Controllers
{
    public class CartController : Controller
    {
        protected readonly IVeilDataAccess db;

        public CartController(IVeilDataAccess veilDataAccess)
        {
            db = veilDataAccess;
        }

        // GET: Cart
        public async Task<ActionResult> Index()
        {
            // TODO: Remove this and actually implement it
            //Member currentMember = new Member();
            //currentMember.Cart = new Cart();

            //return View(currentMember.Cart);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddItem(Guid? productId)
        {
            // TODO: Actually implement this
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> RemoveItem(Guid? productId)
        {
            // TODO: Actually implement this
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> UpdateQuantity(Guid? productId, int? quantity)
        {
            // TODO: Actually implement this
            return RedirectToAction("Index");
        }
    }
}
