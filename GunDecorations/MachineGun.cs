using System;
using System.Collections.Generic;
using System.Text;

namespace GunDecorations
{
    public class MachineGun : Gun
    {
        public override int AmmoCapacity { get; }
        public override float NoiseLevel { get; }

        public override string Render()
        {
            return "hello";
        }
    }
}
