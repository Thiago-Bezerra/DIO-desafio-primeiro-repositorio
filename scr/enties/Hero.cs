namespace POO_Csharp.scr.enties
{
    public class Hero
    {
        public Hero(string Name, int Level, string HeroType, double HeartPoint, double ManaPoint)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HeartPoint = HeartPoint;
            this.ManaPoint = ManaPoint;

        }

        public Hero(){}
        
        public string Name;
        public int Level;
        public string HeroType;
        public double HeartPoint;
        public double ManaPoint;

        public override string ToString()
        {
            return $@"{this.Name} 
Level: {this.Level} Classe: {this.HeroType}
HP - {this.HeartPoint}  MP - {this.ManaPoint}";
            // return this.Name + " " + this.Level + " " + This.HeroType
            // outro modo de escrever o codigo
        }

        public virtual string Attack()
        {
            return $"{this.Name} atacou com a espada";
        }
        public virtual string Attack(int bonus)
        {
             if(bonus > 1 ){
                return $"{this.Name} ataque com a espada causa dano critico";
            }
            else{
                return $"{this.Name} a espada quebrou";
            }
        }



    }
}