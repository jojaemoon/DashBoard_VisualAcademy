using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VisualAcademy.Pages
{
    public partial class About
    {
        public string title { get; set; } = "정보";
        public string SubTilte { get; set; } = "사이트 정보";

        protected override void OnInitialized()
        {
            SubTilte = DateTime.Now.ToLongTimeString();      
        }
    }
}
