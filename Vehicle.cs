using System.Numerics;
using Raylib_cs;

namespace Imperialism;

public abstract class Vehicle {
    public Vector2 Position;
    public bool Selected;

    public virtual void Draw() {}
}
