using System;
using System.Collections.Generic;

// Every class in the program is defined within the "Quest" namespace
// Classes within the same namespace refer to one another without a "using" statement
namespace Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            static void AdventureQuest()
            {

                // Create a few challenges for our Adventurer's quest
                // The "Challenge" Constructor takes three arguments
                //   the text of the challenge
                //   a correct answer
                //   a number of awesome points to gain or lose depending on the success of the challenge
                Challenge twoPlusTwo = new Challenge("2 + 2?", 4, 10);
                Challenge theAnswer = new Challenge(
                    "What's the answer to life, the universe and everything?", 42, 25);
                Challenge whatSecond = new Challenge(
                    @"Which US state has the longest cave system in the world?
                    1) Tennessee
                    2) Kentucky
                    3) Nevada
                    4) North Dakota
                    ", 2, 20);

                // int randomNumber = new Random().Next() % 10;
                Challenge guessRandom = new Challenge(@"What country has the most vending machines per capita?  
                1) United States
                2) England
                3) China
                4) Japan
                "
                 ,4, 25);

                Challenge favoriteBeatle = new Challenge(
                    @"What is Proessor X's real name?
                1) Charles Xavier
                2) Scott Summers
                3) Erik Lehnsherr
                4) James Howelett
",
                    1, 20
                );
                Challenge aragorn = new Challenge(@"What character in the Lord of the Rings initially goes by the name 'Strider'?
                1) Frodo
                2) Aragorn
                3) Legolas
                4) Elrond
                  ", 2, 20);
                Challenge sting = new Challenge(@"What is the name of Frodo's sword?
                1) Glamdring
                2) Anduril
                3) Sting
                4) Excalibur
                  ", 3, 20);

                // "Awesomeness" is like our Adventurer's current "score"
                // A higher Awesomeness is better

                // Here we set some reasonable min and max values.
                //  If an Adventurer has an Awesomeness greater than the max, they are truly awesome
                //  If an Adventurer has an Awesomeness less than the min, they are terrible
                int minAwesomeness = 0;
                int maxAwesomeness = 100;

                Robe newRobe = new Robe();
                {
                    newRobe.RobeLength = 5;
                    newRobe.AddRobeColor("blue");
                    Console.Write(" ");
                    newRobe.AddRobeColor("with cute lil sparkles");
                    Console.Write(" ");
                    newRobe.AddRobeColor("that glistens in the sunlight");

                };
                Hat newHat = new Hat();
                {
                    newHat.ShininessLevel = 5;
                }
                Prize bigPrize = new Prize("A Death Star!!!(use it wisely)");

                // Make a new "Adventurer" object using the "Adventurer" class
                Console.WriteLine("What is your name?> ");
                string name = Console.ReadLine();
                Adventurer theAdventurer = new Adventurer(name, newRobe, newHat);
                theAdventurer.GetDescription();


                // A list of challenges for the Adventurer to complete
                // Note we can use the List class here because have the line "using System.Collections.Generic;" at the top of the file.
                List<Challenge> challenges = new List<Challenge>()
            {
                twoPlusTwo,
                theAnswer,
                whatSecond,
                guessRandom,
                favoriteBeatle,
                sting,
                aragorn
            };

                // Loop through all the challenges and subject the Adventurer to them
                Random i = new Random();
                List<int> indexes = new List<int> {};
                while(indexes.Count <5)
                {
                    int candidate = i.Next(0, challenges.Count);
                    if(!indexes.Contains(candidate)){
                        indexes.Add(candidate);
                    }
                }

                for(int x=0; x <indexes.Count; x++)
                {
                    int index = indexes[x];
                    challenges[index].RunChallenge(theAdventurer);
                }
                // foreach (Challenge challenge in challenges)
                // {
                //     challenge.RunChallenge(theAdventurer);
                // }

                // This code examines how Awesome the Adventurer is after completing the challenges
                // And praises or humiliates them accordingly
                if (theAdventurer.Awesomeness >= maxAwesomeness)
                {
                    Console.WriteLine("YOU DID IT! You are truly awesome!");
                }
                else if (theAdventurer.Awesomeness <= minAwesomeness)
                {
                    Console.WriteLine("Get out of my sight. Your lack of awesomeness offends me!");
                }
                else
                {
                    Console.WriteLine("I guess you did...ok? ...sorta. Still, you should get out of my sight.");
                }
                bigPrize.GimmePrize(theAdventurer);
                Console.WriteLine($"You have completed {theAdventurer.Correct} challenges!");
                theAdventurer.Awesomeness = 50 + theAdventurer.Correct * 10;
                Console.WriteLine("Would you like to try again? (Yes/No)");
                string playAgain = Console.ReadLine().ToLower();
                if (playAgain == "yes")
                {
                    AdventureQuest();
                }
                else
                {
                    Console.WriteLine();
                }

            }
            AdventureQuest();
        }
    }
}
