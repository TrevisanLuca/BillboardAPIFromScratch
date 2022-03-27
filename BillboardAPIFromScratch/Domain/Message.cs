namespace BillboardAPIFromScratch.Domain
{
    public record Message(int Id, string Title, string Body, DateTime CreatedAt, DateTime UpdatedAt, int AuthorId);
}