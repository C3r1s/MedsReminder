namespace Meds;

public class Consume
{
    public DateTime Time { get; init; }
    public List<Pill>? Medicine { get; init; }

    public void Print()
    {
        Console.WriteLine($"Время приема лекарства: {Time.Hour}:{Time.Minute} \n Лекарства для приема:");
    }

    public void PrintMedicine()
    {
        foreach (var item in Medicine)
        {
            Console.WriteLine($"{item.Name} - {item.Dosage} мг");
        }
    }

    public void AddMeds()
    {
        int choice = 1;
        while (choice != 2)
        {
            var pill = new Pill();
            Console.WriteLine("Введите имя лекарства:");
            pill.Name = Console.ReadLine();
            Console.WriteLine("Введите дозировку (в мг) лекарства:");
            pill.Dosage = Convert.ToInt32(Console.ReadLine());
            Medicine.Add(pill);
            Console.WriteLine("Хотите добавить еще? (ДА - 1, НЕТ - 2)");
            choice = Convert.ToInt32(Console.ReadLine());
        }
    }
}