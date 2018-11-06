using System;
using System.Collections.Generic;
using System.Text;

namespace GunDecorations
{
    public abstract class Gun
    {
        public abstract int AmmoCapacity { get; }
        public abstract float NoiseLevel { get; }

        public void Fire()
        {
            Console.WriteLine("Ammo Size: " + AmmoCapacity);
            Console.WriteLine("Noise Size: " + NoiseLevel);
        }

        public abstract string Render();
    }
}
