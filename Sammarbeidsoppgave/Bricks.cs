using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Thomas
namespace Sammarbeidsoppgave
{
    class Bricks
    {
        //Attributter
        private List<Image> pictures;
        private Image[,] picture0 = {
            { Sammarbeidsoppgave.Properties.Resources.Master_sword, Sammarbeidsoppgave.Properties.Resources.Bokoblin_Zelda, Sammarbeidsoppgave.Properties.Resources.Rocket_Leauge_Ball, Sammarbeidsoppgave.Properties.Resources.Rocket_Leauge_Car },
            { Sammarbeidsoppgave.Properties.Resources.Rocket_Leauge_Ball, Sammarbeidsoppgave.Properties.Resources.Rocket_Leauge_Car, Sammarbeidsoppgave.Properties.Resources.Master_sword, Sammarbeidsoppgave.Properties.Resources.Bokoblin_Zelda },
            { null, null, null, null } };
        private Image[,] picture1 = {
            { null, null, null, null },
            { null, null, null, null },
            { null, null, null, null } };
        private Image[,] picture2 = {
            { null, null, null, null },
            { null, null, null, null },
            { null, null, null, null } };
        private Image[,] questions =  {
            { Sammarbeidsoppgave.Properties.Resources.Zelda_Answer, Sammarbeidsoppgave.Properties.Resources.Rocket_Leauge_Answer, Sammarbeidsoppgave.Properties.Resources.League_answer },
            { null, null, null, },
            { null, null, null, } };
        private int difficulty;
        private int questionLvL;

        //Konstruktør
        public Bricks()
        {
            difficulty = 0;
            questionLvL = 0;
        }

        //metoder
        public void push()
        {
            pictures = new List<Image>();
            if(difficulty == 0)
                for (int i = 0; i < picture0.GetLength(1); i++)
                {
                    if(picture0[questionLvL,i] != null)
                        pictures.Add(picture0[0, i]);
                }
            if (difficulty == 1)
                for (int i = 0; i < picture1.GetLength(1); i++)
                {
                    if (picture1[questionLvL, i] != null)
                        pictures.Add(picture1[0, i]);
                }
            if (difficulty == 2)
                for (int i = 0; i < picture2.GetLength(1); i++)
                {
                    if (picture2[questionLvL, i] != null)
                        pictures.Add(picture2[0, i]);
                }
        }

        //Get set metoder
        public int Difficulty
        {
            get { return difficulty; }
            set { difficulty = value; }
        }

        public int QuestionLvL
        {
            get { return questionLvL; }
            set { questionLvL = value; }
        }

        public List<Image> Pictures
        {
            get { return pictures; }
        }

        public Image[,] Questions
        {
            get { return questions; } 
        }
    }
}