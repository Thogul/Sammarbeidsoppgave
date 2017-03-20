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
        List<Image> bilder;
        int diff = 0;
        string[] bildefolder = {"folder1", "folder2", "folder3"};
        string[] bildene = {"bilde 1", "Bilde 2", "bilde 3"};


      //Konstruktør
    public Bricks(int vanskelighetsgrad)
    {
        diff = vanskelighetsgrad;

        for(int i = 0; i < bilder.Count; i++){
            //Hent bilde fra rescources spesifisert ut i fra
            //bilder.Add(/*Nytt bilde */);
        }
    }








    }
}
