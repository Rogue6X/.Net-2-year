using System;
using lab1.cards;

namespace lab1
{
    public class CardFactory
    {
        public static Card CreateCard(double discount, double paysum)
        {
            if (paysum >= 22500 && discount < 0.15)
                return new Integrated(paysum);
            if (paysum >= 12500 && discount < 0.1)
                return new Transistor(paysum);
            if (paysum >= 5000 && discount < 0.05)
                return new Tube(paysum);
            return null;
        }
    }
}