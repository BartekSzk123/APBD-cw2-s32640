using apbd_cw2_s32640.Service;

namespace apbd_cw2_s32640;

class Program
{
    static void Main(string[] args)
    {
        var user1 = new Employee("Jan", "Mazur");
        var user2 = new Employee("Kuba", "Nowak");
        var user3 = new Employee("Sebastian", "Kibel");
        var user4 = new Student("Bartosz", "Szkola");
        
        var equipment1 = new Laptop("macbookAir", "macOS", 16);
        var equipment2 = new Laptop("macbookPro", "macOS", 32);
        var equipment3 = new Laptop("acer", "windows10", 64);

        var equipment4 = new Camera("canon", 1024, true);
        var equipment5 = new Camera("sony", 800, true);

        var equipment6 = new Projector("samsung", true, 2000);
        var equipment7 = new Projector("hisense", true, 2500);
        
        IEquipmentService eqService = new EquipmentService();
        eqService.addEquipment(equipment1);
        eqService.addEquipment(equipment2);
        eqService.addEquipment(equipment3);
        eqService.addEquipment(equipment4);
        eqService.addEquipment(equipment5);
        eqService.addEquipment(equipment6);
        eqService.addEquipment(equipment7);
        
        IRentService rentService = new RentService();
        
        rentService.CreateRent(
            user4, 
            equipment1,
            new DateTime(2026, 3, 26),
            new DateTime(2026, 3, 28));
        
        rentService.CreateRent(
            user4,
            equipment2,
            new DateTime(2026, 3, 26),
            new DateTime(2026, 3, 29));

        
        //too many rents 
        try {
            rentService.CreateRent(
                user4,
                equipment3,
                new DateTime(2026, 3, 26), 
                new DateTime(2026, 3, 29));
            
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
        }
        
        //item unavailable
        try {
            rentService.CreateRent(
                user1, 
                equipment1, 
                new DateTime(2026, 3, 27),
                new DateTime(2026, 3, 31));
            
        }catch(Exception e) {
            Console.WriteLine(e.Message);
        }


        try
        {
            rentService.RetrunRent(2,new DateTime(2026, 3, 31));
            rentService.RetrunRent(1,new DateTime(2026, 3, 27));
        }catch(Exception e) {
            Console.WriteLine(e.Message);
        }
        
        rentService.PrintReport();
    }
}
