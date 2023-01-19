using System;
using System.Collections.Generic; // för att använda List-klassen

class Blog
{
    // skapa en lista för att lagra inlägg
    private List<string[]> posts = new List<string[]>();

    // metod för att visa menyvalen
    public void ShowMenu()
    {
        while (true)
        {
            // visa menyvalen
            Console.WriteLine("Välj ett av följande alternativ:");
            Console.WriteLine("1. Skriv ut inlägg");
            Console.WriteLine("2. Lägg till inlägg");
            Console.WriteLine("3. Sök inlägg");
            Console.WriteLine("4. Avsluta programmet");

            // få input från användaren
            int choice = 0;
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Vänligen välj ett giltigt menyval.");
            }
            switch (choice)
            {
                case 1:
                    // skriv ut alla inlägg
                    PrintPosts();
                    break;
                case 2:
                    // lägg till nytt inlägg
                    AddPost();
                    break;
                case 3:
                    // sök inlägg
                    SearchPosts();
                    break;
                case 4:
                    // avsluta programmet
                    return;
                default:
                    // visa felmeddelande om input inte är giltigt
                    Console.WriteLine("Vänligen välj ett giltigt menyval.");
                    break;
            }
        }
    }

    // metod för att skriva ut alla inlägg
    private void PrintPosts()
    {
        if (posts.Count == 0)
        {
            Console.WriteLine("Inga inlägg att visa.");
        }
        else
        {
            for (int i = 0; i < posts.Count; i++)
            {
                // posts[i][0] är titeln, posts[i][1] är meddelandet
                Console.WriteLine("Inlägg " + (i + 1) + ": " + posts[i][0]);
                Console.WriteLine(posts[i][1]);
                Console.WriteLine();
            }
        }
    }

    // metod för att lägga till nytt inlägg
    private void AddPost()
    {
        Console.WriteLine("Skriv titel för inlägg:");
        string title = Console.ReadLine();

        Console.WriteLine("Skriv innehåll för inlägg:");
        string message = Console.ReadLine();

        // lägg till inlägget i listan
        posts.Add(new string[] { title, message });
    }

    // met
