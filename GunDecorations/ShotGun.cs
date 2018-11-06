using System;
using System.Collections.Generic;
using System.Text;

namespace GunDecorations
{
    public class ShotGun : Gun
    {
        public override int AmmoCapacity { get; }
        public override float NoiseLevel { get; }

        public override string Render()
        {
            return $"shotgun";
        }
    }
}
