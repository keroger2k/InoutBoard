using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InoutBoard.Core.Models.Mappings
{
    public class BoardUserMap : EntityTypeConfiguration<BoardUser>
    {
        public BoardUserMap()
        {
            // Primary Key
            this.HasKey(u => u.Id);

            // Properties
            this.Property(u => u.Note)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("BoardUser");
            this.Property(u => u.Id).HasColumnName("Id");
            this.Property(u => u.Name).HasColumnName("Name");
            this.Property(u => u.Note).HasColumnName("Note");
            this.Property(u => u.Email).HasColumnName("Email");
        }
    }
}
