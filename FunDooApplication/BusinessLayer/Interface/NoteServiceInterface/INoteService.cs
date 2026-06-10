using Model.DTO.RequestDto;
using Model.DTO.ResponceDto;
using Model.Entity.Notes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interface.NoteServiceInterface
{
    public interface INoteService
    {
        Task<NoteResponceDto> CreateNote(CreatedReqDto dto);
        Task<NoteResponceDto> GetNoteById(int noteId, int userId);
        Task<List<NoteResponceDto>> GetAllActiveNotes(int userId);
        Task<List<NoteResponceDto>> GetArchivedNotes(int userId);
        Task<List<NoteResponceDto>> GetTrashedNotes(int userId);
        Task<List<NoteResponceDto>> SearchNotes(int userId, string keyword);
        Task<NoteResponceDto> UpdateNote(UpdateReqDto dto);
        Task<String> DeleteNote(int noteId, int userId);
        Task<String> DeleteNoteForever(int noteId, int userId);
        Task<String> TogglePin(int noteId, int userId);
        Task<String> ToggleArchive(int noteId, int userId);
        Task<String> ToggleTrash(int noteId, int userId);
        
    }
}
