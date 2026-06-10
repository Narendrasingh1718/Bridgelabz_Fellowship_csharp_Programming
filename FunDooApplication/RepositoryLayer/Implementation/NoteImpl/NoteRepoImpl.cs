using Model.Entity.Notes;
using RepositoryLayer.Context;
using RepositoryLayer.Interface.INoteInterface;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace RepositoryLayer.Implementation.NoteImpl
{
    public class NoteRepoImpl : INoteInterface
    {
        private readonly Context.AppDbContext context;

        public NoteRepoImpl(Context.AppDbContext context)
        {
            this.context = context;
        }

        // Create
        public async Task<Notes> CreateNote(Notes note)
        {
            await context.Notes.AddAsync(note);
            await context.SaveChangesAsync();
            return note;
        }

        // Get Active Notes
        public async Task<List<Notes>> GetAllActiveNotes(int userId)
        {
            return await context.Notes
                .Where(n => n.UserId == userId && !n.Archive && !n.Trash)
                .ToListAsync();
        }

        // Get Archived Notes
        public async Task<List<Notes>> GetArchivedNotes(int userId)
        {
            return await context.Notes
                .Where(n => n.UserId == userId && n.Archive && !n.Trash)
                .ToListAsync();
        }

        // Get Trashed Notes
        public async Task<List<Notes>> GetTrashedNotes(int userId)
        {
            return await context.Notes
                .Where(n => n.UserId == userId && n.Trash)
                .ToListAsync();
        }

        //  Search Notes
        public async Task<List<Notes>> SearchNotes(int userId, string keyword)
        {
            return await context.Notes
                .Where(n => n.UserId == userId &&
                           (n.Title.Contains(keyword) || n.Description.Contains(keyword)))
                .ToListAsync();
        }

        // Update Note
        public async Task<Notes> UpdateNote(Notes note)
        {
            context.Notes.Update(note);   
            await context.SaveChangesAsync();
            return note;
        }

        //  Soft Delete 
        public async Task<bool> DeleteNote(int noteId, int userId)
        {
            var note = await context.Notes
                .FirstOrDefaultAsync(n => n.ID == noteId && n.UserId == userId);

            if (note == null) return false;

            note.Trash = true;
            await context.SaveChangesAsync();
            return true;
        }

        // Delete Forever
        public async Task<bool> DeleteNoteForever(int noteId, int userId)
        {
            var note = await context.Notes
                .FirstOrDefaultAsync(n => n.ID == noteId && n.UserId == userId);

            if (note == null) return false;

            context.Notes.Remove(note);
            await context.SaveChangesAsync();
            return true;
        }

        // Toggle Pin
        public async Task<bool> TogglePin(int noteId, int userId)
        {
            var note = await context.Notes
                .FirstOrDefaultAsync(n => n.ID == noteId && n.UserId == userId);

            if (note == null) return false;

            note.Pin = !note.Pin;
            await context.SaveChangesAsync();
            return true;
        }

        // Toggle Archive
        public async Task<bool> ToggleArchive(int noteId, int userId)
        {
            var note = await context.Notes
                .FirstOrDefaultAsync(n => n.ID == noteId && n.UserId == userId);

            if (note == null) return false;

            note.Archive = !note.Archive;
            await context.SaveChangesAsync();
            return true;
        }

        // Toggle Trash
        public async Task<bool> ToggleTrash(int noteId, int userId)
        {
            var note = await context.Notes
                .FirstOrDefaultAsync(n => n.ID == noteId && n.UserId == userId);

            if (note == null) return false;

            note.Trash = !note.Trash;
            await context.SaveChangesAsync();
            return true;
        }
        //get note by id
        public async Task<Notes> GetNoteById(int noteId, int userId)
        {
            return await context.Notes
                .FirstOrDefaultAsync(n => n.ID == noteId && n.UserId == userId);
        }
    }
}
