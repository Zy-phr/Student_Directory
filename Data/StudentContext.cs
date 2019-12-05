using Student_Directory.Models;
using Microsoft.EntityFrameworkCore;

namespace Student_Directory.Data {

    public class StudentContext : DbContext {

        public StudentContext(DbContextOptions options) : base(options) {

        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Major> Majors { get; set; }
    }
}