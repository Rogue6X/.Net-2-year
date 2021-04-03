namespace lab1.cards
{
    public class Card
    {
        public double discount { get; set; }
        public double paysum{ get; set; }

        public Card(double paysum=0,double discount=0)
        {
            this.discount = discount;
            this.paysum = paysum;
        }
    }
}