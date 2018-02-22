using System.Collections.Generic;

namespace RouletteGame.Legacy
{
    public interface IFieldGenerator
    {
        List<Field> CreateFields();
    }
}