using PulsenicsAssessments.Database;
using PulsenicsAssessments.Models;
using PulsenicsAssessments.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PulsenicsAssessments.Helpers
{
    public class UserHandler
    {
        public static bool AddUser(string name, string email, string phone)
        {
            if (FindExistingUser(name) != null)
            {
                return false;
            }

            User user = new User();
            user.Name = name;
            user.Email = email;
            user.Phone = phone;

            using var context = new FilesContext();
            context.Users.Add(user);
            context.SaveChanges();
            return true;
        }

        public static bool UpdateUser(string name, string email, string phone)
        {
            User? existingUser = FindExistingUser(name);
            if (existingUser == null)
            {
                return false;
            }

            existingUser.Email = email;
            existingUser.Phone = phone;

            using var context = new FilesContext();
            context.Users.Update(existingUser);
            context.SaveChanges();
            return true;
        }

        private static User? FindExistingUser(string name)
        {
            using var context = new FilesContext();
            return context.Users.Where(user => user.Name == name).FirstOrDefault();
        }

        public static void AssignFileToUser(string fileName, string userName)
        {
            using var context = new FilesContext();
            FileData? file = context.Files.Where(f => f.Name + f.Extension == fileName).Include("Users").FirstOrDefault();
            if (file == null) throw new FileDataNotFoundException();

            User? user = context.Users.Where(u => u.Name == userName).Include("Files").FirstOrDefault();
            if (user == null) throw new UserNotFoundException();

            if (!file.Users.Any(u => u.UserId == user.UserId))
            {
                file.Users.Add(user);
                context.Files.Update(file);
            }

            if (!user.Files.Any(f => f.FileDataId == file.FileDataId))
            {
                user.Files.Add(file);
                context.Users.Update(user);
            }

            context.SaveChanges();
        }

        public static List<User> SearchForUser(string name)
        {
            using var context = new FilesContext();
            return context.Users.Where(u => u.Name!.ToLower().Contains(name.ToLower())).ToList();
        }

        public static User? GetUserWithFiles(string name)
        {
            using var context = new FilesContext();
            return context.Users.Where(u => u.Name == name).Include("Files").FirstOrDefault();
        }

        public static void DeleteUser(string name)
        {
            using var context = new FilesContext();
            User? existingUser = context.Users.Where(u => u.Name == name).FirstOrDefault();
            if (existingUser != null)
            {
                context.Users.Remove(existingUser);
                context.SaveChanges();
            }
        }
    }
}
