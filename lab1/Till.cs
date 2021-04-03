using System;
using System.Collections.Generic;
using lab1.cards;

namespace lab1
{
    public class Till
    {
        private Card card;
        public double Spend(double amount)
        {
            double sum = amount * (1-card.discount);
            card.paysum += amount;
            return sum;
        }

        public bool CardCheck()
        {
            Card tmp = CardFactory.CreateCard(card.discount, card.paysum);
            if (tmp != null)
            {
                card = tmp;
                return true;
            }

            return false;
        }

        public Till()
        {
            this.card = new Card();
        }
    }
}