using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Music_Store.Domain.Models;
using System.Net;
using Music_Store.Application.ViewModels;
using Music_Store.Service.Services;

namespace Music_Store.UI.Controllers
{
   
    [Route("{action=listar}")]
    public class AlbumController : Controller
    {
        private readonly IAlbumAppService _albumAppService;

        public AlbumController(IAlbumAppService albumAppService)
        {
            _albumAppService = albumAppService;
        }

        [Route("listar")]
        public ActionResult Index()
        {
            return View(_albumAppService.ObterTodos());
        }

        [Route("incluir-novo")]
        public ActionResult Create()
        {
            return View();
        }

        [Route("incluir-novo")]
        [HttpPost]        
        public ActionResult Create(AlbumViewModel albumViewModel)
        {      

            if (ModelState.IsValid)
            {
                albumViewModel = _albumAppService.Adicionar(albumViewModel);                

                return RedirectToAction("Index");
            }

            return View(albumViewModel);
        }

        [Route("excluir/{id:int}")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IEnumerable<AlbumViewModel> albumViewModel = _albumAppService.ObterPorId(id.Value);
            if (albumViewModel == null)
            {
                return HttpNotFound();
            }
            return View(albumViewModel);
        }
        
        [Route("excluir/{id:int}")]
        [HttpPost, ActionName("Delete")]       
        public ActionResult DeleteConfirmed(int id)
        {
            _albumAppService.Remover(id);
            return RedirectToAction("Index");
        }

        [Route("editar/{id:int}")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IEnumerable<AlbumViewModel> albumViewModel = _albumAppService.ObterPorId(id.Value);
            if (albumViewModel == null)
            {
                return HttpNotFound();
            }

            ViewBag.Id = id;
            return View(albumViewModel);
        }

        [Route("editar/{id:int}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AlbumViewModel albumViewModel)
        {
            if (ModelState.IsValid)
            {
                //var errors = ModelState.Values.SelectMany(v => v.Errors);
                _albumAppService.Atualizar(albumViewModel);
                return RedirectToAction("Index");
            }
            IEnumerable<AlbumViewModel> AlbumViewModels = _albumAppService.ObterTodos();
            return View(AlbumViewModels);
        }
    }
}