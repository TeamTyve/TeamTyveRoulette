using System.Collections.Generic;

namespace RouletteGame.Legacy
{
    public class Roulette : IRoulette
    {
        private readonly List<Field> _fields;
        private IFieldGenerator _fieldGenerator;
        private IRandomizer _randomizer;
        private Field _result;

        public uint Lowerbound { get; set; } = 0;
        public uint Higherbound { get; set; } = 37;

        public Roulette(IFieldGenerator fieldGenerator, IRandomizer randomizer)
        {
            _fieldGenerator = fieldGenerator;
            _randomizer = randomizer;
            _fields = _fieldGenerator.CreateFields();
            _result = _fields[0];
        }

        public void Spin()
        {
            var n = _randomizer.GetNext(Lowerbound, Higherbound);
            _result = _fields[(int) n];
        }

        public Field GetResult()
        {
            return _result;
        }
    }
}