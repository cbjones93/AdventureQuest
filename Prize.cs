using System;

namespace Quest
{
    public class Prize
    {
        private string _text { get; set; }

        public Prize(string text)
        {
            _text = text;
        }
        public void GimmePrize(Adventurer person)
        {
            if(person.Awesomeness > 0)
            {
                for (int i = 0; i < person.Awesomeness -1; i++){
                    Console.WriteLine($"{_text}");
                }
            }
            else {
                Console.WriteLine("YOU SUCK OMG");
            }
        }
    }
}