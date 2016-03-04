using System;
using CorsoDiProgrammazione.Abstracts;

namespace CorsoDiProgrammazione
{
    class Corso : CorsoBase, IDisposable
    {
        public Corso()
        {
            this.Titolo = "";
        }

        /// <summary>
        /// N.B.: Viene invocato solo, e solo se, nel metodo Dispose non viene invocato 
        /// GC.SuppressFinalize(this);
        /// </summary>
        ~Corso()
        {
            System.Diagnostics.Trace.WriteLine("Corso's destructor is called.");
        }

        public string Titolo { get; private set; }

        /// <summary>
        /// Se non faccio l'override verrà eseguito il metodo così come implementato nella classe base
        /// </summary>
        /// <param name="ore">numero delle ore totali del corso</param>
        public override void AssegnaOre(int ore)
        {
            if (ore > 0)
                base.AssegnaOre(ore);
        }

        public void AssegnaTitolo(string titolo)
        {
            this.Titolo = titolo;
        }

        #region Dispose
        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
