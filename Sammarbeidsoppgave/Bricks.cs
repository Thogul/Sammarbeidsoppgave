using system;

namespace Sammarbeidsoppgave
{
    class Bricks
    {
      //Attributter
      list<Image> bilder;
      int diff = 0;
      string bildefolder = {"folder1", "folder2", "folder3"};
      string bildene = {"bilde 1", "Bilde 2", "bilde 3"};


      //Konstruktør
      public Brikker(int vanskelighetsgrad){
        diff = vanskelighetsgrad;

        for(int i = 0; i < bilder; i++){
          //Hent bilde fra rescources spesifisert ut i fra
          bilder.add(new Image./*image from rescources eller noe*/);
        }
      }








    }
}
