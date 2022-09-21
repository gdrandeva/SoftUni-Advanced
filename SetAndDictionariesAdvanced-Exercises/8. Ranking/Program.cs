using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();

            SortedList<string, Dictionary<string, int>> candidates = new SortedList<string, Dictionary<string, int>>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command=="end of contests")
                {
                    break;
                }
                string[] credentials = command.Split(":",StringSplitOptions.RemoveEmptyEntries);
                contests.Add(credentials[0], credentials[1]);


            }
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end of submissions")
                {
                    break;
                }

                string[] tokens = command.Split("=>",StringSplitOptions.RemoveEmptyEntries);

                string contest = tokens[0];
                string password = tokens[1];
                string candidate = tokens[2];
                int points = int.Parse(tokens[3]);

                if (contests.ContainsKey(contest) && contests[contest]==password)
                {
                    UpsertCandidate(candidate, points, contest, candidates);
                }

                string bestCandidate = candidates.OrderByDescending(c => c.Value.Values.Sum())
                    .First().Key;

                int bestCandidateTotalPoints = candidates[bestCandidate].Values.Sum();

                Console.WriteLine($"Best candidate is {bestCandidate} with total {bestCandidateTotalPoints} points.");

                Console.WriteLine("Ranking:");

                foreach (var candidate in candidates)
                {
                    var orderByPointsDesc = candidate.Value.OrderByDescending(c =>c.Value);
                    Console.WriteLine(candidate.Key);

                    foreach (var contest in orderByPointsDesc)
                    {
                        Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                    }
                }

            }
        }

         static void UpsertCandidate(string candidate, int points, string contest, SortedList<string, Dictionary<string, int>> candidates)
        {
            if (!candidates.ContainsKey(candidate))
            {
                candidates[candidate] = new Dictionary<string, int>();

            }
            if (!candidates[candidate].ContainsKey(contest))
            {
                candidates[candidate][contest] = 0;
            }

            if (candidates[candidate][contest]<points)
            {
                candidates[candidate][contest] = points;
            }
        }
    }
}
