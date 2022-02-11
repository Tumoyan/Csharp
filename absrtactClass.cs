using System;
//shift+alt+f
namespace Csharp
{

    abstract class Weapon
    {
        public int Damage { get; }

        public abstract void Fire();
    }

    class Gun : Weapon
    {
        public override void Fire()
        {
            System.Console.WriteLine("Стреляю пулями");
        }
    }
    class LazerGun : Weapon
    {
        public override void Fire()
        {
            System.Console.WriteLine("Стреляю лазером");
        }
    }
    class Bow : Weapon
    {
        public override void Fire()
        {
            System.Console.WriteLine("Стреляю луком");
        }
    }

    class Player
    {
        public void Fire(Weapon weapon)
        {
            weapon.Fire();
        }
    }


    class Program
    {
        static void Main(string[] args)

        {
            Player player = new Player();
            player.Fire(new Gun());            
        }

    }
}
