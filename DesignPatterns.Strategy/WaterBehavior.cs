namespace DesignPatterns.Strategy
{
    public class WaterBehavior : IDragonElementalBehavior
    {
        public void ChangeElement(Dragon dragon)
        {
            dragon.ResistFire = 50;
            dragon.ResistWater = 100;
            dragon.ResistEarth = 0;
            dragon.ResistWind = 25;
        }
    }
}
