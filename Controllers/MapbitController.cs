using Mapbit.Abstractions.Queries;
using Mapbit.Commands;
using Mapbit.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;


namespace Mapbit.Controllers
{
    //https://dev.to/iamrule/comprehensive-guide-to-api-versioning-in-net-8-1i9j
    //[ApiVersion("1.0")]

    [Route("api/[controller]")]
    [ApiController]
    public class MapbitController : BaseController
    {

        private readonly ICommandDispatcher _commandDispatcher;
        
        //[HttpGet("{filename:string}")]
        [HttpGet()]
        public async Task<ActionResult<MapbitDto>> Get([FromRoute] IQuery query)
        {
            // var result = await _queryDispatcher.QueryAsync(query);
            MapbitDto mapbit = new MapbitDto("","",0,0,Color.Black);
            var result = mapbit;
            return OkOrNotFound(result);
        }

        [HttpGet(Name = "ReadMessage")]
        public async Task<ActionResult<MapbitDto>> ReadMessage([FromRoute] IQuery query)
        {
            // var result = await _queryDispatcher.QueryAsync(query);

            PixMapper.BitmapFactory f = new PixMapper.BitmapFactory();
            var created = f.Create("", "", 10, 100, Color.Bisque);

            MapbitDto mapbit = new MapbitDto("", "", 0, 0, Color.Black);
            var result = mapbit;
            return OkOrNotFound(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] DecodeMapbit command)
        {
            await _commandDispatcher.DispatchAsync(command);
            // var result = await _queryDispatcher.QueryAsync(query);
            return CreatedAtAction(nameof(Get), new { message = command.embedMessage }, null);
        }


        [HttpGet]
        public async Task<ActionResult> GetProducts()
        {
            //var products = await _mediator.Send(new GetProductsQuery());
            return Ok();
        }




        /*
         * 
         * string StartDirectory = @"c:\Users\exampleuser\start";
            string EndDirectory = @"c:\Users\exampleuser\end";

            foreach (string filename in Directory.EnumerateFiles(StartDirectory))
            {
                using (FileStream SourceStream = File.Open(filename, FileMode.Open))
                {
                    using (FileStream DestinationStream = File.Create(EndDirectory + filename.Substring(filename.LastIndexOf('\\'))))
                    {
                        await SourceStream.CopyToAsync(DestinationStream);
                    }
                }
            }

        //private static HttpClient Client { get; } = new HttpClient();

        [HttpGet("{filename:string}")]
        public async Task<IActionResult> GetFile([FromRoute] IQuery query)
        {
            //var fileIds = factory.GetFileIdsForEntityId(id); // result be like "1,2,3,4"
            //var stream = await Client.GetStreamAsync($"http://file-service/bulk/{fileIds}");

            //return File(stream, "application/octet-stream", "media_files.zip");
        }

        [HttpPost]
        [ActionName("AddAudio")]
        public async Task<IHttpActionResult> AddAudio([FromUri]string name)
        {
          try
          {
            string file = Path.Combine(@"C:\Users\username\Desktop\UploadedFiles", fileName);
            using (FileStream fs = new FileStream(file, FileMode.Create, FileAccess.Write,
                FileShare.None, 4096, useAsync: true))
            {
              await Request.Content.CopyToAsync(fs);
            }
            return Ok();
          }
          catch (Exception ex)
          {
            return BadRequest("ERROR: Audio could not be saved on server.");
          }
        }


        public class EbookController : ApiController
        {
            string bookPath_Pdf = @"C:\MyWorkSpace\SelfDev\UserAPI\UserAPI\Books\sample.pdf";
            string bookPath_xls = @"C:\MyWorkSpace\SelfDev\UserAPI\UserAPI\Books\sample.xls";
            string bookPath_doc = @"C:\MyWorkSpace\SelfDev\UserAPI\UserAPI\Books\sample.doc";
            string bookPath_zip = @"C:\MyWorkSpace\SelfDev\UserAPI\UserAPI\Books\sample.zip";

            [HttpGet]
            [Route("Ebook/GetBookFor/{format}")]
            public IHttpActionResult GetbookFor(string format)
            {
                string reqBook = format.ToLower() == "pdf" ? bookPath_Pdf : (format.ToLower() == "xls" ? bookPath_xls : (format.ToLower() == "doc" ? bookPath_doc : bookPath_zip));
                string bookName = "sample." + format.ToLower();

                //converting Pdf file into bytes array
                var dataBytes = File.ReadAllBytes(reqBook);
                //adding bytes to memory stream
                var dataStream = new MemoryStream(dataBytes);
                return new eBookResult(dataStream, Request, bookName);
            }
            [HttpGet]
            [Route("Ebook/GetBookForHRM/{format}")]
            public HttpResponseMessage GetBookForHRM(string format)
            {
                string reqBook = format.ToLower() == "pdf" ? bookPath_Pdf : (format.ToLower() == "xls" ? bookPath_xls : (format.ToLower() == "doc" ? bookPath_doc : bookPath_zip));
                string bookName = "sample." + format.ToLower();
                //converting Pdf file into bytes array
                var dataBytes = File.ReadAllBytes(reqBook);
                //adding bytes to memory stream
                var dataStream = new MemoryStream(dataBytes);

                HttpResponseMessage httpResponseMessage = Request.CreateResponse(HttpStatusCode.OK);
                httpResponseMessage.Content = new StreamContent(dataStream);
                httpResponseMessage.Content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment");
                httpResponseMessage.Content.Headers.ContentDisposition.FileName = bookName;
                httpResponseMessage.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");

                return httpResponseMessage;
            }
        }

        public class eBookResult : IHttpActionResult
        {
            MemoryStream bookStuff;
            string PdfFileName;
            HttpRequestMessage httpRequestMessage;
            HttpResponseMessage httpResponseMessage;
            public eBookResult(MemoryStream data, HttpRequestMessage request, string filename)
            {
                bookStuff = data;
                httpRequestMessage = request;
                PdfFileName = filename;
            }
            public System.Threading.Tasks.Task<HttpResponseMessage> ExecuteAsync(System.Threading.CancellationToken cancellationToken)
            {
                httpResponseMessage = httpRequestMessage.CreateResponse(HttpStatusCode.OK);
                httpResponseMessage.Content = new StreamContent(bookStuff);
                //httpResponseMessage.Content = new ByteArrayContent(bookStuff.ToArray());
                httpResponseMessage.Content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment");
                httpResponseMessage.Content.Headers.ContentDisposition.FileName = PdfFileName;
                httpResponseMessage.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");

                return System.Threading.Tasks.Task.FromResult(httpResponseMessage);
            }
        }


        */
    }



}
