using System.Drawing;

namespace Poker.Models
{
    public class Card
    {
        private Image image;
        private int rank;
        private string suit;


        public Card(int rank, string suit, string imagePath)
        {
            this.Rank = rank;
            this.Suit = suit;
            this.Image = new Bitmap(imagePath);
        }

        public Image Image
        {
            get { return this.image; }
            private set { this.image = value; }
        }

        public int Rank
        {
            get { return this.rank; }
            private set { this.rank = value; }
        }

        public string Suit
        {
            get { return this.suit; }
            private set { this.suit = value; }
        }
    }
}
