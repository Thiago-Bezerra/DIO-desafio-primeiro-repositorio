namespace POO_Csharp.scr.enties
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, double HeartPoint, double ManaPoint)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HeartPoint = HeartPoint;
            this.ManaPoint = ManaPoint;
        }

        
        public override string Attack()
        {
            return $"{this.Name} atacou com adagas";
        }
        public override string Attack(int bonus){
            if(bonus > 2 ){
                return $"{this.Name} ataque supresa com shurikens";
            }
            else{
                return $"{this.Name} as shurikens cairam ao tenta pegar da bolsa";
            }
        }
    }
}