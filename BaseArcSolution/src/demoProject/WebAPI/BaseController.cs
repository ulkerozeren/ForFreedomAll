using Core.Application.Logging.Serilog.Logger;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected IMediator? Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
        private IMediator? _mediator;

        readonly IConfiguration _configuration;
        readonly FileLogger _fileLogger;
        public FileLogger FileLogger
        {
            get
            {
                return _fileLogger;
            }
        }

        public BaseController(IConfiguration configuration)
        {
            _configuration = configuration;
            _fileLogger = new FileLogger(_configuration);
        }


    }
}
