using Task_12_1_5;



var users = new List<User>()
{
    new User() { Login  = "one", Name = "User1", IsPremium = true },
    new User() { Login = "two", Name = "User2", IsPremium= false },
    new User(){Login = "three", Name = "User3", IsPremium=true },
    new User(){Login = "four", Name = "User4", IsPremium=false },
};

foreach (var user in users)
{
    if (!user.IsPremium)
    {
        Console.WriteLine($"Мы подобрали для Вас, {user.Name}, рекламу:");
        Console.WriteLine();
        ShowAds();
    }
}

static void ShowAds()
{
    Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
    // Остановка на 1 с
    Thread.Sleep(1000);

    Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
    // Остановка на 2 с
    Thread.Sleep(2000);

    Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
    // Остановка на 3 с
    Thread.Sleep(3000);
    Console.Clear();
}

Console.ReadKey();

