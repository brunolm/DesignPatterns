namespace DesignPatterns.Strategy
{
    public class Dragon
    {
        private IDragonElementalBehavior elementMode;

        public int ResistFire { get; set; }

        public int ResistWater { get; set; }

        public int ResistWind { get; set; }

        public int ResistEarth { get; set; }

        public IDragonElementalBehavior ElementMode
        {
            get { return elementMode; }
            set
            {
                elementMode = value;
                elementMode.ChangeElement(this);
            }
        }
    }
}
