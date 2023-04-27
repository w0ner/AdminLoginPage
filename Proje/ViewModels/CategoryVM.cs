using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proje.ViewModels
{
    public class CategoryVM
    {
        public List<Category> Categories { get; set; }
        public IEnumerable<Category> category { get; set; }
    }
}