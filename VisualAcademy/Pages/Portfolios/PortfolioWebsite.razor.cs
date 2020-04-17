using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VisualAcademy.Pages.Portfolios
{
    public partial class PortfolioWebsite
    {
        [Inject]
        public NavigationManager NavigationManagerRefernce { get; set; }
        public string title { get; set; } = "포트폴리오";

        protected override void OnInitialized()
        {
            
        }
        protected void GoToSportsall()
        {
            NavigationManagerRefernce.NavigateTo("http://sportsall.kr");
        }
    }
}
