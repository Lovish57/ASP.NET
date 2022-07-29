using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

using log4net;
namespace Day3_02.Filter
{
    public class Filter1:IExceptionFilter
    {
        private readonly ILog _logger = LogManager.GetLogger(typeof(Filter1));

        public void OnException(ExceptionContext context)
        {

            _logger.Error(context.Exception.Message);
            context.ExceptionHandled = true;
            context.Result = new ViewResult() { ViewName = "CustomError" };
        }
    }
}

    