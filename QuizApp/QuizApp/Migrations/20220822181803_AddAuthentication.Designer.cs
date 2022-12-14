// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuizApp.Data;

#nullable disable

namespace QuizApp.Migrations
{
    [DbContext(typeof(QuizAppContext))]
    [Migration("20220822181803_AddAuthentication")]
    partial class AddAuthentication
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("QuizApp.Models.Country", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("country_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("QuizApp.Models.Result", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("correct_answer")
                        .HasColumnType("int");

                    b.Property<int>("selected_answer")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Result");
                });
#pragma warning restore 612, 618
        }
    }
}
