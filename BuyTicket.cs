// Функція для купівлі квитка
    static void BuyTicket()
    {
        Console.WriteLine("Доступні фільми:");
        for (int i = 0; i < availableMovies.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {availableMovies[i]}");
        }

        Console.Write("Виберіть номер фільму: ");
        int movieIndex = Convert.ToInt32(Console.ReadLine()) - 1;

        if (movieIndex < 0 || movieIndex >= availableMovies.Count)
        {
            Console.WriteLine("Неправильний вибір фільму.");
            return;
        }

        string selectedMovie = availableMovies[movieIndex];

        // Перевірка, чи існує вже запис для обраного фільму в словнику bookedTickets
        if (!bookedTickets.ContainsKey(selectedMovie))
        {
            // Якщо запису немає, створюємо новий запис
            bookedTickets[selectedMovie] = new Dictionary<string, List<Tuple<string, string, int>>>();
        }
