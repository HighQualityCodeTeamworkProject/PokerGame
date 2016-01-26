using System;
using System.Windows.Forms;
using Poker.Core;
using Poker.Interfaces;
using Poker.Models;

namespace Poker
{
    public static class Launcher
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            IBotFactory botFactory = new BotFactory();
            ICardFactory cardFactory = new CardFactory();
            IPokerDatabase pokerDatabase = new PokerDatabase();
            IDealer dealer = new Dealer();
            ITableManager table = new TableManager();


            var engine = new Engine(botFactory, cardFactory, pokerDatabase, dealer, table);
            engine.Run();
            
        }
    }
}
