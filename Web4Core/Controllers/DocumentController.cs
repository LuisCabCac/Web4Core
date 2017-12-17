using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CMS4A4.Model.Content;
using Web4Core.Implements.Documents;

namespace Web4Core.Controllers
{
    [Produces("application/json")]
    [Route("api/Document")]
    public class DocumentController : Controller
    {

        private readonly IDocumentManager documentManager;

        DocumentController(IDocumentManager documentManager)
        {
            this.documentManager = documentManager;
        }

        [HttpGet("[action]/{title}")]
        public IEnumerable<DocumentType> GetDocuments(string title)
        {
            return documentManager.GetListByTitle(title);
        }


        [HttpPost("[action]")]
        public void SaveDocuments(DocumentType document)
        {
            documentManager.SaveDocument(document);
        }
    }
}
