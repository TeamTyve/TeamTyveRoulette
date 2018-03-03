using System.Collections.Generic;

namespace RouletteGame.Library
{
    public interface IFieldGenerator
    {
        List<Field> CreateFields();
    }
}