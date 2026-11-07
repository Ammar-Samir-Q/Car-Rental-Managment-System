namespace CarRental.DTO
{
    public record UserDTO (int UserID,int PersonID,string Username,string Password,byte Role,bool IsActive,DateTime CreationDate);
    
}
