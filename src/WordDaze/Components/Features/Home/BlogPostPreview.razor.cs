using Microsoft.AspNetCore.Components;
using WordDaze.Models;

namespace WordDaze.Components.Features
{
    public class BlogPostPreviewModel : ComponentBase
    {
        [Parameter] protected BlogPost blogPost { get; set; }
    }
}