using Domain.ContractChoice;
using Domain.Entities;
using Domain.Entities.Archivievum;
using Domain.User;
using Microsoft.EntityFrameworkCore;
//using System.Data.Entity;

namespace ConnectionProvider.Context
{
    public class AppDbСontext : DbContext
    {
        public AppDbСontext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<StructuralSubdivision> StructuralSubdivisions { get; set; }
        public DbSet<TrustieFoundation> TrustieFoundations { get; set; }
        public DbSet<Citizenship> Citizenships { get; set; }
        public DbSet<PassportType> PassportTypes { get; set; }
        public DbSet<AgreementConcluder> AgreementConcluders { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<PaymentOrder> PaymentOrders { get; set; }
        public DbSet<PartialPaymentOrder> PartialPaymentOrderNames { get; set; }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<RendedServicesVariations> RendedServicesVariations { get; set; }
        public DbSet<AgreementEntity> AgreementEntities { get; set; }
        public DbSet<ActVariationsOfCompletion> ActVariationsOfCompletions { get; set; }
        public DbSet<Archive> Archives { get; set; }
        public DbSet<UserCode> UserCodes { get; set; }
        public DbSet<PaymentTerm> PaymentTerms { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Role>().HasData(new Role { Id = 1, RoleName = "User"},
                                           new Role { Id = 2, RoleName = "Editor"},
                                           new Role { Id = 3, RoleName = "Admin"});
            
            builder.Entity<City>().HasData(new City { Id = 1, CityName = "г. Душанбе" }); 
           
            builder.Entity<StructuralSubdivision>().HasData(new StructuralSubdivision { Id = 1, SubdivisionName = "Филиали Ҷамъияти саҳомии кушодаи..." });  
            
            builder.Entity<Citizenship>().HasData(new Citizenship { Id = 1, CitizenshipName = "Шахрванди Чумхурии Точикистон" });  
            
            builder.Entity<TrustieFoundation>().HasData(new TrustieFoundation { Id = 1, FoundationName = "Доверенность" }, 
                                                        new TrustieFoundation { Id = 2, FoundationName = "Устав"}); 
            
            builder.Entity<PassportType>().HasData(new PassportType { Id = 1, PassportTypeName = "Шиноснома" }); 
            
            builder.Entity<AgreementConcluder>().HasData(new AgreementConcluder { Id = 1, ConcluderName = "Договор заключает головной офис" }, 
                                                         new AgreementConcluder { Id = 2, ConcluderName = "Договор заключает филиал Банка в г. Душанбе" }, 
                                                         new AgreementConcluder { Id = 3, ConcluderName = "Договор заключает филиал Банка в г. Худжанде" });
            
            builder.Entity<AgreementEntity>().HasData(new AgreementEntity { Id = 1, EntityName = "Юридическое лицо" }, 
                                                      new AgreementEntity { Id = 2, EntityName = "Индивидуальный предприниматель" }, 
                                                      new AgreementEntity { Id = 3, EntityName = "Физическое лицо" });
            
            builder.Entity<Services>().HasData(new Services { Id = 1, ServiceName = "Услуга указывается в самом договоре" }, 
                                               new Services {  Id = 2, ServiceName = "Услуга указывается в приложении к Договору" });
            
            
            builder.Entity<Agent>().HasData(new Agent { Id = 1, AgentLocation = "Aгент находится в Душанбе " }, 
                                            new Agent { Id = 2, AgentLocation = "Агент находится в Худжанде" });
            
            builder.Entity<ActVariationsOfCompletion>().HasData(new ActVariationsOfCompletion { Id = 1, Variation = "Качество оказанных Услуг соответствует предъявленным требованиям" }, 
                                                                new ActVariationsOfCompletion { Id = 2, Variation = "В результате осмотра результата оказанных Услуг недостатки не выявлены" },
                                                                new ActVariationsOfCompletion { Id = 3, Variation = "В результате осмотра выявлены следующие недостатки" });
            
            builder.Entity<RendedServicesVariations>().HasData(new RendedServicesVariations { Id = 1, RendedServiceName = "Головной - улица Багауддинова" },
                                                               new RendedServicesVariations { Id = 2, RendedServiceName = "Филиал в Душанбе - улица Ниёзи" },
                                                               new RendedServicesVariations { Id = 3, RendedServiceName = "Филиал в Худжанде - улицу не помню" });
            
            builder.Entity<PaymentTerm>().HasData(new PaymentTerm { Id = 1, TermText = "Агар дар гуфтушунидҳо ба ҳамфикрӣ ноил нашаванд, баҳс бояд дар суди иқтисодии ш. Душанбе аз рӯи маҳалли воқеъ гардидани Исполнитель баррасӣ карда шавад." },
                                                  new PaymentTerm { Id = 2, TermText = "Агар дар гуфтушунидҳо ба ҳамфикрӣ ноил нашаванд, баҳс бояд дар суди иқтисодии ш. Хучанд аз рӯи маҳалли воқеъ гардидани Исполнитель баррасӣ карда шавад." },
                                                  new PaymentTerm { Id = 3, TermText = "Агар дар гуфтушунидҳо ба ҳамфикрӣ ноил нашаванд, баҳс бояд дар суди ш. Душанбе аз рӯи маҳалли воқеъ гардидани Исполнитель баррасӣ карда шавад." },
                                                  new PaymentTerm { Id = 4, TermText = "Агар дар гуфтушунидҳо ба ҳамфикрӣ ноил нашаванд, баҳс бояд дар суди ш. Хучанд аз рӯи маҳалли воқеъ гардидани Исполнитель баррасӣ карда шавад." });


            builder.Entity<PaymentOrder>().HasData(new PaymentOrder { Id = 1, PaymentOrderName = "Налично" },
                                                   new PaymentOrder { Id = 2, PaymentOrderName = "Безналично" });

            builder.Entity<PartialPaymentOrder>().HasData(new PartialPaymentOrder { Id = 1, PartialPaymentName = "Первый платеж в сомони" },
                                                          new PartialPaymentOrder { Id = 2, PartialPaymentName = "Первый платеж в процентах" },
                                                          new PartialPaymentOrder { Id = 3, PartialPaymentName = "Второй платеж в сомони" },
                                                          new PartialPaymentOrder { Id = 4, PartialPaymentName = "Второй платеж в процентах" });

        } 
    }
}
   