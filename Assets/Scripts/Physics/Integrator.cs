using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Integrator
{
    public static void ExplicitEuler(Body body, float dt)
    {
        body.pos += body.vel * dt;
        body.vel += body.acc * dt;
    }

    public static void SemiImplicitEuler(Body body, float dt)
    {
        body.vel += body.acc * dt;
        body.pos += body.vel * dt;
    }
}
