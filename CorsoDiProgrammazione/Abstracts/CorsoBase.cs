namespace CorsoDiProgrammazione.Abstracts
{
    public abstract class CorsoBase
    {
        public int TotaleOreCorso { get; private set; }
        public string Titolo { get; private set; }

        public virtual void AssegnaOre(int ore)
        {
            this.TotaleOreCorso = ore;
        }

        public virtual void AssegnaTitolo(string titolo)
        {
            this.Titolo = titolo;
        }
    }
}