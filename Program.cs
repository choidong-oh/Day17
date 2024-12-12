using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day17_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Monster monster = new Monster(MobType.Fire,3,"유니콘");
            Trainer trainer = new Trainer(monster);
            trainer.ShowFirstMob();

        }
    }
}
