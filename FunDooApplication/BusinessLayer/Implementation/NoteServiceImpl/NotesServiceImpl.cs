using BusinessLayer.Interface.NoteServiceInterface;
using Microsoft.Extensions.Logging;
using Model.DTO.RequestDto;
using Model.DTO.ResponceDto;
using Model.Entity;
using Model.Entity.Notes;
using Model.Exception;
using RepositoryLayer.Interface.INoteInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Implementation.NoteServiceImpl
{
    public class NotesServiceImpl : INoteService
    {
        private readonly INoteInterface repository;
        private readonly ILogger<NotesServiceImpl> logger;
        public NotesServiceImpl(INoteInterface repository, ILogger<NotesServiceImpl> logger)
        {
            this.repository = repository;
            this.logger = logger;
        }
        // create
        public async Task<NoteResponceDto> CreateNote(CreatedReqDto dto)
        {
            var note = new Notes
            {
                ID = 0,
                Title = dto.Title,
                Description = dto.Description,
                Reminder = dto.Reminder,
                BackgroundColour = dto.BackgroundColour,
                Image = dto.Image,
                Pin = dto.Pin,
                Created = DateTime.Now,
                Edited = null,
                Archive = false,
                Trash = false,
                UserId = dto.UserId
            };
            var result = await repository.CreateNote(note);
            return new NoteResponceDto
            {
                ID = result.ID,
                Title = result.Title,
                Description = result.Description,
                Reminder = result.Reminder,
                BackgroundColour = result.BackgroundColour,
                Image = result.Image,
                Pin = result.Pin,
                Archive = result.Archive,
                Trash = result.Trash,
                Created = result.Created,
                Edited = result.Edited,
            };

        }
        //GetAllActiveNotes
        public async Task<List<NoteResponceDto>> GetAllActiveNotes(int userId)
        {
            var result = await repository.GetAllActiveNotes(userId);
            if (result == null)
            {
                logger.LogWarning("No Record Found");
                throw new NoRecordFound("No Record Found");
            }
            return result.Select(note => new NoteResponceDto
            {
                ID = note.ID,
                Title = note.Title,
                Description = note.Description,
                Reminder = note.Reminder,
                BackgroundColour = note.BackgroundColour,
                Image = note.Image,
                Pin = note.Pin,
                Archive = note.Archive,
                Trash = note.Trash,
                Created = note.Created,
                Edited = note.Edited
            }).ToList();
        }
        //GetArchivedNotes

        public async Task<List<NoteResponceDto>> GetArchivedNotes(int userId)
        {
            var result = await repository.GetArchivedNotes(userId);
            if (result == null)
            {
                logger.LogWarning("No Record Found");
                throw new NoRecordFound("No Record Found");
            }

            return result.Select(note => new NoteResponceDto
            {
                ID = note.ID,
                Title = note.Title,
                Description = note.Description,
                Reminder = note.Reminder,
                BackgroundColour = note.BackgroundColour,
                Image = note.Image,
                Pin = note.Pin,
                Archive = note.Archive,
                Trash = note.Trash,
                Created = note.Created,
                Edited = note.Edited
            }).ToList();
        }
        //GetTrashedNotes

        public async Task<List<NoteResponceDto>> GetTrashedNotes(int userId)
        {
            var result = await repository.GetTrashedNotes(userId);
            if (result == null)
            {
                logger.LogWarning("No Record Found");
                throw new NoRecordFound("No Record Found");
            }

            return result.Select(note => new NoteResponceDto
            {
                ID = note.ID,
                Title = note.Title,
                Description = note.Description,
                Reminder = note.Reminder,
                BackgroundColour = note.BackgroundColour,
                Image = note.Image,
                Pin = note.Pin,
                Archive = note.Archive,
                Trash = note.Trash,
                Created = note.Created,
                Edited = note.Edited
            }).ToList();
        }
        //Search Notes

        public async Task<List<NoteResponceDto>> SearchNotes(int userId, string keyword)
        {

            var result = await repository.SearchNotes(userId, keyword);
            if (result == null)
            {
                logger.LogWarning("No Record Found");
                throw new NoRecordFound("No Record Found");
            }

            return result.Select(note => new NoteResponceDto
            {
                ID = note.ID,
                Title = note.Title,
                Description = note.Description,
                Reminder = note.Reminder,
                BackgroundColour = note.BackgroundColour,
                Image = note.Image,
                Pin = note.Pin,
                Archive = note.Archive,
                Trash = note.Trash,
                Created = note.Created,
                Edited = note.Edited
            }).ToList();
        }
        // update Notes

        public async Task<NoteResponceDto> UpdateNote(UpdateReqDto dto)
        {
           
            var existing = await repository.GetNoteById(dto.Id, dto.UserId);

            if (existing == null)
            {
                logger.LogWarning("No Record Found");
                throw new NoRecordFound("Note not found");
            }

            
            existing.Title = dto.Title;
            existing.Description = dto.Description;
            existing.Reminder = dto.Reminder;
            existing.BackgroundColour = dto.BackgroundColour;
            existing.Image = dto.Image;
            existing.Edited = DateTime.Now;

            
            var updated = await repository.UpdateNote(existing);

            return new NoteResponceDto
            {
                ID = updated.ID,
                Title = updated.Title,
                Description = updated.Description,
                Reminder = updated.Reminder,
                BackgroundColour = updated.BackgroundColour,
                Image = updated.Image,
                Pin = updated.Pin,
                Archive = updated.Archive,
                Trash = updated.Trash,
                Created = updated.Created,
                Edited = updated.Edited
            };
        }
        //  Soft Delete 
        public async Task<String> DeleteNote(int noteId, int userId)
        {
            var result = await repository.DeleteNote(noteId, userId);
            if (result == false)
            {
                logger.LogWarning("user with this isd not found");
                throw new UserNotFoundException("user not found");
            }
            return "Note Trashed Successfully";
        }
        // Delete foreever

        public async Task<String> DeleteNoteForever(int noteId, int userId)
        {
            var result = await repository.DeleteNoteForever(noteId, userId);
            if (result == false)
            {
                logger.LogWarning("user with this isd not found");
                throw new UserNotFoundException("user not found");
            }
            return "Note Deleted Successfully";
        }
        //Toggle Pin

        public async Task<String> TogglePin(int noteId, int userId)
        {
            var result = await repository.TogglePin(noteId, userId);
            if (result == false)
            {
                logger.LogWarning("user with this isd not found");
                throw new UserNotFoundException("user not found");
            }
            return "Toggle pinned Successfully";
        }
        // Toggle Archieve
        public async Task<String> ToggleArchive(int noteId, int userId)
        {
            var result = await repository.ToggleArchive(noteId, userId);
            if (result == false)
            {
                logger.LogWarning("user with this isd not found");
                throw new UserNotFoundException("user not found");
            }
            return "Toggle Archieve Successfully";
        }
        // Toggle Trash
        public async Task<String> ToggleTrash(int noteId, int userId)
        {
            var result = await repository.ToggleTrash(noteId, userId);
            if (result == false)
            {
                logger.LogWarning("user with this isd not found");
                throw new UserNotFoundException("user not found");
            }
            return "Toggle Trash Successfully";
        }
        //GetNoteById

        public async Task<NoteResponceDto> GetNoteById(int noteId, int userId)
        {
            var note = await repository.GetNoteById(noteId, userId);

            if (note == null)
            {
                logger.LogWarning("No Record Found");
                throw new NoRecordFound("No Record Found");
            }

            return new NoteResponceDto
            {
                ID = note.ID,
                Title = note.Title,
                Description = note.Description,
                Reminder = note.Reminder,
                BackgroundColour = note.BackgroundColour,
                Image = note.Image,
                Pin = note.Pin,
                Archive = note.Archive,
                Trash = note.Trash,
                Created = note.Created,
                Edited = note.Edited
            };
        }

    }
}
