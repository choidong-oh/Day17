using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day17_1
{
    public enum MobType
    {
        Normal, Fire, Water, Grass
    }
    internal class Trainer
    {
        public int havebadge;
        public string TrainerName;
        public string StartingName;
        Monster[] TotalMonster ;
        
        public Trainer(string trainername, string monstername)
        {
            this.TrainerName = trainername; 
            this.StartingName = monstername;
            TotalMonster = new Monster[6];
        }

        public Trainer(Monster monster)
        {
            TotalMonster = new Monster[6];

            TotalMonster[0] = monster;


        }
        public void ShowFirstMob()
        {
            Console.WriteLine(TotalMonster[0].MonsterLevel);
            Console.WriteLine(TotalMonster[0].MonsterName);
        }

        public string ChangeMonster(string changemonster)
        {
            this.StartingName = changemonster;

            return StartingName;
        }

    }
}
