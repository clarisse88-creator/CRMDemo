namespace Application.Interface
{
    public interface IUserContext
    {
        int? Id { get; }
        bool IsAuthenticated { get; }
        string? Email { get; }
        string? FullName { get; }  
        string FirstName { get; }
        string LastName { get; }
        string Initials{ get; }
             
    }
}