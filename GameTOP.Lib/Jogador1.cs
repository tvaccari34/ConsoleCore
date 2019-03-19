using GameTOP.Interface;
namespace GameTOP.Lib
{
    public class Jogador1 : IJogador
    {
        public string _Nome { get; set; }

        public Jogador1(string nome)
        {
            _Nome = nome;
        }

        //Chuta
        public string Chuta()
        {
            return $"{_Nome} esta chutando \n";
        }

        //Corre
        public string Corre()
        {
            return $"{_Nome} esta correndo \n";
        }

        //Passe
        public string Passa()
        {
            return $"{_Nome} esta passando \n";
        }
    }
}