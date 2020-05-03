using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZeroDengue.Models;

namespace ZeroDengue.Data
{
    public class SeedingService
    {
        private ZeroDengueContext _context;

        public SeedingService(ZeroDengueContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.User.Any() ||
                _context.Complaint.Any())
            {
                return; // O banco de dados já foi populado
            }

            Address a1 = new Address(1, "Rua Jardim Silva", "27941250", 45, "Caiana", "Minas Gerais");
            Address a2 = new Address(2, "Rua Jardim Vitória", "27841250", 1520, "Catuti", "Minas Gerais");
            Address a3 = new Address(3, "Av Jardim Silva", "27952340", 9, "Dionisio", "Vitória");
            Address a4 = new Address(4, "Av Jardim Silva", "28051250", 4580, "Divino das Laranjeiras", "Vitória");
            Address a5 = new Address(5, "Al Jardim Vitória", "21111250", 3060, "Igarape", "São Paulo");
            Address a6 = new Address(6, "Al Jardim Silva", "27941645", 165, "Inhapim", "São Paulo");
            Address a7 = new Address(7, "Rua Jardim Silva", "27949535", 321, "Ibiai", "Amapá");
            Address a8 = new Address(8, "Rua Jardim Silva", "27946678", 456, "Itambacuri", "Amapá");
            Address a9 = new Address(9, "Av Jardim Silva", "27945439", 78, "Frei Gaspar", "Acre");
            Address a10 = new Address(10, "Av Jardim Silva", "27947898", 25, "Ervalia", "Acre");

            User u1 = new User(1, "Carlos Green", "carlos@gmail.com", "1234567", "98765432103", "21998653241", a10);
            User u2 = new User(2, "Brenda Brown", "brenda@gmail.com", "1234567", "21123456789", "44998653241", a9);
            User u3 = new User(3, "Maria Pink", "maria@gmail.com", "1234567", "22987654321", "73998653241", a8);
            User u4 = new User(4, "Jean Grey", "jean@gmail.com", "1234567", "24123456789", "68998653241", a7);
            User u5 = new User(5, "Alex Red", "alex@gmail.com", "1234567", "31765432103", "32998653241", a6);
            User u6 = new User(6, "Jorge Caldas", "jorge@gmail.com", "1234567", "32123456789", "11998653241", a5);
            User u7 = new User(7, "Cléber Yellow", "cleber@gmail.com", "1234567", "66765432103", "51998653241", a4);
            User u8 = new User(8, "Pedro Bentas", "pedro@gmail.com", "1234567", "68123456789", "22998653241", a3);
            User u9 = new User(9, "Carlos Amado", "amado@gmail.com", "1234567", "73765432103", "42998653241", a2);
            User u10 = new User(10, "Téo Green", "teo@gmail.com", "1234567", "73123456789", "31998653241", a1);

            Complaint c1 = new Complaint(1, 0001, "https://www.folhaonline.es/wp-content/uploads/2015/12/Possivel_Foco05.jpg", "Aqui tem muita caixa d'água assim", a5, Models.Enums.StatusComplaint.Registrado, u6);
            Complaint c2 = new Complaint(2, 0002, "https://www.portal27.com.br/wp-content/uploads/2013/03/2013-03-04-16.26.29.jpg", "Aqui tem muita água parada assim", a9, Models.Enums.StatusComplaint.Cancelado, u2);
            Complaint c3 = new Complaint(3, 0003, "https://dynhb2kccft5e.cloudfront.net/uploads/noticias/lg-ecec05ad-16d2-4229-8a67-d4d19ef91221.jpg", "Aqui tem muita pneu assim", a6, Models.Enums.StatusComplaint.Registrado, u5);
            Complaint c4 = new Complaint(4, 0004, "https://www.jornaldecorupa.com.br/wp-content/uploads/2019/12/465830.jpeg", "Aqui tem muito vaso de planta assim", a4, Models.Enums.StatusComplaint.Registrado, u7);
            Complaint c5 = new Complaint(5, 0005, "https://static5.vvale.com.br/wp-content/uploads/2014/05/Dengue-01.jpg", "Aqui tem muito entulho assim", a5, Models.Enums.StatusComplaint.Pendente, u3);
            Complaint c6 = new Complaint(6, 0006, "https://s03.video.glbimg.com/x720/6880370.jpg", "Aqui tem muita piscina assim", a1, Models.Enums.StatusComplaint.Registrado, u10);

            _context.User.AddRange(u1, u2, u3, u4, u5, u6, u7, u8, u9, u10);
            _context.Complaint.AddRange(c1, c2, c3, c4, c5, c6);

            _context.SaveChanges();
        }
    }
}
