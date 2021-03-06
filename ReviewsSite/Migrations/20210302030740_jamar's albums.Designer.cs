// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReviewsSite;

namespace ReviewsSite.Migrations
{
    [DbContext(typeof(RecordStoreContext))]
    [Migration("20210302030740_jamar's albums")]
    partial class jamarsalbums
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ReviewsSite.Models.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BandName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SongsString")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BandName = "Metallica",
                            Description = "Is the fifth studio album by American heavy metal band Metallica, released on August 12, 1991 through Elektra Records.It was recorded in an eight - month span at One on One Recording Studios in Los Angeles.",
                            Image = "Images/Metallica-Black-Album.jpg",
                            Name = "The Black Album",
                            SongsString = "Enter Sandman, Sad But True, Holier Than Thou, The Unforgiven, Wherever I May Roam, Don't Tread on Me, Through the Never, Nothing Else Matters, Of Wolf and Man, The God That Failed, My Friend of Misery, The Struggle Within"
                        },
                        new
                        {
                            Id = 2,
                            BandName = "Kid Cudi",
                            Description = "Is the seventh studio album by American rapper Kid Cudi. It was released on December 11, 2020 by Republic Records. It is the final installment of Cudi's Man on the Moon trilogy of albums.",
                            Image = "Images/Man_on_the_Moon_III.jpg",
                            Name = "Man on the Moon 3",
                            SongsString = "Beautiful Trip, Tequila Shots, Another Day, She Knows This, Dive, Damaged, Heaven On Earth, Show Out, Solo Dolo, Pt. III, Sad People, Elsie's Baby Boy (flashback), Sept. 16, The Void, Lovin' Me, The Pale Moonlight, Rockstar Knights, 4 Da Kidz, Lord I Know"
                        },
                        new
                        {
                            Id = 3,
                            BandName = "Biggie Smalls",
                            Description = "Ready to Die is the debut studio album by American rapper The Notorious B.I.G., released on September 13, 1994, by Bad Boy Records and Arista Records. The album features productions by Yung Chedder (James Ryan), Bad Boy founder Sean Puffy Combs, Easy Mo Bee, Chucky Thompson, DJ Premier, and Lord Finesse, among others. It was recorded from 1993 to 1994 at The Hit Factory and D&D Studios in New York City",
                            Image = "Images/2nd album.jpg",
                            Name = "Ready To Die",
                            SongsString = "Intro, The What, Unbelievable, Things Done Changed, Juicy, One more chance, Warning, Everyday Struggle, Respect, Suicidal Thoughts, Friend of Me, Gimme the Loot, Machine Gun Funk,Ready To Die, Me & My Bitch, Big Poppa, F*ck Me, Just Playing, Who Shot Ya, Warning, Friend of Mine "
                        });
                });

            modelBuilder.Entity("ReviewsSite.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("ReviewerName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AlbumId = 1,
                            Content = "Man this Album blew my mind",
                            Rating = 2,
                            ReviewerName = "AL Might"
                        },
                        new
                        {
                            Id = 2,
                            AlbumId = 2,
                            Content = "Man this is the best version of Cudi",
                            Rating = 2,
                            ReviewerName = "Mob"
                        },
                        new
                        {
                            Id = 3,
                            AlbumId = 3,
                            Content = "Best of its time",
                            Rating = 5,
                            ReviewerName = "Karen"
                        });
                });

            modelBuilder.Entity("ReviewsSite.Models.Review", b =>
                {
                    b.HasOne("ReviewsSite.Models.Album", "Album")
                        .WithMany("Review")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");
                });

            modelBuilder.Entity("ReviewsSite.Models.Album", b =>
                {
                    b.Navigation("Review");
                });
#pragma warning restore 612, 618
        }
    }
}
