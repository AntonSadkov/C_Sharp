List<string> list = new List<string>();
list.Add("Да");
list.Add("Нет");
list.Add("Скоро");
list.Add("Нужно подождать");
list.Add("Херовая затея");
list.Add("Всё получится!!!");

Random r = new Random();
int randomNumber = r.Next(0, (list.Count));
Console.WriteLine(list[randomNumber]);