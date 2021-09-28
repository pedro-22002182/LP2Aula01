using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CuteAnimal
{
    public class Cat
    {
        private readonly string name;
        private int energy;
        private Mood mood;
        private Feed feed;
        

        public void Meow()
        {
            Console.WriteLine("MIAU");
        }

        public void Sleep(int energiaGanha, int fomePerdeu)
        {
            energy += energiaGanha;
            mood = Random.Range(0, 4);

            ganharEnum(fomePerdeu, Feed.Starving, false);
        }

        public void Eat(int energiaGanha, int fomeGanha, int moodGanho)
        {
            energy += energiaGanha;

            ganharEnum(fomeGanha, Feed.AboutToExploed, true);
            ganharEnum(moodGanho, Mood.HyperActive, true);
        }

        public void Play(int energiaLoose, int fomePerdeu)
        {
            energy -= energiaLoose;

            ganharEnum(fomePerdeu, Feed.Starving, false);
        }


        private void ganharEnum(int score, int nivel, bool add)
        {
            for(int i = 0; i < score; i++)
            {
                if(score != nivel)
                {
                    if(add)
                        score += 1;
                    else
                        score -= 1;
                }
            }
        }

    }
}