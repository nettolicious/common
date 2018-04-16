using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Nettolicious.Common.Data
{

	public class ApiResponse<T>
	{
		public int StatusCode { get; set; }
		public object Error { get; set; }

		public T Data { get; set; }
		
		public ApiResponse() { }

		public ApiResponse(T data, HttpStatusCode statusCode = HttpStatusCode.OK)
		{
			Data = data;
			StatusCode = (int)statusCode;
		}

		public ApiResponse(HttpStatusCode statusCode)
		{
			StatusCode = (int)statusCode;
		}

		public ApiResponse(object error, HttpStatusCode statusCode = HttpStatusCode.InternalServerError)
		{
			Error = error;
			StatusCode = (int)statusCode;
		}
	}
}
