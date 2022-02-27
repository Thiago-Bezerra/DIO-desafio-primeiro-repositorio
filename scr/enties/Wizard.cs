namespace POO_Csharp.scr.enties
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType, double HeartPoint, double ManaPoint)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HeartPoint = HeartPoint;
            this.ManaPoint = ManaPoint;
        }

        public override string Attack()
        {
            return $"{this.Name} lancou magia";
        }
        public override string Attack(int bonus){
            if(bonus > 5 ){
                return $"{this.Name} lancou super magia";
            }
            else{
                return $"{this.Name} lancou magia inefetiva";
            }
        }
    }
}