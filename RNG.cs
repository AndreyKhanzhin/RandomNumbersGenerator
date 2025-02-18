Console.WriteLine("Программа сгенерирует случайное число от 1 до 100. У вас есть 5 попыток, чтобы его угадать.");
Random rnd = new Random();
int rand = rnd.Next(1, 100);
Console.WriteLine("Число загадано.");
int Try = 0;
while (Try < 5){
    string count = Console.ReadLine();
    if (!int.TryParse(count, out int number)){
        Console.WriteLine("Введите ЧИСЛО.");
    }
    else if (number != rand){
        Console.WriteLine("Неправильно.");
        Try++;
    }
    else{
        Console.WriteLine("Поздравляем, вы угадали.");
        break;
    }
}