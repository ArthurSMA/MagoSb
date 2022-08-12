namespace Mago.Mvc.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cor { get; set; }
        public float Preco { get; set; }
        public int QtdEstoque { get; set; }
        public string Tamanho { get; set; }
        public int? Promocional { get; set; }
        public Genero Genero { get; set; }
        public Categoria Categoria { get; set; }

    }
}
