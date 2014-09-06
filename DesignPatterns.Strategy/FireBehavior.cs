namespace DesignPatterns.Strategy
{
    public class FireBehavior : IDragonElementalBehavior
    {
        public void ChangeElement(Dragon dragon)
        {
            dragon.ResistFire = 100;
            dragon.ResistWater = 0;
            dragon.ResistEarth = 25;
            dragon.ResistWind = 50;
        }
    }
}
