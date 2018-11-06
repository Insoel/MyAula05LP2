using System;
using System.Collections.Generic;
using System.Text;

namespace GunDecorations
{
    public abstract class GunDecorator : Gun
    {

        public override int AmmoCapacity { get; }
        public override float NoiseLevel { get; }

        protected Gun gun;

        public GunDecorator(Gun gun)
        {
            this.gun = gun;
        }
    }
}
