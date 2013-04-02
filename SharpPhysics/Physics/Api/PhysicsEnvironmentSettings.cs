﻿namespace SharpPhysics.Physics.Api
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PhysicsEnvironmentSettings
    {
        public float Speed { get; set; }

        public Vector Gravity { get; set; }

        public PhysicsEnvironmentSettings(float speed = 1f, float gravityX = 0, float gravityY = -9.8f)
        {
            this.Speed = speed;
            this.Gravity = new Vector(gravityX, gravityY);
        }
    }
}
