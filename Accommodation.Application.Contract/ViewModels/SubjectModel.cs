using System.Collections.Generic;
using System.Web.Mvc;

namespace Accommodation.Application.Contract.ViewModels
{
    public class SubjectModel
    {
        public List<SelectListItem> SubjectList { get; set; }

        public SubjectModel()
        {
            SubjectList = new List<SelectListItem>();
        }
    }
}