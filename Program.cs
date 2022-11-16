using System.Security.Cryptography;
using System.Xml.Linq;

EcommerceDbContext db = new EcommerceDbContext();
Console.WriteLine("E-COMMERCE - BETTER FOOD");
CheckBeforeStartApplication();

Console.WriteLine("Sei un Cliente o un Dipendente \n1.Cliente 2. Dipendete");
int Response = Convert.ToInt32(Console.ReadLine());

bool mainLoop = true;
switch (Response)
{
    case 1:
        while (mainLoop)
        {
            stampaProdotti();
            Console.WriteLine("per selezionare più prodotti scrivere ES(prodotto1,prodotto2....)");
            Console.WriteLine("1. Seleziona un prodotto");
            string[] Prodotto = Console.ReadLine().Split(',');
        }
        break;
    case 2:
        while (mainLoop)
        {

        }
        break;
    default:
        break;
}

// CONTROLLI PRINCIPALI CHE EFFETTUO PRIMA DELL'AVVIO DEL PROGRAMMA
void CheckBeforeStartApplication()
{ 
    // Controllo che la tabella Customers e Employees e Product non abbia nessun record, se non ci sono record allora li aggiungo altrimenti non faccio niente
    bool CheckCustomer = db.Customers.Any();
    bool CheckEmployee = db.Employees.Any();
    bool CheckProduct = db.Products.Any();

    if (CheckCustomer)
    {
        Console.WriteLine("Avvio del programma....");
        Console.Clear();
    }
    else
    {
        Customer marco = new Customer() { Name = "Marco", Surname = "Mistretta", Email = "marco@email.it" };
        Customer lorenzo = new Customer() { Name = "Lorenzo", Surname = "Veropalumbo", Email = "lorenzo@email.it" };
        Customer luca = new Customer() { Name = "Luca", Surname = "Sergio", Email = "luca@email.it" };

        db.Customers.Add(lorenzo);
        db.Customers.Add(marco);
        db.Customers.Add(luca);

        db.SaveChanges();
    }

    if (CheckEmployee)
    {
        Console.WriteLine("Avvio del programma....");
        Console.Clear();
    }
    else
    {
        Employee paolo = new Employee() { Name = "Paolo", Surname = "Rossi", Level = "Dipendente" };
        Employee nicola = new Employee() { Name = "Nicola", Surname = "Sannino", Level = "Dipendente" };
        Employee riccardo = new Employee() { Name = "Riccardo", Surname = "Binotto", Level = "Dipendente" };

        db.Employees.Add(paolo);
        db.Employees.Add(nicola);
        db.Employees.Add(riccardo);

        db.SaveChanges();
    }

    if (CheckProduct)
    {
        Console.WriteLine("Benvenuto nel nostro shop cosa vuoi mangiare?");
        Console.WriteLine();
    }
    else
    {
        Product bigMac = new Product() { Name = "Big Mac® Menu", description = "Il nostro buonissimo big mac da oggi anche con pollo", Price = 14.99f};
        Product mySelection = new Product() { Name = "My Selection BBQ Menu", description = "Il nostro buonissimo big mac da oggi anche con pollo", Price = 7.99f };
        Product crispyMcBacon = new Product() { Name = "Crispy McBacon® Menu", description = "Il nostro buonissimo big mac da oggi anche con pollo", Price = 18.99f };
        Product falaffel = new Product() { Name = "Falaffel", description = "Falaffel", Price = 2f };
        Product brezel = new Product() { Name = "Brezel", description = "Brezel", Price = 1.25f };
        Product kingKebab = new Product() { Name = "kingKebab", description = "kingKebab solo per i veri pro", Price = 25.99f };
        Product menuInsalataMista = new Product() { Name = "menuInsalataMista", description = "lo magiano le capre e i vegani", Price = 0.10f };
        Product Pizza = new Product() { Name = "Margherita", description = "Margherita consegnata ovunque tu sia fatta a Napoli", Price = 4.99f };
        Product Poke = new Product() { Name = "Poke", description = "Poke", Price = 9.99f };
        Product Aria = new Product() { Name = "Aria", description = "Aria", Price = 0f };

        db.Products.Add(bigMac);
        db.Products.Add(mySelection);
        db.Products.Add(crispyMcBacon);
        db.Products.Add(falaffel);
        db.Products.Add(kingKebab);
        db.Products.Add(brezel);
        db.Products.Add(menuInsalataMista);
        db.Products.Add(Poke);
        db.Products.Add(Pizza);
        db.Products.Add(Aria);

        db.SaveChanges();

        Console.WriteLine("Benvenuto nel nostro shop cosa vuoi mangiare?");
        Console.WriteLine();
    }
}

void stampaProdotti()
{
    List<Product> products = db.Products.ToList<Product>();
    int i = 0;
    foreach (Product product in products)
    {
        Console.WriteLine(++i + " - " + product.Name + " - " + product.description + " - " + product.Price + " $");
    }
}

void CreazioneOrdine()
{
    Console.WriteLine("inserisci il tuo id");
    int id = Convert.ToInt32(Console.ReadLine());
    Customer marco = db.Customers.Where(x => x.Email == ).first();

}