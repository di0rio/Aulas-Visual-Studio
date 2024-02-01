namespace ProjetoMVC.Models
{
	public class Produtos
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public double Price { get; set; }

		public Produtos(int id, string name, double price)
		{
			Id = id;
			Name = name;
			Price = price;
		}
	}
}
