using Microsoft.AspNetCore.Components;

namespace BethanysPieShop.Components
{
    public partial class ProfilePicture
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; }
    }
}
