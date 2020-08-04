using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GameInheritance
{
    class Game
    {
        public int noOfPlayers;
        public string country;
        public Game()
        {

        }
        public Game(int _noOfPlayers,string _country)
        {
            noOfPlayers = _noOfPlayers;
            country = _country;
        }
        public void WorldCup()
        {
            cricket c = new cricket();
            c.country = "Australia";
            Football f = new Football();
            f.country = "Spain";
            DateTime date = new DateTime(2011,10,18);
            Console.WriteLine( "{0} has won the Cricket Worldcup :{1}",c.country,date.Year);
            Console.WriteLine("{0} has won the Football Worldcup :{1}", f.country, date.Year);
        }
    }
    class cricket:Game
    {
        public string coachname;
        public cricket()
        {

        }
        public cricket(int _noOfPlayers,string _country,string _coachname):base(_noOfPlayers,_country)
        {
            coachname = _coachname;
        }
    }
    class Football : Game
    {
        public string Leaguename;
        public Football()
        {

        }
        public Football(int _noOfPlayers, string _country, string _Leaguename) : base(_noOfPlayers, _country)
        {
            Leaguename = _Leaguename;
        }
    }
    class ShowGameDetails
    {
        cricket c = new cricket(11, "India", "John Vright");
        cricket c1 = new cricket(11, "Australia", "John Buchan");
        Football f = new Football(14, "Spain", "Spanish League");
        Football f1 = new Football(14, "England", "English Premur League");
        public void ShowCricketDetails()
        {
            Console.WriteLine("-------------------------------CRICKET INFORMATION-------------------------------");
            Console.WriteLine("Country:{0} No.of Players:{1} Coach Name{2}", c.country, c.noOfPlayers,c.coachname);
            Console.WriteLine("Country:{0} No.of Players:{1} Coach Name{2}", c1.country,c1.noOfPlayers, c1.coachname);
        }
        public void ShowFootballDetails()
        {
            Console.WriteLine("--------------------------------FOOTBALL INFORMATION----------------------------------");
            Console.WriteLine("Country:{0} No.of Players:{1}  Leaguename{2}", f.country ,f.noOfPlayers,  f.Leaguename);
            Console.WriteLine("Country:{0} No.of Players:{1}  Leaguename{2}", f1.country , f1.noOfPlayers , f1.Leaguename);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
          

            ShowGameDetails obj = new ShowGameDetails();
            obj.ShowCricketDetails();
            obj.ShowFootballDetails();

            Game obj1 = new Game();
            Console.WriteLine("--------------------------------------------------");
            obj1.WorldCup();
          

            Console.Read();

        }
    }
}
