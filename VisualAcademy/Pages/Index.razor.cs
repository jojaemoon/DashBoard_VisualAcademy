using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VisualAcademy.Pages
{
    public partial class Index
    {
        [Inject]
        public IJSRuntime JSRuntime { get; set; }  // 카루셀 적용하기
        public string title { get; set; } = "홈페이지";
        protected override void OnInitialized()
        {

        }

        // 카루셀 적용하기
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await JSRuntime.InvokeAsync<object>("RunCarousel");
        }
    }
}
