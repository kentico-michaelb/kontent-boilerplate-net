using System.Collections.Generic;

namespace Kentico.Kontent.Boilerplate.Models
{
    public partial class NavigationItem
   {
        public List<NavigationItem> Parents { get; set; }
        public string customPath { get; set; }
    }
}