namespace DesignPatterns.Strategy
{
    public class EarthBehavior : IDragonElementalBehavior
    {
        public void ChangeElement(Dragon dragon)
        {
            dragon.ResistFire = 25;
            dragon.ResistWater = 50;
            dragon.ResistEarth = 100;
            dragon.ResistWind = 0;
        }
    }
}
