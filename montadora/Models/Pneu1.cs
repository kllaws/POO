namespace Models
{
    internal class Pneu
    {
        private int v1;
        private int v2;
        private string v3;
        private bool v;

        public Pneu(int v1, int v2, string v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public Pneu(int v1, int v2, string v3, bool v) : this(v1, v2, v3)
        {
            this.v = v;
        }

        public static implicit operator int(Pneu v)
        {
            throw new NotImplementedException();
        }
    }
}