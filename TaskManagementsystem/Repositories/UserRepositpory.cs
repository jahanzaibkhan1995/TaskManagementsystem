using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementSystem.Data;

namespace TaskManagementsystem.Repositories
{
    
        public class UserRepository
        {
            private readonly AppDbContext _context;

            public UserRepository()
            {
                _context = new AppDbContext();
            }

            // Add a new user
            public void AddUser(User user)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
            }

            // Authenticate User
            public User Authenticate(string email, string password)
            {
                return _context.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
            }

            // Get a user by ID
            public User GetUserById(int id)
            {
                return _context.Users.Find(id);
            }
        }
    }


