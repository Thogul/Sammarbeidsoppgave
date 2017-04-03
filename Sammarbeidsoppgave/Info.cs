using System;


//Thomas
namespace Sammarbeidsoppgave
{

    public class Info
    {
        private int difficulty;
        private int cleared;
        private int fails;
        private bool gamestate;
        
        //Constructors
        public Info()
        {
            difficulty = 0;
            cleared = 0;
            fails = 0;
            gamestate = false;
        }

        //Methods
        public void Clear()
        {
            cleared++;
        }

        public void Fail()
        {
            fails++;
        }

        public void Reset()
        {
            difficulty = 0;
            fails = 0;
        }
        public void Gamestate()
        {
            gamestate = !gamestate;
        }

        //Accessors
        public int Difficulty
        {
            get { return difficulty; }
            set { difficulty = value; }
        }

        public int Cleared
        {
            get { return cleared; }
        }

        public int Fails
        {
            get { return fails; }
        }
    }
}