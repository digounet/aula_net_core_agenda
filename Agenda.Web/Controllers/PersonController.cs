﻿using Agenda.Application.Interface;
using Agenda.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.Web.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        // GET: PersonController
        public ActionResult Index()
        {
            var persons = _personService.GetPersons();
            return View(persons);
        }

        // GET: PersonController/Details/5
        public ActionResult Details(Guid id)
        {
            var person = _personService.GetPersonById(id);
            return View(person);
        }

        // GET: PersonController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PersonViewModel personViewModel)
        {
            try
            {
                _personService.AddPerson(personViewModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonController/Edit/5
        public ActionResult Edit(Guid id)
        {
            var person = _personService.GetPersonById(id);
            return View(person);
        }

        // POST: PersonController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PersonViewModel personViewModel)
        {
            try
            {
                _personService.UpdatePerson(personViewModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonController/Delete/5
        public ActionResult Delete(Guid id)
        {
            var person = _personService.GetPersonById(id);
            return View(person);
        }

        // POST: PersonController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(PersonViewModel personViewModel)
        {
            try
            {
                _personService.RemovePerson(personViewModel.Id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
