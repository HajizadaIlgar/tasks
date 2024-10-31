using LibraryManagementApp.Models;

namespace LibraryManagementApp.Services.Abstraction;

public interface ILibrarianService
{
    LibraryMember GetBookById(int id);
    LibraryMember GetBookByName(string name);
    List<LibraryMember> GetAllLibrarianMember();
    void CreateLibrarianMember(LibraryMember person);
    void DeleteMember(int id);
}
