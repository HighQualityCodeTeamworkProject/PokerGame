namespace Poker.Models
{
    public class DeckLoader
    {
        private static DeckLoader instance;

        private DeckLoader()
        {
            
        }

        public static DeckLoader Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DeckLoader();
                }

                return instance;
            }
        }

        public Deck Load()
        {
            return new Deck();
        }
    }
}
