using ConsoleAppLivres;

internal class Program
{
    public static void Main(string[] args)
    {
        Revue No1 = new Revue(45, 2023 ,"Revue Science", "Dr. Smith",500);
        Revue No2 = new Revue(32, 2022, "Revue Art", "Mme. Dupont", 250);
        Revue No3 = new Revue(12, 2021, "Revue Tech", "John Doe", 300);

        No1.afficherDetails();
        No2.afficherDetails();
        No3.afficherDetails();


        Roman N1 = new Roman("Le Grand Bleu", "Paul Martin", 200, "Aventure");
        Roman N2 = new Roman("L'Ombre du vent", "Carlos Ruiz Zafón", 200, "Drame");
        Roman N3 = new Roman("1984", "George Orwell", 195, "Dystopie");

        N1.afficherDetails();
        N2.afficherDetails();
        N3.afficherDetails();

        
        
        List<Livre> Collection = new List<Livre>();

        
        Collection.Add(new Revue(45, 2023, "Revue Science", "Dr. Smith", 500));
        Collection.Add(new Revue(32, 2022, "Revue Art", "Mme. Dupont", 250));
        Collection.Add(new Revue(12, 2021, "Revue Tech", "John Doe", 300));

        
        Collection.Add(new Roman("Le Grand Bleu", "Paul Martin", 200, "Aventure"));
        Collection.Add(new Roman("L'Ombre du vent", "Carlos Ruiz Zafón", 200, "Drame"));
        Collection.Add(new Roman("1984", "George Orwell", 195, "Dystopie"));

       
        foreach (Livre livre in Collection)
        {
            livre.afficherDetails();
            Console.WriteLine();
        }

    }
}