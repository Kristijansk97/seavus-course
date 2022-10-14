using Microsoft.EntityFrameworkCore;
using DomainModels;

namespace DataAccess
{
    public class BurgerAppDbContext : DbContext
    {
        public BurgerAppDbContext(DbContextOptions<BurgerAppDbContext> options) : base(options)
        {
        }

        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Burger> Burgers { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<MenuItem>(x => x.ToTable("MenuItem"));
            builder.Entity<Burger>(x => x.ToTable("Burger"));
            builder.Entity<Size>(x => x.ToTable("Size"));
            builder.Entity<OrderItem>(x => x.ToTable("OrderItem"));
            builder.Entity<Order>(x => x.ToTable("Order")
            .HasMany(y => y.OrderItems)
            .WithOne(z => z.Order)
            .HasForeignKey(t => t.OrderId));

            // Seeding
            builder.Entity<Burger>().HasData(
                    new Burger("Cheeseburger", "Beef, Cheese, Onion, Tomatoes, Lettuce, Secret Bite ME! Sauce", "https://d21klxpge3tttg.cloudfront.net/wp-content/uploads/2015/07/Burger-628x373.jpg")
                    {
                        Id = 1
                    },
                    new Burger("Hamburger", "Beef, Onion, Tomatoes, Lettuce, Secret Bite ME! Sauce", "https://burgermeistermia.com/wp-content/uploads/2022/03/4-Best-Burger-Sauce-Recipes.jpg")
                    {
                        Id = 2
                    },
                    new Burger("Crispy chickenburger", "Fried Chicken, Onions, Tomatoes, , Lettuce, Secret Bite Me! Sauce", "https://www.amicella.de/fileadmin/_processed_/5/3/csm_Mr-Lavaman-Crispy-Chicken-Burger_69_Burger_Gold_2f52607b26.jpg")
                    {
                        Id = 3
                    }
                );

            builder.Entity<Size>().HasData(
                new Size("S", "10cm")
                {
                 Id = 1
                },
                new Size("M", "15cm")
                {
                    Id = 2
                },
                new Size("L", "20cm")
                {
                    Id = 3
                }
            );

            builder.Entity<MenuItem>().HasData(
                    new MenuItem(1, 1, 150)
                    {
                        Id = 1
                    },
                    new MenuItem(1, 2, 180)
                    {
                        Id = 2
                    },
                    new MenuItem(1, 3, 200)
                    {
                        Id = 3
                    },
                    new MenuItem(2, 1, 130)
                    {
                        Id = 4
                    },
                    new MenuItem(2, 2, 170)
                    {
                        Id = 5
                    },
                    new MenuItem(2, 3, 190)
                    {
                        Id = 6
                    },
                    new MenuItem(3, 1, 160)
                    {
                        Id = 7
                    },
                    new MenuItem(3, 2, 190)
                    {
                        Id = 8
                    },
                    new MenuItem(3, 3, 210)
                    {
                        Id = 9
                    }
                );
        }
    }
}
