using Microsoft.Extensions.Hosting;

namespace Relacionamentos.Models
{
    public class Blog
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public virtual Uri SiteUri { get; set; }

        public ICollection<Post>? Posts { get; }
    }
}
