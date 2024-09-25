
        static void WriteNewEntry(Journal journal)
        {
            string prompt = GetRandomPrompt();
            Console.WriteLine($"Prompt: {prompt}");
            Console.Write("Response: ");
            string response = Console.ReadLine();
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            Entry entry = new Entry(prompt, response, date);
            journal.AddEntry(entry);
        }

        static void DisplayJournal(Journal journal)
        {
            foreach (Entry entry in journal.Entries)
            {
                Console.WriteLine($"Prompt: {entry.Prompt}");
                Console.WriteLine($"Response: {entry.Response}");
                Console.WriteLine($"Date: {entry.Date}");
                Console.WriteLine();
            }
        }

        static void SaveJournalToFile(Journal journal)
        {
            Console.Write("Enter a filename: ");
            string filename = Console.ReadLine();
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Entry entry in journal.Entries)
                {
                    writer.WriteLine($"{entry.Prompt}|{entry.Response}|{entry.Date}");
                }
            }
        }

        static void LoadJournalFromFile(Journal journal)
        {
            Console.Write("Enter a filename: ");
            string filename = Console.ReadLine();
            journal.Entries.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    Entry entry = new Entry(parts[0], parts[1], parts[2]);
                    journal.AddEntry(entry);
                }
            }
        }

        static string GetRandomPrompt()
        {
            string[] prompts = new string[]
            {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?",
                "What did I learn today?",
                "What am I grateful for today?",
                "What did I accomplish today?"
            };
            Random random = new Random();
            return prompts[random.Next(prompts.Length)];
        }
    }

    class Journal
    {
        public List<Entry> Entries { get; set; }

        public Journal()
        {
            Entries = new List<Entry>();
        }

        public void AddEntry(Entry entry)
        {
            Entries.Add(entry);
        }
    }

    class Entry
    {
        public string Prompt { get; set; }
        public string Response { get; set; }
        public string Date { get; set; }

        public Entry(string prompt, string response, string date)
        {
            Prompt = prompt;
            Response = response;
            Date = date;
        }
    }
