using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CMS4A4.Model.Content
{
    public class DocumentType
    {
        public string Title { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long DocumentTypeId { get; set; }

        public List<Field> Fields { get; set; }
    }
}
