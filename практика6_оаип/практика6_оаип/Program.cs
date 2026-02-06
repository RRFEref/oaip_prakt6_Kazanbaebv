using System;

class Architecture
{
    public string Style { get; set; }
    public string Name { get; set; }
    public int Year { get; set; }
    public double Size { get; set; }

    public Architecture(string style, string name, int year, double size)
    {
        Style = style;
        Name = name;
        Year = year;
        Size = size;
    }
    public void GeoRespublice() //свой метод
    {
        Console.WriteLine("Республика: Татарстан"); // исправлена опечатка
    }
    public void GeoKazan() //свой метод
    {
        Console.WriteLine("Город: Казань");
    }
    public void CountFloors() // для сокрытия
    {
        Console.WriteLine("Один этаж");
    }
    public void CountApartments() // для сокрытия - исправлено на CountApartments
    {
        Console.WriteLine("несколько квартир");
    }
    public virtual void MakeBuild() //виртуальный метод
    {
        Console.WriteLine("Здание не построено");
    }

    public virtual void residents() //виртуальный метод
    {
        Console.WriteLine("Здание не заселено");
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Архитектура: {Name}, Стиль: {Style}, Год: {Year}, Размер: {Size} кв.м");
    }
}

class Museum : Architecture
{
    public string MuseumType { get; set; }
    public int ExhibitCount { get; set; }

    public Museum(string style, string name, int year, double size,
                 string museumType, int exhibitCount)
       : base(style, name, year, size)
    {
        MuseumType = museumType;
        ExhibitCount = exhibitCount;
    }

    public override void MakeBuild() //измнение вирт. метода
    {
        Console.WriteLine("Здание на реставрации");
    }

    public override void residents() //измнение вирт. метода
    {
        Console.WriteLine("Здание не для жительства");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Тип музея: {MuseumType}, Количество экспонатов: {ExhibitCount}");
    }

    public void Topic() //свой метод
    {
        Console.WriteLine("Тема: вторая мировая война");
    }
    public void TimeInterval() //свой метод
    {
        Console.WriteLine("Эпоха: XX век");
    }
    public new void CountFloors() //сокрытие
    {
        Console.WriteLine("Три этажа");
    }
    public new void CountApartments() // сокрытие
    {
        Console.WriteLine("Нет квартир");
    }
}

class Program
{
    static void Main()
    {
        Architecture architecture = new Architecture("Классицизм", "Жилой дом", 1985, 1200);
        architecture.DisplayInfo();
        architecture.GeoRespublice();
        architecture.GeoKazan();
        architecture.MakeBuild();
        architecture.residents();
        architecture.CountFloors();
        architecture.CountApartments();

        Museum museum = new Museum("Современный", "Музей Победы", 2020, 5000,
                                  "Военно-исторический", 1500);
        museum.DisplayInfo();
        museum.GeoRespublice();
        museum.GeoKazan();
        museum.MakeBuild();
        museum.residents();
        museum.CountFloors();
        museum.CountApartments();
        museum.Topic();
        museum.TimeInterval();
        Architecture myConstruction = new Museum("Барокко", "Музей искусств", 2015, 3500,
                                               "Художественный", 800);

        myConstruction.DisplayInfo();
        myConstruction.MakeBuild();
        myConstruction.residents();
        myConstruction.CountFloors();
        myConstruction.CountApartments();
        if (myConstruction is Museum castedMuseum)
        {
            castedMuseum.CountFloors(); 
            castedMuseum.CountApartments();
            castedMuseum.Topic();
            castedMuseum.TimeInterval();
        }
    }
}