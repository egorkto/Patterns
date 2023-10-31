namespace Observer
{
    public struct TrainingData
    {
        public float Hands { get; set; }
        public float Chest { get; set; }
        public float Abs { get; set; }
        public float Legs { get; set; }

        public TrainingData(float _Hands, float _Chest, float _Abs, float _Legs)
        {
            Hands = _Hands;
            Chest = _Chest;
            Abs = _Abs;
            Legs = _Legs;
        }

        public static TrainingData operator +(TrainingData data1, TrainingData data2)
        {
            return new TrainingData()
            {
                Hands = data1.Hands + data2.Hands,
                Chest = data1.Chest + data2.Chest,
                Abs = data1.Abs + data2.Abs,
                Legs = data1.Legs + data2.Legs
            };
        }

        public override string ToString()
        {
            return $"\n{Hands}\n{Chest}\n{Abs}\n{Legs}";
        }

    }
}
