using System;


//Thomas
namespace Sammarbeidsoppgave
{

    public class Info
    {
        private int difficulty;
        private int cleared;
        private int fails;
        private int round;
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
            if (round < 3)
                round++;
        }

        public void Fail()
        {
            fails++;
            if (round < 3)
                round++;
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