using Meds;

List<Consume> plannedConsumes = new List<Consume>();
var choice = 1;
while (choice != 2)
{
    Console.WriteLine("Введите время приема лекарства(hh:mm):");
    var medsConsume = new Consume()
    {
        Time = Convert.ToDateTime(Console.ReadLine()),
        Medicine = new List<Pill>()
    };

    medsConsume.AddMeds();
    medsConsume.Print();
    medsConsume.PrintMedicine();
    plannedConsumes.Add(medsConsume);
    Console.WriteLine("Хотите запланировать еще? (ДА - 1, НЕТ - 2)");
    choice = Convert.ToInt32(Console.ReadLine());
}

foreach (var item in plannedConsumes)
{
    item.Print();
    item.PrintMedicine();
}