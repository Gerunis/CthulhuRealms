using System;
using System.Collections.Generic;
using System.Text;

namespace CthulhuRealms
{
    class Attribute
    {
        Condition Condition { get; }
        bool Discard { get; }
        bool DoubleAttribute { get; }
        Attribute FirstAttribute { get; }
        Attribute SecondAttribute { get; }
        int Count { get; }
        int CountDrop { get; }
    }

    enum AttributeType
    {
        TakeDrop,
        Discard,
        Return,
        GetStrength,
        DamageHeal,
        Destroy
    }
}
