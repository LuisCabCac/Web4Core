using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS4A4.Model.Content
{
    public class Field
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long FieldId { get; set; }

        public Type Type { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }
    }
}
