using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 : iJogador
 {
    
     public string Chuta()
        {
            return "Messi estas pateando /n";
        }

        public string Corre()
        {
            return "Messi estas corriendo /n";
        }

        public string Passe()
        {
            return "Messi estas passando /n";
        }
    }

 }
