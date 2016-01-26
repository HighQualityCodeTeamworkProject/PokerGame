using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Poker.Entities;
using Poker.Enums;
using Poker.Interfaces;
using Poker.Models;

namespace Poker.Core
{
    public class Engine : IRunnable
    {
        private readonly IBotFactory botFactory;
        private readonly ICardFactory cardFactory;
        private readonly IPokerDatabase database;
        private readonly IDealer dealer;
        private readonly ITableManager table;
        
        private const bool IsRunning = true;

        private static Engine instance;

        public Engine(
            IBotFactory botFactory,
            ICardFactory cardFactory,
            IPokerDatabase database,
            IDealer dealer,
            ITableManager table)
        {
            this.botFactory = botFactory;
            this.cardFactory = cardFactory;
            this.database = database;
            this.dealer = dealer;
            this.table = table;
        }

        public Engine()
        {
        }

        public static Engine Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Engine();
                }

                return instance;
            }
        }

        

        private static void ThreadStart()
        {
            Application.Run(new UI()); // <-- form started on its own UI thread
        }

        public void Run()
        {
            var thread = new Thread(ThreadStart);
            thread.TrySetApartmentState(ApartmentState.STA);
            thread.Start();

            dealer.FillDeck(database, cardFactory);
            dealer.Shuffle(database.Deck);

            database.AddHuman(new Player("Pesho", 10000));
            database.AddBot(botFactory.CreateBot("Bot1", Constants.DefaultChips));
            database.AddBot(botFactory.CreateBot("Bot2", Constants.DefaultChips));
            database.AddBot(botFactory.CreateBot("Bot3", Constants.DefaultChips));
            database.AddBot(botFactory.CreateBot("Bot4", Constants.DefaultChips));
            database.AddBot(botFactory.CreateBot("Bot5", Constants.DefaultChips));

            dealer.DealCards(database.Deck, database.HumanPlayers, database.BotPlayers, database.TableCards);

            database.BotPlayers.Add(this.botFactory.CreateBot("penka", 10));
            //DialogResult botNames = MessageBox.Show(database.BotPlayers[0].Name);

            //while (IsRunning)
            //{

            //}
        }
    }
}