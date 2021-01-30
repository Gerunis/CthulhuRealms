using System;
using System.Collections.Generic;
using System.Text;

namespace CthulhuRealms
{
    class Condition
    {
        ConditionType ConditionType { get; }
        CardColor CardColor { get; }
        CardType CardType { get; }
    }

    enum ConditionType
    {
        CardType,
        CardColor,
        Drop,
        Discard,
    }
}
