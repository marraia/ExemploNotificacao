using ExemploNotificacao.Application.Interface;
using ExemploNotificacao.Common.Model;
using ExemploNotificacao.Controllers.Base;
using ExemploNotificacao.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ExemploNotificacao.Controllers
{
    [Produces("application/json")]
    [Route("api/Student")]
    public class StudentController : BaseController
    {
        private readonly IStudentAppService _appService;
        public StudentController(INotificationHandler<Notifications> notification,
            IStudentAppService appService) : base(notification)
        {
            _appService = appService;
        }

        [HttpPost]
        public IActionResult Add([FromBody] Student obj)
        {
            return CreatedHasNotification(nameof(Add), _appService.Add(obj));
        }
    }
}