using System.ComponentModel.DataAnnotations.Schema;

namespace FullStackAuth_WebAPI.Models
{
    public class Favorite
    {
        public int FavoriteId { get; set; }
        public int UserId { get; set; }
        public int RecipeId { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
