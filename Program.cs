using DataAccess;

namespace M6P1;

internal class Program
{
    static void Main(string[] args)
    {
        using ApplicationContext context = new ApplicationContext();
        context.Commands.Add(new Entities.FC() { Name = "Real", City = "Madrid", Win = 12, Lose = 1, Draw = 2, GoalsScored = 33, GoalsConceded = 9 });
        context.Commands.Add(new Entities.FC() { Name = "Gerona", City = "Girona", Win = 12, Lose = 1, Draw = 2, GoalsScored = 34, GoalsConceded = 18 });
        context.Commands.Add(new Entities.FC() { Name = "Barcelona", City = "Barcelona", Win = 10, Lose = 1, Draw = 4, GoalsScored = 28, GoalsConceded = 14 });
        context.Commands.Add(new Entities.FC() { Name = "Atletico M", City = "Madrid", Win = 10, Lose = 3, Draw = 1, GoalsScored = 30, GoalsConceded = 13 });
        context.Commands.Add(new Entities.FC() { Name = "Athletic B", City = "Bilbao", Win = 8, Lose = 3, Draw = 4, GoalsScored = 30, GoalsConceded = 18 });
        context.SaveChanges();
        List<Entities.FC> fCs = context.Commands.ToList();
        Console.WriteLine("{0,-15} {1,-10} {2,-15} {3,-15} {4,-15} {5,-15} {6,-15}", "Command", "City", "Win", "Draw", "Lose", "GoalsScored", "GoalsConceded");
        Console.WriteLine();
        foreach (Entities.FC f in fCs)
        {
            Console.WriteLine("{0,-15} {1,-10} {2,-15} {3,-15} {4,-15} {5,-15} {6,-15}", f.Name, f.City, f.Win, f.Draw, f.Lose, f.GoalsScored, f.GoalsConceded);
        }

    }
}
