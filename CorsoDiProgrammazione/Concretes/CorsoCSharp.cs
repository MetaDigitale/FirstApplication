using CorsoDiProgrammazione.Abstracts;

namespace CorsoDiProgrammazione.Concretes
{
    public class CorsoCSharp : CorsoBase
    {
        public override void AssegnaTitolo(string titolo)
        {
            if (!string.IsNullOrEmpty(titolo))
                base.AssegnaTitolo(titolo);
        }

        /// <summary>
        /// Shadowing base class method
        /// </summary>
        /// <param name="ore"></param>
        public new void AssegnaOre(int ore)
        {
            
        }
    }
}