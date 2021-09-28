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
        
        private Random random;


        private Cat()
        {
            random = new Random();
        }

        public Cat(string nome, string energy, Feed feed, Mood mood) : this()
        {
            this.nome = nome;
            this.energy = energy;
            this.feed = feed;
            this.mood = mood;
        }

        public Cat(string name) : this()
        {
            this.name = name;
            this.energy = random.Next(0,101);
            this.feed = (Feed)(random.Next(0, (int)Feed.AboutToExploed + 1));
            this.mood = (Mood)(random.Next(0, (int)Mood.HyperActive + 1));
        }

        public void Meow()
        {
            Console.WriteLine("MIAU");
        }

        public void Sleep(int energiaGanha, int fomePerdeu)
        {
            energy += energiaGanha;
            mood = (Mood)(random.Next(0, (int)Mood.HyperActive + 1));

            fomePerdeu = (Feed)ganharEnum(fomePerdeu, (int)Feed.Starving, false);
        }

        public void Eat(int energiaGanha, int fomeGanha, int moodGanho)
        {
            energy += energiaGanha;

            fomeGanha = (Feed)ganharEnum(fomeGanha, (int)Feed.AboutToExploed, true);
            moodGanho = (Mood)ganharEnum(moodGanho, (int)Mood.HyperActive, true);
        }

        public void Play(int energiaLoose, int fomePerdeu)
        {
            energy -= energiaLoose;

            fomePerdeu = (Feed)ganharEnum(fomePerdeu, (int)Feed.Starving, false);
        }

        public void Print()
        {
            Console.WriteLine("Cat " + this.name);
            Console.WriteLine("Energy " + this.energy);
            Console.WriteLine("Feed " + this.feed);
            Console.WriteLine("Mood " + this.mood);
        }


        private int ganharEnum(int score, int nivel, bool add)
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

            return score;
        }

    }
}