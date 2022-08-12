namespace Mago.Mvc.Models
{
    public class Carrinho
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public Item Item { get; set; }
        public Usuario Usuario { get; set; }
    }
}
