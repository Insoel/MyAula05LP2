using System;

namespace GunDecorations
{
    class Program
    {
        static void Main(string[] args)
        {
            Gun shotGun = new GunClip(new ShotGun());
            Gun machineGun = new GunClip(new MachineGun());

            shotGun.Fire();
            Console.WriteLine(shotGun.Render());

            machineGun.Fire();
            Console.WriteLine(machineGun.Render());

        }
    }
}
