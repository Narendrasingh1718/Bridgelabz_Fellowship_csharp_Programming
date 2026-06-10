using Model.Entity.Notes;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Interface.INoteInterface
{
    public interface INoteInterface
    {
     
        Task<Notes> CreateNote(Notes note);
        Task<Notes> GetNoteById(int noteId, int userId);
        Task<List<Notes>> GetAllActiveNotes(int userId);
        Task<List<Notes>> GetArchivedNotes(int userId);
        Task<List<Notes>> GetTrashedNotes(int userId);
        Task<List<Notes>> SearchNotes(int userId, string keyword);
        Task<Notes> UpdateNote(Notes note);
        Task<bool> DeleteNote(int noteId, int userId);
        Task<bool> DeleteNoteForever(int noteId, int userId);
        Task<bool> TogglePin(int noteId, int userId);
        Task<bool> ToggleArchive(int noteId, int userId);
        Task<bool> ToggleTrash(int noteId, int userId);
        
    }
}
