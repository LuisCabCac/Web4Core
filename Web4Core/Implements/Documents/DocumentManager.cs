using CMS4A4.Model.Content;
using CMS4A4.Repository.SQLServer.Context;
using System.Collections.Generic;
using System.Linq;

namespace Web4Core.Implements.Documents
{
    public interface IDocumentManager
    {
        List<DocumentType> GetListByTitle(string title);
        void SaveDocument(DocumentType document);
    }

    public class DocumentManager : IDocumentManager
    {
        public List<DocumentType> GetListByTitle(string title)
        {
            List<DocumentType> documents = null;
            using (var db = new CmsContext())
            {
                documents = db.DocumentTypes
                   .Where(b => b.Title != "")
                   .ToList();
            }
            return documents;
        }

        public void SaveDocument(DocumentType document)
        {
            using (var db = new CmsContext())
            {
                db.DocumentTypes.Add(document);
                db.SaveChanges();
            }
        }
    }
}
