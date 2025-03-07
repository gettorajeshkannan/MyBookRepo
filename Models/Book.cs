using System.ComponentModel.DataAnnotations;

public class Book
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Title is required")]
    [StringLength(100, ErrorMessage = "Title length can't be more than 100 characters.")]
    public string Title { get; set; }

    [Required(ErrorMessage = "Author is required")]
    [StringLength(50, ErrorMessage = "Author length can't be more than 50 characters.")]
    public string Author { get; set; }

    [Required(ErrorMessage = "Language is required")]
    [StringLength(20, ErrorMessage = "Language length can't be more than 20 characters.")]
    public string Language { get; set; }

    [Required(ErrorMessage = "Category is required")]
    [StringLength(50, ErrorMessage = "Category length can't be more than 50 characters.")]
    public string Category { get; set; }

    [Range(1450, 2100, ErrorMessage = "Published year must be between 1450 and 2100.")]
    public int PublishedYear { get; set; }

    [Range(1, 10000, ErrorMessage = "Number of pages must be between 1 and 10000.")]
    public int NoOfPages { get; set; }
}