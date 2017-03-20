using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sammarbeidsoppgave
{
    class Bricks
    {
        //Attributter
        private List<Image> bilder;
        private string[] bildefolder = {"folder1", "folder2", "folder3"};
        private string[] pictures1 = { "bilde 1", "Bilde 2", "bilde 3" };
        private string[] pictrues2 = { "bilde 1", "Bilde 2", "bilde 3" };
        private string[] pictures3 = { "bilde 1", "Bilde 2", "bilde 3" };
        private string[,] pictures = { 
            { "bilde 1", "Bilde 2", "bilde 3" },
            { "bilde 1", "Bilde 2", "bilde 3" },
            { "bilde 1", "Bilde 2", "bilde 3" } };


      //Konstruktør
    public Bricks(int vanskelighetsgrad)
    {
        int diff = vanskelighetsgrad;

    }


    }
}
