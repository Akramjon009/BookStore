﻿using BookStore.Application.useCases.Authors.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly IMediator _mediator;

        public AuthorsController(IMediator mediator)
            => _mediator = mediator;

        public async Task<IActionResult> Index()
        {
            var query = new GetAllAuthorsQuery();
            var authors = await _mediator.Send(query);

            return View(authors);
        }
    }
}
