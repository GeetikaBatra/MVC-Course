using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EdmValidation.Models
{
    public class tbl_deptMeta
    {
        public class tbl_DeptMeta
        {
            [Required]
            public string D_Name { get; set; }
        }

        [MetadataTypeAttribute(typeof(tbl_DeptMeta))]

        public partial class tbl_Department
        {

        }
    }
}