﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HungerGamesProjectV2.Components.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HungerGamesEntities : DbContext
    {
        public HungerGamesEntities()
            : base("name=HungerGamesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<History_Votes> History_Votes { get; set; }
        public virtual DbSet<Hunger_Events> Hunger_Events { get; set; }
        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<Loc_Player> Loc_Player { get; set; }
        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<Player_Items_Inventory> Player_Items_Inventory { get; set; }
        public virtual DbSet<Players> Players { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Viewers> Viewers { get; set; }
        public virtual DbSet<Votes> Votes { get; set; }
    }
}
