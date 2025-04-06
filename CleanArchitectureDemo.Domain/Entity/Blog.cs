namespace CleanArchitectureDemo.Domain.Entity
{
	public class Blog
	{
		public int Id { get; set; }
		public string Title { get; set; } = string.Empty;
		public string Content { get; set; } = string.Empty;
		public string Author { get; set; } = string.Empty;
		public DateTime CreatedDate { get; set; }
		public DateTime UpdatedDate { get; set; }
		public Blog()
		{
			CreatedDate = DateTime.UtcNow;
			UpdatedDate = DateTime.UtcNow;
		}
	}
}
