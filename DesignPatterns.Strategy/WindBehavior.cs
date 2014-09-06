namespace DesignPatterns.Strategy
{
    public class WindBehavior : IDragonElementalBehavior
    {
        public void ChangeElement(Dragon dragon)
        {
            dragon.ResistFire = 0;
            dragon.ResistWater = 25;
            dragon.ResistEarth = 50;
            dragon.ResistWind = 100;
        }
    }
}
