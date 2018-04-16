using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Nettolicious.Common.AspNetCore.Mvc
{
	public class InternalServerErrorResult : ObjectResult
	{
		public InternalServerErrorResult(object value) : base(value)
		{
			StatusCode = (int)HttpStatusCode.InternalServerError;
		}
	}
}
