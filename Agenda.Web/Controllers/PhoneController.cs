using Agenda.Application.Interface;
using Agenda.Application.Service;
using Agenda.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.Web.Controllers
{
    public class PhoneController : Controller
    {
        private readonly IPhoneService _phoneService;
        private readonly IPersonService _personService;
        public PhoneController(IPhoneService phoneService, IPersonService personService)
        {
            _phoneService = phoneService;
            _personService = personService;

        }
        public IActionResult Index(Guid idPessoa)
        {
            ViewBag.IdPessoa = idPessoa;
            return View(_phoneService.GetPhones(idPessoa));
        }

        public ActionResult Create(Guid idPessoa) 
        {

            ViewBag.IdPessoa = idPessoa;
            return View();

            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PhoneViewModel phoneViewModel, Guid idPessoa)
        {
            try
            {
                ViewBag.IdPessoa = idPessoa;
                _phoneService.AddPhone(phoneViewModel,idPessoa);

                return RedirectToAction(nameof(Index), new { idPessoa = idPessoa });
            }
            catch
            {
                ViewBag.IdPessoa = idPessoa;
                return View(idPessoa);
            }
        }

        public ActionResult Edit(Guid id, Guid idPessoa)
        {
            var phone = _phoneService.GetPhoneById(id);
            ViewBag.IdPessoa = idPessoa;
            phone.PersonId = idPessoa;
            return View(phone);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PhoneViewModel phoneViewModel, Guid idPessoa)
        {
            try
            {
                ViewBag.IdPessoa = idPessoa;
                _phoneService.UpdatePhone(phoneViewModel,idPessoa);
                return RedirectToAction(nameof(Index), new { idPessoa = idPessoa });
            }
            catch
            {
                ViewBag.IdPessoa = idPessoa;
                return View(idPessoa);
            }
        }
        // GET: PersonController/Delete/5
        public ActionResult Delete(Guid id)
        {
            var phone = _phoneService.GetPhoneById(id);
            return View(phone);
        }

        // POST: PersonController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(PersonViewModel phoneViewModel)
        {
            try
            {
                _phoneService.RemovePhone(phoneViewModel.Id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
