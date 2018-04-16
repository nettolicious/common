using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Dynamic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Nettolicious.Common.Data
{
	public static class HttpClientHelper
	{
		public static HttpClient NewHttpClient(bool useDefaultCredentials = true)
		{
			return new HttpClient(new HttpClientHandler() { UseDefaultCredentials = useDefaultCredentials });
		}

		public static async Task<ApiResponse<T>> AsApiResponse<T>(this HttpContent httpContent)
		{
			var stream = await httpContent.ReadAsStreamAsync();
			using (JsonReader reader = new JsonTextReader(new StreamReader(stream)))
			{
				var serializer = new JsonSerializer();
				return serializer.Deserialize<ApiResponse<T>>(reader);
			}
		}

		public static async Task<ApiResponse<dynamic>> AsDynamicApiResponse(this HttpContent httpContent)
		{
			var stream = await httpContent.ReadAsStreamAsync();
			ApiResponse<ExpandoObject> expandoResponse;
			using (JsonReader reader = new JsonTextReader(new StreamReader(stream)))
			{
				var serializer = new JsonSerializer();
				serializer.Converters.Add(new ExpandoObjectConverter());
				expandoResponse = serializer.Deserialize<ApiResponse<ExpandoObject>>(reader);
			}
			return new ApiResponse<dynamic>
			{
				StatusCode = expandoResponse.StatusCode,
				Data = expandoResponse.Data,
				Error = expandoResponse.Error
			};
		}

		public static async Task<ApiResponse<QueryResult<dynamic>>> AsDynamicQueryApiResponse(this HttpContent httpContent)
		{
			var stream = await httpContent.ReadAsStreamAsync();
			ApiResponse<QueryResult<ExpandoObject>> expandoResponse;
			using (JsonReader reader = new JsonTextReader(new StreamReader(stream)))
			{
				var serializer = new JsonSerializer();
				serializer.Converters.Add(new ExpandoObjectConverter());
				expandoResponse = serializer.Deserialize<ApiResponse<QueryResult<ExpandoObject>>>(reader);
			}
			return new ApiResponse<QueryResult<dynamic>>
			{
				StatusCode = expandoResponse.StatusCode,
				Data = new QueryResult<dynamic>
				{
					QTime = expandoResponse.Data.QTime,
					NumFound = expandoResponse.Data.NumFound,
					Start = expandoResponse.Data.Start,
					Docs = expandoResponse.Data.Docs
				},
				Error = expandoResponse.Error
			};
		}

		public static StringContent AsStringContent(this object content)
		{
			using (var writer = new StringWriter())
			{
				var serializer = JsonSerializer.Create();
				serializer.Serialize(writer, content);
				return new StringContent(writer.ToString(), Encoding.UTF8, "application/json");
			}
		}
	}
}
